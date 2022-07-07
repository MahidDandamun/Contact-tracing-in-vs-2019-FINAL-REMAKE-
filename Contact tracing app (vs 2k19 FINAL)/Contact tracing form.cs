using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Contact_tracing_app__vs_2k19_FINAL_
{
    public partial class FrmContactTracingForm : Form
    {
        public FrmContactTracingForm()
        {
            InitializeComponent();
        }

        private void FrmContactTracingForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubnit_Click(object sender, EventArgs e)
        {

            if ((txtbxAddress.Text != "") && (txtbxFullname.Text != "") && (txtbxEmail.Text != "") && (cbxAge.Text != "") &&
         (txtbxContact.Text != "") && (cbxTemp.Text != "") && (txtbxZip.Text != "") &&
         ((rdbtn1.Checked != false) || (rdbtn2.Checked != false)) &&
         ((rdbtn3.Checked != false) || (rdbtn4.Checked != false)) &&
         ((rdbtn5.Checked != false) || (rdbtn6.Checked != false)) &&
         ((rdbtn7.Checked != false) || (rdbtn8.Checked != false)) &&
         ((rdbtn9.Checked != false) || (rdbtn10.Checked != false)) &&
         ((rdbtn11.Checked != false) || (rdbtn12.Checked != false)) &&
         ((rdbtn13.Checked != false) || (rdbtn14.Checked != false)))
            {
                StreamWriter file = new StreamWriter(@"E:\Downloads\Contact persons.txt", true);
                file.WriteLine(txtbxFullname.Text);
                file.WriteLine(dtpDov.Value.ToString("o"));
                file.WriteLine("Fullname: " + txtbxFullname.Text);
                file.WriteLine("Address: " + txtbxAddress.Text);
                file.WriteLine("Time of visit: " + dtpTov.Text);
                file.WriteLine("Email: " + txtbxEmail.Text);
                file.WriteLine("Contact number: " + txtbxContact.Text);
                file.WriteLine("Date of visit: " + dtpDov.Text);
                file.WriteLine("Zip code: " + txtbxZip.Text);
                file.WriteLine("Age: " + cbxAge.Text);
                file.WriteLine("Temperature: " + cbxTemp.Text);

                if (rdbtn1.Checked)
                {
                    file.WriteLine("Question1: This person have lost his sens of taste and smell");
                }
                else if (rdbtn2.Checked)
                {
                    file.WriteLine("Question1: NO");
                }
                if (rdbtn3.Checked)
                {
                    file.WriteLine("Question2: This person have sore throat");
                }
                else if (rdbtn4.Checked)
                {
                    file.WriteLine("Question2: NO");
                }
                if (rdbtn5.Checked)
                {
                    file.WriteLine("Question3: This person have fever");
                }
                else if (rdbtn6.Checked)
                {
                    file.WriteLine("Question3: NO");
                }
                if (rdbtn7.Checked)
                {
                    file.WriteLine("Question4: This person is experiencing difficulty in breathing");
                }
                else if (rdbtn8.Checked)
                {
                    file.WriteLine("Question4: NO");
                }
                if (rdbtn9.Checked)
                {
                    file.WriteLine("Question5: This person have been exposed to covid patient");
                }
                else if (rdbtn10.Checked)
                {
                    file.WriteLine("Question5: NO");
                }
                if (rdbtn11.Checked)
                {
                    file.WriteLine("Question6: This person have travelled outside the country ");
                }
                else if (rdbtn12.Checked)
                {
                    file.WriteLine("Question6: NO");
                }
                if (rdbtn13.Checked)
                {
                    file.WriteLine("Question7: This person have already received two doses of Covid-19 Vaccine");
                }
                else if (rdbtn14.Checked)
                {
                    file.WriteLine("Question7: This person is not fully Vaccinated");
                }
                file.WriteLine();
                file.Close();
                MessageBox.Show("Your response has been recorded");


                FrmRecords frmrecords = new FrmRecords();
                frmrecords.originalform = this;
                frmrecords.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Please fill in the fields properly");
        }

        private void btnQrcode_Click(object sender, EventArgs e)
        {
            FrmQrScanner frmQrScanner = new FrmQrScanner();
            frmQrScanner.originalform = this;
            frmQrScanner.Show();
           
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
