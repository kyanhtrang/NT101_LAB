namespace LAB03_BAI01
{
    partial class LAB03_BAI01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LAB03_BAI01));
            this.cbFormat = new System.Windows.Forms.ComboBox();
            this.lbFormat = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.inputData = new System.Windows.Forms.TextBox();
            this.checkMD5 = new System.Windows.Forms.CheckBox();
            this.checkSHA384 = new System.Windows.Forms.CheckBox();
            this.checkSHA1 = new System.Windows.Forms.CheckBox();
            this.outputMD5 = new System.Windows.Forms.TextBox();
            this.outputSHA1 = new System.Windows.Forms.TextBox();
            this.outputSHA384 = new System.Windows.Forms.TextBox();
            this.btnCal = new System.Windows.Forms.Button();
            this.outputSHA256 = new System.Windows.Forms.TextBox();
            this.checkSHA256 = new System.Windows.Forms.CheckBox();
            this.outputSHA512 = new System.Windows.Forms.TextBox();
            this.checkSHA512 = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbFormat
            // 
            this.cbFormat.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFormat.FormattingEnabled = true;
            this.cbFormat.Items.AddRange(new object[] {
            "Text string",
            "Hex string",
            "File"});
            this.cbFormat.Location = new System.Drawing.Point(150, 25);
            this.cbFormat.Name = "cbFormat";
            this.cbFormat.Size = new System.Drawing.Size(250, 27);
            this.cbFormat.TabIndex = 0;
            // 
            // lbFormat
            // 
            this.lbFormat.AutoSize = true;
            this.lbFormat.BackColor = System.Drawing.Color.Transparent;
            this.lbFormat.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormat.Location = new System.Drawing.Point(15, 25);
            this.lbFormat.Name = "lbFormat";
            this.lbFormat.Size = new System.Drawing.Size(120, 24);
            this.lbFormat.TabIndex = 1;
            this.lbFormat.Text = "Data format";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.BackColor = System.Drawing.Color.Transparent;
            this.lbData.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(15, 75);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(54, 24);
            this.lbData.TabIndex = 2;
            this.lbData.Text = "Data";
            // 
            // inputData
            // 
            this.inputData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputData.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputData.Location = new System.Drawing.Point(150, 72);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(625, 27);
            this.inputData.TabIndex = 3;
            // 
            // checkMD5
            // 
            this.checkMD5.AutoSize = true;
            this.checkMD5.BackColor = System.Drawing.Color.Transparent;
            this.checkMD5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMD5.Location = new System.Drawing.Point(15, 125);
            this.checkMD5.Name = "checkMD5";
            this.checkMD5.Size = new System.Drawing.Size(64, 23);
            this.checkMD5.TabIndex = 4;
            this.checkMD5.Text = "MD5";
            this.checkMD5.UseVisualStyleBackColor = false;
            // 
            // checkSHA384
            // 
            this.checkSHA384.AutoSize = true;
            this.checkSHA384.BackColor = System.Drawing.Color.Transparent;
            this.checkSHA384.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSHA384.Location = new System.Drawing.Point(15, 275);
            this.checkSHA384.Name = "checkSHA384";
            this.checkSHA384.Size = new System.Drawing.Size(87, 23);
            this.checkSHA384.TabIndex = 9;
            this.checkSHA384.Text = "SHA384";
            this.checkSHA384.UseVisualStyleBackColor = false;
            // 
            // checkSHA1
            // 
            this.checkSHA1.AutoSize = true;
            this.checkSHA1.BackColor = System.Drawing.Color.Transparent;
            this.checkSHA1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSHA1.Location = new System.Drawing.Point(15, 175);
            this.checkSHA1.Name = "checkSHA1";
            this.checkSHA1.Size = new System.Drawing.Size(69, 23);
            this.checkSHA1.TabIndex = 10;
            this.checkSHA1.Text = "SHA1";
            this.checkSHA1.UseVisualStyleBackColor = false;
            // 
            // outputMD5
            // 
            this.outputMD5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputMD5.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputMD5.Location = new System.Drawing.Point(150, 122);
            this.outputMD5.Name = "outputMD5";
            this.outputMD5.Size = new System.Drawing.Size(625, 27);
            this.outputMD5.TabIndex = 11;
            // 
            // outputSHA1
            // 
            this.outputSHA1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputSHA1.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputSHA1.Location = new System.Drawing.Point(150, 172);
            this.outputSHA1.Name = "outputSHA1";
            this.outputSHA1.Size = new System.Drawing.Size(625, 27);
            this.outputSHA1.TabIndex = 12;
            // 
            // outputSHA384
            // 
            this.outputSHA384.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputSHA384.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputSHA384.Location = new System.Drawing.Point(150, 272);
            this.outputSHA384.Multiline = true;
            this.outputSHA384.Name = "outputSHA384";
            this.outputSHA384.Size = new System.Drawing.Size(625, 50);
            this.outputSHA384.TabIndex = 13;
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCal.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.Location = new System.Drawing.Point(675, 22);
            this.btnCal.Margin = new System.Windows.Forms.Padding(2);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(100, 32);
            this.btnCal.TabIndex = 14;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // outputSHA256
            // 
            this.outputSHA256.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputSHA256.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputSHA256.Location = new System.Drawing.Point(150, 222);
            this.outputSHA256.Name = "outputSHA256";
            this.outputSHA256.Size = new System.Drawing.Size(625, 27);
            this.outputSHA256.TabIndex = 18;
            // 
            // checkSHA256
            // 
            this.checkSHA256.AutoSize = true;
            this.checkSHA256.BackColor = System.Drawing.Color.Transparent;
            this.checkSHA256.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSHA256.Location = new System.Drawing.Point(15, 225);
            this.checkSHA256.Name = "checkSHA256";
            this.checkSHA256.Size = new System.Drawing.Size(87, 23);
            this.checkSHA256.TabIndex = 17;
            this.checkSHA256.Text = "SHA256";
            this.checkSHA256.UseVisualStyleBackColor = false;
            // 
            // outputSHA512
            // 
            this.outputSHA512.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputSHA512.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputSHA512.Location = new System.Drawing.Point(150, 348);
            this.outputSHA512.Multiline = true;
            this.outputSHA512.Name = "outputSHA512";
            this.outputSHA512.Size = new System.Drawing.Size(625, 50);
            this.outputSHA512.TabIndex = 20;
            // 
            // checkSHA512
            // 
            this.checkSHA512.AutoSize = true;
            this.checkSHA512.BackColor = System.Drawing.Color.Transparent;
            this.checkSHA512.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSHA512.Location = new System.Drawing.Point(15, 350);
            this.checkSHA512.Name = "checkSHA512";
            this.checkSHA512.Size = new System.Drawing.Size(87, 23);
            this.checkSHA512.TabIndex = 19;
            this.checkSHA512.Text = "SHA512";
            this.checkSHA512.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(550, 22);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 32);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(425, 22);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(100, 32);
            this.btnOpenFile.TabIndex = 22;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // LAB03_BAI01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.outputSHA512);
            this.Controls.Add(this.checkSHA512);
            this.Controls.Add(this.outputSHA256);
            this.Controls.Add(this.checkSHA256);
            this.Controls.Add(this.btnCal);
            this.Controls.Add(this.outputSHA384);
            this.Controls.Add(this.outputSHA1);
            this.Controls.Add(this.outputMD5);
            this.Controls.Add(this.checkSHA1);
            this.Controls.Add(this.checkSHA384);
            this.Controls.Add(this.checkMD5);
            this.Controls.Add(this.inputData);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbFormat);
            this.Controls.Add(this.cbFormat);
            this.Name = "LAB03_BAI01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAB03_BAI01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFormat;
        private System.Windows.Forms.Label lbFormat;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.TextBox inputData;
        private System.Windows.Forms.CheckBox checkMD5;
        private System.Windows.Forms.CheckBox checkSHA384;
        private System.Windows.Forms.CheckBox checkSHA1;
        private System.Windows.Forms.TextBox outputMD5;
        private System.Windows.Forms.TextBox outputSHA1;
        private System.Windows.Forms.TextBox outputSHA384;
        private System.Windows.Forms.Button btnCal;
        private System.Windows.Forms.TextBox outputSHA256;
        private System.Windows.Forms.CheckBox checkSHA256;
        private System.Windows.Forms.TextBox outputSHA512;
        private System.Windows.Forms.CheckBox checkSHA512;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOpenFile;
    }
}

