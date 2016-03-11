namespace PlanettePalette
{
    partial class PalColor
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClassLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SetCol = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.TextBox();
            this.A = new System.Windows.Forms.TextBox();
            this.G = new System.Windows.Forms.TextBox();
            this.R = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Location = new System.Drawing.Point(3, 10);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(55, 13);
            this.ClassLabel.TabIndex = 1;
            this.ClassLabel.Text = "colorClass";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "(";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ",";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = ",";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = ",";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(422, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = ")";
            // 
            // SetCol
            // 
            this.SetCol.Location = new System.Drawing.Point(439, 5);
            this.SetCol.Name = "SetCol";
            this.SetCol.Size = new System.Drawing.Size(75, 23);
            this.SetCol.TabIndex = 3;
            this.SetCol.Text = "Set Color";
            this.SetCol.UseVisualStyleBackColor = true;
            this.SetCol.Click += new System.EventHandler(this.SetCol_Click);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(260, 7);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(67, 20);
            this.B.TabIndex = 4;
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(349, 7);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(67, 20);
            this.A.TabIndex = 4;
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(171, 7);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(67, 20);
            this.G.TabIndex = 4;
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(82, 7);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(67, 20);
            this.R.TabIndex = 4;
            // 
            // PalColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.A);
            this.Controls.Add(this.R);
            this.Controls.Add(this.G);
            this.Controls.Add(this.B);
            this.Controls.Add(this.SetCol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClassLabel);
            this.Name = "PalColor";
            this.Size = new System.Drawing.Size(518, 32);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SetCol;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.TextBox A;
        private System.Windows.Forms.TextBox G;
        private System.Windows.Forms.TextBox R;
    }
}
