using BotanicalGarden.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotanicalGarden.View
{
    public partial class FormRowStatistic : Form
    {
        public FormRowStatistic(string table, DataGridViewSelectedCellCollection selectedCells)
        {
            InitializeComponent();
            using (var context = new BotanicalGardenContext())
            {
                int key = int.Parse(selectedCells[0].Value.ToString());
                switch (table)
                {
                    case "Tree":
                        DataGridView.DataSource = context.Statistics.Where(s => s.TreeId == key).ToList();
                        break;
                    case "Plant":
                        DataGridView.DataSource = context.Statistics.Where(s => s.PlantId == key).ToList();
                        break;
                }
                DataGridView.Columns["Tree"].Visible = false;
                DataGridView.Columns["Plant"].Visible = false;
                DataGridView.Columns["Plant"].Visible = false;
                DataGridView.Columns["Id"].HeaderText = "№";
                DataGridView.Columns["DateTime"].HeaderText = "Дата/Время";
                DataGridView.Columns["LivingСonditions"].HeaderText = "Условия обитания";
                DataGridView.Columns["Сondition"].HeaderText = "Состояние";
                DataGridView.Columns["Population"].HeaderText = "Популяция";
                DataGridView.Columns["TreeId"].Visible = false;
                DataGridView.Columns["PlantId"].Visible = false;
                DataGridView.Refresh();
            }
        }
    }
}
