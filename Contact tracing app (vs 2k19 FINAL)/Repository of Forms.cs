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
    public partial class FrmRecords : Form
    {
        public FrmContactTracingForm originalform;
        List<DateTime> dates = new List<DateTime>();
        List<ListViewItem> items = new List<ListViewItem>();
        List<string> datasummary = new List<string>();
        public FrmRecords()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmRecords_Load(object sender, EventArgs e)
        {
             
        }

        private void FrmRecords_Shown(object sender, EventArgs e)
        {
            dates.Clear();
            datasummary.Clear();
            items.Clear();
            StreamReader file = new StreamReader(@"E:\Downloads\Contact persons.txt");

            while (file.EndOfStream == false)
            {
                string Details = "";
                String FullName = file.ReadLine();
                DateTime Date;
                if (!DateTime.TryParse(file.ReadLine(), out Date))
                {
                    return;
                }
                string line = file.ReadLine();
                while (line != "")
                {
                    Details += line + "\n";
                    line = file.ReadLine();
                }
                datasummary.Add(Details);
                dates.Add(DateTime.FromOADate(Date.ToOADate()));
                ListViewItem item = new ListViewItem(new String[] { FullName, Date.ToString() });
                item.Tag = items.Count;
                items.Add(item);
            }
            lvRecords.Items.Clear();
            lvRecords.Items.AddRange(items.ToArray());
        }

        private void lvRecords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRecords.SelectedItems.Count > 0)
            {
                ListViewItem item = lvRecords.SelectedItems[0];
                int index = (int)item.Tag;
                lblDetailOfPerson.Text = datasummary[index];

            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
           

            DateTime currentdate = DateTime.FromOADate(dtpDov.Value.ToOADate());

            lvRecords.Items.Clear();
            for (int i = 0; i < dates.Count; i++)
            {
                if (currentdate.CompareTo(dates[i]) == 0)
                {
                    lvRecords.Items.Add(items[i]);
                }
            }
        }
    }
}
