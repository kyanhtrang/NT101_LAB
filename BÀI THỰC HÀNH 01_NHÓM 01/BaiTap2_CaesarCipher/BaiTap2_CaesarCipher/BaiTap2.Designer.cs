namespace BaiTap2_CaesarCipher
{
    partial class BaiTap2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaiTap2));
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.inputKey = new System.Windows.Forms.RichTextBox();
            this.lbKey = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.lbContent = new System.Windows.Forms.FlowLayoutPanel();
            this.outputText = new System.Windows.Forms.Label();
            this.lbContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Linen;
            this.btnEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(493, 31);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(200, 43);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Linen;
            this.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(713, 31);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(200, 43);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // inputKey
            // 
            this.inputKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputKey.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputKey.Location = new System.Drawing.Point(180, 34);
            this.inputKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputKey.Name = "inputKey";
            this.inputKey.Size = new System.Drawing.Size(265, 36);
            this.inputKey.TabIndex = 4;
            this.inputKey.Text = "";
            // 
            // lbKey
            // 
            this.lbKey.AutoSize = true;
            this.lbKey.BackColor = System.Drawing.Color.Transparent;
            this.lbKey.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKey.Location = new System.Drawing.Point(27, 37);
            this.lbKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKey.Name = "lbKey";
            this.lbKey.Size = new System.Drawing.Size(114, 32);
            this.lbKey.TabIndex = 5;
            this.lbKey.Text = "Your key:";
            // 
            // inputText
            // 
            this.inputText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputText.Location = new System.Drawing.Point(20, 105);
            this.inputText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.inputText.Multiline = true;
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(433, 430);
            this.inputText.TabIndex = 7;
            // 
            // lbContent
            // 
            this.lbContent.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbContent.Controls.Add(this.outputText);
            this.lbContent.Location = new System.Drawing.Point(480, 105);
            this.lbContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(433, 430);
            this.lbContent.TabIndex = 8;
            // 
            // outputText
            // 
            this.outputText.AutoSize = true;
            this.outputText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.Location = new System.Drawing.Point(4, 0);
            this.outputText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(0, 28);
            this.outputText.TabIndex = 0;
            // 
            // BaiTap2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BaiTap2_CaesarCipher.Properties.Resources.magicpattern_oPH_5xuMgQw_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.inputText);
            this.Controls.Add(this.lbKey);
            this.Controls.Add(this.inputKey);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BaiTap2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm 1 - Bài tập số 2";
            this.lbContent.ResumeLayout(false);
            this.lbContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.RichTextBox inputKey;
        private System.Windows.Forms.Label lbKey;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.FlowLayoutPanel lbContent;
        private System.Windows.Forms.Label outputText;
    }
}

