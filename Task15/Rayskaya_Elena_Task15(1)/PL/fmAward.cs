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
    public partial class fmAward : Form
    {
        private int id;
        private string title;
        private string description;
        public int ID
        {
            get; set;
        }
        public string Title
        {
            get { return title; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Поле не может быть пустым.");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Количество символов не может быть больше 50.");
                }
                else title = value;
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                if (value.Length > 250)
                {
                    throw new Exception("Количество символов не может быть больше 250.");
                }
                else description = value;
            }
        }
        public fmAward()
        {

            InitializeComponent();
            tbTitle.Validating += tbTitle_Validating;
        }
        public fmAward(Award award)
        {
            ID = award.ID;
            Title = award.Title;
            Description = award.Description;
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            DialogResult = ValidateChildren() ? DialogResult.OK : DialogResult.None;
        }

        private void fmAward_Load(object sender, EventArgs e)
        {
            tbTitle.Text = Title;
            tbDescription.Text = Description;

        }

        private void tbTitle_Validated(object sender, EventArgs e)
        {
            Title = tbTitle.Text;
        }

        private void tbDescription_Validated(object sender, EventArgs e)
        {
            Description = tbDescription.Text;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbTitle_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(tbTitle.Text))
            {
                errorProvider.SetError(tbTitle, "Значение не введено.");
            }
            else errorProvider.Clear();
        }
    }
}
