using House_PM.Models.Domain;
using House_PM_Client.PatientServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace House_PM_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            using (ServiceReference1.ProductClient client = new ServiceReference1.ProductClient())
            {
                var temp = client.GetById(id);
                LabelID.Text = temp.Name;
            }
        }

#pragma warning disable IDE1006 // Naming Styles
        private void button2_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            int id = int.Parse(txtID.Text);
            using (PatientServiceReference.PatientServiceWCFClient client = new PatientServiceReference.PatientServiceWCFClient())
            {
                var temp = client.GetById(id);
                LabelID.Text = temp.Name;
            }
        }

        private void GetAll_Click(object sender, EventArgs e)
        {
            using (PatientServiceReference.PatientServiceWCFClient client = new PatientServiceReference.PatientServiceWCFClient())
            {
                var List = client.GetAll();
                LabelID.Text = List.ToString();
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            using (PatientServiceReference.PatientServiceWCFClient client = new PatientServiceReference.PatientServiceWCFClient())
            {
                PatientWCF entity = new PatientWCF
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text
                };

                client.Create(entity);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            using (PatientServiceReference.PatientServiceWCFClient client = new PatientServiceReference.PatientServiceWCFClient())
            {
                PatientWCF entity = new PatientWCF
                {
                    Id = int.Parse(txtID.Text),
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    CreatedOn = DateTime.Now
                    
                };

                client.Update(entity);

            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            using (PatientServiceReference.PatientServiceWCFClient client = new PatientServiceReference.PatientServiceWCFClient())
            {
                int id = int.Parse(txtID.Text);
                client.Delete(id);
            }
        }
    }
}
