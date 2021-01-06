using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
namespace Base_project
{
    public partial class PrintInfoDialog : Form
    {
        public PrintInfoDialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GlobalStaticVariablesAndMethods.selectedPrinter = comboBoxPrinterList.SelectedItem.ToString();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void PrintInfoDialog_Load(object sender, EventArgs e)
        {
            //See if any printers are installed  
            if (PrinterSettings.InstalledPrinters.Count <= 0)
            {
                MessageBox.Show("Printer not found!");
                return;
            }

            //Get all available printers and add them to the combo box  
            foreach (String printer in PrinterSettings.InstalledPrinters)
            {
                comboBoxPrinterList.Items.Add(printer.ToString());
            }
        }
    }
}
