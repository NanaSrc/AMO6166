
namespace amo6166
{
    partial class ProgressBar
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
            this.lbLoading = new System.Windows.Forms.Label();
            this.lbBar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbLoading
            // 
            this.lbLoading.AutoSize = true;
            this.lbLoading.Font = new System.Drawing.Font("Cascadia Code SemiLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lbLoading.Location = new System.Drawing.Point(543, 394);
            this.lbLoading.Name = "lbLoading";
            this.lbLoading.Size = new System.Drawing.Size(132, 28);
            this.lbLoading.TabIndex = 0;
            this.lbLoading.Text = "Loading...";
            // 
            // lbBar
            // 
            this.lbBar.AutoSize = true;
            this.lbBar.Font = new System.Drawing.Font("Cascadia Code SemiLight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(179)))), ((int)(((byte)(255)))));
            this.lbBar.Location = new System.Drawing.Point(459, 355);
            this.lbBar.Name = "lbBar";
            this.lbBar.Size = new System.Drawing.Size(288, 28);
            this.lbBar.TabIndex = 1;
            this.lbBar.Text = "</////////////////////>\r\n";
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.ControlBox = false;
            this.Controls.Add(this.lbBar);
            this.Controls.Add(this.lbLoading);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "ProgressBar";
            this.Opacity = 0.93D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.ProgressBar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLoading;
        private System.Windows.Forms.Label lbBar;
    }
}