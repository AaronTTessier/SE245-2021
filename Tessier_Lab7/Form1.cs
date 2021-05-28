using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TessierLab5;

namespace Tessier_Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            PersonV2 temp = new PersonV2();
            temp.FirstName = txtFName.Text;
            temp.MiddleName = txtMName.Text;
            temp.LastName = txtLName.Text;
            temp.Street1 = txtStreet1.Text;
            temp.Street2 = txtStreet2.Text;
            temp.City = txtCity.Text;
            temp.State = txtState.Text;
            temp.ZipCode = txtZipCode.Text;
            temp.Phone = txtPhoneNum.Text;
            temp.Email = txtEmail.Text;
            temp.InstagramURL = txtInstagramURL.Text;
            temp.CellPhone = txtCellPhone.Text;

            if (temp.Feedback.Contains("WARNING:"))
            {
                txtFeedback.Text = temp.Feedback;
            }
            else
            {
                //txtFeedback.Text = "First Name: " + temp.FirstName + " Middle Name: " + temp.MiddleName + " Last Name: " + temp.LastName + " Address: " + temp.Street1 + " Apartment Number: " + temp.Street2 + " City: " + temp.City + " State: " + temp.State + " Zip Code: " + temp.ZipCode + " Phone #: " + temp.Phone + " Email: " + temp.Email + " Cell Phone Number: " + temp.CellPhone + " Instagram URL: " + temp.InstagramURL;
                txtFeedback.Text = temp.AddARecord();
            }
        }
    }
}
