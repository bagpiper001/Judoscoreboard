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

        DirectoryInfo dInfo = new DirectoryInfo("images");
        List<Image> reclameList;

        int timerTijd = 0;
       
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

            FileInfo[] pngFiles = dInfo.GetFiles("*.png");
            reclameList = new List<Image>();
            foreach(FileInfo d in pngFiles)
            {
                reclameList.Add(Image.FromFile(d.FullName));
            }
        }

        /**
        *This is for resizing the public screen, in the end, the public screen will be dynamically scaled.
        *This will be done in this method.
        */
        private void publicScreen_Resize(object sender, System.EventArgs e)
        {

        }

        private void publicScreen_Load(object sender, EventArgs e)
        {
            publicScreen_Resize(sender, e);
            boxReclameImage.Image = reclameList[0];
            boxReclameImage.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void reclameTimer_Tick(object sender, EventArgs e)
        {
            timerTijd += 1;
            if (reclameList.Count == timerTijd)
                timerTijd = 0;
            try
            {
                boxReclameImage.Image = reclameList[timerTijd];
            } catch(Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        private void lblIpponWit_Click(object sender, EventArgs e)
        {

        }
    }
}
