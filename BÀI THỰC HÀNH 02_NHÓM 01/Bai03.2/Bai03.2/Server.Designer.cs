
namespace Bai03._2
{
    partial class Server
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
            this.tbMessageShow = new System.Windows.Forms.ListView();
            this.btnListen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMessageShow
            // 
            this.tbMessageShow.HideSelection = false;
            this.tbMessageShow.Location = new System.Drawing.Point(125, 125);
            this.tbMessageShow.Name = "tbMessageShow";
            this.tbMessageShow.Size = new System.Drawing.Size(550, 300);
            this.tbMessageShow.TabIndex = 7;
            this.tbMessageShow.UseCompatibleStateImageBehavior = false;
            this.tbMessageShow.View = System.Windows.Forms.View.List;
            // 
            // btnListen
            // 
            this.btnListen.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListen.Location = new System.Drawing.Point(525, 82);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(150, 35);
            this.btnListen.TabIndex = 6;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbMessageShow);
            this.Controls.Add(this.btnListen);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView tbMessageShow;
        private System.Windows.Forms.Button btnListen;
    }
}