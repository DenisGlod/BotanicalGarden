using BotanicalGarden.Model;
using BotanicalGarden.Model.Entity;
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

namespace BotanicalGarden
{
    public partial class FormAddEdit : Form
    {
        private readonly FormStart fsClass;
        private readonly ActionParameters param;
        private readonly DataGridViewSelectedCellCollection selectedCells;

        public FormAddEdit(FormStart fsClass, ActionParameters param)
        {
            InitializeComponent();
            this.fsClass = fsClass;
            this.param = param;
            switch (param)
            {
                case ActionParameters.AddTree:
                    IntiPositionIfTree(true);
                    Text = "Добавить";
                    Icon = Icon.FromHandle(Properties.Resources.plus.GetHicon());
                    break;
                case ActionParameters.AddPlant:
                    IntiPositionIfTree(false);
                    Text = "Добавить";
                    Icon = Icon.FromHandle(Properties.Resources.plus.GetHicon());
                    break;
                case ActionParameters.EditTree:
                    IntiPositionIfTree(true);
                    Text = "Редактировать";
                    Icon = Icon.FromHandle(Properties.Resources.edit.GetHicon());
                    break;
                case ActionParameters.EditPlant:
                    IntiPositionIfTree(false);
                    Text = "Редактировать";
                    Icon = Icon.FromHandle(Properties.Resources.edit.GetHicon());
                    break;
            }
        }
        private void IntiPositionIfTree(bool flag)
        {
            if (flag)
            {
                TBFamily.Visible = true;
                TBRod.Visible = true;
                LabelFamily.Visible = true;
                LabelRod.Visible = true;
                Size = new Size(331, 212);
                ButtonSave.Location = new Point(123, 133);
            } else
            {
                TBFamily.Visible = false;
                TBRod.Visible = false;
                LabelFamily.Visible = false;
                LabelRod.Visible = false;
                Size = new Size(331, 168);
                ButtonSave.Location = new Point(123, 86);
            }

        }

        public FormAddEdit(FormStart fsClass, ActionParameters param, DataGridViewSelectedCellCollection selectedCells) : this(fsClass, param)
        {
            this.selectedCells = selectedCells;
            switch (param)
            {
                case ActionParameters.EditTree:
                    TBName.Text = selectedCells[1].Value.ToString();
                    TBType.Text = selectedCells[2].Value.ToString();
                    TBFamily.Text = selectedCells[3].Value.ToString();
                    TBRod.Text = selectedCells[4].Value.ToString();
                    break;
                case ActionParameters.EditPlant:
                    TBName.Text = selectedCells[1].Value.ToString();
                    TBType.Text = selectedCells[2].Value.ToString();
                    break;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var name = TBName.Text;
            var type = TBType.Text;
            var family = TBFamily.Text;
            var rod = TBRod.Text;
            using (var context = new BotanicalGardenContext())
            {
                switch (param)
                {
                    case ActionParameters.AddTree:
                        context.Trees.Add(new Tree { Name = name, View = type, Family = family, Rod = rod });
                        break;
                    case ActionParameters.AddPlant:
                        context.Plants.Add(new Plant { Name = name, Type = type });
                        break;
                    case ActionParameters.EditTree:
                        var tree = context.Trees.Find(selectedCells[0].Value);
                        tree.Name = name;
                        tree.View = type;
                        tree.Family = family;
                        tree.Rod = rod;
                        context.Entry(tree).State = EntityState.Modified;
                        break;
                    case ActionParameters.EditPlant:
                        var plant = context.Plants.Find(selectedCells[0].Value);
                        plant.Name = name;
                        plant.Type = type;
                        context.Entry(plant).State = EntityState.Modified;
                        break;
                }
                context.SaveChanges();
            }
            Hide();
            switch (param)
            {
                case ActionParameters.AddTree:
                case ActionParameters.EditTree:
                    fsClass.InitDGVTree();
                    break;
                case ActionParameters.AddPlant:
                case ActionParameters.EditPlant:
                    fsClass.InitDGVPlants();
                    break;
            }
            
        }
    }
}
