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

namespace PL
{
    public partial class fmUser : Form
    {
        private int id;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirthDay;
        private int age;
        BindingSource bs;
        public List<string> title = new List<string>();

        public int ID
        {
            get; set;
        }
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Поле не может быть пустым.");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Длина строки не может быть больше 50.");
                }
                else firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Поле не может быть пустым.");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Длина строки не может быть больше 50.");
                }
                else lastName = value;
            }
        }
        public DateTime DateOfBirthDay
        {
            get { return dateOfBirthDay; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Поле не может быть пустым.");
                }
                else if (value > DateTime.Now)
                {
                    throw new Exception("Введена неверная дата рождения.");
                }
                else dateOfBirthDay = value;
            }
        }
        public int Age { get; set; }
        public string UsersAward;
        public List<string> usersAwards = new List<string>();
        public fmUser()
        {
            InitializeComponent();
        }
        /*public fmUser(Award award, User user)
        {
            UsersAward = user.usersAwards;
            cbAwards.DataSource = award;
            cbAwards.DisplayMember = "Title";
            cbAwards.ValueMember = "ID";
            cbAwards.SelectedIndexChanged += cbAwards_SelectedIndexChanged;
        }*/
        public fmUser(User user)
        {
            InitializeComponent();
            ID = user.ID;
            FirstName = user.FirstName;
            LastName = user.LastName;
            DateOfBirthDay = user.DateOfBirthDay;
            Age = user.Age;
            UsersAward = user.usersAwarda; /////////////////

        }

        private void fmUser_Load(object sender, EventArgs e)
        {
            tbName.Text = FirstName;
            tbSurname.Text = LastName;
            tbDay.Text = DateOfBirthDay.ToShortDateString();
            foreach(string s in title)
            {
                cbAwards.Items.Add(s);
                clbAwards.Items.Add(s);
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
        }

        private void tbName_Validated(object sender, EventArgs e)
        {
            FirstName = tbName.Text;
        }

        private void tbSurname_Validated(object sender, EventArgs e)
        {
            LastName = tbSurname.Text;
        }

        private void tbDay_Validated(object sender, EventArgs e)
        {
            DateOfBirthDay = DateTime.Parse(tbDay.Text);
        }

        private void cbAwards_SelectedIndexChanged(object sender, EventArgs e)
        {
            usersAwards.Add(cbAwards.SelectedItem.ToString());
            foreach(string s in usersAwards)
            {
                UsersAward = s;
            }
            //int id = (int)cbAwards.SelectedValue;

            // получаем весь выделенный объект
            /*Award award = (Award)cbAwards.SelectedItem;
            MessageBox.Show(ID.ToString() + ". " + award.Title);*/
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clbAwards_SelectedIndexChanged(object sender, EventArgs e)
        {
            usersAwards.Add(clbAwards.SelectedItem.ToString());
            foreach (string s in usersAwards)
            {
                UsersAward = s;
            }
        }
    }
}
