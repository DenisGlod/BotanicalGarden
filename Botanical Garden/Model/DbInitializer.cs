using BotanicalGarden.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotanicalGarden.Model
{
    class BotanicalGardenInitializer : DropCreateDatabaseIfModelChanges<BotanicalGardenContext>
    {
        protected override void Seed(BotanicalGardenContext context)
        {
            var tree1 = new Tree { Name = "Яблоня", View = "Плодовое дерево", Family = "Розовые", Rod = "Яблоня" };
            var tree2 = new Tree { Name = "Груша", View = "Плодовое дерево", Family = "Розовые", Rod = "Груша" };
            var tree3 = new Tree { Name = "Ель", View = "Хвойное дерево", Family = "Сосновые", Rod = "Ель" };
            var plant1 = new Plant { Name = "Феоцерос гладкий", Type = "Мохообразные" };
            var plant2 = new Plant { Name = "Полия поникшая", Type = "Мохообразные" };
            var plant3 = new Plant { Name = "Маршанция многообразная", Type = "Мохообразные" };
            context.Trees.Add(tree1);
            context.Trees.Add(tree2);
            context.Trees.Add(tree3);
            context.Plants.Add(plant1);
            context.Plants.Add(plant2);
            context.Plants.Add(plant3);
            context.SaveChanges();
            var stat1 = new Statistic { DateTime = DateTime.UtcNow, Population = 10, Сondition = "Среднее", LivingСonditions = "Нормальная", TreeId = 1, Tree = tree1 };
            var stat2 = new Statistic { DateTime = DateTime.UtcNow, Population = 9, Сondition = "Хорошее", LivingСonditions = "Нормальная", PlantId = 1, Plant = plant1 };
            context.Statistics.Add(stat1);
            context.Statistics.Add(stat2);
            context.SaveChanges();
        }
    }
}
