
namespace marco
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbVer = new System.Windows.Forms.CheckBox();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbClaro = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbMuito = new System.Windows.Forms.RadioButton();
            this.btCancel = new System.Windows.Forms.Button();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.btLogin = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbVer);
            this.groupBox1.Controls.Add(this.rbSim);
            this.groupBox1.Controls.Add(this.rbClaro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbMuito);
            this.groupBox1.Controls.Add(this.btCancel);
            this.groupBox1.Controls.Add(this.rbNao);
            this.groupBox1.Controls.Add(this.btLogin);
            this.groupBox1.Controls.Add(this.tbNome);
            this.groupBox1.Controls.Add(this.tbKey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 259);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login, my angel";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbVer
            // 
            this.cbVer.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbVer.AutoSize = true;
            this.cbVer.Location = new System.Drawing.Point(441, 67);
            this.cbVer.Name = "cbVer";
            this.cbVer.Size = new System.Drawing.Size(52, 26);
            this.cbVer.TabIndex = 24;
            this.cbVer.Text = ":eye:";
            this.cbVer.UseVisualStyleBackColor = true;
            this.cbVer.CheckedChanged += new System.EventHandler(this.cbVer_CheckedChanged);
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.BackColor = System.Drawing.SystemColors.Control;
            this.rbSim.Location = new System.Drawing.Point(104, 134);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(263, 20);
            this.rbSim.TabIndex = 23;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Se eu amo? Com você eu quero casar";
            this.rbSim.UseVisualStyleBackColor = false;
            // 
            // rbClaro
            // 
            this.rbClaro.AutoSize = true;
            this.rbClaro.BackColor = System.Drawing.SystemColors.Control;
            this.rbClaro.Location = new System.Drawing.Point(310, 108);
            this.rbClaro.Name = "rbClaro";
            this.rbClaro.Size = new System.Drawing.Size(172, 20);
            this.rbClaro.TabIndex = 21;
            this.rbClaro.TabStop = true;
            this.rbClaro.Text = "Eu te amo demais Anna";
            this.rbClaro.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(7, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Você me ama?";
            // 
            // rbMuito
            // 
            this.rbMuito.AutoSize = true;
            this.rbMuito.BackColor = System.Drawing.SystemColors.Control;
            this.rbMuito.Location = new System.Drawing.Point(104, 108);
            this.rbMuito.Name = "rbMuito";
            this.rbMuito.Size = new System.Drawing.Size(200, 20);
            this.rbMuito.TabIndex = 19;
            this.rbMuito.TabStop = true;
            this.rbMuito.Text = "Muito, mas pq a pergunta?";
            this.rbMuito.UseVisualStyleBackColor = false;
            // 
            // btCancel
            // 
            this.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancel.Location = new System.Drawing.Point(23, 214);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(470, 32);
            this.btCancel.TabIndex = 14;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.BackColor = System.Drawing.SystemColors.Control;
            this.rbNao.Location = new System.Drawing.Point(384, 134);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(95, 20);
            this.rbNao.TabIndex = 21;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não :rage:";
            this.rbNao.UseVisualStyleBackColor = false;
            this.rbNao.CheckedChanged += new System.EventHandler(this.rbNao_CheckedChanged);
            // 
            // btLogin
            // 
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Location = new System.Drawing.Point(23, 176);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(470, 32);
            this.btLogin.TabIndex = 13;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(56, 34);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(437, 21);
            this.tbNome.TabIndex = 15;
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(56, 69);
            this.tbKey.MaxLength = 32;
            this.tbKey.Name = "tbKey";
            this.tbKey.PasswordChar = '♥';
            this.tbKey.Size = new System.Drawing.Size(379, 21);
            this.tbKey.TabIndex = 16;
            this.tbKey.Enter += new System.EventHandler(this.tbKey_Enter);
            this.tbKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKey_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(7, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Key:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(415, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Feito por: Nana";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(539, 292);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "We are hated, but I feel loved with you";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbMuito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbClaro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbVer;
        public System.Windows.Forms.TextBox tbKey;
    }
}

