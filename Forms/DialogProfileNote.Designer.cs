using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GenieClient
{

    public partial class DialogProfileNote : Form
    {
        private IContainer components = null;
        private Button OK_Button;
        private Button Cancel_Button;
        private TextBox TextBoxNote;
        private Label LabelName;

        private void InitializeComponent()
        {
            this.OK_Button = new Button();
            this.Cancel_Button = new Button();
            this.TextBoxNote = new TextBox();
            this.LabelName = new Label();
            this.SuspendLayout();

            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(237, 67);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new EventHandler(this.OK_Button_Click);

            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(318, 67);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new EventHandler(this.Cancel_Button_Click);

            // 
            // TextBoxNote
            // 
            this.TextBoxNote.Location = new System.Drawing.Point(18, 29);
            this.TextBoxNote.Name = "TextBoxNote";
            this.TextBoxNote.Size = new System.Drawing.Size(375, 20);
            this.TextBoxNote.TabIndex = 2;

            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(15, 10);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(30, 13);
            this.LabelName.TabIndex = 3;
            this.LabelName.Text = "Note";

            // 
            // DialogProfileNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 100);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.TextBoxNote);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OK_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DialogProfileNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile Note";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
