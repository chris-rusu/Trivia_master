﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trivia_master
{
    public partial class AlphabetForm : Form1
    {
        List<AlphabetButton> list;
        public AlphabetForm()
        {
            InitializeComponent();
            list = new List<AlphabetButton>();
            list.Add(button1);
            list.Add(triviaButton1);
            list.Add(triviaButton2);
            list.Add(triviaButton3);
            list.Add(triviaButton4);
            list.Add(triviaButton5);
            list.Add(triviaButton6);
            list.Add(triviaButton7);
            list.Add(triviaButton8);
            list.Add(triviaButton9);
            list.Add(triviaButton10);
            list.Add(triviaButton11);
            list.Add(triviaButton12);
            list.Add(triviaButton13);
            list.Add(triviaButton14);
            list.Add(triviaButton15);
            list.Add(triviaButton16);
            list.Add(triviaButton17);
            list.Add(triviaButton18);
            list.Add(triviaButton19);
            list.Add(triviaButton20);
            list.Add(triviaButton21);
            list.Add(triviaButton22);
            list.Add(triviaButton23);
            list.Add(triviaButton24);
            list.Add(triviaButton25);
        }

        private void AlphabetForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (AlphabetButton btn in list)
                btn.checkCharacter(e.KeyChar);
        }
    }
}
