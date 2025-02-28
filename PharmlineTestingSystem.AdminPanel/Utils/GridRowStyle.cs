using PharmlineTestingSystem.Utils;
using System.Drawing;
using System.Windows.Forms;

namespace PharmlineTestingSystem.AdminPanel.Utils
{
    public static class GridRowStyle
    {
        public static void SetRowsStyle(this DataGridViewRowCollection rows, int index)
        {
            foreach (DataGridViewRow row in rows)
            {                
                if (row.Cells[index].Value is not null && row.Cells[index].Value.ToInt() != 1)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 222, 222);
            }
        }
    }
}
