using System.Drawing;
using System.Windows.Forms;

namespace Sticky_Notes_App
{
    partial class FirstPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPage));
            this.label1 = new System.Windows.Forms.Label();
            this.search = new Sticky_Notes_App.RoundButton();
            this.addbutton = new Sticky_Notes_App.RoundButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablelayout = new System.Windows.Forms.TableLayoutPanel();
            this.note1 = new System.Windows.Forms.Label();
            this.note2 = new System.Windows.Forms.Label();
            this.note3 = new System.Windows.Forms.Label();
            this.note4 = new System.Windows.Forms.Label();
            this.note5 = new System.Windows.Forms.Label();
            this.note6 = new System.Windows.Forms.Label();
            this.note7 = new System.Windows.Forms.Label();
            this.note8 = new System.Windows.Forms.Label();
            this.note9 = new System.Windows.Forms.Label();
            this.note10 = new System.Windows.Forms.Label();
            this.note11 = new System.Windows.Forms.Label();
            this.note12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tablelayout.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(1366, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quick Notes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.White;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Image = global::Sticky_Notes_App.Properties.Resources.search_icon2;
            this.search.Location = new System.Drawing.Point(200, 560);
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(30);
            this.search.Size = new System.Drawing.Size(70, 70);
            this.search.TabIndex = 1;
            this.search.UseVisualStyleBackColor = false;
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.Transparent;
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbutton.Image = global::Sticky_Notes_App.Properties.Resources.add_icon;
            this.addbutton.Location = new System.Drawing.Point(1100, 560);
            this.addbutton.Name = "addbutton";
            this.addbutton.Padding = new System.Windows.Forms.Padding(30);
            this.addbutton.Size = new System.Drawing.Size(60, 60);
            this.addbutton.TabIndex = 1;
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.Button_add);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tablelayout);
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 450);
            this.panel1.TabIndex = 2;

            // 
            // tablelayout
            // 
            this.tablelayout.AutoSize = true; // Let the TableLayoutPanel size itself based on its content
            this.tablelayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.tablelayout.Dock = DockStyle.None; // Remove DockStyle.Fill so it doesn't auto-resize to panel
            this.tablelayout.Size = new Size(screenWidth, 1000); // Example size larger than the panel

            this.tablelayout.ColumnStyles.Clear();
            this.tablelayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 440F)); // Example width
            this.tablelayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 440F));
            this.tablelayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 440F));

            this.tablelayout.RowStyles.Clear();
            this.tablelayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F)); // Example height
            this.tablelayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            this.tablelayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            this.tablelayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));


            this.tablelayout.AutoScroll = true;
            this.tablelayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tablelayout.ColumnCount = 3;
            this.tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tablelayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tablelayout.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablelayout.Location = new System.Drawing.Point(0, 0);
            this.tablelayout.Name = "tablelayout";
            this.tablelayout.RowCount = 4;
            this.tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablelayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablelayout.TabIndex = 0;
            this.tablelayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tablelayout_Paint);
           
            this.tablelayout.Controls.Add(this.note1, 0, 0);
            this.tablelayout.Controls.Add(this.note2, 1, 0);
            this.tablelayout.Controls.Add(this.note3, 2, 0);
            this.tablelayout.Controls.Add(this.note4, 0, 1);
            this.tablelayout.Controls.Add(this.note5, 1, 1);
            this.tablelayout.Controls.Add(this.note6, 2, 1);
            this.tablelayout.Controls.Add(this.note7, 0, 2);
            this.tablelayout.Controls.Add(this.note8, 1, 2);
            this.tablelayout.Controls.Add(this.note9, 2, 2);
            this.tablelayout.Controls.Add(this.note10, 0, 3);
            this.tablelayout.Controls.Add(this.note11, 1, 3);
            this.tablelayout.Controls.Add(this.note12, 2, 3);


            // 
            // note1
            // 
            this.note1.AutoSize = true;
            this.note1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.note1.Location = new System.Drawing.Point(4, 1);
            this.note1.Name = "note1";
            this.note1.Size = new System.Drawing.Size(447, 110);
            this.note1.TabIndex = 0;
            this.note1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.note2.AutoSize = true;
            this.note2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note2.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.note2.Location = new System.Drawing.Point(4, 1);
            this.note2.Name = "note2";
            this.note2.Size = new System.Drawing.Size(447, 110);
            this.note2.TabIndex = 0;
            this.note2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.note3.AutoSize = true;
            this.note3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note3.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.note3.Location = new System.Drawing.Point(4, 1);
            this.note3.Name = "note3";
            this.note3.Size = new System.Drawing.Size(447, 110);
            this.note3.TabIndex = 0;
            this.note3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.note4.AutoSize = true;
            this.note4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note4.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.note4.Location = new System.Drawing.Point(4, 1);
            this.note4.Name = "note4";
            this.note4.Size = new System.Drawing.Size(447, 110);
            this.note4.TabIndex = 0;
            this.note4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.note5.AutoSize = true;
            this.note5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note5.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.note5.Location = new System.Drawing.Point(4, 1);
            this.note5.Name = "note5";
            this.note5.Size = new System.Drawing.Size(447, 110);
            this.note5.TabIndex = 0;
            this.note5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.note6.AutoSize = true;
            this.note6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note6.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.note6.Location = new System.Drawing.Point(4, 1);
            this.note6.Name = "note6";
            this.note6.Size = new System.Drawing.Size(447, 110);
            this.note6.TabIndex = 0;
            this.note6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        
            this.note7.AutoSize = true;
            this.note7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note7.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.note7.Location = new System.Drawing.Point(4, 1);
            this.note7.Name = "note7";
            this.note7.Size = new System.Drawing.Size(447, 110);
            this.note7.TabIndex = 0;
            this.note7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.note8.AutoSize = true;
            this.note8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note8.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.note8.Location = new System.Drawing.Point(4, 1);
            this.note8.Name = "note8";
            this.note8.Size = new System.Drawing.Size(447, 110);
            this.note8.TabIndex = 0;
            this.note8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.note9.AutoSize = true;
            this.note9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note9.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.note9.Location = new System.Drawing.Point(4, 1);
            this.note9.Name = "note9";
            this.note9.Size = new System.Drawing.Size(447, 110);
            this.note9.TabIndex = 0;
            this.note9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.note10.AutoSize = true;
            this.note10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note10.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.note10.Location = new System.Drawing.Point(4, 1);
            this.note10.Name = "note10";
            this.note10.Size = new System.Drawing.Size(447, 110);
            this.note10.TabIndex = 0;
            this.note10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.note11.AutoSize = true;
            this.note11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note11.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.note11.Location = new System.Drawing.Point(4, 1);
            this.note11.Name = "note11";
            this.note11.Size = new System.Drawing.Size(447, 110);
            this.note11.TabIndex = 0;
            this.note11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.note12.AutoSize = true;
            this.note12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.note12.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.note12.Location = new System.Drawing.Point(4, 1);
            this.note12.Name = "note12";
            this.note12.Size = new System.Drawing.Size(447, 110);
            this.note12.TabIndex = 0;
            this.note12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;


            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstPage";
            this.Text = "Sticky Notes - Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosed_);
            this.Load += new System.EventHandler(this.First_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tablelayout.ResumeLayout(false);
            this.tablelayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RoundButton search;
        private RoundButton addbutton;
        private Panel panel1;
        private TableLayoutPanel tablelayout;
        private Label note1;
        private Label note2;
        private Label note3;
        private Label note4;
        private Label note5;
        private Label note6;
        private Label note7;
        private Label note8;
        private Label note9;
        private Label note10;
        private Label note11;
        private Label note12;


    }
}

