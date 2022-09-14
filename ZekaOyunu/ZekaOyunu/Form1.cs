using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZekaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AssignIconsToSquares();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* string[] resimler = new string[16] { "ö", "ö", "ñ ", "ñ ", "õ ", "õ", "û", "û", "$","$","h","h","%","%","s","s"};
             int[] yerler = new int[16];

             Random rass = new Random();
             int satir, sutun;

             for(int i = 0; i < yerler.Length; i++)
             {
                 satir = rass.Next(4);
                 sutun = rass.Next(4);

                 tableLayoutPanel1.Controls.Add(resimler[i], satir, sutun);
             }

            */

           public Random rass = new Random();

        List<string> icons = new List<string>()
            {"ö", "ö", "ñ ", "ñ ", "õ ", "õ", "û", "û", "$","$","h","h","%","%","s","s"};


        private void AssignIconsToSquares()
        {
            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = rass.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    // iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }


        

         }

         
       }
    }

