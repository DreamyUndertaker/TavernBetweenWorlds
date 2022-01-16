
namespace LaunhcerForMinecraft
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LogoImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.PassField = new System.Windows.Forms.TextBox();
            this.DiskordLink = new System.Windows.Forms.PictureBox();
            this.VKLink = new System.Windows.Forms.PictureBox();
            this.YouTubeLink = new System.Windows.Forms.PictureBox();
            this.CivitatumTeamLink = new System.Windows.Forms.PictureBox();
            this.RegistrationLabel = new System.Windows.Forms.Label();
            this.LostPassLabel = new System.Windows.Forms.Label();
            this.FAQLabel = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.SettingsBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiskordLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VKLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YouTubeLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CivitatumTeamLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoImage
            // 
            this.LogoImage.BackColor = System.Drawing.Color.Sienna;
            this.LogoImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoImage.BackgroundImage")));
            this.LogoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogoImage.Image = ((System.Drawing.Image)(resources.GetObject("LogoImage.Image")));
            this.LogoImage.Location = new System.Drawing.Point(12, 12);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(277, 271);
            this.LogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoImage.TabIndex = 0;
            this.LogoImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 621);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.LoginField.Location = new System.Drawing.Point(12, 313);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(277, 23);
            this.LoginField.TabIndex = 2;
            this.LoginField.Enter += new System.EventHandler(this.LoginField_Enter);
            this.LoginField.Leave += new System.EventHandler(this.LoginField_Leave);
            // 
            // PassField
            // 
            this.PassField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassField.Location = new System.Drawing.Point(12, 342);
            this.PassField.Name = "PassField";
            this.PassField.Size = new System.Drawing.Size(277, 23);
            this.PassField.TabIndex = 3;
            this.PassField.Enter += new System.EventHandler(this.PassField_Enter);
            this.PassField.Leave += new System.EventHandler(this.PassField_Leave);
            // 
            // DiskordLink
            // 
            this.DiskordLink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DiskordLink.BackgroundImage")));
            this.DiskordLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DiskordLink.Location = new System.Drawing.Point(22, 543);
            this.DiskordLink.Name = "DiskordLink";
            this.DiskordLink.Size = new System.Drawing.Size(60, 60);
            this.DiskordLink.TabIndex = 4;
            this.DiskordLink.TabStop = false;
            this.DiskordLink.Click += new System.EventHandler(this.DiskordLink_Click);
            // 
            // VKLink
            // 
            this.VKLink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VKLink.BackgroundImage")));
            this.VKLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.VKLink.Location = new System.Drawing.Point(88, 543);
            this.VKLink.Name = "VKLink";
            this.VKLink.Size = new System.Drawing.Size(60, 60);
            this.VKLink.TabIndex = 5;
            this.VKLink.TabStop = false;
            this.VKLink.Click += new System.EventHandler(this.VKLink_Click);
            // 
            // YouTubeLink
            // 
            this.YouTubeLink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("YouTubeLink.BackgroundImage")));
            this.YouTubeLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.YouTubeLink.Location = new System.Drawing.Point(154, 543);
            this.YouTubeLink.Name = "YouTubeLink";
            this.YouTubeLink.Size = new System.Drawing.Size(60, 60);
            this.YouTubeLink.TabIndex = 6;
            this.YouTubeLink.TabStop = false;
            this.YouTubeLink.Click += new System.EventHandler(this.YouTubeLink_Click);
            // 
            // CivitatumTeamLink
            // 
            this.CivitatumTeamLink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CivitatumTeamLink.BackgroundImage")));
            this.CivitatumTeamLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CivitatumTeamLink.Location = new System.Drawing.Point(220, 543);
            this.CivitatumTeamLink.Name = "CivitatumTeamLink";
            this.CivitatumTeamLink.Size = new System.Drawing.Size(60, 60);
            this.CivitatumTeamLink.TabIndex = 7;
            this.CivitatumTeamLink.TabStop = false;
            this.CivitatumTeamLink.Click += new System.EventHandler(this.CivitatumTeamLink_Click);
            // 
            // RegistrationLabel
            // 
            this.RegistrationLabel.AutoSize = true;
            this.RegistrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationLabel.ForeColor = System.Drawing.Color.White;
            this.RegistrationLabel.Location = new System.Drawing.Point(8, 391);
            this.RegistrationLabel.Name = "RegistrationLabel";
            this.RegistrationLabel.Size = new System.Drawing.Size(131, 25);
            this.RegistrationLabel.TabIndex = 8;
            this.RegistrationLabel.Text = "Регистрация";
            this.RegistrationLabel.Click += new System.EventHandler(this.RegistrationLabel_Click);
            // 
            // LostPassLabel
            // 
            this.LostPassLabel.AutoSize = true;
            this.LostPassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LostPassLabel.ForeColor = System.Drawing.Color.White;
            this.LostPassLabel.Location = new System.Drawing.Point(8, 424);
            this.LostPassLabel.Name = "LostPassLabel";
            this.LostPassLabel.Size = new System.Drawing.Size(164, 25);
            this.LostPassLabel.TabIndex = 9;
            this.LostPassLabel.Text = "Забыли пароль?";
            // 
            // FAQLabel
            // 
            this.FAQLabel.AutoSize = true;
            this.FAQLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FAQLabel.ForeColor = System.Drawing.Color.White;
            this.FAQLabel.Location = new System.Drawing.Point(8, 457);
            this.FAQLabel.Name = "FAQLabel";
            this.FAQLabel.Size = new System.Drawing.Size(268, 25);
            this.FAQLabel.TabIndex = 10;
            this.FAQLabel.Text = "Есть вопрос? Нажми сюда!";
            // 
            // EnterButton
            // 
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.EnterButton.ForeColor = System.Drawing.Color.White;
            this.EnterButton.Location = new System.Drawing.Point(733, 544);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(239, 65);
            this.EnterButton.TabIndex = 11;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // SettingsBox
            // 
            this.SettingsBox.BackColor = System.Drawing.Color.Sienna;
            this.SettingsBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsBox.BackgroundImage")));
            this.SettingsBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("SettingsBox.ErrorImage")));
            this.SettingsBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("SettingsBox.InitialImage")));
            this.SettingsBox.Location = new System.Drawing.Point(661, 544);
            this.SettingsBox.Name = "SettingsBox";
            this.SettingsBox.Size = new System.Drawing.Size(66, 65);
            this.SettingsBox.TabIndex = 12;
            this.SettingsBox.TabStop = false;
            this.SettingsBox.Click += new System.EventHandler(this.SettingsBox_Click);
            // 
            // LoginForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 621);
            this.Controls.Add(this.SettingsBox);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.FAQLabel);
            this.Controls.Add(this.LostPassLabel);
            this.Controls.Add(this.RegistrationLabel);
            this.Controls.Add(this.CivitatumTeamLink);
            this.Controls.Add(this.YouTubeLink);
            this.Controls.Add(this.VKLink);
            this.Controls.Add(this.DiskordLink);
            this.Controls.Add(this.PassField);
            this.Controls.Add(this.LoginField);
            this.Controls.Add(this.LogoImage);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "• Tavern Between Worlds •";
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DiskordLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VKLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YouTubeLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CivitatumTeamLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SettingsBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.TextBox PassField;
        private System.Windows.Forms.PictureBox DiskordLink;
        private System.Windows.Forms.PictureBox VKLink;
        private System.Windows.Forms.PictureBox YouTubeLink;
        private System.Windows.Forms.PictureBox CivitatumTeamLink;
        private System.Windows.Forms.Label RegistrationLabel;
        private System.Windows.Forms.Label LostPassLabel;
        private System.Windows.Forms.Label FAQLabel;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.PictureBox SettingsBox;
    }
}

