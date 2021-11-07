namespace LoginForm
{
    partial class UserForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ServiceCodeLabel = new System.Windows.Forms.Label();
            this.ServiceCodeBox = new System.Windows.Forms.TextBox();
            this.PassCodeBox = new System.Windows.Forms.TextBox();
            this.PassCodeLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServiceCodeLabel
            // 
            this.ServiceCodeLabel.AutoSize = true;
            this.ServiceCodeLabel.Location = new System.Drawing.Point(95, 90);
            this.ServiceCodeLabel.Name = "ServiceCodeLabel";
            this.ServiceCodeLabel.Size = new System.Drawing.Size(69, 12);
            this.ServiceCodeLabel.TabIndex = 0;
            this.ServiceCodeLabel.Text = "サービスコード";
            // 
            // ServiceCodeBox
            // 
            this.ServiceCodeBox.Location = new System.Drawing.Point(170, 87);
            this.ServiceCodeBox.Name = "ServiceCodeBox";
            this.ServiceCodeBox.Size = new System.Drawing.Size(204, 19);
            this.ServiceCodeBox.TabIndex = 1;
            // 
            // PassCodeBox
            // 
            this.PassCodeBox.Location = new System.Drawing.Point(170, 139);
            this.PassCodeBox.Name = "PassCodeBox";
            this.PassCodeBox.Size = new System.Drawing.Size(204, 19);
            this.PassCodeBox.TabIndex = 3;
            this.PassCodeBox.TextChanged += new System.EventHandler(this.PassCodeBox_TextChanged);
            // 
            // PassCodeLabel
            // 
            this.PassCodeLabel.AutoSize = true;
            this.PassCodeLabel.Location = new System.Drawing.Point(113, 142);
            this.PassCodeLabel.Name = "PassCodeLabel";
            this.PassCodeLabel.Size = new System.Drawing.Size(51, 12);
            this.PassCodeLabel.TabIndex = 2;
            this.PassCodeLabel.Text = "パスコード";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.MenuText;
            this.LoginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginButton.Location = new System.Drawing.Point(196, 216);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(130, 35);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "ログイン";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 316);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassCodeBox);
            this.Controls.Add(this.PassCodeLabel);
            this.Controls.Add(this.ServiceCodeBox);
            this.Controls.Add(this.ServiceCodeLabel);
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ログイン画面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServiceCodeLabel;
        private System.Windows.Forms.TextBox ServiceCodeBox;
        private System.Windows.Forms.TextBox PassCodeBox;
        private System.Windows.Forms.Label PassCodeLabel;
        private System.Windows.Forms.Button LoginButton;
    }
}

