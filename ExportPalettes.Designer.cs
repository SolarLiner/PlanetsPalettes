namespace PlanettePalette
{
    partial class ExportPalettes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportPalettes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.FileExport = new System.Windows.Forms.RadioButton();
            this.CopyPastePlain = new System.Windows.Forms.RadioButton();
            this.CopyPasteForum = new System.Windows.Forms.RadioButton();
            this.ExportTD = new Ookii.Dialogs.TaskDialog(this.components);
            this.OKbt = new Ookii.Dialogs.TaskDialogButton(this.components);
            this.ShowCopiedbt = new Ookii.Dialogs.TaskDialogButton(this.components);
            this.CopyPastForumNoColors = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exporting palettes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(629, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Here you can set/change names and colors of palettes before exporting. You can ch" +
    "oose between sharing via copy/paste for forum\r\nor export into files.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Representative color";
            // 
            // cd
            // 
            this.cd.AnyColor = true;
            this.cd.FullOpen = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 440);
            this.panel1.TabIndex = 5;
            // 
            // OK
            // 
            this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OK.Location = new System.Drawing.Point(623, 450);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 6;
            this.OK.Text = "Export";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.Location = new System.Drawing.Point(542, 450);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // FileExport
            // 
            this.FileExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FileExport.AutoSize = true;
            this.FileExport.Enabled = false;
            this.FileExport.Location = new System.Drawing.Point(13, 453);
            this.FileExport.Name = "FileExport";
            this.FileExport.Size = new System.Drawing.Size(74, 17);
            this.FileExport.TabIndex = 8;
            this.FileExport.Text = "File Export";
            this.FileExport.UseVisualStyleBackColor = true;
            // 
            // CopyPastePlain
            // 
            this.CopyPastePlain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CopyPastePlain.AutoSize = true;
            this.CopyPastePlain.Location = new System.Drawing.Point(93, 453);
            this.CopyPastePlain.Name = "CopyPastePlain";
            this.CopyPastePlain.Size = new System.Drawing.Size(131, 17);
            this.CopyPastePlain.TabIndex = 8;
            this.CopyPastePlain.Text = "Copy/Paste Plain Text";
            this.CopyPastePlain.UseVisualStyleBackColor = true;
            // 
            // CopyPasteForum
            // 
            this.CopyPasteForum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CopyPasteForum.AutoSize = true;
            this.CopyPasteForum.Checked = true;
            this.CopyPasteForum.Location = new System.Drawing.Point(230, 453);
            this.CopyPasteForum.Name = "CopyPasteForum";
            this.CopyPasteForum.Size = new System.Drawing.Size(113, 17);
            this.CopyPasteForum.TabIndex = 8;
            this.CopyPasteForum.TabStop = true;
            this.CopyPasteForum.Text = "Copy/Paste Forum";
            this.CopyPasteForum.UseVisualStyleBackColor = true;
            // 
            // ExportTD
            // 
            this.ExportTD.Buttons.Add(this.OKbt);
            this.ExportTD.Buttons.Add(this.ShowCopiedbt);
            this.ExportTD.ButtonStyle = Ookii.Dialogs.TaskDialogButtonStyle.CommandLinks;
            this.ExportTD.CenterParent = true;
            this.ExportTD.FooterIcon = Ookii.Dialogs.TaskDialogIcon.Information;
            this.ExportTD.MainIcon = Ookii.Dialogs.TaskDialogIcon.Information;
            this.ExportTD.MainInstruction = "Export successful!";
            this.ExportTD.WindowTitle = "Export successful!";
            this.ExportTD.ButtonClicked += new System.EventHandler<Ookii.Dialogs.TaskDialogItemClickedEventArgs>(this.ExportTD_ButtonClicked);
            // 
            // OKbt
            // 
            this.OKbt.ButtonType = Ookii.Dialogs.ButtonType.Ok;
            this.OKbt.Default = true;
            this.OKbt.Text = "OK";
            // 
            // ShowCopiedbt
            // 
            this.ShowCopiedbt.Text = "See what have been coiped";
            // 
            // CopyPastForumNoColors
            // 
            this.CopyPastForumNoColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CopyPastForumNoColors.AutoSize = true;
            this.CopyPastForumNoColors.Location = new System.Drawing.Point(349, 453);
            this.CopyPastForumNoColors.Name = "CopyPastForumNoColors";
            this.CopyPastForumNoColors.Size = new System.Drawing.Size(165, 17);
            this.CopyPastForumNoColors.TabIndex = 8;
            this.CopyPastForumNoColors.Text = "Copy/Paste Forum (no colors)";
            this.CopyPastForumNoColors.UseVisualStyleBackColor = true;
            // 
            // ExportPalettes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(710, 482);
            this.Controls.Add(this.CopyPastForumNoColors);
            this.Controls.Add(this.CopyPasteForum);
            this.Controls.Add(this.CopyPastePlain);
            this.Controls.Add(this.FileExport);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExportPalettes";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Palettes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog cd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.RadioButton FileExport;
        private System.Windows.Forms.RadioButton CopyPastePlain;
        private System.Windows.Forms.RadioButton CopyPasteForum;
        private Ookii.Dialogs.TaskDialog ExportTD;
        private Ookii.Dialogs.TaskDialogButton OKbt;
        private Ookii.Dialogs.TaskDialogButton ShowCopiedbt;
        private System.Windows.Forms.RadioButton CopyPastForumNoColors;
    }
}