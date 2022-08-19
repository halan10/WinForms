using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinForms
{
  
        public partial class EditUserForm : Form
        {
            public string Pib { get; set; }

            public string Email { get; set; }
            public string Phone { get; set; }

            public string ImagePhoto { get; set; }

            public EditUserForm()
            {
                InitializeComponent();
            
            }



        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void EditUserForm_Load(object sender, EventArgs e)
        {
            pbImage.Image = Image.FromFile(ImagePhoto);
            txtNameEdit.Text = Pib;
            txtEmailEdit.Text = Email;
            txtPhoneEdit.Text = Phone;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Pib = txtNameEdit.Text;
            this.Email = txtEmailEdit.Text;
            this.Phone = txtPhoneEdit.Text;
            this.DialogResult = DialogResult.OK;
        }



        private void pbImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Images File|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(dlg.FileName);
                ImagePhoto = dlg.FileName;
                //MessageBox.Show("Select image " + dlg.FileName);
            }
        }
    }
    }
