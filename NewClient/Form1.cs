using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewClient
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

            // TODO: checken ob wenigstens eine Leistung ausgewählt wurde
            Debug.WriteLine("Create Button Clicked");

            string folderName = @"c:\Users\jonathan.rhein\Mandanten";
            folderName = @"N:\Daten N NEU\02 Mandant";
            string clientName = NameTextBox.Text;
            string pathString = System.IO.Path.Combine(folderName, clientName);
            string[] clientFolders = Directory.GetDirectories(folderName);
            
            string selectedYear = YearComboBox.Text;
            bool atLeastOneServiceSelected = (Finanzbuchhaltung_Check_Box.Checked ||
                Jahresabschluss_CheckBox.Checked ||
                Einkommenssteuererklaerung_CheckBox.Checked ||
                Lohnbuchhaltung_CheckBox.Checked ||
                Umsatzsteuervoranmeldung_CheckBox.Checked);

            string message = "";
            string caption = "Fehler beim Ausfüllen";

            if (!atLeastOneServiceSelected) message = "Bitte geben Sie mindestens eine Leistung an.";
            if (selectedYear == "- bitte auswählen -") message = "Bitte wählen Sie das Jahr der Mandatsaufnahme aus.";
            if (clientName == "") message = "Bitte geben Sie einen Mandantennamen an.";
            if (clientFolders.Contains(pathString)) message = $"{clientName} existiert bereits. Bitte geben Sie einen anderen Mandantennamen ein.";

            Debug.WriteLine(message);
            if (message != "")
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            } else
            {           
                System.IO.Directory.CreateDirectory(pathString);

                List<string> subfoldersLevel1 = new List<string> { "00 Dauerakte", "04 Kommunikation mit Mandant", "05 Kommunikation mit Behörden", "06 Sendeprotokolle", "07 Bescheide", "10 Rechnungen (Digital)" };
                if (Finanzbuchhaltung_Check_Box.Checked) subfoldersLevel1.Add("01 Buchhaltung");
                if (Jahresabschluss_CheckBox.Checked) subfoldersLevel1.Add("02 Jahresabschluss");
                if (Einkommenssteuererklaerung_CheckBox.Checked) subfoldersLevel1.Add("03 Einkommenssteuer");
                if (Lohnbuchhaltung_CheckBox.Checked) subfoldersLevel1.Add("08 Lohnbuchhaltung");
                if (Umsatzsteuervoranmeldung_CheckBox.Checked) subfoldersLevel1.Add("09 Umsatzsteuervoranmeldung");

                foreach (string item in subfoldersLevel1)
                {
                    System.IO.Directory.CreateDirectory(System.IO.Path.Combine(pathString, item));
                }
                this.Close();
            }
           
        }


        private void HeadingLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var year in Enumerable.Range(1990, DateTime.Today.Year - 1989).ToList())
            {
                YearComboBox.Items.Add(year);
            }          
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AbortButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }


    }
}
