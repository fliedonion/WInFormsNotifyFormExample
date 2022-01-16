
namespace case_of_t.WinFormNotifyFormExample
{
    partial class TestForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.TextBox();
            this.messageText = new System.Windows.Forms.TextBox();
            this.asErrCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "showBottomRight";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(25, 36);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(169, 19);
            this.titleText.TabIndex = 0;
            this.titleText.Text = "Title. Longer Title will be suppressed.";
            // 
            // messageText
            // 
            this.messageText.Location = new System.Drawing.Point(25, 61);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(169, 80);
            this.messageText.TabIndex = 1;
            this.messageText.Text = "message.\r\nSecond Line.\r\nblur\r\nblur...";
            // 
            // asErrCheck
            // 
            this.asErrCheck.AutoSize = true;
            this.asErrCheck.Location = new System.Drawing.Point(25, 148);
            this.asErrCheck.Name = "asErrCheck";
            this.asErrCheck.Size = new System.Drawing.Size(97, 16);
            this.asErrCheck.TabIndex = 2;
            this.asErrCheck.Text = "use Red Color";
            this.asErrCheck.UseVisualStyleBackColor = true;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 207);
            this.Controls.Add(this.asErrCheck);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(444, 246);
            this.MinimumSize = new System.Drawing.Size(444, 246);
            this.Name = "TestForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox messageText;
        private System.Windows.Forms.CheckBox asErrCheck;
    }
}

