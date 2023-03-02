
namespace Bai06
{
    partial class Client
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPRKey = new System.Windows.Forms.TextBox();
            this.tbPUKey = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lvMessageShow = new System.Windows.Forms.ListView();
            this.tbNameInput = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbMessageText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(403, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Private Key:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(403, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Public Key:";
            // 
            // tbPRKey
            // 
            this.tbPRKey.Location = new System.Drawing.Point(497, 222);
            this.tbPRKey.Multiline = true;
            this.tbPRKey.Name = "tbPRKey";
            this.tbPRKey.Size = new System.Drawing.Size(272, 52);
            this.tbPRKey.TabIndex = 30;
            // 
            // tbPUKey
            // 
            this.tbPUKey.Location = new System.Drawing.Point(497, 142);
            this.tbPUKey.Multiline = true;
            this.tbPUKey.Name = "tbPUKey";
            this.tbPUKey.Size = new System.Drawing.Size(272, 52);
            this.tbPUKey.TabIndex = 29;
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(578, 41);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 32);
            this.btnConnect.TabIndex = 28;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lvMessageShow
            // 
            this.lvMessageShow.HideSelection = false;
            this.lvMessageShow.Location = new System.Drawing.Point(31, 88);
            this.lvMessageShow.Name = "lvMessageShow";
            this.lvMessageShow.Size = new System.Drawing.Size(342, 275);
            this.lvMessageShow.TabIndex = 27;
            this.lvMessageShow.UseCompatibleStateImageBehavior = false;
            this.lvMessageShow.View = System.Windows.Forms.View.List;
            // 
            // tbNameInput
            // 
            this.tbNameInput.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNameInput.Location = new System.Drawing.Point(238, 41);
            this.tbNameInput.Name = "tbNameInput";
            this.tbNameInput.Size = new System.Drawing.Size(325, 32);
            this.tbNameInput.TabIndex = 26;
            this.tbNameInput.TextChanged += new System.EventHandler(this.tbNameInput_TextChanged);
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.BackColor = System.Drawing.Color.Transparent;
            this.ClientName.Location = new System.Drawing.Point(119, 56);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(88, 17);
            this.ClientName.TabIndex = 25;
            this.ClientName.Text = "Client Name:";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(594, 381);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 28);
            this.btnSend.TabIndex = 24;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbMessageText
            // 
            this.tbMessageText.Location = new System.Drawing.Point(119, 381);
            this.tbMessageText.Name = "tbMessageText";
            this.tbMessageText.Size = new System.Drawing.Size(450, 22);
            this.tbMessageText.TabIndex = 23;
            this.tbMessageText.TextChanged += new System.EventHandler(this.tbMessageText_TextChanged);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPRKey);
            this.Controls.Add(this.tbPUKey);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lvMessageShow);
            this.Controls.Add(this.tbNameInput);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbMessageText);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPRKey;
        private System.Windows.Forms.TextBox tbPUKey;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListView lvMessageShow;
        private System.Windows.Forms.TextBox tbNameInput;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbMessageText;
    }
}