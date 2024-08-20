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
            this.label1 = new System.Windows.Forms.Label();
            RoundButton addbutton = new RoundButton();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Ribeye Marrow", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(44, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(1227, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "302 Project";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addbutton
            // 
            addbutton.Width = 100;
            addbutton.Height = 100;
           // addButton.Image = Image.FromFile();

            //  this.addbutton.Location = new System.Drawing.Point(754, 530);
            // this.addbutton.Name = "addbutton";
            // this.addbutton.Size = new System.Drawing.Size(54, 33);
            //this.addbutton.TabIndex = 1;
            //this.addbutton.Text = "addbutton";
            //this.addbutton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(36, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 573);
            this.Controls.Add(this.button2);
          //  this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
      //  private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button button2;
    }
}

