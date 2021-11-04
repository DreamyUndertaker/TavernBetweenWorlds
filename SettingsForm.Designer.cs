
namespace LaunhcerForMinecraft
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.OZUChanger = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.OZUChanger)).BeginInit();
            this.SuspendLayout();
            // 
            // OZUChanger
            // 
            this.OZUChanger.BackColor = System.Drawing.Color.Snow;
            this.OZUChanger.Location = new System.Drawing.Point(126, 154);
            this.OZUChanger.Name = "OZUChanger";
            this.OZUChanger.Size = new System.Drawing.Size(510, 45);
            this.OZUChanger.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.OZUChanger);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)(this.OZUChanger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TrackBar OZUChanger;
    }
}