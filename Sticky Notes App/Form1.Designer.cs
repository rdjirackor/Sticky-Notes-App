using System.Drawing;
using System.Windows.Forms;

namespace Sticky_Notes_App
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.cancel = new Sticky_Notes_App.RoundButton();
            this.Done = new Sticky_Notes_App.RoundButton();
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
            this.label2.Size = new System.Drawing.Size(1227, 78);
            this.label2.TabIndex = 0;
            this.label2.Text = "302 Project";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.White;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Image = global::Sticky_Notes_App.Properties.Resources.rotate_x;
            this.cancel.Location = new System.Drawing.Point(36, 492);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(70, 70);
            this.cancel.TabIndex = 1;
            this.cancel.UseVisualStyleBackColor = false;
            // 
            // Done
            // 
            this.Done.BackColor = System.Drawing.Color.Transparent;
            this.Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Done.Image = global::Sticky_Notes_App.Properties.Resources.bluecheck;
            this.Done.Location = new System.Drawing.Point(749, 492);
            this.Done.Name = "Done";
            this.Done.Padding = new System.Windows.Forms.Padding(30);
            this.Done.Size = new System.Drawing.Size(60, 60);
            this.Done.TabIndex = 1;
            this.Done.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 573);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private RoundButton cancel;
        private RoundButton Done;
    }
}

