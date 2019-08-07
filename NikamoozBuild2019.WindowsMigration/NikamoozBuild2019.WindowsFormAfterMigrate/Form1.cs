using NikamoozBuild2019.DAL.AfterMigrate;
using NikamoozBuild2019.ModelAfterMigrate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace NikamoozBuild2019.WindowsFormAfterMigrate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            
            PersonRepository personRepository = new PersonRepository();
            var result = personRepository.Insert(new Person
            {

                FirstName = firstName.Text,
                LastName = lastName.Text
            });
            if (result == 1)
            {
                MessageBox.Show("Done");
                firstName.Text = lastName.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
