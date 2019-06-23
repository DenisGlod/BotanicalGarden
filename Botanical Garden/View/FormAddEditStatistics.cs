using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BotanicalGarden.Model;
using BotanicalGarden.Model.Entity;

namespace BotanicalGarden.View
{
    public partial class FormAddEditStatistics : Form
    {
        private readonly FormStart fsClass;
        private readonly ActionParameters param;
        private readonly DataGridViewSelectedCellCollection selectedCells;

        public FormAddEditStatistics(FormStart fsClass, ActionParameters param)
        {
            InitializeComponent();
            this.fsClass = fsClass;
            this.param = param;
            switch (param)
            {
                case ActionParameters.AddStatistics:
                    Text = "Добавить";
                    Icon = Icon.FromHandle(Properties.Resources.plus.GetHicon());
                    break;
                case ActionParameters.EditStatistics:
                    Text = "Редактировать";
                    Icon = Icon.FromHandle(Properties.Resources.edit.GetHicon());
                    break;
            }
        }

        public FormAddEditStatistics(FormStart fsClass, ActionParameters param, DataGridViewSelectedCellCollection selectedCells) : this(fsClass, param)
        {
            this.selectedCells = selectedCells;
            TBDateTime.Text = selectedCells[1].Value.ToString();
            TBLivingСonditions.Text = selectedCells[2].Value.ToString();
            TBCondition.Text = selectedCells[3].Value.ToString();
            TBPopulation.Text = selectedCells[4].Value.ToString();
            var tree = selectedCells[5].Value;
            var plant = selectedCells[7].Value;

            if (tree != null)
            {
                RBTree.Checked = true;
            }
            if (plant != null)
            {
                RBPlant.Checked = true;
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            var dateTime = TBDateTime.Text;
            var livingСonditions = TBLivingСonditions.Text;
            var condition = TBCondition.Text;
            var population = TBPopulation.Text;
            var key = TreeView.SelectedNode != null ? int.Parse(TreeView.SelectedNode.Name) : -1;
            if (dateTime.Equals("") || livingСonditions.Equals("") || condition.Equals("") || population.Equals("") || key == -1)
            {
                MessageBox.Show("Укажите все параметры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var stat = new Statistic();
            using (var context = new BotanicalGardenContext())
            {
                switch (param)
                {
                    case ActionParameters.AddStatistics:
                        stat.DateTime = Convert.ToDateTime(dateTime);
                        stat.LivingСonditions = livingСonditions;
                        stat.Сondition = condition;
                        stat.Population = int.Parse(population);
                        if (RBTree.Checked) stat.TreeId = key;
                        if (RBPlant.Checked) stat.PlantId = key;
                        context.Statistics.Add(stat);
                        break;
                    case ActionParameters.EditStatistics:
                        stat = context.Statistics.Find(selectedCells[0].Value);
                        stat.DateTime = Convert.ToDateTime(dateTime);
                        stat.LivingСonditions = livingСonditions;
                        stat.Сondition = condition;
                        stat.Population = int.Parse(population);
                        if (RBTree.Checked) { stat.TreeId = key; stat.PlantId = null; }
                        if (RBPlant.Checked) { stat.PlantId = key; stat.TreeId = null; }
                        break;
                }
                context.SaveChanges();
            }
            Hide();
            fsClass.InitDGVStatistics();
        }

        private void SelectedNode(TreeNode node)
        {
            if (node != null)
            {
                TreeView.Select();
                TreeView.SelectedNode = node;
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            using (var context = new BotanicalGardenContext())
            {
                TreeView.Nodes.Clear();
                if (RBTree.Checked)
                {
                    var listTree = context.Trees.ToList();
                    switch (param)
                    {
                        case ActionParameters.AddStatistics:
                            listTree.ForEach(item => { TreeView.Nodes.Add(item.Id.ToString(), item.Id + " | " + item.Name + " | " + item.View); });
                            break;
                        case ActionParameters.EditStatistics:
                            var tree = selectedCells[5].Value;
                            listTree.ForEach(item =>
                            {
                                var tn = TreeView.Nodes.Add(item.Id.ToString(), item.Id + " | " + item.Name + " | " + item.View);
                                if (tree != null && item.Id == (int)tree)
                                {
                                    SelectedNode(tn);
                                }
                            });
                            break;
                    }
                }
                if (RBPlant.Checked)
                {
                    var listPlants = context.Plants.ToList();
                    switch (param)
                    {
                        case ActionParameters.AddStatistics:
                            listPlants.ForEach(item => { TreeView.Nodes.Add(item.Id.ToString(), item.Id + " | " + item.Name + " | " + item.Type); });
                            break;
                        case ActionParameters.EditStatistics:
                            var plants = selectedCells[7].Value;
                            listPlants.ForEach(item =>
                            {
                                var tn = TreeView.Nodes.Add(item.Id.ToString(), item.Id + " | " + item.Name + " | " + item.Type);
                                if (plants != null && RBPlant.Checked && item.Id == (int)plants)
                                {
                                    SelectedNode(tn);
                                }
                            });
                            break;
                    }
                }
            }
        }
    }
}
