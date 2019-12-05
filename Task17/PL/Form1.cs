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
using DAL;

namespace PL
{
    public partial class Form1 : Form
    {
        public UserBL users = new UserBL(new UserSQLDAO());
        public AwardBL awards = new AwardBL(new AwardSQLDAO());
        public List<string> title = new List<string>();
        public Form1()
        {
            /*users = new UserBL();
            awards = new AwardBL();*/
            InitializeComponent();
            dgUsers.RowCount = users.GetUsersList().ToList().Count;
            for (int i = 0; i < dgUsers.RowCount; i++)
            {
                dgUsers[0, i].Value = users.GetUsersList().ToList()[i].ID;
                dgUsers[1, i].Value = users.GetUsersList().ToList()[i].LastName;
                dgUsers[2, i].Value = users.GetUsersList().ToList()[i].FirstName;
                dgUsers[3, i].Value = users.GetUsersList().ToList()[i].DateOfBirthDay.ToShortDateString();
                dgUsers[4, i].Value = users.GetUsersList().ToList()[i].Age;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*dgUsers.DataSource = users.InitUsersList();
            dgAwards.DataSource = awards.InitAwardsList();*/
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
            }
        }

        private void tmAddUser_Click(object sender, EventArgs e)
        {
            fmUser fm = new fmUser();
            //User user = new User();
            fm.title = title;
            if (fm.ShowDialog(this) == DialogResult.OK)
            {
                users.AddUser(fm.FirstName, fm.LastName, fm.DateOfBirthDay/*, fm.UsersAward*/);
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
