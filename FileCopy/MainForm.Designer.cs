namespace FileCopy
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelect = new System.Windows.Forms.Button();
            this.tbFolderPath = new System.Windows.Forms.TextBox();
            this.lbFolderTitle = new System.Windows.Forms.Label();
            this.btnFindFileType = new System.Windows.Forms.Button();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.btnSelect2 = new System.Windows.Forms.Button();
            this.tbFolderPath2 = new System.Windows.Forms.TextBox();
            this.lbFolderTitle2 = new System.Windows.Forms.Label();
            this.btnCoptFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(598, 52);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "选择";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // tbFolderPath
            // 
            this.tbFolderPath.Location = new System.Drawing.Point(120, 52);
            this.tbFolderPath.Name = "tbFolderPath";
            this.tbFolderPath.ReadOnly = true;
            this.tbFolderPath.Size = new System.Drawing.Size(472, 21);
            this.tbFolderPath.TabIndex = 1;
            // 
            // lbFolderTitle
            // 
            this.lbFolderTitle.Location = new System.Drawing.Point(52, 50);
            this.lbFolderTitle.Name = "lbFolderTitle";
            this.lbFolderTitle.Size = new System.Drawing.Size(62, 23);
            this.lbFolderTitle.TabIndex = 2;
            this.lbFolderTitle.Text = "文件夹：";
            this.lbFolderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFindFileType
            // 
            this.btnFindFileType.Location = new System.Drawing.Point(120, 563);
            this.btnFindFileType.Name = "btnFindFileType";
            this.btnFindFileType.Size = new System.Drawing.Size(94, 23);
            this.btnFindFileType.TabIndex = 3;
            this.btnFindFileType.Text = "查找文件类型";
            this.btnFindFileType.UseVisualStyleBackColor = true;
            this.btnFindFileType.Click += new System.EventHandler(this.btnFindFileType_Click);
            // 
            // rtbContent
            // 
            this.rtbContent.BackColor = System.Drawing.Color.White;
            this.rtbContent.Location = new System.Drawing.Point(120, 138);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(553, 406);
            this.rtbContent.TabIndex = 4;
            this.rtbContent.Text = "";
            // 
            // btnSelect2
            // 
            this.btnSelect2.Location = new System.Drawing.Point(598, 88);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.Size = new System.Drawing.Size(75, 23);
            this.btnSelect2.TabIndex = 0;
            this.btnSelect2.Text = "选择";
            this.btnSelect2.UseVisualStyleBackColor = true;
            this.btnSelect2.Click += new System.EventHandler(this.btnSelect2_Click);
            // 
            // tbFolderPath2
            // 
            this.tbFolderPath2.Location = new System.Drawing.Point(120, 88);
            this.tbFolderPath2.Name = "tbFolderPath2";
            this.tbFolderPath2.ReadOnly = true;
            this.tbFolderPath2.Size = new System.Drawing.Size(472, 21);
            this.tbFolderPath2.TabIndex = 1;
            // 
            // lbFolderTitle2
            // 
            this.lbFolderTitle2.Location = new System.Drawing.Point(36, 86);
            this.lbFolderTitle2.Name = "lbFolderTitle2";
            this.lbFolderTitle2.Size = new System.Drawing.Size(78, 23);
            this.lbFolderTitle2.TabIndex = 2;
            this.lbFolderTitle2.Text = "复制文件夹：";
            this.lbFolderTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCoptFile
            // 
            this.btnCoptFile.Location = new System.Drawing.Point(231, 563);
            this.btnCoptFile.Name = "btnCoptFile";
            this.btnCoptFile.Size = new System.Drawing.Size(75, 23);
            this.btnCoptFile.TabIndex = 5;
            this.btnCoptFile.Text = "复制文件";
            this.btnCoptFile.UseVisualStyleBackColor = true;
            this.btnCoptFile.Click += new System.EventHandler(this.btnCoptFile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(749, 618);
            this.Controls.Add(this.btnCoptFile);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.btnFindFileType);
            this.Controls.Add(this.lbFolderTitle2);
            this.Controls.Add(this.lbFolderTitle);
            this.Controls.Add(this.tbFolderPath2);
            this.Controls.Add(this.btnSelect2);
            this.Controls.Add(this.tbFolderPath);
            this.Controls.Add(this.btnSelect);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox tbFolderPath;
        private System.Windows.Forms.Label lbFolderTitle;
        private System.Windows.Forms.Button btnFindFileType;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Button btnSelect2;
        private System.Windows.Forms.TextBox tbFolderPath2;
        private System.Windows.Forms.Label lbFolderTitle2;
        private System.Windows.Forms.Button btnCoptFile;
    }
}

