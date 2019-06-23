namespace BotanicalGarden
{
    partial class FormAddEdit
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
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TBFamily = new System.Windows.Forms.TextBox();
            this.TBRod = new System.Windows.Forms.TextBox();
            this.LabelFamily = new System.Windows.Forms.Label();
            this.LabelRod = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(123, 16);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(150, 20);
            this.TBName.TabIndex = 0;
            // 
            // TBType
            // 
            this.TBType.Location = new System.Drawing.Point(123, 42);
            this.TBType.Name = "TBType";
            this.TBType.Size = new System.Drawing.Size(150, 20);
            this.TBType.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Разновидность:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Image = global::BotanicalGarden.Properties.Resources.save;
            this.ButtonSave.Location = new System.Drawing.Point(123, 133);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(90, 26);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TBFamily
            // 
            this.TBFamily.Location = new System.Drawing.Point(123, 68);
            this.TBFamily.Name = "TBFamily";
            this.TBFamily.Size = new System.Drawing.Size(150, 20);
            this.TBFamily.TabIndex = 5;
            // 
            // TBRod
            // 
            this.TBRod.Location = new System.Drawing.Point(123, 94);
            this.TBRod.Name = "TBRod";
            this.TBRod.Size = new System.Drawing.Size(150, 20);
            this.TBRod.TabIndex = 6;
            // 
            // LabelFamily
            // 
            this.LabelFamily.AutoSize = true;
            this.LabelFamily.Location = new System.Drawing.Point(51, 71);
            this.LabelFamily.Name = "LabelFamily";
            this.LabelFamily.Size = new System.Drawing.Size(66, 13);
            this.LabelFamily.TabIndex = 7;
            this.LabelFamily.Text = "Семейство:";
            // 
            // LabelRod
            // 
            this.LabelRod.AutoSize = true;
            this.LabelRod.Location = new System.Drawing.Point(88, 97);
            this.LabelRod.Name = "LabelRod";
            this.LabelRod.Size = new System.Drawing.Size(29, 13);
            this.LabelRod.TabIndex = 8;
            this.LabelRod.Text = "Род:";
            // 
            // FormAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 173);
            this.Controls.Add(this.LabelRod);
            this.Controls.Add(this.LabelFamily);
            this.Controls.Add(this.TBRod);
            this.Controls.Add(this.TBFamily);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBType);
            this.Controls.Add(this.TBName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox TBFamily;
        private System.Windows.Forms.TextBox TBRod;
        private System.Windows.Forms.Label LabelFamily;
        private System.Windows.Forms.Label LabelRod;
    }
}