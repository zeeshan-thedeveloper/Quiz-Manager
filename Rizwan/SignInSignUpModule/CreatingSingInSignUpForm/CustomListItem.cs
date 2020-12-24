using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomList
{
    public partial class CustomListItem : UserControl
    {
        public CustomListItem()
        {
            InitializeComponent();
        }
        #region  
        private string _question;
        private string _options;
        private Image _icon;
        private Color _iconbackground;
        
        [Category("Custom Prop")]
        public string Question
        {
            get { return _question; }
            set { _question = value;labelQuestion.Text = value; }
        }

        [Category("Custom Prop")]          
        public string Options
        {
            get { return _options; }
            set { _options = value;richTextBoxOptions.Text = value; }
        }


        [Category("Custom Prop")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }
        
        [Category("Custom Prop")]
        public Color IconBackground
        {
            get { return _iconbackground; }
            set { _iconbackground = value; panel1.BackColor = value; }
        }


        #endregion

        private void CustomListItem_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void CustomListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(128, 128, 255);
        }

        private void CustomListItem_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Title is : "+labelQuestion.Text+ "\n Description is : " +richTextBoxOptions.Text);

        }
    }
}
