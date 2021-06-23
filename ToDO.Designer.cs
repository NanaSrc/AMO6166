
namespace amo6166
{
    partial class ToDo
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
            this.SuspendLayout();
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 625);
            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "ToDo";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "To do:";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroCheckBox cb1;
        private MetroFramework.Controls.MetroCheckBox cbTwo;
        private MetroFramework.Controls.MetroCheckBox cbThree;
        private MetroFramework.Controls.MetroCheckBox cbFour;
        private MetroFramework.Controls.MetroCheckBox cbFive;
        private MetroFramework.Controls.MetroCheckBox cbSix;
        private System.Windows.Forms.Panel panel1;
    }
}