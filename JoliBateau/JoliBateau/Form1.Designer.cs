namespace JoliBateau
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
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.radioButtonCasA = new System.Windows.Forms.RadioButton();
            this.radioButtonCasB = new System.Windows.Forms.RadioButton();
            this.radioButtonCasC = new System.Windows.Forms.RadioButton();
            this.labelTreeview = new System.Windows.Forms.Label();
            this.listeSolution = new System.Windows.Forms.ListBox();
            this.labelSolution = new System.Windows.Forms.Label();
            this.labelCountOpen = new System.Windows.Forms.Label();
            this.labelCountClosed = new System.Windows.Forms.Label();
            this.tempsSolution = new System.Windows.Forms.Label();
            this.nbNoeudsSolution = new System.Windows.Forms.Label();
            this.labelStopwatch = new System.Windows.Forms.Label();
            this.groupCas = new System.Windows.Forms.GroupBox();
            this.groupBoxPavage = new System.Windows.Forms.GroupBox();
            this.radioButtonPavage3 = new System.Windows.Forms.RadioButton();
            this.comboTailleCarre = new System.Windows.Forms.ComboBox();
            this.radioButtonPavage2 = new System.Windows.Forms.RadioButton();
            this.radioButtonPavage1 = new System.Windows.Forms.RadioButton();
            this.radioButtonPavage0 = new System.Windows.Forms.RadioButton();
            this.textBoxP1X = new System.Windows.Forms.TextBox();
            this.textBoxP1Y = new System.Windows.Forms.TextBox();
            this.textBoxPfX = new System.Windows.Forms.TextBox();
            this.textBoxPfY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();

            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupCas.SuspendLayout();
            this.groupBoxPavage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();

            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Recherche A*";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(2291, 458);
            this.treeView1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(436, 717);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 

            // radioButtonCasA
            // 
            this.radioButtonCasA.AutoSize = true;
            this.radioButtonCasA.Checked = true;
            this.radioButtonCasA.Location = new System.Drawing.Point(15, 19);
            this.radioButtonCasA.Name = "radioButtonCasA";
            this.radioButtonCasA.Size = new System.Drawing.Size(31, 17);
            this.radioButtonCasA.TabIndex = 4;
            this.radioButtonCasA.TabStop = true;
            this.radioButtonCasA.Text = "a";
            this.radioButtonCasA.UseVisualStyleBackColor = true;
            // 
            // radioButtonCasB
            // 
            this.radioButtonCasB.AutoSize = true;
            this.radioButtonCasB.Location = new System.Drawing.Point(15, 51);
            this.radioButtonCasB.Name = "radioButtonCasB";
            this.radioButtonCasB.Size = new System.Drawing.Size(31, 17);
            this.radioButtonCasB.TabIndex = 5;
            this.radioButtonCasB.Text = "b";
            this.radioButtonCasB.UseVisualStyleBackColor = true;
            // 
            // radioButtonCasC
            // 
            this.radioButtonCasC.AutoSize = true;
            this.radioButtonCasC.Location = new System.Drawing.Point(15, 84);
            this.radioButtonCasC.Name = "radioButtonCasC";
            this.radioButtonCasC.Size = new System.Drawing.Size(31, 17);
            this.radioButtonCasC.TabIndex = 6;
            this.radioButtonCasC.Text = "c";
            this.radioButtonCasC.UseVisualStyleBackColor = true;

            // 
            // labelTreeview
            // 
            this.labelTreeview.AutoSize = true;
            this.labelTreeview.Location = new System.Drawing.Point(2325, 379);
            this.labelTreeview.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelTreeview.Name = "labelTreeview";
            this.labelTreeview.Size = new System.Drawing.Size(364, 32);
            this.labelTreeview.TabIndex = 7;
            this.labelTreeview.Text = "Arborescence des solutions";
            // 
            // listeSolution
            // 
            this.listeSolution.FormattingEnabled = true;
            this.listeSolution.ItemHeight = 31;
            this.listeSolution.Location = new System.Drawing.Point(1896, 458);
            this.listeSolution.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listeSolution.Name = "listeSolution";
            this.listeSolution.Size = new System.Drawing.Size(343, 717);
            this.listeSolution.TabIndex = 8;
            // 
            // labelSolution
            // 
            this.labelSolution.AutoSize = true;

            this.labelSolution.Location = new System.Drawing.Point(221, 789);
            this.labelSolution.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);

            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(0, 32);
            this.labelSolution.TabIndex = 9;
            // 
            // labelCountOpen
            // 
            this.labelCountOpen.AutoSize = true;
            this.labelCountOpen.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;

            this.labelCountOpen.Location = new System.Drawing.Point(800, 997);
            this.labelCountOpen.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);

            this.labelCountOpen.Name = "labelCountOpen";
            this.labelCountOpen.Size = new System.Drawing.Size(0, 32);
            this.labelCountOpen.TabIndex = 10;
            // 
            // labelCountClosed
            // 
            this.labelCountClosed.AutoSize = true;

            this.labelCountClosed.Location = new System.Drawing.Point(800, 1066);
            this.labelCountClosed.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);

            this.labelCountClosed.Name = "labelCountClosed";
            this.labelCountClosed.Size = new System.Drawing.Size(0, 32);
            this.labelCountClosed.TabIndex = 11;
            // 
            // tempsSolution
            // 
            this.tempsSolution.AutoSize = true;

            this.tempsSolution.Location = new System.Drawing.Point(800, 882);
            this.tempsSolution.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);

            this.tempsSolution.Name = "tempsSolution";
            this.tempsSolution.Size = new System.Drawing.Size(0, 32);
            this.tempsSolution.TabIndex = 12;
            // 
            // nbNoeudsSolution
            // 
            this.nbNoeudsSolution.AutoSize = true;

            this.nbNoeudsSolution.Location = new System.Drawing.Point(800, 930);
            this.nbNoeudsSolution.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);

            this.nbNoeudsSolution.Name = "nbNoeudsSolution";
            this.nbNoeudsSolution.Size = new System.Drawing.Size(0, 32);
            this.nbNoeudsSolution.TabIndex = 13;
            // 
            // labelStopwatch
            // 
            this.labelStopwatch.AutoSize = true;
            this.labelStopwatch.Location = new System.Drawing.Point(800, 1185);
            this.labelStopwatch.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelStopwatch.Name = "labelStopwatch";
            this.labelStopwatch.Size = new System.Drawing.Size(0, 32);
            this.labelStopwatch.TabIndex = 14;
            this.labelStopwatch.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupCas
            // 

            this.groupCas.Controls.Add(this.radioButton1);
            this.groupCas.Controls.Add(this.radioButton2);
            this.groupCas.Controls.Add(this.radioButton3);
            this.groupCas.Location = new System.Drawing.Point(67, 382);
            this.groupCas.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupCas.Name = "groupCas";
            this.groupCas.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupCas.Size = new System.Drawing.Size(533, 255);

            this.groupCas.TabIndex = 15;
            this.groupCas.TabStop = false;
            this.groupCas.Text = "Vent";
            this.groupCas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBoxPavage
            // 
            this.groupBoxPavage.Controls.Add(this.radioButtonPavage3);
            this.groupBoxPavage.Controls.Add(this.comboTailleCarre);
            this.groupBoxPavage.Controls.Add(this.radioButtonPavage2);
            this.groupBoxPavage.Controls.Add(this.radioButtonPavage1);
            this.groupBoxPavage.Controls.Add(this.radioButtonPavage0);

            this.groupBoxPavage.Location = new System.Drawing.Point(67, 997);
            this.groupBoxPavage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBoxPavage.Name = "groupBoxPavage";
            this.groupBoxPavage.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBoxPavage.Size = new System.Drawing.Size(533, 360);

            this.groupBoxPavage.TabIndex = 16;
            this.groupBoxPavage.TabStop = false;
            this.groupBoxPavage.Text = "Pavage";
            // 
            // radioButtonPavage3
            // 
            this.radioButtonPavage3.AutoSize = true;
            this.radioButtonPavage3.Location = new System.Drawing.Point(18, 94);
            this.radioButtonPavage3.Name = "radioButtonPavage3";
            this.radioButtonPavage3.Size = new System.Drawing.Size(89, 17);
            this.radioButtonPavage3.TabIndex = 3;
            this.radioButtonPavage3.Text = "Carré de taille";
            this.radioButtonPavage3.UseVisualStyleBackColor = true;
            // 
            // comboTailleCarre
            // 
            this.comboTailleCarre.FormattingEnabled = true;
            this.comboTailleCarre.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboTailleCarre.Location = new System.Drawing.Point(113, 94);
            this.comboTailleCarre.Name = "comboTailleCarre";
            this.comboTailleCarre.Size = new System.Drawing.Size(41, 21);
            this.comboTailleCarre.TabIndex = 26;
            this.comboTailleCarre.Text = "1";
            // 
            // radioButtonPavage2
            // 
            this.radioButtonPavage2.AutoSize = true;

            this.radioButtonPavage2.Location = new System.Drawing.Point(48, 200);
            this.radioButtonPavage2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);

            this.radioButtonPavage2.Name = "radioButtonPavage2";
            this.radioButtonPavage2.Size = new System.Drawing.Size(166, 36);
            this.radioButtonPavage2.TabIndex = 2;
            this.radioButtonPavage2.Text = "Diagonal";
            this.radioButtonPavage2.UseVisualStyleBackColor = true;
            // 
            // radioButtonPavage1
            // 
            this.radioButtonPavage1.AutoSize = true;

            this.radioButtonPavage1.Location = new System.Drawing.Point(48, 122);
            this.radioButtonPavage1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonPavage1.Name = "radioButtonPavage1";
            this.radioButtonPavage1.Size = new System.Drawing.Size(200, 36);

            this.radioButtonPavage1.TabIndex = 1;
            this.radioButtonPavage1.Text = "Carré de 7";
            this.radioButtonPavage1.UseVisualStyleBackColor = true;
            this.radioButtonPavage1.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButtonPavage0
            // 
            this.radioButtonPavage0.AutoSize = true;
            this.radioButtonPavage0.Checked = true;
            this.radioButtonPavage0.Location = new System.Drawing.Point(48, 45);
            this.radioButtonPavage0.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonPavage0.Name = "radioButtonPavage0";
            this.radioButtonPavage0.Size = new System.Drawing.Size(184, 36);
            this.radioButtonPavage0.TabIndex = 0;
            this.radioButtonPavage0.TabStop = true;
            this.radioButtonPavage0.Text = "Carré de 1";
            this.radioButtonPavage0.UseVisualStyleBackColor = true;
            // 

            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDist2);
            this.groupBox1.Controls.Add(this.radioButtonDist1);
            this.groupBox1.Controls.Add(this.radioButtonDist0);
            this.groupBox1.Location = new System.Drawing.Point(67, 684);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(533, 255);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distance entre noeuds";
            // 
            // radioButtonDist2
            // 
            this.radioButtonDist2.AutoSize = true;
            this.radioButtonDist2.Location = new System.Drawing.Point(48, 155);
            this.radioButtonDist2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonDist2.Name = "radioButtonDist2";
            this.radioButtonDist2.Size = new System.Drawing.Size(84, 36);
            this.radioButtonDist2.TabIndex = 2;
            this.radioButtonDist2.Text = "10";
            this.radioButtonDist2.UseVisualStyleBackColor = true;
            // 
            // radioButtonDist1
            // 
            this.radioButtonDist1.AutoSize = true;
            this.radioButtonDist1.Location = new System.Drawing.Point(48, 100);
            this.radioButtonDist1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonDist1.Name = "radioButtonDist1";
            this.radioButtonDist1.Size = new System.Drawing.Size(92, 36);
            this.radioButtonDist1.TabIndex = 1;
            this.radioButtonDist1.Text = "0.1";
            this.radioButtonDist1.UseVisualStyleBackColor = true;
            // 
            // radioButtonDist0
            // 
            this.radioButtonDist0.AutoSize = true;
            this.radioButtonDist0.Checked = true;
            this.radioButtonDist0.Location = new System.Drawing.Point(48, 45);
            this.radioButtonDist0.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.radioButtonDist0.Name = "radioButtonDist0";
            this.radioButtonDist0.Size = new System.Drawing.Size(68, 36);
            this.radioButtonDist0.TabIndex = 0;
            this.radioButtonDist0.TabStop = true;
            this.radioButtonDist0.Text = "1";
            this.radioButtonDist0.UseVisualStyleBackColor = true;
            // 

            // textBoxP1X
            // 
            this.textBoxP1X.Location = new System.Drawing.Point(115, 234);
            this.textBoxP1X.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxP1X.Name = "textBoxP1X";
            this.textBoxP1X.Size = new System.Drawing.Size(260, 38);
            this.textBoxP1X.TabIndex = 18;
            this.textBoxP1X.Text = "100";
            // 
            // textBoxP1Y
            // 
            this.textBoxP1Y.Location = new System.Drawing.Point(115, 296);
            this.textBoxP1Y.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxP1Y.Name = "textBoxP1Y";
            this.textBoxP1Y.Size = new System.Drawing.Size(260, 38);
            this.textBoxP1Y.TabIndex = 19;
            this.textBoxP1Y.Text = "200";
            // 
            // textBoxPfX
            // 
            this.textBoxPfX.Location = new System.Drawing.Point(448, 234);
            this.textBoxPfX.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxPfX.Name = "textBoxPfX";
            this.textBoxPfX.Size = new System.Drawing.Size(260, 38);
            this.textBoxPfX.TabIndex = 20;
            this.textBoxPfX.Text = "200";
            // 
            // textBoxPfY
            // 
            this.textBoxPfY.Location = new System.Drawing.Point(448, 296);
            this.textBoxPfY.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxPfY.Name = "textBoxPfY";
            this.textBoxPfY.Size = new System.Drawing.Size(260, 38);
            this.textBoxPfY.TabIndex = 21;
            this.textBoxPfY.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 188);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 32);
            this.label1.TabIndex = 22;
            this.label1.Text = "Point Initial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(445, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 23;
            this.label2.Text = "Point Final";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 32);
            this.label3.TabIndex = 24;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 303);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "Y";
            // 

            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = global::JoliBateau.Properties.Resources.ocean;
            this.pictureBox1.Location = new System.Drawing.Point(1023, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(3204, 1748);
            this.Controls.Add(this.pictureBox1);

            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPfY);
            this.Controls.Add(this.textBoxPfX);
            this.Controls.Add(this.textBoxP1Y);
            this.Controls.Add(this.textBoxP1X);
            this.Controls.Add(this.groupBoxPavage);
            this.Controls.Add(this.groupCas);
            this.Controls.Add(this.labelStopwatch);
            this.Controls.Add(this.nbNoeudsSolution);
            this.Controls.Add(this.tempsSolution);
            this.Controls.Add(this.labelCountClosed);
            this.Controls.Add(this.labelCountOpen);
            this.Controls.Add(this.labelSolution);
            this.Controls.Add(this.listeSolution);
            this.Controls.Add(this.labelTreeview);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupCas.ResumeLayout(false);
            this.groupCas.PerformLayout();
            this.groupBoxPavage.ResumeLayout(false);
            this.groupBoxPavage.PerformLayout();

            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RadioButton radioButtonCasA;
        private System.Windows.Forms.RadioButton radioButtonCasB;
        private System.Windows.Forms.RadioButton radioButtonCasC;
        private System.Windows.Forms.Label labelTreeview;
        private System.Windows.Forms.ListBox listeSolution;
        private System.Windows.Forms.Label labelSolution;
        private System.Windows.Forms.Label labelCountOpen;
        private System.Windows.Forms.Label labelCountClosed;
        private System.Windows.Forms.Label tempsSolution;
        private System.Windows.Forms.Label nbNoeudsSolution;
        private System.Windows.Forms.Label labelStopwatch;
        private System.Windows.Forms.GroupBox groupCas;
        private System.Windows.Forms.GroupBox groupBoxPavage;
        private System.Windows.Forms.RadioButton radioButtonPavage2;
        private System.Windows.Forms.RadioButton radioButtonPavage1;
        private System.Windows.Forms.RadioButton radioButtonPavage0;
        private System.Windows.Forms.TextBox textBoxP1X;
        private System.Windows.Forms.TextBox textBoxP1Y;
        private System.Windows.Forms.TextBox textBoxPfX;
        private System.Windows.Forms.TextBox textBoxPfY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.ComboBox comboTailleCarre;
        private System.Windows.Forms.RadioButton radioButtonPavage3;
        private System.Windows.Forms.Label label5;

    }
}

