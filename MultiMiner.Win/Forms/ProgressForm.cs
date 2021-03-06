﻿using MultiMiner.Utility.Forms;

namespace MultiMiner.Win.Forms
{
    public partial class ProgressForm : MessageBoxFontForm
    {
        public ProgressForm(string labelText)
        {
            InitializeComponent();
            label1.Text = labelText;
        }

        public string LabelText
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
    }
}
