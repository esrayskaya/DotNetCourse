namespace PL
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcUsersAndAwards = new System.Windows.Forms.TabControl();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.tpAwards = new System.Windows.Forms.TabPage();
            this.dgAwards = new System.Windows.Forms.DataGridView();
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.tmUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tmAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tmDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tmChangeUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tmAwards = new System.Windows.Forms.ToolStripMenuItem();
            this.tmAddAwards = new System.Windows.Forms.ToolStripMenuItem();
            this.tmDeleteAwards = new System.Windows.Forms.ToolStripMenuItem();
            this.tmChangeAwards = new System.Windows.Forms.ToolStripMenuItem();
            this.tcUsersAndAwards.SuspendLayout();
            this.tpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.tpAwards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAwards)).BeginInit();
            this.mnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcUsersAndAwards
            // 
            this.tcUsersAndAwards.Controls.Add(this.tpUsers);
            this.tcUsersAndAwards.Controls.Add(this.tpAwards);
            this.tcUsersAndAwards.Location = new System.Drawing.Point(35, 64);
            this.tcUsersAndAwards.Name = "tcUsersAndAwards";
            this.tcUsersAndAwards.SelectedIndex = 0;
            this.tcUsersAndAwards.Size = new System.Drawing.Size(938, 403);
            this.tcUsersAndAwards.TabIndex = 4;
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.dgUsers);
            this.tpUsers.Location = new System.Drawing.Point(4, 25);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpUsers.Size = new System.Drawing.Size(930, 374);
            this.tpUsers.TabIndex = 0;
            this.tpUsers.Text = "Пользователи";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            this.dgUsers.AllowUserToDeleteRows = false;
            this.dgUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Location = new System.Drawing.Point(3, 6);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.RowHeadersWidth = 51;
            this.dgUsers.RowTemplate.Height = 24;
            this.dgUsers.Size = new System.Drawing.Size(918, 304);
            this.dgUsers.TabIndex = 0;
            // 
            // tpAwards
            // 
            this.tpAwards.Controls.Add(this.dgAwards);
            this.tpAwards.Location = new System.Drawing.Point(4, 25);
            this.tpAwards.Name = "tpAwards";
            this.tpAwards.Padding = new System.Windows.Forms.Padding(3);
            this.tpAwards.Size = new System.Drawing.Size(930, 374);
            this.tpAwards.TabIndex = 1;
            this.tpAwards.Text = "Награды";
            this.tpAwards.UseVisualStyleBackColor = true;
            // 
            // dgAwards
            // 
            this.dgAwards.AllowUserToAddRows = false;
            this.dgAwards.AllowUserToDeleteRows = false;
            this.dgAwards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAwards.Location = new System.Drawing.Point(6, 6);
            this.dgAwards.Name = "dgAwards";
            this.dgAwards.RowHeadersWidth = 51;
            this.dgAwards.RowTemplate.Height = 24;
            this.dgAwards.Size = new System.Drawing.Size(918, 305);
            this.dgAwards.TabIndex = 0;
            // 
            // mnMain
            // 
            this.mnMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmUser,
            this.tmAwards});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(1009, 28);
            this.mnMain.TabIndex = 5;
            this.mnMain.Text = "menuStrip1";
            // 
            // tmUser
            // 
            this.tmUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmAddUser,
            this.tmDeleteUser,
            this.tmChangeUser});
            this.tmUser.Name = "tmUser";
            this.tmUser.Size = new System.Drawing.Size(121, 24);
            this.tmUser.Text = "Пользователь";
            this.tmUser.Click += new System.EventHandler(this.tmUser_Click);
            // 
            // tmAddUser
            // 
            this.tmAddUser.Name = "tmAddUser";
            this.tmAddUser.Size = new System.Drawing.Size(186, 26);
            this.tmAddUser.Text = "добавить";
            this.tmAddUser.Click += new System.EventHandler(this.tmAddUser_Click);
            // 
            // tmDeleteUser
            // 
            this.tmDeleteUser.Name = "tmDeleteUser";
            this.tmDeleteUser.Size = new System.Drawing.Size(186, 26);
            this.tmDeleteUser.Text = "удалить";
            this.tmDeleteUser.Click += new System.EventHandler(this.tmDeleteUser_Click);
            // 
            // tmChangeUser
            // 
            this.tmChangeUser.Name = "tmChangeUser";
            this.tmChangeUser.Size = new System.Drawing.Size(186, 26);
            this.tmChangeUser.Text = "редактирвать";
            // 
            // tmAwards
            // 
            this.tmAwards.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmAddAwards,
            this.tmDeleteAwards,
            this.tmChangeAwards});
            this.tmAwards.Name = "tmAwards";
            this.tmAwards.Size = new System.Drawing.Size(81, 24);
            this.tmAwards.Text = "Награда";
            // 
            // tmAddAwards
            // 
            this.tmAddAwards.Name = "tmAddAwards";
            this.tmAddAwards.Size = new System.Drawing.Size(224, 26);
            this.tmAddAwards.Text = "добавить";
            this.tmAddAwards.Click += new System.EventHandler(this.tmAddAwards_Click);
            // 
            // tmDeleteAwards
            // 
            this.tmDeleteAwards.Name = "tmDeleteAwards";
            this.tmDeleteAwards.Size = new System.Drawing.Size(224, 26);
            this.tmDeleteAwards.Text = "удалить";
            this.tmDeleteAwards.Click += new System.EventHandler(this.tmDeleteAwards_Click);
            // 
            // tmChangeAwards
            // 
            this.tmChangeAwards.Name = "tmChangeAwards";
            this.tmChangeAwards.Size = new System.Drawing.Size(224, 26);
            this.tmChangeAwards.Text = "редактировать";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 531);
            this.Controls.Add(this.mnMain);
            this.Controls.Add(this.tcUsersAndAwards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcUsersAndAwards.ResumeLayout(false);
            this.tpUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.tpAwards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAwards)).EndInit();
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcUsersAndAwards;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.TabPage tpAwards;
        private System.Windows.Forms.DataGridView dgAwards;
        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem tmUser;
        private System.Windows.Forms.ToolStripMenuItem tmAddUser;
        private System.Windows.Forms.ToolStripMenuItem tmDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem tmChangeUser;
        private System.Windows.Forms.ToolStripMenuItem tmAwards;
        private System.Windows.Forms.ToolStripMenuItem tmAddAwards;
        private System.Windows.Forms.ToolStripMenuItem tmDeleteAwards;
        private System.Windows.Forms.ToolStripMenuItem tmChangeAwards;
    }
}

