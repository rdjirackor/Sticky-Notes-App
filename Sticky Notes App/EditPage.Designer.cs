using System.Drawing;
using System.Windows.Forms;

namespace Sticky_Notes_App
{
    partial class EditPage
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
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPage));
            this.label2 = new System.Windows.Forms.Label();
            this.cancel = new Sticky_Notes_App.RoundButton();
            this.Done = new Sticky_Notes_App.RoundButton();
            this.panel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Ribeye Marrow", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(1300, 78);
            this.label2.TabIndex = 0;
            this.label2.Text = "302 Project";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.White;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Image = global::Sticky_Notes_App.Properties.Resources.rotate_x;
            this.cancel.Location = new System.Drawing.Point(200, 560);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(70, 70);
            this.cancel.TabIndex = 1;
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.Button_Cancel);           
            // Done
            // 
            this.Done.BackColor = System.Drawing.Color.Transparent;
            this.Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Done.Image = global::Sticky_Notes_App.Properties.Resources.bluecheck;
            this.Done.Location = new System.Drawing.Point(1100, 560);
            this.Done.Name = "Done";
            this.Done.Padding = new System.Windows.Forms.Padding(30);
            this.Done.Size = new System.Drawing.Size(60, 60);
            this.Done.TabIndex = 1;
            this.Done.UseVisualStyleBackColor = false;
            this.Done.Click += new System.EventHandler(this.Button_Done);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.textBox1);
            this.panel.Controls.Add(this.richTextBox);
            this.panel.Location = new System.Drawing.Point(0, 78);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(screenWidth, 350);
            this.panel.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(450, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 20);
            this.textBox1.TabIndex = 0;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(0, 100);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(1300, 300);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // EditPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditPage";
            this.Text = "Sticky Notes - Edit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosed_);
            this.Load += new System.EventHandler(this.EditPage_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.Label label2;
        private RoundButton cancel;
        private RoundButton Done;
        private Panel panel;
        private TextBox textBox1;
        private RichTextBox richTextBox;
        
    }
}

