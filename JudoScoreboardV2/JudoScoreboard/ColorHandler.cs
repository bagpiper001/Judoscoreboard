using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JudoScoreboard
{
    class ColorHandler
    {
        Color rood = Color.Red;
        Color wit = Color.White;
        Color grijs = Color.Gray;
        Color blauw = Color.Blue;

        List<Control> timerLabelList;

        List<Control> witLabelList;
        List<Control> witTextLabelList;
        List<Control> witConfirmLabelList;

        List<Control> roodLabelList;
        List<Control> roodTextLabelList;
        List<Control> roodConfirmLabelList;

        List<Control> witVoorkantLabelList;
        List<Control> witVoorkantTextLabelList;
        List<Control> witVoorkantConfirmLabelList;

        List<Control> roodVoorkantLabelList;
        List<Control> roodVoorkantTextLabelList;
        List<Control> roodVoorkantConfirmLabelList;

        static string[] witLabels = { "lblYukoWit", "lblWazariWit", "lblIpponWit", "lblShidoWit" };
        static string[] witTextLabels = { "lblYukoTextWit", "lblWazariTextWit", "lblIpponTextWit", "lblShidoTextWit" };
        static string[] witConfirmLabels = { "lblConfirmWit1", "lblConfirmWit2", "lblConfirmWit3" };
        static string[] roodLabels = { "lblYukoRood", "lblWazariRood", "lblIpponRood", "lblShidoRood" };
        static string[] roodTextLabels = { "lblYukoTextRood", "lblWazariTextRood", "lblIpponTextRood", "lblShidoTextRood" };
        static string[] roodConfirmLabels = { "lblConfirmRood1", "lblConfirmRood2", "lblConfirmRood3" };
        static string[] timerLabels = { "lblMin", "lblTimeSeperate", "lblSec" };


        public ColorHandler()
        {
            timerLabelList = new List<Control>();

            witLabelList = new List<Control>();
            witTextLabelList = new List<Control>();
            witConfirmLabelList = new List<Control>();

            roodLabelList = new List<Control>();
            roodTextLabelList = new List<Control>();
            roodConfirmLabelList = new List<Control>();

            witVoorkantLabelList = new List<Control>();
            witVoorkantTextLabelList = new List<Control>();
            witVoorkantConfirmLabelList = new List<Control>();

            roodVoorkantLabelList = new List<Control>();
            roodVoorkantTextLabelList = new List<Control>();
            roodVoorkantConfirmLabelList = new List<Control>();
        }

        public void assignList(Control control)
        {
            if (witLabels.Contains(control.Name.ToString()))
                witLabelList.Add((Label)control);
            if (witConfirmLabels.Contains(control.Name.ToString()))
                witConfirmLabelList.Add((Label)control);
            if (witTextLabels.Contains(control.Name.ToString()))
                witTextLabelList.Add((Label)control);
            if (roodLabels.Contains(control.Name.ToString()))
                roodLabelList.Add((Label)control);
            if (roodTextLabels.Contains(control.Name.ToString()))
                roodTextLabelList.Add((Label)control);
            if (roodConfirmLabels.Contains(control.Name.ToString()))
                roodConfirmLabelList.Add((Label)control);
            if (timerLabels.Contains(control.Name.ToString()))
                timerLabelList.Add((Label)control);
        }

        public void assignVoorkantList(Control control)
        {
            if (timerLabels.Contains(control.Name.ToString()))
                timerLabelList.Add((Label)control);
            if (witLabels.Contains(control.Name.ToString()))
                witVoorkantLabelList.Add((Label)control);
            if (witConfirmLabels.Contains(control.Name.ToString()))
                witVoorkantConfirmLabelList.Add((Label)control);
            if (witTextLabels.Contains(control.Name.ToString()))
                witVoorkantTextLabelList.Add((Label)control);
            if (roodLabels.Contains(control.Name.ToString()))
                roodVoorkantLabelList.Add((Label)control);
            if (roodConfirmLabels.Contains(control.Name.ToString()))
                roodVoorkantConfirmLabelList.Add((Label)control);
            if (roodTextLabels.Contains(control.Name.ToString()))
                roodVoorkantTextLabelList.Add((Label)control);
        }

        public Color getDefaultColor(Control control)
        {
            Color returnColor = new Color();
            if (roodLabelList.Contains(control) || roodVoorkantLabelList.Contains(control))
                returnColor = rood;
            if (witLabelList.Contains(control) || witVoorkantLabelList.Contains(control))
                returnColor = wit;
            else
                returnColor = grijs;

            return returnColor;
        }
    }
}
