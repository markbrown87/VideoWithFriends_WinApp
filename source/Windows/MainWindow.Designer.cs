
namespace VideoWithFriends
{
  partial class MainWindow
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.SendButton = new System.Windows.Forms.Button();
      this.TextBoxEntryField = new System.Windows.Forms.TextBox();
      this.TextBoxDisplayField = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // SendButton
      // 
      this.SendButton.Location = new System.Drawing.Point(644, 360);
      this.SendButton.Name = "SendButton";
      this.SendButton.Size = new System.Drawing.Size(94, 38);
      this.SendButton.TabIndex = 0;
      this.SendButton.Text = "Send";
      this.SendButton.UseVisualStyleBackColor = true;
      this.SendButton.Click += new System.EventHandler(this.button1_Click);
      // 
      // TextBoxEntryField
      // 
      this.TextBoxEntryField.Location = new System.Drawing.Point(12, 360);
      this.TextBoxEntryField.Multiline = true;
      this.TextBoxEntryField.Name = "TextBoxEntryField";
      this.TextBoxEntryField.Size = new System.Drawing.Size(594, 38);
      this.TextBoxEntryField.TabIndex = 1;
      this.TextBoxEntryField.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      this.TextBoxEntryField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox1_KeyDown);
      // 
      // TextBoxDisplayField
      // 
      this.TextBoxDisplayField.Enabled = false;
      this.TextBoxDisplayField.Location = new System.Drawing.Point(12, 12);
      this.TextBoxDisplayField.Multiline = true;
      this.TextBoxDisplayField.Name = "TextBoxDisplayField";
      this.TextBoxDisplayField.ReadOnly = true;
      this.TextBoxDisplayField.Size = new System.Drawing.Size(594, 333);
      this.TextBoxDisplayField.TabIndex = 2;
      this.TextBoxDisplayField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(769, 430);
      this.Controls.Add(this.TextBoxDisplayField);
      this.Controls.Add(this.TextBoxEntryField);
      this.Controls.Add(this.SendButton);
      this.Name = "MainWindow";
      this.Text = "Video W/ Friends";
      this.Load += new System.EventHandler(this.MainWindow_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button SendButton;
    private System.Windows.Forms.TextBox TextBoxEntryField;
    private System.Windows.Forms.TextBox TextBoxDisplayField;
  }
}

