using System;
using System.Windows.Forms;


namespace LaufwerkAnzeige
{
    public partial class Form1 : Form
    {
        private string[] laufwerke;
        //private string ausgabe;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLaufwerk_Click(object sender, EventArgs e)
        {
            laufwerke = Environment.GetLogicalDrives();
            //zur Verhinderung von Doppeleinträgen
            lbx_Ausgabe.Items.Clear();                                  
            foreach (string laufwerk in laufwerke)
            {
                lbx_Ausgabe.Items.Add(laufwerk);
            }          
        }

        private void lbx_Ausgabe_DoubleClick(object sender, EventArgs e)
        {
            if (lbx_Ausgabe.SelectedIndex >= 0)
                MessageBox.Show(laufwerke[lbx_Ausgabe.SelectedIndex]);
            //Die Elsebedingung muss rein, sonst gibt es eine Exception, bei Fehlklick
            else
                MessageBox.Show("Bitte Laufwerk auswählen");                    
        }
    }
}
