﻿namespace ChangeGitRemoteUrlTool
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGetBasePath = new System.Windows.Forms.Button();
            this.txtBasePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldUrl = new System.Windows.Forms.TextBox();
            this.txtNewUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReplaceUrl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReplaceUrl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNewUrl);
            this.groupBox1.Controls.Add(this.txtOldUrl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBasePath);
            this.groupBox1.Controls.Add(this.btnGetBasePath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnGetBasePath
            // 
            this.btnGetBasePath.Location = new System.Drawing.Point(370, 26);
            this.btnGetBasePath.Name = "btnGetBasePath";
            this.btnGetBasePath.Size = new System.Drawing.Size(32, 23);
            this.btnGetBasePath.TabIndex = 1;
            this.btnGetBasePath.Text = "...";
            this.btnGetBasePath.UseVisualStyleBackColor = true;
            this.btnGetBasePath.Click += new System.EventHandler(this.btnGetBasePath_Click);
            // 
            // txtBasePath
            // 
            this.txtBasePath.Location = new System.Drawing.Point(86, 26);
            this.txtBasePath.Name = "txtBasePath";
            this.txtBasePath.Size = new System.Drawing.Size(285, 21);
            this.txtBasePath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择目录：";
            // 
            // txtOldUrl
            // 
            this.txtOldUrl.Location = new System.Drawing.Point(86, 71);
            this.txtOldUrl.Name = "txtOldUrl";
            this.txtOldUrl.Size = new System.Drawing.Size(316, 21);
            this.txtOldUrl.TabIndex = 4;
            // 
            // txtNewUrl
            // 
            this.txtNewUrl.Location = new System.Drawing.Point(86, 111);
            this.txtNewUrl.Name = "txtNewUrl";
            this.txtNewUrl.Size = new System.Drawing.Size(316, 21);
            this.txtNewUrl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "原地址：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "新地址：";
            // 
            // btnReplaceUrl
            // 
            this.btnReplaceUrl.Location = new System.Drawing.Point(152, 148);
            this.btnReplaceUrl.Name = "btnReplaceUrl";
            this.btnReplaceUrl.Size = new System.Drawing.Size(98, 23);
            this.btnReplaceUrl.TabIndex = 8;
            this.btnReplaceUrl.Text = "替换地址";
            this.btnReplaceUrl.UseVisualStyleBackColor = true;
            this.btnReplaceUrl.Click += new System.EventHandler(this.btnReplaceUrl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 211);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Git远程地址修改工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGetBasePath;
        private System.Windows.Forms.TextBox txtBasePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewUrl;
        private System.Windows.Forms.TextBox txtOldUrl;
        private System.Windows.Forms.Button btnReplaceUrl;
    }
}

