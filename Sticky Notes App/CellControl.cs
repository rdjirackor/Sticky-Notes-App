using System;
using System.Windows.Forms;

namespace Sticky_Notes_App
{
    public class CellControl
    {
        private TableLayoutPanel tablelayout;

        public CellControl(TableLayoutPanel layout)
        {
            this.tablelayout = layout;
        }

        public void AddLabelsToCells()
        {
            for (int row = 0; row < this.tablelayout.RowCount; row++)
            {
                for (int col = 0; col < this.tablelayout.ColumnCount; col++)
                {
                    Label label = new Label();
                    label.Text = $"Row {row + 1}, Col {col + 1}";
                    label.Dock = DockStyle.Fill;
                    this.tablelayout.Controls.Add(label);
                }
            }
        }
    }
}
