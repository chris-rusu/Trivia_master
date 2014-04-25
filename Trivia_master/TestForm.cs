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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* MultipleChoiceForm mcf = new MultipleChoiceForm();
            mcf.ShowDialog();*/
            Easy obj = new Easy();
            Category<string, string> cat = new Category<string, string>() { CategoryName = "History"};
            MultipleChoiceQ<string,string> mc = new MultipleChoiceQ<string,string>();
            mc.Question.Add("Who was the first president of the USA?");
            mc.CorrectAnswers.Add("George Washington");
            mc.Answers.Add("1");
            mc.Answers.Add("2");
            mc.Answers.Add("3");
            mc.Answers.Add("4");
            cat.questions.Add(mc);
            obj.showQ(cat);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlphabetForm apf = new AlphabetForm();
            apf.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AssociationForm a = new AssociationForm();
            a.ShowDialog();
        }
    }
}
