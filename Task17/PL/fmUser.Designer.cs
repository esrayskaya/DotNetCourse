namespace PL
{
    partial class fmUser
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
            this.btCancel = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbDay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAwards = new System.Windows.Forms.ComboBox();
            this.lbBirthDay = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.clbAwards = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCancel.Location = new System.Drawing.Point(11, 235);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(121, 30);
            this.btCancel.TabIndex = 19;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOk.Location = new System.Drawing.Point(264, 235);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(121, 30);
            this.btOk.TabIndex = 18;
            this.btOk.Text = "ОК";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.Location = new System.Drawing.Point(194, 12);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(121, 26);
            this.tbName.TabIndex = 17;
            this.tbName.Validated += new System.EventHandler(this.tbName_Validated);
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbSurname.Location = new System.Drawing.Point(194, 68);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(121, 26);
            this.tbSurname.TabIndex = 16;
            this.tbSurname.Validated += new System.EventHandler(this.tbSurname_Validated);
            // 
            // tbDay
            // 
            this.tbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDay.Location = new System.Drawing.Point(194, 119);
            this.tbDay.Name = "tbDay";
            this.tbDay.Size = new System.Drawing.Size(121, 26);
            this.tbDay.TabIndex = 15;
            this.tbDay.Validated += new System.EventHandler(this.tbDay_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(91, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Награда:";
            // 
            // cbAwards
            // 
            this.cbAwards.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAwards.FormattingEnabled = true;
            this.cbAwards.Location = new System.Drawing.Point(194, 176);
            this.cbAwards.Name = "cbAwards";
            this.cbAwards.Size = new System.Drawing.Size(121, 28);
            this.cbAwards.TabIndex = 13;
            this.cbAwards.SelectedIndexChanged += new System.EventHandler(this.cbAwards_SelectedIndexChanged);
            // 
            // lbBirthDay
            // 
            this.lbBirthDay.AutoSize = true;
            this.lbBirthDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbBirthDay.Location = new System.Drawing.Point(32, 121);
            this.lbBirthDay.Name = "lbBirthDay";
            this.lbBirthDay.Size = new System.Drawing.Size(146, 20);
            this.lbBirthDay.TabIndex = 12;
            this.lbBirthDay.Text = "Дата рождения:";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSurname.Location = new System.Drawing.Point(86, 68);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(92, 20);
            this.lbSurname.TabIndex = 11;
            this.lbSurname.Text = "Фамилия:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.Location = new System.Drawing.Point(131, 14);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(47, 20);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Имя:";
            // 
            // clbAwards
            // 
            this.clbAwards.FormattingEnabled = true;
            this.clbAwards.Location = new System.Drawing.Point(420, 14);
            this.clbAwards.Name = "clbAwards";
            this.clbAwards.Size = new System.Drawing.Size(200, 191);
            this.clbAwards.TabIndex = 20;
            this.clbAwards.SelectedIndexChanged += new System.EventHandler(this.clbAwards_SelectedIndexChanged);
            // 
            // fmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 278);
            this.Controls.Add(this.clbAwards);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.tbDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAwards);
            this.Controls.Add(this.lbBirthDay);
            this.Controls.Add(this.lbSurname);
            this.Controls.Add(this.lbName);
            this.Name = "fmUser";
            this.Text = "fmUser";
            this.Load += new System.EventHandler(this.fmUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAwards;
        private System.Windows.Forms.Label lbBirthDay;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.CheckedListBox clbAwards;
    }
}