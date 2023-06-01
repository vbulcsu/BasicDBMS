﻿
namespace Frontend.Components
{
    public partial class TextQueryControl : UserControl
    {
        public SqlRichTextBox TextBox { get { return sqlRichTextBox1; } }
        public ListBox LineCounter { get { return listBox1; } }

        public TextQueryControl()
        {
            InitializeComponent();

            Name = "TextEditor";

            TextBox.TextChanged += SqlRichTextBox_TextChanged;
        }

        private void SqlRichTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateLineNumbers();
        }

        private void UpdateLineNumbers()
        {
            LineCounter.Items.Clear();

            int count = TextBox.Lines.Length;
            for (int i = 1; i <= count; i++)
            {
                LineCounter.Items.Add(i.ToString());
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
