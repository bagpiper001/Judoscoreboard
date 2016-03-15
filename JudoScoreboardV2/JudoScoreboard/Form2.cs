using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JudoScoreboard
{
    public partial class publicScreen : Form
    {
        public int width;
        public int height;
       
        public List<Control> roodLabelList = new List<Control>();
        public List<Control> witLabelList = new List<Control>();
        public List<Control> buttonList = new List<Control>();
        public List<Control> timerLabelList = new List<Control>();
        public publicScreen()
        {
            InitializeComponent();
            width = this.Size.Width;
            height = this.Size.Height;

            //fill the lists
            foreach(Control control in this.Controls)
            {
                if (control.GetType() == typeof(Button))
                    buttonList.Add((Button)control);
            }
        }

        /**
        *This is for resizing the public screen, in the end, the public screen will be dynamically scaled.
        *This will be done in this method.
        */
        private void publicScreen_Resize(object sender, System.EventArgs e)
        {

        }
    }
}
