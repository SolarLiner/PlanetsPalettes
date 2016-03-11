namespace PlanettePalette
{
    partial class ImportCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportCreate));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PalName = new System.Windows.Forms.TextBox();
            this.Class = new System.Windows.Forms.ComboBox();
            this.RepColor = new System.Windows.Forms.Panel();
            this.AddColor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.CancelTD = new Ookii.Dialogs.TaskDialog(this.components);
            this.taskDialogButton1 = new Ookii.Dialogs.TaskDialogButton(this.components);
            this.taskDialogButton2 = new Ookii.Dialogs.TaskDialogButton(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Import Palette";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Simply paste the code(s) in the box below:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(543, 195);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Create Palette";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(428, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Specify a name, a class and representative color, then add all needed values.\r\nTi" +
    "ck the checkboxes where you want to add colors. Unchecked colors will not be add" +
    "ed.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Type:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Representative Color:";
            // 
            // PalName
            // 
            this.PalName.Location = new System.Drawing.Point(23, 379);
            this.PalName.Name = "PalName";
            this.PalName.Size = new System.Drawing.Size(222, 20);
            this.PalName.TabIndex = 7;
            // 
            // Class
            // 
            this.Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Class.FormattingEnabled = true;
            this.Class.Location = new System.Drawing.Point(265, 379);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(132, 21);
            this.Class.TabIndex = 8;
            // 
            // RepColor
            // 
            this.RepColor.BackColor = System.Drawing.Color.Black;
            this.RepColor.Location = new System.Drawing.Point(412, 379);
            this.RepColor.Name = "RepColor";
            this.RepColor.Size = new System.Drawing.Size(63, 19);
            this.RepColor.TabIndex = 9;
            this.RepColor.Click += new System.EventHandler(this.RepColor_Click);
            // 
            // AddColor
            // 
            this.AddColor.Location = new System.Drawing.Point(24, 417);
            this.AddColor.Name = "AddColor";
            this.AddColor.Size = new System.Drawing.Size(75, 23);
            this.AddColor.TabIndex = 11;
            this.AddColor.Text = "Add Color";
            this.AddColor.UseVisualStyleBackColor = true;
            this.AddColor.Click += new System.EventHandler(this.AddColor_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddColor);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RepColor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Class);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.PalName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 616);
            this.panel1.TabIndex = 12;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(486, 622);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 23);
            this.OK.TabIndex = 13;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(405, 622);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 627);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Tip: You can import AND create palettes at the same time.";
            // 
            // CancelTD
            // 
            this.CancelTD.Buttons.Add(this.taskDialogButton1);
            this.CancelTD.Buttons.Add(this.taskDialogButton2);
            this.CancelTD.Content = "You\'re about to cancel the import/creation of palettes. Really want to quit?";
            this.CancelTD.MainInstruction = "Really want to cancel?";
            this.CancelTD.WindowTitle = "Really abandon?";
            // 
            // taskDialogButton1
            // 
            this.taskDialogButton1.ButtonType = Ookii.Dialogs.ButtonType.Yes;
            this.taskDialogButton1.Default = true;
            this.taskDialogButton1.Text = "Yes, cancel that!";
            // 
            // taskDialogButton2
            // 
            this.taskDialogButton2.ButtonType = Ookii.Dialogs.ButtonType.No;
            this.taskDialogButton2.Text = "Nope, wanna finish this!";
            // 
            // ImportCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 652);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImportCreate";
            this.Text = "Import/Create Palettes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PalName;
        private System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.Panel RepColor;
        private System.Windows.Forms.Button AddColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label8;
        private Ookii.Dialogs.TaskDialog CancelTD;
        private Ookii.Dialogs.TaskDialogButton taskDialogButton1;
        private Ookii.Dialogs.TaskDialogButton taskDialogButton2;
    }
}