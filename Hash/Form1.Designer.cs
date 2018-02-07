namespace Hash
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sha256HashOption = new System.Windows.Forms.RadioButton();
            this.sha512HashOption = new System.Windows.Forms.RadioButton();
            this.sha1HashOption = new System.Windows.Forms.RadioButton();
            this.md5HashOption = new System.Windows.Forms.RadioButton();
            this.txtText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHash = new System.Windows.Forms.Button();
            this.pickFile = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sha512HashOption);
            this.groupBox1.Controls.Add(this.sha256HashOption);
            this.groupBox1.Controls.Add(this.md5HashOption);
            this.groupBox1.Controls.Add(this.sha1HashOption);
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hashing Algorithms";
            // 
            // sha256HashOption
            // 
            this.sha256HashOption.AutoSize = true;
            this.sha256HashOption.Location = new System.Drawing.Point(20, 95);
            this.sha256HashOption.Name = "sha256HashOption";
            this.sha256HashOption.Size = new System.Drawing.Size(104, 19);
            this.sha256HashOption.TabIndex = 7;
            this.sha256HashOption.Text = "SHA256 Hash";
            this.sha256HashOption.UseVisualStyleBackColor = true;
            // 
            // sha512HashOption
            // 
            this.sha512HashOption.AutoSize = true;
            this.sha512HashOption.Location = new System.Drawing.Point(20, 125);
            this.sha512HashOption.Name = "sha512HashOption";
            this.sha512HashOption.Size = new System.Drawing.Size(104, 19);
            this.sha512HashOption.TabIndex = 6;
            this.sha512HashOption.Text = "SHA512 Hash";
            this.sha512HashOption.UseVisualStyleBackColor = true;
            // 
            // sha1HashOption
            // 
            this.sha1HashOption.AutoSize = true;
            this.sha1HashOption.Checked = true;
            this.sha1HashOption.Location = new System.Drawing.Point(20, 65);
            this.sha1HashOption.Name = "sha1HashOption";
            this.sha1HashOption.Size = new System.Drawing.Size(90, 19);
            this.sha1HashOption.TabIndex = 5;
            this.sha1HashOption.TabStop = true;
            this.sha1HashOption.Text = "SHA1 Hash";
            this.sha1HashOption.UseVisualStyleBackColor = true;
            // 
            // md5HashOption
            // 
            this.md5HashOption.AutoSize = true;
            this.md5HashOption.Location = new System.Drawing.Point(20, 35);
            this.md5HashOption.Name = "md5HashOption";
            this.md5HashOption.Size = new System.Drawing.Size(85, 19);
            this.md5HashOption.TabIndex = 4;
            this.md5HashOption.Text = "MD5 Hash";
            this.md5HashOption.UseVisualStyleBackColor = true;
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(190, 30);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(330, 36);
            this.txtText.TabIndex = 1;
            this.txtText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Get text file containing text:";
            // 
            // txtValue
            // 
            this.txtValue.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValue.Location = new System.Drawing.Point(193, 136);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(379, 36);
            this.txtValue.TabIndex = 3;
            this.txtValue.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hashed Value:";
            // 
            // btnHash
            // 
            this.btnHash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHash.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHash.Location = new System.Drawing.Point(335, 80);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(80, 25);
            this.btnHash.TabIndex = 5;
            this.btnHash.Text = "Hash Text";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // pickFile
            // 
            this.pickFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pickFile.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickFile.Location = new System.Drawing.Point(526, 30);
            this.pickFile.Name = "pickFile";
            this.pickFile.Size = new System.Drawing.Size(43, 36);
            this.pickFile.TabIndex = 7;
            this.pickFile.Text = "...";
            this.pickFile.UseVisualStyleBackColor = true;
            this.pickFile.Click += new System.EventHandler(this.pickFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 191);
            this.Controls.Add(this.pickFile);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sha512HashOption;
        private System.Windows.Forms.RadioButton sha256HashOption;
        private System.Windows.Forms.RadioButton md5HashOption;
        private System.Windows.Forms.RadioButton sha1HashOption;
        private System.Windows.Forms.RichTextBox txtText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Button pickFile;
    }
}

