namespace WhatsappMessageSender
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.borderPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleText = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.phoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.messageTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneToSendTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cuantityText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelMargin = new System.Windows.Forms.Panel();
            this.showPass = new System.Windows.Forms.PictureBox();
            this.hidePass = new System.Windows.Forms.PictureBox();
            this.warning = new System.Windows.Forms.PictureBox();
            this.panelErr = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.enterSend = new System.Windows.Forms.CheckBox();
            this.borderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning)).BeginInit();
            this.panelErr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // borderPanel
            // 
            this.borderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.borderPanel.Controls.Add(this.pictureBox1);
            this.borderPanel.Controls.Add(this.titleText);
            this.borderPanel.Controls.Add(this.minimizeButton);
            this.borderPanel.Controls.Add(this.exitButton);
            this.borderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderPanel.Location = new System.Drawing.Point(0, 0);
            this.borderPanel.Name = "borderPanel";
            this.borderPanel.Size = new System.Drawing.Size(344, 28);
            this.borderPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // titleText
            // 
            this.titleText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(28, 6);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(83, 16);
            this.titleText.TabIndex = 11;
            this.titleText.Text = "Missing No.";
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.minimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeButton.BackgroundImage")));
            this.minimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Location = new System.Drawing.Point(290, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(27, 27);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.exitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitButton.BackgroundImage")));
            this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(316, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(27, 27);
            this.exitButton.TabIndex = 1;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // phoneNumber
            // 
            this.phoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumber.Location = new System.Drawing.Point(13, 61);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(203, 31);
            this.phoneNumber.TabIndex = 1;
            this.phoneNumber.Tag = "control";
            this.phoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneNumber.UseSystemPasswordChar = true;
            this.phoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumber_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número emisor";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messageTextBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageTextBox.Location = new System.Drawing.Point(12, 180);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(320, 231);
            this.messageTextBox.TabIndex = 3;
            this.messageTextBox.Tag = "control";
            this.messageTextBox.Text = "";
            this.messageTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageTextBox_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número receptor";
            // 
            // phoneToSendTextBox
            // 
            this.phoneToSendTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneToSendTextBox.AsciiOnly = true;
            this.phoneToSendTextBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneToSendTextBox.Location = new System.Drawing.Point(13, 117);
            this.phoneToSendTextBox.Name = "phoneToSendTextBox";
            this.phoneToSendTextBox.Size = new System.Drawing.Size(203, 31);
            this.phoneToSendTextBox.TabIndex = 4;
            this.phoneToSendTextBox.Tag = "control";
            this.phoneToSendTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.phoneToSendTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mensaje";
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sendButton.Location = new System.Drawing.Point(166, 417);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(178, 79);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "Enviar";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(0, 417);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 79);
            this.button2.TabIndex = 8;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cuantityText
            // 
            this.cuantityText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuantityText.AutoWordSelection = true;
            this.cuantityText.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuantityText.Location = new System.Drawing.Point(245, 61);
            this.cuantityText.MaxLength = 9;
            this.cuantityText.Multiline = false;
            this.cuantityText.Name = "cuantityText";
            this.cuantityText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.cuantityText.Size = new System.Drawing.Size(87, 31);
            this.cuantityText.TabIndex = 9;
            this.cuantityText.Tag = "control";
            this.cuantityText.Text = "999999999";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "cantidad";
            // 
            // panelMargin
            // 
            this.panelMargin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(165)))));
            this.panelMargin.Location = new System.Drawing.Point(344, 27);
            this.panelMargin.Name = "panelMargin";
            this.panelMargin.Size = new System.Drawing.Size(10, 468);
            this.panelMargin.TabIndex = 11;
            // 
            // showPass
            // 
            this.showPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showPass.BackgroundImage")));
            this.showPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showPass.Location = new System.Drawing.Point(197, 38);
            this.showPass.Name = "showPass";
            this.showPass.Size = new System.Drawing.Size(20, 20);
            this.showPass.TabIndex = 12;
            this.showPass.TabStop = false;
            this.showPass.Click += new System.EventHandler(this.showPass_Click);
            // 
            // hidePass
            // 
            this.hidePass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hidePass.BackgroundImage")));
            this.hidePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hidePass.Location = new System.Drawing.Point(171, 38);
            this.hidePass.Name = "hidePass";
            this.hidePass.Size = new System.Drawing.Size(20, 20);
            this.hidePass.TabIndex = 13;
            this.hidePass.TabStop = false;
            this.hidePass.Visible = false;
            this.hidePass.Click += new System.EventHandler(this.hidePass_Click);
            // 
            // warning
            // 
            this.warning.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("warning.BackgroundImage")));
            this.warning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.warning.Location = new System.Drawing.Point(6, 4);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(20, 20);
            this.warning.TabIndex = 14;
            this.warning.TabStop = false;
            // 
            // panelErr
            // 
            this.panelErr.Controls.Add(this.pictureBox2);
            this.panelErr.Controls.Add(this.warning);
            this.panelErr.Location = new System.Drawing.Point(214, 61);
            this.panelErr.Name = "panelErr";
            this.panelErr.Size = new System.Drawing.Size(30, 87);
            this.panelErr.TabIndex = 15;
            this.panelErr.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(6, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon.BalloonTipText = "Atención: SOLO NÚMEROS!";
            this.notifyIcon.BalloonTipTitle = "Atención: SOLO NÚMEROS!";
            this.notifyIcon.Text = "Atención: SOLO NÚMEROS!";
            this.notifyIcon.Visible = true;
            // 
            // enterSend
            // 
            this.enterSend.AutoSize = true;
            this.enterSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterSend.Location = new System.Drawing.Point(235, 480);
            this.enterSend.Name = "enterSend";
            this.enterSend.Size = new System.Drawing.Size(115, 17);
            this.enterSend.TabIndex = 16;
            this.enterSend.Text = "Enviar con \"Enter\"";
            this.enterSend.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(344, 494);
            this.Controls.Add(this.enterSend);
            this.Controls.Add(this.phoneToSendTextBox);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.panelErr);
            this.Controls.Add(this.showPass);
            this.Controls.Add(this.hidePass);
            this.Controls.Add(this.cuantityText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelMargin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.borderPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message Sender";
            this.Load += new System.EventHandler(this.Index_Load);
            this.borderPanel.ResumeLayout(false);
            this.borderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warning)).EndInit();
            this.panelErr.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel borderPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MaskedTextBox phoneNumber;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.MaskedTextBox phoneToSendTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.RichTextBox cuantityText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelMargin;
        public System.Windows.Forms.RichTextBox messageTextBox;
        private System.Windows.Forms.PictureBox showPass;
        private System.Windows.Forms.PictureBox hidePass;
        private System.Windows.Forms.PictureBox warning;
        private System.Windows.Forms.Panel panelErr;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.CheckBox enterSend;
    }
}

