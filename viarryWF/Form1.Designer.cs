﻿namespace viarryWF
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
            this.button1 = new System.Windows.Forms.Button();
            this.userInputText = new System.Windows.Forms.TextBox();
            this.serverReturnContext = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputtingContents = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userInputText
            // 
            this.userInputText.Location = new System.Drawing.Point(13, 13);
            this.userInputText.Name = "userInputText";
            this.userInputText.Size = new System.Drawing.Size(205, 21);
            this.userInputText.TabIndex = 1;
            this.userInputText.DockChanged += new System.EventHandler(this.userInputText_CursorChanged);
            this.userInputText.TextChanged += new System.EventHandler(this.userInputText_TextChanged);
            // 
            // serverReturnContext
            // 
            this.serverReturnContext.Location = new System.Drawing.Point(17, 195);
            this.serverReturnContext.Name = "serverReturnContext";
            this.serverReturnContext.Size = new System.Drawing.Size(286, 96);
            this.serverReturnContext.TabIndex = 2;
            this.serverReturnContext.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "服务器返回的";
            // 
            // inputtingContents
            // 
            this.inputtingContents.Location = new System.Drawing.Point(17, 81);
            this.inputtingContents.Name = "inputtingContents";
            this.inputtingContents.Size = new System.Drawing.Size(286, 96);
            this.inputtingContents.TabIndex = 4;
            this.inputtingContents.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "您现在输入的内容如下：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputtingContents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverReturnContext);
            this.Controls.Add(this.userInputText);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox userInputText;
        private System.Windows.Forms.RichTextBox serverReturnContext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox inputtingContents;
        private System.Windows.Forms.Label label2;
    }
}

