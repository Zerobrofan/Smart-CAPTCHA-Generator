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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboCaptchaType = new System.Windows.Forms.ComboBox();
            this.lblCaptchaType = new System.Windows.Forms.Label();
            this.txtCaptchaInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.picCaptchaImage = new System.Windows.Forms.PictureBox();
            this.chkReCaptcha = new System.Windows.Forms.CheckBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelCaptchaContainer = new System.Windows.Forms.Panel();
            this.lblMathProblem = new System.Windows.Forms.Label(); // Added math problem label
            this.lblInstruction = new System.Windows.Forms.Label();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblAppDescription = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.picCaptchaVerification = new System.Windows.Forms.PictureBox(); // Added verification picture box
            ((System.ComponentModel.ISupportInitialize)(this.picCaptchaImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptchaVerification)).BeginInit(); // Added initialization
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelCaptchaContainer.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 65);
            this.panelHeader.TabIndex = 7;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(25, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(290, 32);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Smart CAPTCHA Validator";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.panelMain.Controls.Add(this.panelCaptchaContainer);
            this.panelMain.Controls.Add(this.panelLeft);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 65);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 335);
            this.panelMain.TabIndex = 8;
            // 
            // panelCaptchaContainer
            // 
            this.panelCaptchaContainer.BackColor = System.Drawing.Color.White;
            this.panelCaptchaContainer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelCaptchaContainer.Controls.Add(this.lblCaptchaType);
            this.panelCaptchaContainer.Controls.Add(this.comboCaptchaType);
            this.panelCaptchaContainer.Controls.Add(this.lblInstruction);
            this.panelCaptchaContainer.Controls.Add(this.picCaptchaImage);
            this.panelCaptchaContainer.Controls.Add(this.btnRefresh);
            this.panelCaptchaContainer.Controls.Add(this.txtCaptchaInput);
            this.panelCaptchaContainer.Controls.Add(this.chkReCaptcha);
            this.panelCaptchaContainer.Controls.Add(this.lblMathProblem); // Added to controls
            this.panelCaptchaContainer.Location = new System.Drawing.Point(250, 15);
            this.panelCaptchaContainer.Name = "panelCaptchaContainer";
            this.panelCaptchaContainer.Size = new System.Drawing.Size(535, 280);
            this.panelCaptchaContainer.TabIndex = 9;
            this.panelCaptchaContainer.Padding = new System.Windows.Forms.Padding(20);
            this.panelCaptchaContainer.BackColor = System.Drawing.Color.White;
            this.panelCaptchaContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelCaptchaContainer_Paint);
            // 
            // lblMathProblem
            // 
            this.lblMathProblem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMathProblem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.lblMathProblem.Location = new System.Drawing.Point(55, 100);
            this.lblMathProblem.Size = new System.Drawing.Size(330, 30);
            this.lblMathProblem.Name = "lblMathProblem";
            this.lblMathProblem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMathProblem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.lblMathProblem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMathProblem.Visible = false;
            this.lblMathProblem.TabIndex = 8;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblInstruction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblInstruction.Location = new System.Drawing.Point(55, 175);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(223, 19);
            this.lblInstruction.TabIndex = 7;
            this.lblInstruction.Text = "Enter the characters you see above:";
            // 
            // comboCaptchaType
            // 
            this.comboCaptchaType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.comboCaptchaType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCaptchaType.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.comboCaptchaType.FormattingEnabled = true;
            this.comboCaptchaType.Location = new System.Drawing.Point(170, 20);
            this.comboCaptchaType.Name = "comboCaptchaType";
            this.comboCaptchaType.Size = new System.Drawing.Size(330, 28);
            this.comboCaptchaType.TabIndex = 0;
            this.comboCaptchaType.SelectedIndexChanged += new System.EventHandler(this.comboCaptchaType_SelectedIndexChanged);
            // 
            // lblCaptchaType
            // 
            this.lblCaptchaType.AutoSize = true;
            this.lblCaptchaType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblCaptchaType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.lblCaptchaType.Location = new System.Drawing.Point(5, 22);
            this.lblCaptchaType.Name = "lblCaptchaType";
            this.lblCaptchaType.Size = new System.Drawing.Size(128, 21);
            this.lblCaptchaType.TabIndex = 1;
            this.lblCaptchaType.Text = "Select CAPTCHA:";
            // 
            // txtCaptchaInput
            // 
            this.txtCaptchaInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.txtCaptchaInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCaptchaInput.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCaptchaInput.Location = new System.Drawing.Point(55, 205);
            this.txtCaptchaInput.Name = "txtCaptchaInput";
            this.txtCaptchaInput.Size = new System.Drawing.Size(330, 27);
            this.txtCaptchaInput.TabIndex = 2;
            this.txtCaptchaInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCaptchaInput_KeyPress);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(156)))), ((int)(((byte)(227)))));
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(395, 100);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(105, 40);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "↻ Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // picCaptchaImage
            // 
            this.picCaptchaImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.picCaptchaImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCaptchaImage.Location = new System.Drawing.Point(55, 70);
            this.picCaptchaImage.Name = "picCaptchaImage";
            this.picCaptchaImage.Size = new System.Drawing.Size(330, 95);
            this.picCaptchaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCaptchaImage.TabIndex = 5;
            this.picCaptchaImage.TabStop = false;
            // 
            // chkReCaptcha
            // 
            this.chkReCaptcha.AutoSize = true;
            this.chkReCaptcha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkReCaptcha.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.chkReCaptcha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.chkReCaptcha.Location = new System.Drawing.Point(55, 205);
            this.chkReCaptcha.Name = "chkReCaptcha";
            this.chkReCaptcha.Size = new System.Drawing.Size(131, 24);
            this.chkReCaptcha.TabIndex = 6;
            this.chkReCaptcha.Text = "I'm not a robot";
            this.chkReCaptcha.UseVisualStyleBackColor = true;
            this.chkReCaptcha.Visible = false;
            this.chkReCaptcha.CheckedChanged += new System.EventHandler(this.chkReCaptcha_CheckedChanged);
            // 
            // picCaptchaVerification
            // 
            this.picCaptchaVerification.Size = new System.Drawing.Size(24, 24);
            this.picCaptchaVerification.Location = new System.Drawing.Point(chkReCaptcha.Right + 5, chkReCaptcha.Top);
            this.picCaptchaVerification.Name = "picCaptchaVerification";
            this.picCaptchaVerification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCaptchaVerification.TabIndex = 11;
            this.picCaptchaVerification.TabStop = false;
            this.picCaptchaVerification.Visible = false;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(75)))), ((int)(((byte)(110)))));
            this.panelLeft.Controls.Add(this.pictureBoxLogo);
            this.panelLeft.Controls.Add(this.lblAppDescription);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(235, 335);
            this.panelLeft.TabIndex = 10;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(67, 40);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblAppDescription
            // 
            this.lblAppDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAppDescription.ForeColor = System.Drawing.Color.White;
            this.lblAppDescription.Location = new System.Drawing.Point(20, 160);
            this.lblAppDescription.Name = "lblAppDescription";
            this.lblAppDescription.Size = new System.Drawing.Size(195, 135);
            this.lblAppDescription.TabIndex = 1;
            this.lblAppDescription.Text = "Validate different types of CAPTCHAs to enhance your site security and protect against automated bots.";
            this.lblAppDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.panelFooter.Controls.Add(this.btnSubmit);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 400);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(800, 70);
            this.panelFooter.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(168)))), ((int)(((byte)(83)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(480, 15);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(180, 45);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Verify CAPTCHA";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 470);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 10;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.picCaptchaVerification); // Added to main form controls
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart CAPTCHA Validator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picCaptchaImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptchaVerification)).EndInit(); // Added finalization
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelCaptchaContainer.ResumeLayout(false);
            this.panelCaptchaContainer.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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