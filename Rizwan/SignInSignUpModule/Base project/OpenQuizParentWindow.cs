using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Printing;
namespace Base_project
{
    public partial class OpenQuizParentWindow : Form
    {
        public OpenQuizParentWindow()
        {
            InitializeComponent();
        }

        private void OpenQuizParentWindow_Load(object sender, EventArgs e)
        {
            labelTopicName.Text = GlobalStaticVariablesAndMethods.currentTopicName;
            labelSubjectName.Text = GlobalStaticVariablesAndMethods.currentSubjectName;
            richTextBoxContentdisplayer.Text = CreateQuizInTextFormate();
        }
        private String CreateQuizInTextFormate()
        {
            

            DataTableReader dataTableReader = new DataTableReader(GlobalStaticVariablesAndMethods.currentDataSetUsedForHoldingQuestions.Tables[0]);
            String textLine = "";
            int index = 1;
            while (dataTableReader.Read())
            {


                String topic = dataTableReader[1] as String;
                if (topic.Equals(GlobalStaticVariablesAndMethods.currentTopicName))
                {
                    String question = (String)dataTableReader["Question"];
                    String answers = (String)dataTableReader["Answers"];
                    textLine += " Question No : " + (index++) +"      "+ question+"\n";

                    String[] opt = answers.Split(GlobalStaticVariablesAndMethods.seperatorCharactor);
                    answers = "";

                    foreach (String asn in opt)
                    {
                        answers += asn + "           ";
                    }
                    textLine += answers + "\n\n\n";

                }

            }

            Console.WriteLine("TExt is "+textLine);

            return textLine;
        }

        private void buttonSaveAsPdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = " Pdf files | *.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Document document = new Document(PageSize.A4.Rotate());
                try
                {
                    PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();
                    document.Add(new Paragraph(richTextBoxContentdisplayer.Text));
                    document.Close();
                    GlobalStaticVariablesAndMethods.CreateInfoMesssage(GlobalStaticVariablesAndMethods.FileavedAsPdfInfoMessage);
                }
                catch (Exception v)
                {
                    MessageBox.Show(v.Message);
                }
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintInfoDialog pid = new PrintInfoDialog();

            pid.ShowDialog();

            //Create a PrintDocument object  
            PrintDocument pd = new PrintDocument();

            //Set PrinterName as the selected printer in the printers list  
            //     pd.PrinterSettings.PrinterName = printersList.SelectedItem.ToString();

            pd.PrinterSettings.PrinterName = GlobalStaticVariablesAndMethods.selectedPrinter;

            //Add PrintPage event handler  
            pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);

            //Print the document  
            pd.Print();

        }
        public void pd_PrintPage(object sender, PrintPageEventArgs ev)
        {

            //Get the Graphics object  
            Graphics g = ev.Graphics;

            //Create a font Arial with size 16  
            System.Drawing.Font font = new System.Drawing.Font("Arial", 16);

            //Create a solid brush with black color  
            SolidBrush brush = new SolidBrush(Color.Black);

            //Draw "";  
            g.DrawString(richTextBoxContentdisplayer.Text,
            font, brush,
            new System.Drawing.Rectangle(20, 20, 200, 100));
        }
    }
}
