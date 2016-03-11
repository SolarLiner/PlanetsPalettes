namespace PlanettePalette
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlanetPicBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TerraTab = new System.Windows.Forms.Button();
            this.DesertTab = new System.Windows.Forms.Button();
            this.OceaniaTab = new System.Windows.Forms.Button();
            this.SelenaTab = new System.Windows.Forms.Button();
            this.IceWldTab = new System.Windows.Forms.Button();
            this.TitanTab = new System.Windows.Forms.Button();
            this.AsteroidTab = new System.Windows.Forms.Button();
            this.IceGntTab = new System.Windows.Forms.Button();
            this.GasGntTab = new System.Windows.Forms.Button();
            this.BrownDwarfTab = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.PalettesData = new System.Windows.Forms.ListView();
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColorCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WeightCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PalettesData_ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportTD = new Ookii.Dialogs.TaskDialog(this.components);
            this.OKbt = new Ookii.Dialogs.TaskDialogButton(this.components);
            this.Import = new System.Windows.Forms.Button();
            this.ErrorState = new System.Windows.Forms.Label();
            this.ErrorTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PlanetPicBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.PalettesData_ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlanetPicBox
            // 
            this.PlanetPicBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PlanetPicBox.Location = new System.Drawing.Point(523, 12);
            this.PlanetPicBox.Name = "PlanetPicBox";
            this.PlanetPicBox.Size = new System.Drawing.Size(250, 250);
            this.PlanetPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlanetPicBox.TabIndex = 0;
            this.PlanetPicBox.TabStop = false;
            this.PlanetPicBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Planet Palettes editor!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 91);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(18, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 78);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tab Control";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TerraTab);
            this.flowLayoutPanel1.Controls.Add(this.DesertTab);
            this.flowLayoutPanel1.Controls.Add(this.OceaniaTab);
            this.flowLayoutPanel1.Controls.Add(this.SelenaTab);
            this.flowLayoutPanel1.Controls.Add(this.IceWldTab);
            this.flowLayoutPanel1.Controls.Add(this.TitanTab);
            this.flowLayoutPanel1.Controls.Add(this.AsteroidTab);
            this.flowLayoutPanel1.Controls.Add(this.IceGntTab);
            this.flowLayoutPanel1.Controls.Add(this.GasGntTab);
            this.flowLayoutPanel1.Controls.Add(this.BrownDwarfTab);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(492, 59);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // TerraTab
            // 
            this.TerraTab.Location = new System.Drawing.Point(3, 3);
            this.TerraTab.Name = "TerraTab";
            this.TerraTab.Size = new System.Drawing.Size(92, 23);
            this.TerraTab.TabIndex = 0;
            this.TerraTab.Text = "Terra";
            this.TerraTab.UseVisualStyleBackColor = true;
            this.TerraTab.Click += new System.EventHandler(this.TerraTab_Click);
            // 
            // DesertTab
            // 
            this.DesertTab.Location = new System.Drawing.Point(101, 3);
            this.DesertTab.Name = "DesertTab";
            this.DesertTab.Size = new System.Drawing.Size(92, 23);
            this.DesertTab.TabIndex = 1;
            this.DesertTab.Text = "Desert";
            this.DesertTab.UseVisualStyleBackColor = true;
            this.DesertTab.Click += new System.EventHandler(this.DesertTab_Click);
            // 
            // OceaniaTab
            // 
            this.OceaniaTab.Location = new System.Drawing.Point(199, 3);
            this.OceaniaTab.Name = "OceaniaTab";
            this.OceaniaTab.Size = new System.Drawing.Size(92, 23);
            this.OceaniaTab.TabIndex = 2;
            this.OceaniaTab.Text = "Oceania";
            this.OceaniaTab.UseVisualStyleBackColor = true;
            this.OceaniaTab.Click += new System.EventHandler(this.OceaniaTab_Click);
            // 
            // SelenaTab
            // 
            this.SelenaTab.Location = new System.Drawing.Point(297, 3);
            this.SelenaTab.Name = "SelenaTab";
            this.SelenaTab.Size = new System.Drawing.Size(92, 23);
            this.SelenaTab.TabIndex = 3;
            this.SelenaTab.Text = "Selena";
            this.SelenaTab.UseVisualStyleBackColor = true;
            this.SelenaTab.Click += new System.EventHandler(this.SelenaTab_Click);
            // 
            // IceWldTab
            // 
            this.IceWldTab.Location = new System.Drawing.Point(395, 3);
            this.IceWldTab.Name = "IceWldTab";
            this.IceWldTab.Size = new System.Drawing.Size(92, 23);
            this.IceWldTab.TabIndex = 4;
            this.IceWldTab.Text = "Ice World";
            this.IceWldTab.UseVisualStyleBackColor = true;
            this.IceWldTab.Click += new System.EventHandler(this.IceWldTab_Click);
            // 
            // TitanTab
            // 
            this.TitanTab.Location = new System.Drawing.Point(3, 32);
            this.TitanTab.Name = "TitanTab";
            this.TitanTab.Size = new System.Drawing.Size(92, 23);
            this.TitanTab.TabIndex = 5;
            this.TitanTab.Text = "Titan";
            this.TitanTab.UseVisualStyleBackColor = true;
            this.TitanTab.Click += new System.EventHandler(this.TitanTab_Click);
            // 
            // AsteroidTab
            // 
            this.AsteroidTab.Location = new System.Drawing.Point(101, 32);
            this.AsteroidTab.Name = "AsteroidTab";
            this.AsteroidTab.Size = new System.Drawing.Size(92, 23);
            this.AsteroidTab.TabIndex = 6;
            this.AsteroidTab.Text = "Asteroid";
            this.AsteroidTab.UseVisualStyleBackColor = true;
            this.AsteroidTab.Click += new System.EventHandler(this.AsteroidTab_Click);
            // 
            // IceGntTab
            // 
            this.IceGntTab.Location = new System.Drawing.Point(199, 32);
            this.IceGntTab.Name = "IceGntTab";
            this.IceGntTab.Size = new System.Drawing.Size(92, 23);
            this.IceGntTab.TabIndex = 7;
            this.IceGntTab.Text = "Ice Giants";
            this.IceGntTab.UseVisualStyleBackColor = true;
            this.IceGntTab.Click += new System.EventHandler(this.IceGntTab_Click);
            // 
            // GasGntTab
            // 
            this.GasGntTab.Location = new System.Drawing.Point(297, 32);
            this.GasGntTab.Name = "GasGntTab";
            this.GasGntTab.Size = new System.Drawing.Size(92, 23);
            this.GasGntTab.TabIndex = 8;
            this.GasGntTab.Text = "Gas Giant";
            this.GasGntTab.UseVisualStyleBackColor = true;
            this.GasGntTab.Click += new System.EventHandler(this.GasGntTab_Click);
            // 
            // BrownDwarfTab
            // 
            this.BrownDwarfTab.Location = new System.Drawing.Point(395, 32);
            this.BrownDwarfTab.Name = "BrownDwarfTab";
            this.BrownDwarfTab.Size = new System.Drawing.Size(92, 23);
            this.BrownDwarfTab.TabIndex = 9;
            this.BrownDwarfTab.Text = "Brown Dwarf";
            this.BrownDwarfTab.UseVisualStyleBackColor = true;
            this.BrownDwarfTab.Click += new System.EventHandler(this.BrownDwarfTab_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(416, 225);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(92, 23);
            this.RefreshBtn.TabIndex = 4;
            this.RefreshBtn.Text = "Refresh palettes";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(122, 225);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(92, 23);
            this.Save.TabIndex = 4;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(318, 225);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(92, 23);
            this.Export.TabIndex = 4;
            this.Export.Text = "Export ...";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(24, 225);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(92, 23);
            this.Read.TabIndex = 4;
            this.Read.Text = "Read";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Import_Click);
            // 
            // PalettesData
            // 
            this.PalettesData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PalettesData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCol,
            this.ColorCol,
            this.WeightCol});
            this.PalettesData.ContextMenuStrip = this.PalettesData_ContextMenu;
            this.PalettesData.FullRowSelect = true;
            this.PalettesData.Location = new System.Drawing.Point(18, 268);
            this.PalettesData.Name = "PalettesData";
            this.PalettesData.Size = new System.Drawing.Size(755, 337);
            this.PalettesData.TabIndex = 5;
            this.PalettesData.UseCompatibleStateImageBehavior = false;
            this.PalettesData.View = System.Windows.Forms.View.Details;
            // 
            // NameCol
            // 
            this.NameCol.Text = "Name";
            this.NameCol.Width = 407;
            // 
            // ColorCol
            // 
            this.ColorCol.Text = "Color";
            this.ColorCol.Width = 203;
            // 
            // WeightCol
            // 
            this.WeightCol.Text = "Weight";
            this.WeightCol.Width = 141;
            // 
            // PalettesData_ContextMenu
            // 
            this.PalettesData_ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifyToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.changeColorToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.PalettesData_ContextMenu.Name = "PalettesData_ContextMenu";
            this.PalettesData_ContextMenu.Size = new System.Drawing.Size(148, 120);
            this.PalettesData_ContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.PalettesData_ContextMenu_Opening);
            // 
            // modifyToolStripMenuItem
            // 
            this.modifyToolStripMenuItem.Name = "modifyToolStripMenuItem";
            this.modifyToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.modifyToolStripMenuItem.Text = "Modify ...";
            this.modifyToolStripMenuItem.Click += new System.EventHandler(this.modifyToolStripMenuItem_Click);
            // 
            // renameToolStripMenuItem
            // 
            this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
            this.renameToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.renameToolStripMenuItem.Text = "Rename";
            this.renameToolStripMenuItem.Click += new System.EventHandler(this.renameToolStripMenuItem_Click);
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.changeColorToolStripMenuItem.Text = "Change Color";
            this.changeColorToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exportToolStripMenuItem.Text = "Export ...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.Export_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(144, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // ExportTD
            // 
            this.ExportTD.Buttons.Add(this.OKbt);
            this.ExportTD.CenterParent = true;
            this.ExportTD.Content = "You have to select in the list the palettes you want to export.";
            this.ExportTD.Footer = "You can export several classes by exporting class by class then pasting everythin" +
    "g to one place.";
            this.ExportTD.FooterIcon = Ookii.Dialogs.TaskDialogIcon.Information;
            this.ExportTD.MainInstruction = "Export palettes";
            this.ExportTD.WindowTitle = "Export function";
            // 
            // OKbt
            // 
            this.OKbt.ButtonType = Ookii.Dialogs.ButtonType.Ok;
            this.OKbt.Text = "OK";
            // 
            // Import
            // 
            this.Import.Location = new System.Drawing.Point(220, 225);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(92, 23);
            this.Import.TabIndex = 4;
            this.Import.Text = "Import/Create";
            this.Import.UseVisualStyleBackColor = true;
            this.Import.Click += new System.EventHandler(this.Import_Click_1);
            // 
            // ErrorState
            // 
            this.ErrorState.AutoSize = true;
            this.ErrorState.Location = new System.Drawing.Point(12, 617);
            this.ErrorState.Name = "ErrorState";
            this.ErrorState.Size = new System.Drawing.Size(0, 13);
            this.ErrorState.TabIndex = 6;
            // 
            // ErrorTimer
            // 
            this.ErrorTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 639);
            this.Controls.Add(this.ErrorState);
            this.Controls.Add(this.PalettesData);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Import);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlanetPicBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(801, 2048);
            this.MinimumSize = new System.Drawing.Size(801, 655);
            this.Name = "Form1";
            this.Text = "Planets Palettes                             By SolarLiner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlanetPicBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.PalettesData_ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PlanetPicBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button TerraTab;
        private System.Windows.Forms.Button DesertTab;
        private System.Windows.Forms.Button OceaniaTab;
        private System.Windows.Forms.Button SelenaTab;
        private System.Windows.Forms.Button IceWldTab;
        private System.Windows.Forms.Button TitanTab;
        private System.Windows.Forms.Button AsteroidTab;
        private System.Windows.Forms.Button IceGntTab;
        private System.Windows.Forms.Button GasGntTab;
        private System.Windows.Forms.Button BrownDwarfTab;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.ListView PalettesData;
        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.ColumnHeader ColorCol;
        private System.Windows.Forms.ColumnHeader WeightCol;
        private Ookii.Dialogs.TaskDialog ExportTD;
        private Ookii.Dialogs.TaskDialogButton OKbt;
        private System.Windows.Forms.Button Import;
        private System.Windows.Forms.ContextMenuStrip PalettesData_ContextMenu;
        private System.Windows.Forms.ToolStripMenuItem modifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        internal System.Windows.Forms.Label ErrorState;
        internal System.Windows.Forms.Timer ErrorTimer;
    }
}

