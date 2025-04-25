using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CVValidator
{
    public partial class Form1 : Form
    {
        private string currentCaptchaText = "";
        private Random random = new Random(); private int verificationAttempts = 0;
        private Label lblTextCaptcha;

        // Store previous CAPTCHAs to prevent reuse
        private System.Collections.Generic.HashSet<string> usedCaptchas = new System.Collections.Generic.HashSet<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            InitializeCustomUI();
            comboCaptchaType.SelectedIndex = 0;
            GenerateCaptcha();
            UpdateUIForSelectedCaptchaType();
        }

        private void InitializeCustomUI()
        {
            // Set up math problem label (not defined in designer)
            lblMathProblem = new Label();
            lblMathProblem.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblMathProblem.ForeColor = Color.FromArgb(32, 64, 96);
            lblMathProblem.Location = new Point(55, 100);
            lblMathProblem.Size = new Size(330, 30);
            lblMathProblem.TextAlign = ContentAlignment.MiddleCenter;
            lblMathProblem.BackColor = Color.FromArgb(250, 250, 255);
            lblMathProblem.BorderStyle = BorderStyle.FixedSingle;
            lblMathProblem.Visible = false;
            panelCaptchaContainer.Controls.Add(lblMathProblem);

            // Set up reCAPTCHA verification picture box (for the "I'm not a robot" visual feedback)
            picCaptchaVerification = new PictureBox();
            picCaptchaVerification.Size = new Size(24, 24);
            picCaptchaVerification.Location = new Point(chkReCaptcha.Right + 5, chkReCaptcha.Top);
            picCaptchaVerification.SizeMode = PictureBoxSizeMode.StretchImage;
            picCaptchaVerification.Visible = false;
            this.Controls.Add(picCaptchaVerification);

            lblTextCaptcha = new Label();
            lblTextCaptcha.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblTextCaptcha.ForeColor = Color.FromArgb(32, 64, 96);
            lblTextCaptcha.Location = new Point(55, 100);
            lblTextCaptcha.Size = new Size(330, 50);
            lblTextCaptcha.TextAlign = ContentAlignment.MiddleCenter;
            lblTextCaptcha.BackColor = Color.FromArgb(250, 250, 255);
            lblTextCaptcha.BorderStyle = BorderStyle.FixedSingle;
            lblTextCaptcha.Visible = false;
            panelCaptchaContainer.Controls.Add(lblTextCaptcha);


            // Add items to combo box
            comboCaptchaType.Items.Clear();
            comboCaptchaType.Items.AddRange(new string[] { "Text-Based", "Image-Based", "Math-Based", "reCAPTCHA Checkbox" });

            // Set default logo
            try
            {
                // Create a basic shield icon as placeholder
                Bitmap logoBitmap = new Bitmap(100, 100);
                using (Graphics g = Graphics.FromImage(logoBitmap))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.Clear(Color.FromArgb(40, 75, 110));

                    // Draw shield shape
                    GraphicsPath path = new GraphicsPath();
                    path.AddArc(20, 10, 60, 60, 180, 180);
                    path.AddLine(80, 40, 80, 70);
                    path.AddCurve(new Point[] {
                        new Point(80, 70),
                        new Point(70, 85),
                        new Point(50, 90),
                        new Point(30, 85),
                        new Point(20, 70)
                    });
                    path.CloseFigure();

                    g.FillPath(new SolidBrush(Color.White), path);

                    // Draw lock icon
                    Rectangle lockRect = new Rectangle(40, 45, 20, 20);
                    g.FillRectangle(new SolidBrush(Color.FromArgb(32, 64, 96)), lockRect);
                    g.FillEllipse(new SolidBrush(Color.FromArgb(32, 64, 96)), 35, 30, 30, 25);
                    g.FillEllipse(new SolidBrush(Color.White), 45, 35, 10, 10);
                }
                pictureBoxLogo.Image = logoBitmap;
            }
            catch
            {
                // If there's any error, we'll just leave the logo empty
            }

            // Set up keyboard shortcuts
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnRefresh_Click(sender, EventArgs.Empty);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnSubmit_Click(sender, EventArgs.Empty);
                e.Handled = true;
            }
        }

        private void comboCaptchaType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateCaptcha();
            UpdateUIForSelectedCaptchaType();
        }

        private void UpdateUIForSelectedCaptchaType()
        {
            

            if (comboCaptchaType.SelectedItem is null) return;
            string selectedCaptchaType = comboCaptchaType.SelectedItem?.ToString() ?? "";
         
            var dynamicControls = panelCaptchaContainer.Controls
                .OfType<Control>()
                .Where(c => c.Tag?.ToString() == "colorBox")
                .ToList();

            foreach (var ctrl in dynamicControls)
            {
                panelCaptchaContainer.Controls.Remove(ctrl);
                ctrl.Dispose();
            }


            // Reset all controls visibility first
            txtCaptchaInput.Visible = true;
            picCaptchaImage.Visible = false;
            chkReCaptcha.Visible = false;
            lblMathProblem.Visible = false;
            lblInstruction.Visible = true;
            picCaptchaVerification.Visible = false;
            lblTextCaptcha.Visible = false;

            // Show/hide controls based on selected CAPTCHA type
            switch (selectedCaptchaType)
            {
                case "Text-Based":
                    lblTextCaptcha.Visible = true;
                    picCaptchaImage.Visible = false;
                    statusLabel.Text = "Text-Based CAPTCHA Selected";
                    break;
                case "Image-Based":
                    picCaptchaImage.Visible = true;
                    statusLabel.Text = "Image-Based CAPTCHA Selected";
                    break;
                case "Math-Based":
                    lblMathProblem.Visible = true;
                    statusLabel.Text = "Math-Based CAPTCHA Selected";
                    break;
                case "reCAPTCHA Checkbox":
                    txtCaptchaInput.Visible = false;
                    chkReCaptcha.Visible = true;
                    picCaptchaVerification.Visible = true;
                    lblInstruction.Visible = true;
                    lblInstruction.Text = "Please confirm you're not a robot:";
                    statusLabel.Text = "reCAPTCHA Checkbox Selected";
                    return;
            }

            // Update form labels based on CAPTCHA type
            lblInstruction.Text = selectedCaptchaType == "Math-Based"
                ? "Enter the solution to the math problem:"
                : "Enter the characters you see above:";
        }

        private void GenerateCaptcha()
        {
            if (comboCaptchaType.SelectedItem is null) return;
            string selectedCaptchaType = comboCaptchaType.SelectedItem?.ToString() ?? "";

            // Reset verification attempts when generating a new CAPTCHA
            verificationAttempts = 0;

            switch (selectedCaptchaType)
            {
                case "Image-Based":
                    picCaptchaImage.Visible = false;
                    txtCaptchaInput.Visible = true;
                    txtCaptchaInput.Text = "";

                    panelCaptchaContainer.Controls.OfType<Button>()
                        .Where(b => b.Tag?.ToString() == "colorBox")
                        .ToList()
                        .ForEach(b => panelCaptchaContainer.Controls.Remove(b));

                    Color[] colors = new Color[]
                    {
        Color.Red, Color.Green, Color.Blue, Color.Yellow,
        Color.Orange, Color.Purple, Color.Brown, Color.Pink, Color.Teal
                    };

                    colors = colors.OrderBy(x => random.Next()).ToArray();
                    Color targetColor = colors[random.Next(colors.Length)];
                    currentCaptchaText = targetColor.Name.ToLower();

                    lblInstruction.Text = $"Click the box with this color: {currentCaptchaText.ToUpper()}";

                    int size = 50;
                    int spacing = 10;
                    int startX = 55;
                    int startY = 70;
                    int index = 0;

                    for (int row = 0; row < 3; row++)
                    {
                        for (int col = 0; col < 3; col++)
                        {
                            Button box = new Button();
                            box.Size = new Size(size, size);
                            box.Location = new Point(startX + col * (size + spacing), startY + row * (size + spacing));
                            box.BackColor = colors[index++];
                            box.Tag = "colorBox";
                            box.FlatStyle = FlatStyle.Flat;
                            box.FlatAppearance.BorderSize = 1;
                            box.Click += (s, e) =>
                            {
                                Color clickedColor = ((Button)s).BackColor;
                                if (clickedColor.Name.ToLower() == currentCaptchaText)
                                {
                                    MessageBox.Show("Correct color selected!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    statusLabel.Text = "Color CAPTCHA Passed";
                                    GenerateCaptcha();
                                }
                                else
                                {
                                    MessageBox.Show("Wrong color. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    statusLabel.Text = "Color CAPTCHA Failed";
                                }
                            };
                            panelCaptchaContainer.Controls.Add(box);
                        }
                    }
                    break;


                case "Text-Based":
                    do
                    {
                        currentCaptchaText = GenerateRandomText();
                    } while (usedCaptchas.Contains(currentCaptchaText));

                    usedCaptchas.Add(currentCaptchaText);
                    if (usedCaptchas.Count > 10)
                    {
                        usedCaptchas.Remove(usedCaptchas.First());
                    }

                    Bitmap textCaptchaImage = new Bitmap(330, 95);
                    using (Graphics g = Graphics.FromImage(textCaptchaImage))
                    {
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.Clear(Color.FromArgb(250, 250, 255));

                        using (Pen noisePen = new Pen(Color.FromArgb(230, 230, 240), 1))
                        {
                            for (int i = 0; i < 20; i++)
                            {
                                g.DrawLine(noisePen,
                                    random.Next(0, textCaptchaImage.Width),
                                    random.Next(0, textCaptchaImage.Height),
                                    random.Next(0, textCaptchaImage.Width),
                                    random.Next(0, textCaptchaImage.Height));
                            }
                        }

                        for (int i = 0; i < currentCaptchaText.Length; i++)
                        {
                            using (Font charFont = new Font("Consolas", 26 + random.Next(-5, 6), FontStyle.Bold))
                            using (SolidBrush brush = new SolidBrush(GetRandomDarkColor()))
                            {
                                float xPos = 20 + (i * 45) + random.Next(-5, 6);
                                float yPos = 20 + random.Next(-10, 11);
                                Matrix matrix = new Matrix();
                                matrix.RotateAt(random.Next(-15, 16), new PointF(xPos, yPos));
                                g.Transform = matrix;
                                g.DrawString(currentCaptchaText[i].ToString(), charFont, brush, xPos, yPos);
                                g.ResetTransform();
                            }
                        }

                        using (Pen linePen = new Pen(GetRandomDarkColor(), 2))
                        {
                            g.DrawLine(linePen, 0, random.Next(20, 75), textCaptchaImage.Width, random.Next(20, 75));
                        }
                    }

                    picCaptchaImage.Image = textCaptchaImage;
                    picCaptchaImage.Visible = true;
                    txtCaptchaInput.Text = "";
                    break;
                case "Math-Based":
                    int a = random.Next(1, 20);
                    int b = random.Next(1, 20);
                    string operation = random.Next(0, 4) switch
                    {
                        0 => "+",
                        1 => "-",
                        2 => "×",
                        _ => "÷"
                    };

                    switch (operation)
                    {
                        case "+":
                            currentCaptchaText = (a + b).ToString();
                            break;
                        case "-":
                            if (a < b) { int temp = a; a = b; b = temp; }
                            currentCaptchaText = (a - b).ToString();
                            break;
                        case "×":
                            a = random.Next(1, 10);
                            b = random.Next(1, 10);
                            currentCaptchaText = (a * b).ToString();
                            break;
                        case "÷":
                            b = random.Next(1, 10);
                            a = b * random.Next(1, 10);
                            currentCaptchaText = (a / b).ToString();
                            break;
                    }

                    lblMathProblem.Text = $"{a} {operation} {b} = ?";
                    txtCaptchaInput.Text = "";
                    break;

            }
        }

        private string GenerateRandomText()
        {
            // Removed easily confused characters like 0, O, 1, I, etc.
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            char[] stringChars = new char[6];
            for (int i = 0; i < stringChars.Length; i++)
                stringChars[i] = chars[random.Next(chars.Length)];
            return new string(stringChars);
        }

        private Color GetRandomDarkColor()
        {
            return Color.FromArgb(
                random.Next(10, 100),
                random.Next(10, 100),
                random.Next(10, 100));
        }

        private Color GetRandomLightColor()
        {
            return Color.FromArgb(
                random.Next(180, 256),
                random.Next(180, 256),
                random.Next(180, 256));
        }

        private void UpdateRecaptchaVerificationImage()
        {
            if (chkReCaptcha.Checked)
            {
                // Create checkmark image when verified
                Bitmap checkmark = new Bitmap(24, 24);
                using (Graphics g = Graphics.FromImage(checkmark))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.Clear(Color.FromArgb(76, 175, 80)); // Green background

                    // Draw white checkmark
                    using (Pen checkPen = new Pen(Color.White, 3))
                    {
                        g.DrawLine(checkPen, 5, 12, 10, 17);
                        g.DrawLine(checkPen, 10, 17, 18, 7);
                    }
                }
                picCaptchaVerification.Image = checkmark;
            }
            else
            {
                // Create empty/reset image
                Bitmap emptyCheck = new Bitmap(24, 24);
                using (Graphics g = Graphics.FromImage(emptyCheck))
                {
                    g.Clear(Color.FromArgb(240, 240, 240));
                }
                picCaptchaVerification.Image = emptyCheck;
            }
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            GenerateCaptcha();
            statusLabel.Text = "CAPTCHA refreshed";
        }

        private void chkReCaptcha_CheckedChanged(object? sender, EventArgs e)
        {
            if (chkReCaptcha.Checked)
            {
                // Simulate verification process
                Cursor = Cursors.WaitCursor;
                statusLabel.Text = "Verifying...";

                // Use timer to simulate verification delay
                System.Windows.Forms.Timer verifyTimer = new System.Windows.Forms.Timer();

                verifyTimer.Interval = 1500;
                verifyTimer.Tick += (s, args) =>
                {
                    verifyTimer.Stop();
                    UpdateRecaptchaVerificationImage();
                    Cursor = Cursors.Default;
                    statusLabel.Text = "Ready to submit";
                };
                verifyTimer.Start();
            }
            else
            {
                UpdateRecaptchaVerificationImage();
            }
        }

        private void btnSubmit_Click(object? sender, EventArgs e)
        {
            if (comboCaptchaType.SelectedItem is null) return;
            string selectedCaptchaType = comboCaptchaType.SelectedItem?.ToString() ?? "";
            verificationAttempts++;

            if (selectedCaptchaType == "reCAPTCHA Checkbox")
            {
                if (chkReCaptcha.Checked)
                {
                    MessageBox.Show("You are not a robot!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    statusLabel.Text = "Verification successful";
                    // Reset after successful verification
                    verificationAttempts = 0;
                }
                else
                {
                    MessageBox.Show("Please confirm you are not a robot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    statusLabel.Text = "Verification failed";

                    // After multiple failed attempts, show challenge
                    if (verificationAttempts >= 3)
                    {
                        ShowAdvancedCaptchaChallenge();
                    }
                }
                return;
            }

            if (txtCaptchaInput.Text.Trim().Equals(currentCaptchaText, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("CAPTCHA validation successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                statusLabel.Text = "Validation successful";
                // Reset attempts after success
                verificationAttempts = 0;
                GenerateCaptcha(); // Generate new CAPTCHA after successful validation
            }
            else
            {
                MessageBox.Show("Incorrect CAPTCHA. Please try again.", "Validation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Validation failed";

                // After multiple failed attempts, make it harder
                if (verificationAttempts >= 3)
                {
                    MakeCaptchaHarder();
                }
            }
        }

        private void ShowAdvancedCaptchaChallenge()
        {
            // When reCAPTCHA fails multiple times, transition to a more complex challenge
            MessageBox.Show("Additional verification required.", "Advanced Challenge", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Switch to image-based CAPTCHA
            comboCaptchaType.SelectedIndex = 1; // Index 1 is Image-Based
            // Make it harder
            MakeCaptchaHarder();
        }

        private void MakeCaptchaHarder()
        {
            if (comboCaptchaType.SelectedItem is null) return;
            string selectedCaptchaType = comboCaptchaType.SelectedItem?.ToString() ?? "";

            switch (selectedCaptchaType)
            {
                case "Text-Based":
                    // Make text-based CAPTCHA longer
                    const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnpqrstuvwxyz23456789";
                    char[] stringChars = new char[8]; // Increase from 6 to 8 chars
                    for (int i = 0; i < stringChars.Length; i++)
                        stringChars[i] = chars[random.Next(chars.Length)];
                    currentCaptchaText = new string(stringChars);

                    // Create a more complex text-based image
                    Bitmap textCaptchaImage = new Bitmap(330, 95);
                    using (Graphics g = Graphics.FromImage(textCaptchaImage))
                    {
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.Clear(Color.FromArgb(250, 250, 255));

                        // Add more noise
                        using (Pen noisePen = new Pen(Color.FromArgb(230, 230, 240), 1))
                        {
                            for (int i = 0; i < 40; i++) // More noise lines
                            {
                                g.DrawLine(noisePen,
                                    random.Next(0, textCaptchaImage.Width),
                                    random.Next(0, textCaptchaImage.Height),
                                    random.Next(0, textCaptchaImage.Width),
                                    random.Next(0, textCaptchaImage.Height));
                            }
                        }

                        // Draw the text with more extreme distortion
                        for (int i = 0; i < currentCaptchaText.Length; i++)
                        {
                            using (Font charFont = new Font("Consolas", 24 + random.Next(-8, 9), FontStyle.Bold))
                            {
                                using (SolidBrush brush = new SolidBrush(GetRandomDarkColor()))
                                {
                                    // More varied position
                                    float xPos = 15 + (i * 35) + random.Next(-8, 9);
                                    float yPos = 20 + random.Next(-15, 16);

                                    // More extreme rotation
                                    Matrix rotationMatrix = new Matrix();
                                    rotationMatrix.RotateAt(random.Next(-25, 26), new PointF(xPos, yPos));
                                    g.Transform = rotationMatrix;

                                    // Draw the character
                                    g.DrawString(currentCaptchaText[i].ToString(), charFont, brush, xPos, yPos);

                                    // Reset transformation
                                    g.ResetTransform();
                                }
                            }
                        }

                        // Add more crossing lines
                        using (Pen linePen = new Pen(GetRandomDarkColor(), 2))
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                g.DrawLine(linePen,
                                    0, random.Next(10, textCaptchaImage.Height - 10),
                                    textCaptchaImage.Width, random.Next(10, textCaptchaImage.Height - 10));
                            }
                        }
                    }
                    picCaptchaImage.Image = textCaptchaImage;
                    txtCaptchaInput.Text = "";
                    break;

                case "Image-Based":
                    // Make image-based CAPTCHA more complex with mixed case and more characters
                    const string mixedChars = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnpqrstuvwxyz23456789";
                    char[] mixedStringChars = new char[8]; // Increase from 6 to 8 chars
                    for (int i = 0; i < mixedStringChars.Length; i++)
                        mixedStringChars[i] = mixedChars[random.Next(mixedChars.Length)];
                    currentCaptchaText = new string(mixedStringChars);

                    // Create a more complex image with additional distortion
                    Bitmap captchaImage = new Bitmap(330, 95);
                    using (Graphics g = Graphics.FromImage(captchaImage))
                    {
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        g.Clear(Color.FromArgb(250, 250, 255));

                        // Create more complex background pattern
                        for (int y = 0; y < captchaImage.Height; y += 4)
                        {
                            for (int x = 0; x < captchaImage.Width; x += 4)
                            {
                                if ((x + y) % 8 == 0)
                                {
                                    using (SolidBrush b = new SolidBrush(GetRandomLightColor()))
                                    {
                                        g.FillRectangle(b, x, y, 4, 4);
                                    }
                                }
                            }
                        }

                        // Add more noise dots
                        for (int i = 0; i < 500; i++)
                        {
                            int x = random.Next(0, captchaImage.Width);
                            int y = random.Next(0, captchaImage.Height);
                            captchaImage.SetPixel(x, y, GetRandomLightColor());
                        }

                        // Draw highly distorted text
                        using (Font font = new Font("Arial", 26, FontStyle.Bold))
                        {
                            GraphicsPath path = new GraphicsPath();
                            path.AddString(currentCaptchaText, font.FontFamily, (int)font.Style,
                                font.Size, new Point(15, 25), StringFormat.GenericDefault);

                            // Apply more extreme wave distortion
                            PointF[] points = new PointF[8] {
                                new PointF(random.Next(5, 20), random.Next(0, 10)),
                                new PointF(random.Next(50, 70), random.Next(0, 15)),
                                new PointF(random.Next(100, 120), random.Next(0, 5)),
                                new PointF(random.Next(150, 170), random.Next(0, 15)),
                                new PointF(random.Next(5, 20), random.Next(captchaImage.Height - 10, captchaImage.Height)),
                                new PointF(random.Next(50, 70), random.Next(captchaImage.Height - 15, captchaImage.Height)),
                                new PointF(random.Next(100, 120), random.Next(captchaImage.Height - 5, captchaImage.Height)),
                                new PointF(random.Next(150, 170), random.Next(captchaImage.Height - 15, captchaImage.Height))
                            };

                            Matrix matrix = new Matrix();
                            path.Warp(points, new Rectangle(0, 0, captchaImage.Width, captchaImage.Height), matrix, WarpMode.Perspective);

                            // Draw the text with color gradient
                            using (LinearGradientBrush textBrush = new LinearGradientBrush(
                                new Rectangle(0, 0, captchaImage.Width, captchaImage.Height),
                                Color.FromArgb(32, 64, 96), Color.FromArgb(64, 32, 96),
                                LinearGradientMode.ForwardDiagonal))
                            {
                                g.FillPath(textBrush, path);
                                g.DrawPath(new Pen(Color.FromArgb(96, 96, 128), 1), path);
                            }
                        }

                        // Add more crossing lines
                        for (int i = 0; i < 6; i++)
                        {
                            using (Pen pen = new Pen(GetRandomDarkColor(), 1))
                            {
                                g.DrawLine(pen,
                                    random.Next(0, captchaImage.Width / 4),
                                    random.Next(0, captchaImage.Height),
                                    random.Next(3 * captchaImage.Width / 4, captchaImage.Width),
                                    random.Next(0, captchaImage.Height));
                            }
                        }
                    }
                    picCaptchaImage.Image = captchaImage;
                    txtCaptchaInput.Text = "";
                    break;

                case "Math-Based":
                    // Create more complex math problem
                    int difficulty = Math.Min(verificationAttempts, 5); // Cap difficulty level at 5

                    // Generate more complex math problem based on difficulty
                    GenerateComplexMathCaptcha(difficulty);
                    txtCaptchaInput.Text = "";
                    break;
            }

            statusLabel.Text = "Advanced CAPTCHA challenge shown";
        }

        private void GenerateComplexMathCaptcha(int difficulty)
        {
            switch (difficulty)
            {
                case 3: // First tier of increased difficulty
                    // Two-operation problem
                    int a = random.Next(5, 20);
                    int b = random.Next(1, 10);
                    int c = random.Next(1, 10);

                    // Choose two operations
                    string op1 = random.Next(0, 3) switch
                    {
                        0 => "+",
                        1 => "-",
                        _ => "×"
                    };

                    string op2 = random.Next(0, 3) switch
                    {
                        0 => "+",
                        1 => "-",
                        _ => "×"
                    };

                    // Calculate result
                    int firstResult = op1 switch
                    {
                        "+" => a + b,
                        "-" => a - b,
                        "×" => a * b,
                        _ => 0
                    };

                    int finalResult = op2 switch
                    {
                        "+" => firstResult + c,
                        "-" => firstResult - c,
                        "×" => firstResult * c,
                        _ => 0
                    };

                    currentCaptchaText = finalResult.ToString();
                    lblMathProblem.Text = $"{a} {op1} {b} {op2} {c} = ?";
                    break;

                case 4: // Second tier 
                    // Equation with parentheses
                    a = random.Next(2, 10);
                    b = random.Next(2, 10);
                    c = random.Next(2, 10);

                    // Format: (a ± b) × c or a × (b ± c)
                    bool firstGrouping = random.Next(2) == 0;
                    string innerOp = random.Next(2) == 0 ? "+" : "-";

                    if (firstGrouping)
                    {
                        // (a ± b) × c
                        int innerResult = innerOp == "+" ? a + b : a - b;
                        finalResult = innerResult * c;
                        currentCaptchaText = finalResult.ToString();
                        lblMathProblem.Text = $"({a} {innerOp} {b}) × {c} = ?";
                    }
                    else
                    {
                        // a × (b ± c)
                        int innerResult = innerOp == "+" ? b + c : b - c;
                        finalResult = a * innerResult;
                        currentCaptchaText = finalResult.ToString();
                        lblMathProblem.Text = $"{a} × ({b} {innerOp} {c}) = ?";
                    }
                    break;

                case 5: // Hardest tier
                    // More complex equation with powers or multiple operations
                    int type = random.Next(3);

                    if (type == 0)
                    {
                        // Square or cube
                        a = random.Next(2, 12);
                        int power = random.Next(2) == 0 ? 2 : 3;
                        finalResult = (int)Math.Pow(a, power);
                        currentCaptchaText = finalResult.ToString();
                        lblMathProblem.Text = power == 2 ? $"{a}² = ?" : $"{a}³ = ?";
                    }
                    else if (type == 1)
                    {
                        // Complex equation with three operands and mixed operations
                        a = random.Next(2, 15);
                        b = random.Next(2, 10);
                        c = random.Next(2, 10);
                        int d = random.Next(2, 10);

                        // Format: a + b × c - d
                        finalResult = a + (b * c) - d;
                        currentCaptchaText = finalResult.ToString();
                        lblMathProblem.Text = $"{a} + {b} × {c} - {d} = ?";
                    }
                    else
                    {
                        // Division with remainder format
                        int divisor = random.Next(2, 11);
                        int quotient = random.Next(1, 10);
                        int remainder = random.Next(0, divisor);
                        int dividend = (divisor * quotient) + remainder;

                        currentCaptchaText = remainder.ToString();
                        lblMathProblem.Text = $"What is the remainder when {dividend} ÷ {divisor}?";
                    }
                    break;

                default: // Normal difficulty (shouldn't reach here normally)
                    GenerateSimpleMathCaptcha();
                    break;
            }
        }

        private void GenerateSimpleMathCaptcha()
        {
            int a = random.Next(1, 20);
            int b = random.Next(1, 20);
            string operation = random.Next(0, 4) switch
            {
                0 => "+",
                1 => "-",
                2 => "×",
                _ => "÷"
            };

            switch (operation)
            {
                case "+":
                    currentCaptchaText = (a + b).ToString();
                    break;
                case "-":
                    // Ensure positive result
                    if (a < b) { int temp = a; a = b; b = temp; }
                    currentCaptchaText = (a - b).ToString();
                    break;
                case "×":
                    // Use smaller numbers for multiplication
                    a = random.Next(1, 10);
                    b = random.Next(1, 10);
                    currentCaptchaText = (a * b).ToString();
                    break;
                case "÷":
                    // Generate division with whole number result
                    b = random.Next(1, 10);
                    a = b * random.Next(1, 10); // This ensures a is divisible by b
                    currentCaptchaText = (a / b).ToString();
                    break;
            }

            lblMathProblem.Text = $"{a} {operation} {b} = ?";
        }

        private void txtCaptchaInput_KeyPress(object? sender, KeyPressEventArgs e)
        {
            // Allow submission with Enter key
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSubmit_Click(sender, EventArgs.Empty);
            }
        }

        // This method would be called when the form is closing to clean up resources
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Clean up any resources
            if (picCaptchaImage.Image != null)
            {
                picCaptchaImage.Image.Dispose();
            }

            if (picCaptchaVerification.Image != null)
            {
                picCaptchaVerification.Image.Dispose();
            }

            if (pictureBoxLogo.Image != null)
            {
                pictureBoxLogo.Image.Dispose();
            }
        }

        private void picCaptchaImage_Click(object sender, EventArgs e)
        {

        }

        // The InitializeComponent method would be auto-generated and contain designer code
        // This is a placeholder for that method
    }
}