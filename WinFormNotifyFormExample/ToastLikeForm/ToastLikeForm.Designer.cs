
namespace case_of_t.ToastLikeForm
{
    partial class ToastLikeForm
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
            this.components = new System.ComponentModel.Container();
            this.closeFormButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.animateTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // closeFormButton
            // 
            this.closeFormButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeFormButton.BackColor = System.Drawing.Color.Crimson;
            this.closeFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeFormButton.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.closeFormButton.ForeColor = System.Drawing.Color.White;
            this.closeFormButton.Location = new System.Drawing.Point(243, 0);
            this.closeFormButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeFormButton.Name = "closeFormButton";
            this.closeFormButton.Size = new System.Drawing.Size(75, 23);
            this.closeFormButton.TabIndex = 0;
            this.closeFormButton.Text = "x";
            this.closeFormButton.UseVisualStyleBackColor = false;
            this.closeFormButton.Click += new System.EventHandler(this.closeFormButton_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.Font = new System.Drawing.Font("游ゴシック", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.messageLabel.Location = new System.Drawing.Point(12, 31);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Padding = new System.Windows.Forms.Padding(4);
            this.messageLabel.Size = new System.Drawing.Size(294, 88);
            this.messageLabel.TabIndex = 1;
            this.messageLabel.Text = "Message";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoEllipsis = true;
            this.titleLabel.Location = new System.Drawing.Point(14, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(210, 16);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "テストタイトルTestTitleテストタイトルTestTitle";
            // 
            // animateTimer
            // 
            this.animateTimer.Enabled = true;
            this.animateTimer.Tick += new System.EventHandler(this.animateTimer_Tick);
            // 
            // ToastLikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 128);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.closeFormButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToastLikeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ToastLikeForm";
            this.Load += new System.EventHandler(this.ToastLikeForm_Load);
            this.Shown += new System.EventHandler(this.ToastLikeForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeFormButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Timer animateTimer;
    }
}