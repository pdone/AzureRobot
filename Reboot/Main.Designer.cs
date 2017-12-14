namespace Robot
{
    partial class Main
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.send = new System.Windows.Forms.Button();
            this.input_tbx = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.main_tbx = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // send
            // 
            this.send.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.send.Location = new System.Drawing.Point(455, 424);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(43, 30);
            this.send.TabIndex = 0;
            this.send.Text = "发送";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // input_tbx
            // 
            this.input_tbx.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.input_tbx.Location = new System.Drawing.Point(12, 424);
            this.input_tbx.Multiline = true;
            this.input_tbx.Name = "input_tbx";
            this.input_tbx.Size = new System.Drawing.Size(437, 30);
            this.input_tbx.TabIndex = 1;
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.clear.Location = new System.Drawing.Point(504, 424);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(43, 30);
            this.clear.TabIndex = 4;
            this.clear.Text = "清屏";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // main_tbx
            // 
            this.main_tbx.Cursor = System.Windows.Forms.Cursors.Default;
            this.main_tbx.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.main_tbx.Location = new System.Drawing.Point(13, 13);
            this.main_tbx.Name = "main_tbx";
            this.main_tbx.ReadOnly = true;
            this.main_tbx.Size = new System.Drawing.Size(534, 405);
            this.main_tbx.TabIndex = 5;
            this.main_tbx.Text = "";
            this.main_tbx.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.main_tbx_LinkClicked);
            // 
            // Main
            // 
            this.AcceptButton = this.send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 461);
            this.Controls.Add(this.main_tbx);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.input_tbx);
            this.Controls.Add(this.send);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AzureRobot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox input_tbx;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.RichTextBox main_tbx;
    }
}

