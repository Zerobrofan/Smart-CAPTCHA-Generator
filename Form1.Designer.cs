namespace CVValidator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">True if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            comboCaptchaType = new ComboBox();
            lblCaptchaType = new Label();
            txtCaptchaInput = new TextBox();
            btnSubmit = new Button();
            btnRefresh = new Button();
            picCaptchaImage = new PictureBox();
            chkReCaptcha = new CheckBox();
            panelHeader = new Panel();
            lblHeader = new Label();
            panelMain = new Panel();
            panelCaptchaContainer = new Panel();
            lblInstruction = new Label();
            lblMathProblem = new Label();
            panelLeft = new Panel();
            pictureBoxLogo = new PictureBox();
            lblAppDescription = new Label();
            panelFooter = new Panel();
            statusStrip = new StatusStrip();
            statusLabel = new ToolStripStatusLabel();
            picCaptchaVerification = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picCaptchaImage).BeginInit();
            panelHeader.SuspendLayout();
            panelMain.SuspendLayout();
            panelCaptchaContainer.SuspendLayout();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelFooter.SuspendLayout();
            statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCaptchaVerification).BeginInit();
            SuspendLayout();
            // 
            // comboCaptchaType
            // 
            comboCaptchaType.BackColor = Color.FromArgb(250, 250, 255);
            comboCaptchaType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboCaptchaType.Font = new Font("Segoe UI", 11F);
            comboCaptchaType.FormattingEnabled = true;
            comboCaptchaType.Location = new Point(170, 20);
            comboCaptchaType.Name = "comboCaptchaType";
            comboCaptchaType.Size = new Size(330, 33);
            comboCaptchaType.TabIndex = 0;
            comboCaptchaType.SelectedIndexChanged += comboCaptchaType_SelectedIndexChanged;
            // 
            // lblCaptchaType
            // 
            lblCaptchaType.AutoSize = true;
            lblCaptchaType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblCaptchaType.ForeColor = Color.FromArgb(32, 64, 96);
            lblCaptchaType.Location = new Point(5, 22);
            lblCaptchaType.Name = "lblCaptchaType";
            lblCaptchaType.Size = new Size(164, 28);
            lblCaptchaType.TabIndex = 1;
            lblCaptchaType.Text = "Select CAPTCHA:";
            // 
            // txtCaptchaInput
            // 
            txtCaptchaInput.BackColor = Color.FromArgb(250, 250, 255);
            txtCaptchaInput.BorderStyle = BorderStyle.FixedSingle;
            txtCaptchaInput.Font = new Font("Segoe UI", 11F);
            txtCaptchaInput.Location = new Point(55, 265);
            txtCaptchaInput.Name = "txtCaptchaInput";
            txtCaptchaInput.Size = new Size(330, 32);
            txtCaptchaInput.TabIndex = 2;
            txtCaptchaInput.KeyPress += txtCaptchaInput_KeyPress;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(52, 168, 83);
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(480, 15);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(180, 45);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Verify CAPTCHA";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(66, 156, 227);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 11F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(395, 100);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 40);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "↻ Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // picCaptchaImage
            // 
            picCaptchaImage.BackColor = Color.FromArgb(250, 250, 255);
            picCaptchaImage.BorderStyle = BorderStyle.FixedSingle;
            picCaptchaImage.Location = new Point(55, 70);
            picCaptchaImage.Name = "picCaptchaImage";
            picCaptchaImage.Size = new Size(330, 95);
            picCaptchaImage.SizeMode = PictureBoxSizeMode.StretchImage;
            picCaptchaImage.TabIndex = 5;
            picCaptchaImage.TabStop = false;
            picCaptchaImage.Click += picCaptchaImage_Click;
            // 
            // chkReCaptcha
            // 
            chkReCaptcha.AutoSize = true;
            chkReCaptcha.Cursor = Cursors.Hand;
            chkReCaptcha.Font = new Font("Segoe UI", 11F);
            chkReCaptcha.ForeColor = Color.FromArgb(32, 64, 96);
            chkReCaptcha.Location = new Point(55, 265);
            chkReCaptcha.Name = "chkReCaptcha";
            chkReCaptcha.Size = new Size(158, 29);
            chkReCaptcha.TabIndex = 6;
            chkReCaptcha.Text = "I'm not a robot";
            chkReCaptcha.UseVisualStyleBackColor = true;
            chkReCaptcha.Visible = false;
            chkReCaptcha.CheckedChanged += chkReCaptcha_CheckedChanged;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(32, 64, 96);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(800, 65);
            panelHeader.TabIndex = 7;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(25, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(386, 41);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Smart CAPTCHA Validator";
            lblHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(245, 248, 252);
            panelMain.Controls.Add(panelCaptchaContainer);
            panelMain.Controls.Add(panelLeft);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 65);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(800, 331);
            panelMain.TabIndex = 8;
            // 
            // panelCaptchaContainer
            // 
            panelCaptchaContainer.BackColor = Color.White;
            panelCaptchaContainer.Controls.Add(lblCaptchaType);
            panelCaptchaContainer.Controls.Add(comboCaptchaType);
            panelCaptchaContainer.Controls.Add(lblInstruction);
            panelCaptchaContainer.Controls.Add(picCaptchaImage);
            panelCaptchaContainer.Controls.Add(btnRefresh);
            panelCaptchaContainer.Controls.Add(txtCaptchaInput);
            panelCaptchaContainer.Controls.Add(chkReCaptcha);
            panelCaptchaContainer.Controls.Add(lblMathProblem);
            panelCaptchaContainer.Location = new Point(250, 15);
            panelCaptchaContainer.Name = "panelCaptchaContainer";
            panelCaptchaContainer.Padding = new Padding(20);
            panelCaptchaContainer.Size = new Size(535, 310);
            panelCaptchaContainer.TabIndex = 9;
            panelCaptchaContainer.Paint += PanelCaptchaContainer_Paint;
            // 
            // lblInstruction
            // 
            lblInstruction.AutoSize = true;
            lblInstruction.Font = new Font("Segoe UI", 10F);
            lblInstruction.ForeColor = Color.FromArgb(80, 80, 80);
            lblInstruction.Location = new Point(55, 235);
            lblInstruction.Name = "lblInstruction";
            lblInstruction.Size = new Size(281, 23);
            lblInstruction.TabIndex = 7;
            lblInstruction.Text = "Enter the characters you see above:";
            // 
            // lblMathProblem
            // 
            lblMathProblem.BackColor = Color.FromArgb(250, 250, 255);
            lblMathProblem.BorderStyle = BorderStyle.FixedSingle;
            lblMathProblem.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMathProblem.ForeColor = Color.FromArgb(32, 64, 96);
            lblMathProblem.Location = new Point(55, 100);
            lblMathProblem.Name = "lblMathProblem";
            lblMathProblem.Size = new Size(330, 30);
            lblMathProblem.TabIndex = 8;
            lblMathProblem.TextAlign = ContentAlignment.MiddleCenter;
            lblMathProblem.Visible = false;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(40, 75, 110);
            panelLeft.Controls.Add(pictureBoxLogo);
            panelLeft.Controls.Add(lblAppDescription);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(235, 331);
            panelLeft.TabIndex = 10;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Location = new Point(67, 40);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(100, 100);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // lblAppDescription
            // 
            lblAppDescription.Font = new Font("Segoe UI", 10F);
            lblAppDescription.ForeColor = Color.White;
            lblAppDescription.Location = new Point(20, 160);
            lblAppDescription.Name = "lblAppDescription";
            lblAppDescription.Size = new Size(195, 135);
            lblAppDescription.TabIndex = 1;
            lblAppDescription.Text = "Validate different types of CAPTCHAs to enhance your site security and protect against automated bots.";
            lblAppDescription.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(245, 248, 252);
            panelFooter.Controls.Add(btnSubmit);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 396);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(800, 70);
            panelFooter.TabIndex = 9;
            // 
            // statusStrip
            // 
            statusStrip.BackColor = Color.FromArgb(32, 64, 96);
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { statusLabel });
            statusStrip.Location = new Point(0, 466);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 26);
            statusStrip.TabIndex = 10;
            statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            statusLabel.ForeColor = Color.White;
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(50, 20);
            statusLabel.Text = "Ready";
            // 
            // picCaptchaVerification
            // 
            picCaptchaVerification.Location = new Point(213, 205);
            picCaptchaVerification.Name = "picCaptchaVerification";
            picCaptchaVerification.Size = new Size(24, 24);
            picCaptchaVerification.SizeMode = PictureBoxSizeMode.StretchImage;
            picCaptchaVerification.TabIndex = 11;
            picCaptchaVerification.TabStop = false;
            picCaptchaVerification.Visible = false;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 492);
            Controls.Add(panelMain);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Controls.Add(statusStrip);
            Controls.Add(picCaptchaVerification);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Smart CAPTCHA Validator";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picCaptchaImage).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelMain.ResumeLayout(false);
            panelCaptchaContainer.ResumeLayout(false);
            panelCaptchaContainer.PerformLayout();
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelFooter.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCaptchaVerification).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboCaptchaType;
        private System.Windows.Forms.Label lblCaptchaType;
        private System.Windows.Forms.TextBox txtCaptchaInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox picCaptchaImage;
        private System.Windows.Forms.CheckBox chkReCaptcha;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Panel panelCaptchaContainer;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblAppDescription;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label lblMathProblem; // Added declaration
        private System.Windows.Forms.PictureBox picCaptchaVerification; // Added declaration

        private void PanelCaptchaContainer_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            // Create shadow effect for the panel
            System.Drawing.Graphics g = e.Graphics;
            System.Drawing.Rectangle rect = panelCaptchaContainer.ClientRectangle;
            System.Drawing.Drawing2D.LinearGradientBrush shadowBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
                rect,
                System.Drawing.Color.FromArgb(8, 8, 8, 8),
                System.Drawing.Color.Transparent,
                System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(shadowBrush, rect);
        }
    }
}