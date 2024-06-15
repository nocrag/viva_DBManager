using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutApp
{
    public static class UIUtilities
    {
        public static void FillListControl(ListControl control, string displayMember, string valueMember, 
            DataTable dt, bool insertBlank = false, string defaultText = "")
        {
            if (insertBlank)
            {
                DataRow row = dt.NewRow();
                row[valueMember] = DBNull.Value;
                row[displayMember] = defaultText;
                dt.Rows.InsertAt(row, 0);
            }

            control.DisplayMember = displayMember;
            control.ValueMember = valueMember;
            control.DataSource = dt;
        }

        public static void BtnColorChange(int red, int green, int blue, params Button[] buttons)
        {
            foreach (var btn in buttons)
            {
                if (btn.Enabled)
                    btn.BackColor = Color.FromArgb(red, green, blue);
                else
                    btn.BackColor = Color.FromArgb(35, 35, 35);

            }
        }
    }
}
