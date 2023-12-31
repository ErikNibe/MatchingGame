﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AssignIconsToSquares();
        }

        Random random = new Random();

        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor; 
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void RevealIcon_Click(object sender, EventArgs e)
        {
            Label clickedIcon = sender as Label;

            if (clickedIcon != null)
            {
                if (clickedIcon.ForeColor == Color.Black) return;

                clickedIcon.ForeColor = Color.Black;
            }
        }
    }
}
