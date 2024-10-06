using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorna4
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Resize(object sender, EventArgs e)
        {
            int buttonsSize = 5 * btnAdd.Width + 2 * tsSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width - buttonsSize, 0, 0, 0);
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            gvHouse.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Width";
            column.Name = "Ширина";
            gvHouse.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Length";
            column.Name = "Довжина";
            gvHouse.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Height";
            column.Name = "Висота";
            gvHouse.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Room";
            column.Name = "Кількість кімнат";
            gvHouse.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Floor";
            column.Name = "Кількість поверхів";
            gvHouse.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Value";
            column.Name = "Вартість опалення";
            gvHouse.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Price";
            column.Name = "Вартість м кв";
            gvHouse.Columns.Add(column);

            column = new DataGridViewCheckBoxColumn();
            column.DataPropertyName = "HasForniture";
            column.Name = "Чи є меблі та техніка?";
            column.Width = 60;
            gvHouse.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "GetCost";
            column.Name = "Ціна за будинок";
            gvHouse.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Heating";
            column.Name = "Ціна за опалення";
            gvHouse.Columns.Add(column);

            bindSrcHouse.Add(new House(40, 34, 3, 4, 5, 18, 20000, true, 432, 423));
            EventArgs args = new EventArgs(); OnResize(args);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            House house = new House();

            fHouse ft = new fHouse(house);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcHouse.Add(house);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            House house = (House)bindSrcHouse.List[bindSrcHouse.Position];

            fHouse ft = new fHouse(house);
            if (ft.ShowDialog() == DialogResult.OK)
            {
                bindSrcHouse.List[bindSrcHouse.Position] = house;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                bindSrcHouse.RemoveCurrent();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bindSrcHouse.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
