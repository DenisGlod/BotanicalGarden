namespace BotanicalGarden
{
    partial class FormStart
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.panel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TPTree = new System.Windows.Forms.TabPage();
            this.DGVTree = new System.Windows.Forms.DataGridView();
            this.TPPlants = new System.Windows.Forms.TabPage();
            this.DGVPlant = new System.Windows.Forms.DataGridView();
            this.TBStatistics = new System.Windows.Forms.TabPage();
            this.DGVStatistics = new System.Windows.Forms.DataGridView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.panel.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.TPTree.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTree)).BeginInit();
            this.TPPlants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPlant)).BeginInit();
            this.TBStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStatistics)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.button3);
            this.panel.Controls.Add(this.button2);
            this.panel.Controls.Add(this.button1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 410);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(800, 40);
            this.panel.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Image = global::BotanicalGarden.Properties.Resources.del;
            this.button3.Location = new System.Drawing.Point(607, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Image = global::BotanicalGarden.Properties.Resources.edit;
            this.button2.Location = new System.Drawing.Point(337, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Редактировать";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BEdit_Click);
            // 
            // button1
            // 
            this.button1.Image = global::BotanicalGarden.Properties.Resources.plus;
            this.button1.Location = new System.Drawing.Point(86, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TPTree);
            this.TabControl.Controls.Add(this.TPPlants);
            this.TabControl.Controls.Add(this.TBStatistics);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ImageList = this.imageList;
            this.TabControl.Location = new System.Drawing.Point(0, 24);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(800, 386);
            this.TabControl.TabIndex = 2;
            this.TabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
            // 
            // TPTree
            // 
            this.TPTree.Controls.Add(this.DGVTree);
            this.TPTree.ImageIndex = 0;
            this.TPTree.Location = new System.Drawing.Point(4, 23);
            this.TPTree.Name = "TPTree";
            this.TPTree.Padding = new System.Windows.Forms.Padding(3);
            this.TPTree.Size = new System.Drawing.Size(792, 359);
            this.TPTree.TabIndex = 0;
            this.TPTree.Text = "Деревья";
            this.TPTree.UseVisualStyleBackColor = true;
            // 
            // DGVTree
            // 
            this.DGVTree.AllowUserToAddRows = false;
            this.DGVTree.AllowUserToDeleteRows = false;
            this.DGVTree.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVTree.Location = new System.Drawing.Point(3, 3);
            this.DGVTree.Name = "DGVTree";
            this.DGVTree.ReadOnly = true;
            this.DGVTree.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTree.Size = new System.Drawing.Size(786, 353);
            this.DGVTree.TabIndex = 0;
            this.DGVTree.DoubleClick += new System.EventHandler(this.DGView_DoubleClick);
            // 
            // TPPlants
            // 
            this.TPPlants.Controls.Add(this.DGVPlant);
            this.TPPlants.ImageIndex = 2;
            this.TPPlants.Location = new System.Drawing.Point(4, 23);
            this.TPPlants.Name = "TPPlants";
            this.TPPlants.Padding = new System.Windows.Forms.Padding(3);
            this.TPPlants.Size = new System.Drawing.Size(792, 359);
            this.TPPlants.TabIndex = 1;
            this.TPPlants.Text = "Растения";
            this.TPPlants.UseVisualStyleBackColor = true;
            // 
            // DGVPlant
            // 
            this.DGVPlant.AllowUserToAddRows = false;
            this.DGVPlant.AllowUserToDeleteRows = false;
            this.DGVPlant.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVPlant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPlant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPlant.Location = new System.Drawing.Point(3, 3);
            this.DGVPlant.Name = "DGVPlant";
            this.DGVPlant.ReadOnly = true;
            this.DGVPlant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVPlant.Size = new System.Drawing.Size(786, 353);
            this.DGVPlant.TabIndex = 0;
            this.DGVPlant.DoubleClick += new System.EventHandler(this.DGView_DoubleClick);
            // 
            // TBStatistics
            // 
            this.TBStatistics.Controls.Add(this.DGVStatistics);
            this.TBStatistics.ImageIndex = 1;
            this.TBStatistics.Location = new System.Drawing.Point(4, 23);
            this.TBStatistics.Name = "TBStatistics";
            this.TBStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.TBStatistics.Size = new System.Drawing.Size(792, 359);
            this.TBStatistics.TabIndex = 2;
            this.TBStatistics.Text = "Статистика";
            this.TBStatistics.UseVisualStyleBackColor = true;
            // 
            // DGVStatistics
            // 
            this.DGVStatistics.AllowUserToAddRows = false;
            this.DGVStatistics.AllowUserToDeleteRows = false;
            this.DGVStatistics.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVStatistics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVStatistics.Location = new System.Drawing.Point(3, 3);
            this.DGVStatistics.Name = "DGVStatistics";
            this.DGVStatistics.ReadOnly = true;
            this.DGVStatistics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVStatistics.Size = new System.Drawing.Size(786, 353);
            this.DGVStatistics.TabIndex = 0;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "plant.png");
            this.imageList.Images.SetKeyName(1, "statistics.png");
            this.imageList.Images.SetKeyName(2, "pl.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemExcel,
            this.MenuItemAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemExcel
            // 
            this.MenuItemExcel.Image = global::BotanicalGarden.Properties.Resources.excel;
            this.MenuItemExcel.Name = "MenuItemExcel";
            this.MenuItemExcel.Size = new System.Drawing.Size(162, 20);
            this.MenuItemExcel.Text = "Экспортировать в Excel";
            this.MenuItemExcel.Click += new System.EventHandler(this.MenuItemExcel_Click);
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Image = global::BotanicalGarden.Properties.Resources.help;
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(110, 20);
            this.MenuItemAbout.Text = "О программе";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ботанический сад";
            this.panel.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.TPTree.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTree)).EndInit();
            this.TPPlants.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPlant)).EndInit();
            this.TBStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVStatistics)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TPTree;
        private System.Windows.Forms.TabPage TPPlants;
        private System.Windows.Forms.DataGridView DGVTree;
        private System.Windows.Forms.DataGridView DGVPlant;
        private System.Windows.Forms.TabPage TBStatistics;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExcel;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.DataGridView DGVStatistics;
    }
}

