using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;
using BLL;

namespace PL
{
    public partial class Form1 : Form
    {
        private readonly UserBL users;
        private readonly AwardBL awards;
        public List<string> title = new List<string>();
        public Form1()
        {
            users = new UserBL();
            awards = new AwardBL();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgUsers.DataSource = users.InitUsersList();
            dgAwards.DataSource = awards.InitAwardsList();
        }

        private void tmAddAwards_Click(object sender, EventArgs e)
        {
            fmAward fm = new fmAward();
            if (fm.ShowDialog(this) == DialogResult.OK)
            {
                awards.AddAward(fm.Title, fm.Description);
                dgAwards.DataSource = null;
                dgAwards.DataSource = awards.GetAwardsList();
                title.Add(fm.Title); ////*****/////
                title.Add("Нобелевская премия");
                title.Add("Оскар");
            }
        }

        private void tmAddUser_Click(object sender, EventArgs e)
        {
            fmUser fm = new fmUser();
            //User user = new User();
            fm.title = title;
            if (fm.ShowDialog(this) == DialogResult.OK)
            {
                users.AddUser(fm.FirstName, fm.LastName, fm.DateOfBirthDay, fm.UsersAward);
                dgUsers.DataSource = null;
                dgUsers.DataSource = users.GetUsersList();
            }
        }

        private void tmDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgUsers.SelectedCells.Count > 0)
            {
                User user = (User)dgUsers.SelectedCells[0].OwningRow.DataBoundItem;
                users.DeleteUser(user);
                dgUsers.DataSource = null;
                dgUsers.DataSource = users.GetUsersList();
            }
        }

        private void tmUser_Click(object sender, EventArgs e)
        {

        }

        private void tmDeleteAwards_Click(object sender, EventArgs e)
        {
            if (dgAwards.SelectedCells.Count > 0)
            {
                Award user = (Award)dgAwards.SelectedCells[0].OwningRow.DataBoundItem;
                awards.DeleteAwaed(user);
                for(int i = 0; i < dgUsers.RowCount; i++)
                {
                    if (dgUsers[0, i].Value?.ToString() == user.Title)
                    {
                        dgUsers[0, i].Value = null;
                    }
                }
                
                dgAwards.DataSource = null;
                dgAwards.DataSource = awards.GetAwardsList();
            }
        }
    }
}
