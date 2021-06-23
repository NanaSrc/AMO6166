
namespace amo6166
{
    partial class love
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(love));
            this.panel = new MetroFramework.Controls.MetroPanel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lbLogin = new MetroFramework.Controls.MetroLabel();
            this.lbUser = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelIcon = new MetroFramework.Controls.MetroPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btLogout = new System.Windows.Forms.Label();
            this.btToDo = new System.Windows.Forms.Button();
            this.btShop = new System.Windows.Forms.Button();
            this.btAlbum = new System.Windows.Forms.Button();
            this.btDiary = new System.Windows.Forms.Button();
            this.btBank = new System.Windows.Forms.Button();
            this.btSite = new System.Windows.Forms.Button();
            this.btProfile = new System.Windows.Forms.Button();
            this.btNotes = new System.Windows.Forms.Button();
            this.btCalendar = new System.Windows.Forms.Button();
            this.btBirthdays = new System.Windows.Forms.Button();
            this.btFireplace = new System.Windows.Forms.Button();
            this.btMenu = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.cbTheme = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.rbLight = new MetroFramework.Controls.MetroRadioButton();
            this.rbDark = new MetroFramework.Controls.MetroRadioButton();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel.Controls.Add(this.pic);
            this.panel.HorizontalScrollbarBarColor = true;
            this.panel.HorizontalScrollbarHighlightOnWheel = false;
            this.panel.HorizontalScrollbarSize = 10;
            this.panel.Location = new System.Drawing.Point(207, 103);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1129, 625);
            this.panel.Style = MetroFramework.MetroColorStyle.Purple;
            this.panel.TabIndex = 0;
            this.panel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panel.UseCustomBackColor = true;
            this.panel.UseStyleColors = true;
            this.panel.VerticalScrollbarBarColor = true;
            this.panel.VerticalScrollbarHighlightOnWheel = false;
            this.panel.VerticalScrollbarSize = 10;
            // 
            // pic
            // 
            this.pic.BackgroundImage = global::amo6166.Properties.Resources.US2;
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic.InitialImage = null;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1129, 625);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(1010, 53);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Usuário: ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(1132, 53);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Login:";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseStyleColors = true;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbLogin.Location = new System.Drawing.Point(1178, 53);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(21, 19);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "--";
            this.lbLogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbLogin.UseCustomForeColor = true;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbUser.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbUser.Location = new System.Drawing.Point(1069, 53);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(21, 19);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "--";
            this.lbUser.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.lbUser.UseCustomForeColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 53;
            this.label1.Text = "AMO6166™ ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelIcon
            // 
            this.panelIcon.BackgroundImage = global::amo6166.Properties.Resources.icon;
            this.panelIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelIcon.HorizontalScrollbarBarColor = true;
            this.panelIcon.HorizontalScrollbarHighlightOnWheel = false;
            this.panelIcon.HorizontalScrollbarSize = 10;
            this.panelIcon.Location = new System.Drawing.Point(23, 22);
            this.panelIcon.Name = "panelIcon";
            this.panelIcon.Size = new System.Drawing.Size(65, 62);
            this.panelIcon.Style = MetroFramework.MetroColorStyle.Purple;
            this.panelIcon.TabIndex = 52;
            this.panelIcon.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelIcon.VerticalScrollbarBarColor = true;
            this.panelIcon.VerticalScrollbarHighlightOnWheel = false;
            this.panelIcon.VerticalScrollbarSize = 10;
            this.panelIcon.Paint += new System.Windows.Forms.PaintEventHandler(this.panelIcon_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(225, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 54;
            this.label2.Text = "Manage your problems";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(23, 741);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "Version: BETA 2.1.3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbInfo.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbInfo.ForeColor = System.Drawing.Color.DarkGray;
            this.lbInfo.Location = new System.Drawing.Point(121, 737);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(24, 21);
            this.lbInfo.TabIndex = 55;
            this.lbInfo.Text = "ⓘ";
            this.lbInfo.Click += new System.EventHandler(this.lbInfo_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Black;
            this.metroLabel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroLabel3.Location = new System.Drawing.Point(1182, 737);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(154, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroLabel3.TabIndex = 57;
            this.metroLabel3.Text = "Developed by Nαnα™ ©";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // btLogout
            // 
            this.btLogout.AutoSize = true;
            this.btLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.btLogout.Location = new System.Drawing.Point(1271, 53);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(49, 17);
            this.btLogout.TabIndex = 17;
            this.btLogout.Text = "Logout";
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btToDo
            // 
            this.btToDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btToDo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btToDo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.btToDo.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.InfoText;
            this.btToDo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btToDo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(7)))), ((int)(((byte)(16)))));
            this.btToDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btToDo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btToDo.Location = new System.Drawing.Point(20, 155);
            this.btToDo.Name = "btToDo";
            this.btToDo.Size = new System.Drawing.Size(177, 46);
            this.btToDo.TabIndex = 2;
            this.btToDo.Text = "☆ To do list";
            this.btToDo.UseVisualStyleBackColor = true;
            this.btToDo.Click += new System.EventHandler(this.btNanaPage_Click);
            // 
            // btShop
            // 
            this.btShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btShop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.btShop.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.InfoText;
            this.btShop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btShop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(7)))), ((int)(((byte)(16)))));
            this.btShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btShop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btShop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btShop.Location = new System.Drawing.Point(19, 207);
            this.btShop.Name = "btShop";
            this.btShop.Size = new System.Drawing.Size(178, 46);
            this.btShop.TabIndex = 3;
            this.btShop.Text = "☆ Shop list";
            this.btShop.UseVisualStyleBackColor = true;
            this.btShop.Click += new System.EventHandler(this.btMarcoPage_Click);
            // 
            // btAlbum
            // 
            this.btAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAlbum.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.btAlbum.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.InfoText;
            this.btAlbum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btAlbum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(7)))), ((int)(((byte)(16)))));
            this.btAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btAlbum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btAlbum.Location = new System.Drawing.Point(18, 363);
            this.btAlbum.Name = "btAlbum";
            this.btAlbum.Size = new System.Drawing.Size(179, 46);
            this.btAlbum.TabIndex = 6;
            this.btAlbum.Text = "☆ Album";
            this.btAlbum.UseVisualStyleBackColor = true;
            this.btAlbum.Click += new System.EventHandler(this.btGallery_Click);
            // 
            // btDiary
            // 
            this.btDiary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDiary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.btDiary.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.InfoText;
            this.btDiary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btDiary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(7)))), ((int)(((byte)(16)))));
            this.btDiary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDiary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btDiary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btDiary.Location = new System.Drawing.Point(18, 311);
            this.btDiary.Name = "btDiary";
            this.btDiary.Size = new System.Drawing.Size(179, 46);
            this.btDiary.TabIndex = 5;
            this.btDiary.Text = "☆ Diary";
            this.btDiary.UseVisualStyleBackColor = true;
            this.btDiary.Click += new System.EventHandler(this.btTerm_Click);
            // 
            // btBank
            // 
            this.btBank.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBank.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.btBank.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.InfoText;
            this.btBank.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btBank.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(7)))), ((int)(((byte)(16)))));
            this.btBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btBank.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btBank.Location = new System.Drawing.Point(18, 259);
            this.btBank.Name = "btBank";
            this.btBank.Size = new System.Drawing.Size(179, 46);
            this.btBank.TabIndex = 4;
            this.btBank.Text = "☆ Mini bank";
            this.btBank.UseVisualStyleBackColor = true;
            this.btBank.Click += new System.EventHandler(this.btGame_Click);
            // 
            // btSite
            // 
            this.btSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.btSite.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.InfoText;
            this.btSite.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btSite.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(7)))), ((int)(((byte)(16)))));
            this.btSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btSite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btSite.Location = new System.Drawing.Point(18, 623);
            this.btSite.Name = "btSite";
            this.btSite.Size = new System.Drawing.Size(179, 46);
            this.btSite.TabIndex = 11;
            this.btSite.Text = "☆ amo6166.com";
            this.btSite.UseVisualStyleBackColor = true;
            this.btSite.Click += new System.EventHandler(this.btSite_Click);
            // 
            // btProfile
            // 
            this.btProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.btProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.btProfile.Location = new System.Drawing.Point(915, 50);
            this.btProfile.Name = "btProfile";
            this.btProfile.Size = new System.Drawing.Size(89, 26);
            this.btProfile.TabIndex = 16;
            this.btProfile.Text = "Profile";
            this.btProfile.UseVisualStyleBackColor = true;
            this.btProfile.Click += new System.EventHandler(this.btProfile_Click);
            // 
            // btNotes
            // 
            this.btNotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNotes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.btNotes.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.InfoText;
            this.btNotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btNotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(7)))), ((int)(((byte)(16)))));
            this.btNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btNotes.Location = new System.Drawing.Point(18, 415);
            this.btNotes.Name = "btNotes";
            this.btNotes.Size = new System.Drawing.Size(179, 46);
            this.btNotes.TabIndex = 7;
            this.btNotes.Text = "☆ Notes";
            this.btNotes.UseVisualStyleBackColor = true;
            this.btNotes.Click += new System.EventHandler(this.btPainting_Click);
            // 
            // btCalendar
            // 
            this.btCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCalendar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.btCalendar.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.InfoText;
            this.btCalendar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btCalendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(7)))), ((int)(((byte)(16)))));
            this.btCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btCalendar.Location = new System.Drawing.Point(18, 467);
            this.btCalendar.Name = "btCalendar";
            this.btCalendar.Size = new System.Drawing.Size(179, 46);
            this.btCalendar.TabIndex = 8;
            this.btCalendar.Text = "☆ Calendar";
            this.btCalendar.UseVisualStyleBackColor = true;
            this.btCalendar.Click += new System.EventHandler(this.btMovie_Click);
            // 
            // btBirthdays
            // 
            this.btBirthdays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBirthdays.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.btBirthdays.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.InfoText;
            this.btBirthdays.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btBirthdays.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(7)))), ((int)(((byte)(16)))));
            this.btBirthdays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBirthdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btBirthdays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btBirthdays.Location = new System.Drawing.Point(18, 519);
            this.btBirthdays.Name = "btBirthdays";
            this.btBirthdays.Size = new System.Drawing.Size(179, 46);
            this.btBirthdays.TabIndex = 9;
            this.btBirthdays.Text = "☆ Birthdays";
            this.btBirthdays.UseVisualStyleBackColor = true;
            this.btBirthdays.Click += new System.EventHandler(this.btLibrary_Click);
            // 
            // btFireplace
            // 
            this.btFireplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFireplace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.btFireplace.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.InfoText;
            this.btFireplace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btFireplace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(7)))), ((int)(((byte)(16)))));
            this.btFireplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFireplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btFireplace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btFireplace.Location = new System.Drawing.Point(18, 571);
            this.btFireplace.Name = "btFireplace";
            this.btFireplace.Size = new System.Drawing.Size(179, 46);
            this.btFireplace.TabIndex = 10;
            this.btFireplace.Text = "☆ ";
            this.btFireplace.UseVisualStyleBackColor = true;
            this.btFireplace.Click += new System.EventHandler(this.btFireplace_Click);
            // 
            // btMenu
            // 
            this.btMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.btMenu.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.InfoText;
            this.btMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(7)))), ((int)(((byte)(16)))));
            this.btMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btMenu.Location = new System.Drawing.Point(20, 103);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(177, 46);
            this.btMenu.TabIndex = 1;
            this.btMenu.Text = "☆ Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMain_Click);
            // 
            // btExit
            // 
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.btExit.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.InfoText;
            this.btExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(29)))), ((int)(((byte)(39)))));
            this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(7)))), ((int)(((byte)(16)))));
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btExit.Location = new System.Drawing.Point(18, 682);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(179, 46);
            this.btExit.TabIndex = 12;
            this.btExit.Text = "☆ Exit light";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // cbTheme
            // 
            this.cbTheme.ItemHeight = 23;
            this.cbTheme.Items.AddRange(new object[] {
            "Black",
            "Blue",
            "Brown",
            "Green",
            "Lime",
            "Magenta",
            "Orange",
            "Pink",
            "Purple",
            "Red",
            "Silver",
            "Teal",
            "White",
            "Yellow"});
            this.cbTheme.Location = new System.Drawing.Point(735, 49);
            this.cbTheme.Name = "cbTheme";
            this.cbTheme.Size = new System.Drawing.Size(139, 29);
            this.cbTheme.Style = MetroFramework.MetroColorStyle.Purple;
            this.cbTheme.TabIndex = 15;
            this.cbTheme.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbTheme.UseSelectable = true;
            this.cbTheme.SelectedIndexChanged += new System.EventHandler(this.cbTheme_SelectedIndexChanged);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(161)))), ((int)(((byte)(255)))));
            this.metroLabel4.Location = new System.Drawing.Point(688, 53);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel4.TabIndex = 73;
            this.metroLabel4.Text = "Style:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // rbLight
            // 
            this.rbLight.AutoSize = true;
            this.rbLight.Location = new System.Drawing.Point(495, 57);
            this.rbLight.Name = "rbLight";
            this.rbLight.Size = new System.Drawing.Size(72, 15);
            this.rbLight.Style = MetroFramework.MetroColorStyle.Purple;
            this.rbLight.TabIndex = 13;
            this.rbLight.Text = "Exit Light";
            this.rbLight.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbLight.UseSelectable = true;
            this.rbLight.UseStyleColors = true;
            this.rbLight.CheckedChanged += new System.EventHandler(this.rbLight_CheckedChanged);
            // 
            // rbDark
            // 
            this.rbDark.AutoSize = true;
            this.rbDark.Location = new System.Drawing.Point(573, 57);
            this.rbDark.Name = "rbDark";
            this.rbDark.Size = new System.Drawing.Size(83, 15);
            this.rbDark.Style = MetroFramework.MetroColorStyle.Purple;
            this.rbDark.TabIndex = 14;
            this.rbDark.Text = "Enter Night";
            this.rbDark.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.rbDark.UseSelectable = true;
            this.rbDark.UseStyleColors = true;
            this.rbDark.UseVisualStyleBackColor = false;
            this.rbDark.CheckedChanged += new System.EventHandler(this.rbDark_CheckedChanged);
            // 
            // love
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.rbDark);
            this.Controls.Add(this.rbLight);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cbTheme);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.btSite);
            this.Controls.Add(this.btFireplace);
            this.Controls.Add(this.btBirthdays);
            this.Controls.Add(this.btCalendar);
            this.Controls.Add(this.btNotes);
            this.Controls.Add(this.btProfile);
            this.Controls.Add(this.btBank);
            this.Controls.Add(this.btDiary);
            this.Controls.Add(this.btAlbum);
            this.Controls.Add(this.btShop);
            this.Controls.Add(this.btToDo);
            this.Controls.Add(this.btLogout);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelIcon);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.lbLogin);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "love";
            this.Opacity = 0.96D;
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = " ☆";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.love_Load);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lbLogin;
        private MetroFramework.Controls.MetroLabel lbUser;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel panelIcon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbInfo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label btLogout;
        private System.Windows.Forms.Button btToDo;
        private System.Windows.Forms.Button btShop;
        private System.Windows.Forms.Button btAlbum;
        private System.Windows.Forms.Button btDiary;
        private System.Windows.Forms.Button btBank;
        private System.Windows.Forms.Button btSite;
        private System.Windows.Forms.Button btProfile;
        private System.Windows.Forms.Button btNotes;
        private System.Windows.Forms.Button btCalendar;
        private System.Windows.Forms.Button btBirthdays;
        private System.Windows.Forms.Button btFireplace;
        private System.Windows.Forms.Button btMenu;
        private System.Windows.Forms.Button btExit;
        private MetroFramework.Controls.MetroComboBox cbTheme;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroRadioButton rbLight;
        private MetroFramework.Controls.MetroRadioButton rbDark;
        private System.Windows.Forms.PictureBox pic;
    }
}