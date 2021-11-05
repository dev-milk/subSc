namespace LoginForm
{
    partial class MainMenu
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
            this.MainMenuImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuImage
            // 
            this.MainMenuImage.Image = global::LoginForm.Properties.Resources.prof_devmilk;
            this.MainMenuImage.Location = new System.Drawing.Point(132, 80);
            this.MainMenuImage.Name = "MainMenuImage";
            this.MainMenuImage.Size = new System.Drawing.Size(301, 304);
            this.MainMenuImage.TabIndex = 0;
            this.MainMenuImage.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 526);
            this.Controls.Add(this.MainMenuImage);
            this.Name = "MainMenu";
            this.Text = "メインメニュー";
            ((System.ComponentModel.ISupportInitialize)(this.MainMenuImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MainMenuImage;
    }
}