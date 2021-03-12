using System;
using System.Windows.Forms;

namespace VideoWithFriends
{
  public partial class MainWindow : Form
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void MainWindow_Load(object sender, EventArgs e)
    {
      TextBoxDisplayField.AppendText("Welcome to the printer..." + Environment.NewLine);
    }

    private void textbox1_KeyDown(object sender, KeyEventArgs e)
    {
      // If the user hits enter //
      if (e.KeyCode == Keys.Enter)
        button1_Click(sender, e);
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
      // Do Nothing here yet //
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
      // Do Nothing here yet //
    }

    private void button1_Click(object sender, EventArgs e)
    {
      // Append the text to the text box and clear the text box enter //
      if (TextBoxDisplayField.Text != "")
      {
        TextBoxDisplayField.AppendText(TextBoxEntryField.Text.Trim() + Environment.NewLine);
        TextBoxEntryField.ResetText();
      }
    }
  }
}
