﻿namespace JoliBateau
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
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
            this.radioButtonPavage2 = new System.Windows.Forms.RadioButton();
            this.radioButtonPavage1 = new System.Windows.Forms.RadioButton();
            this.radioButtonPavage0 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDist3 = new System.Windows.Forms.RadioButton();
            this.radioButtonDist2 = new System.Windows.Forms.RadioButton();
            this.radioButtonDist4 = new System.Windows.Forms.RadioButton();
            this.radioButtonDist1 = new System.Windows.Forms.RadioButton();
            this.radioButtonDist0 = new System.Windows.Forms.RadioButton();
            this.textBoxP1X = new System.Windows.Forms.TextBox();
            this.textBoxP1Y = new System.Windows.Forms.TextBox();
            this.textBoxPfX = new System.Windows.Forms.TextBox();
            this.textBoxPfY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupCas.SuspendLayout();
            this.groupBoxPavage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Recherche A*";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(1094, 208);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(166, 303);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "a";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 51);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.Text = "b";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 84);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.Text = "c";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // labelTreeview
            // 
            this.labelTreeview.AutoSize = true;
            this.labelTreeview.Location = new System.Drawing.Point(1107, 175);
            this.labelTreeview.Name = "labelTreeview";
            this.labelTreeview.Size = new System.Drawing.Size(137, 13);
            this.labelTreeview.TabIndex = 7;
            this.labelTreeview.Text = "Arborescence des solutions";
            // 
            // listeSolution
            // 
            this.listeSolution.FormattingEnabled = true;
            this.listeSolution.Location = new System.Drawing.Point(946, 208);
            this.listeSolution.Name = "listeSolution";
            this.listeSolution.Size = new System.Drawing.Size(131, 303);
            this.listeSolution.TabIndex = 8;
            // 
            // labelSolution
            // 
            this.labelSolution.AutoSize = true;
            this.labelSolution.Location = new System.Drawing.Point(83, 331);
            this.labelSolution.Name = "labelSolution";
            this.labelSolution.Size = new System.Drawing.Size(0, 13);
            this.labelSolution.TabIndex = 9;
            // 
            // labelCountOpen
            // 
            this.labelCountOpen.AutoSize = true;
            this.labelCountOpen.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelCountOpen.Location = new System.Drawing.Point(300, 418);
            this.labelCountOpen.Name = "labelCountOpen";
            this.labelCountOpen.Size = new System.Drawing.Size(0, 13);
            this.labelCountOpen.TabIndex = 10;
            // 
            // labelCountClosed
            // 
            this.labelCountClosed.AutoSize = true;
            this.labelCountClosed.Location = new System.Drawing.Point(300, 447);
            this.labelCountClosed.Name = "labelCountClosed";
            this.labelCountClosed.Size = new System.Drawing.Size(0, 13);
            this.labelCountClosed.TabIndex = 11;
            // 
            // tempsSolution
            // 
            this.tempsSolution.AutoSize = true;
            this.tempsSolution.Location = new System.Drawing.Point(300, 370);
            this.tempsSolution.Name = "tempsSolution";
            this.tempsSolution.Size = new System.Drawing.Size(0, 13);
            this.tempsSolution.TabIndex = 12;
            // 
            // nbNoeudsSolution
            // 
            this.nbNoeudsSolution.AutoSize = true;
            this.nbNoeudsSolution.Location = new System.Drawing.Point(300, 390);
            this.nbNoeudsSolution.Name = "nbNoeudsSolution";
            this.nbNoeudsSolution.Size = new System.Drawing.Size(0, 13);
            this.nbNoeudsSolution.TabIndex = 13;
            // 
            // labelStopwatch
            // 
            this.labelStopwatch.AutoSize = true;
            this.labelStopwatch.Location = new System.Drawing.Point(300, 497);
            this.labelStopwatch.Name = "labelStopwatch";
            this.labelStopwatch.Size = new System.Drawing.Size(0, 13);
            this.labelStopwatch.TabIndex = 14;
            this.labelStopwatch.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupCas
            // 
            this.groupCas.Controls.Add(this.radioButton1);
            this.groupCas.Controls.Add(this.radioButton2);
            this.groupCas.Controls.Add(this.radioButton3);
            this.groupCas.Location = new System.Drawing.Point(25, 208);
            this.groupCas.Name = "groupCas";
            this.groupCas.Size = new System.Drawing.Size(200, 107);
            this.groupCas.TabIndex = 15;
            this.groupCas.TabStop = false;
            this.groupCas.Text = "Cas à traiter";
            this.groupCas.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBoxPavage
            // 
            this.groupBoxPavage.Controls.Add(this.radioButtonPavage3);
            this.groupBoxPavage.Controls.Add(this.radioButtonPavage2);
            this.groupBoxPavage.Controls.Add(this.radioButtonPavage1);
            this.groupBoxPavage.Controls.Add(this.radioButtonPavage0);
            this.groupBoxPavage.Location = new System.Drawing.Point(25, 331);
            this.groupBoxPavage.Name = "groupBoxPavage";
            this.groupBoxPavage.Size = new System.Drawing.Size(200, 151);
            this.groupBoxPavage.TabIndex = 16;
            this.groupBoxPavage.TabStop = false;
            this.groupBoxPavage.Text = "Pavage";
            // 
            // radioButtonPavage3
            // 
            this.radioButtonPavage3.AutoSize = true;
            this.radioButtonPavage3.Location = new System.Drawing.Point(18, 112);
            this.radioButtonPavage3.Name = "radioButtonPavage3";
            this.radioButtonPavage3.Size = new System.Drawing.Size(55, 17);
            this.radioButtonPavage3.TabIndex = 3;
            this.radioButtonPavage3.TabStop = true;
            this.radioButtonPavage3.Text = "Cercle";
            this.radioButtonPavage3.UseVisualStyleBackColor = true;
            // 
            // radioButtonPavage2
            // 
            this.radioButtonPavage2.AutoSize = true;
            this.radioButtonPavage2.Location = new System.Drawing.Point(18, 84);
            this.radioButtonPavage2.Name = "radioButtonPavage2";
            this.radioButtonPavage2.Size = new System.Drawing.Size(67, 17);
            this.radioButtonPavage2.TabIndex = 2;
            this.radioButtonPavage2.Text = "Diagonal";
            this.radioButtonPavage2.UseVisualStyleBackColor = true;
            // 
            // radioButtonPavage1
            // 
            this.radioButtonPavage1.AutoSize = true;
            this.radioButtonPavage1.Location = new System.Drawing.Point(18, 51);
            this.radioButtonPavage1.Name = "radioButtonPavage1";
            this.radioButtonPavage1.Size = new System.Drawing.Size(80, 17);
            this.radioButtonPavage1.TabIndex = 1;
            this.radioButtonPavage1.Text = "Carré de 10";
            this.radioButtonPavage1.UseVisualStyleBackColor = true;
            this.radioButtonPavage1.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButtonPavage0
            // 
            this.radioButtonPavage0.AutoSize = true;
            this.radioButtonPavage0.Checked = true;
            this.radioButtonPavage0.Location = new System.Drawing.Point(18, 19);
            this.radioButtonPavage0.Name = "radioButtonPavage0";
            this.radioButtonPavage0.Size = new System.Drawing.Size(74, 17);
            this.radioButtonPavage0.TabIndex = 0;
            this.radioButtonPavage0.TabStop = true;
            this.radioButtonPavage0.Text = "Carré de 1";
            this.radioButtonPavage0.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDist3);
            this.groupBox1.Controls.Add(this.radioButtonDist2);
            this.groupBox1.Controls.Add(this.radioButtonDist4);
            this.groupBox1.Controls.Add(this.radioButtonDist1);
            this.groupBox1.Controls.Add(this.radioButtonDist0);
            this.groupBox1.Location = new System.Drawing.Point(271, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 136);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distance entre noeuds";
            // 
            // radioButtonDist3
            // 
            this.radioButtonDist3.AutoSize = true;
            this.radioButtonDist3.Location = new System.Drawing.Point(18, 88);
            this.radioButtonDist3.Name = "radioButtonDist3";
            this.radioButtonDist3.Size = new System.Drawing.Size(31, 17);
            this.radioButtonDist3.TabIndex = 19;
            this.radioButtonDist3.Text = "5";
            this.radioButtonDist3.UseVisualStyleBackColor = true;
            // 
            // radioButtonDist2
            // 
            this.radioButtonDist2.AutoSize = true;
            this.radioButtonDist2.Location = new System.Drawing.Point(18, 65);
            this.radioButtonDist2.Name = "radioButtonDist2";
            this.radioButtonDist2.Size = new System.Drawing.Size(31, 17);
            this.radioButtonDist2.TabIndex = 18;
            this.radioButtonDist2.Text = "2";
            this.radioButtonDist2.UseVisualStyleBackColor = true;
            // 
            // radioButtonDist4
            // 
            this.radioButtonDist4.AutoSize = true;
            this.radioButtonDist4.Location = new System.Drawing.Point(18, 113);
            this.radioButtonDist4.Name = "radioButtonDist4";
            this.radioButtonDist4.Size = new System.Drawing.Size(37, 17);
            this.radioButtonDist4.TabIndex = 2;
            this.radioButtonDist4.Text = "10";
            this.radioButtonDist4.UseVisualStyleBackColor = true;
            // 
            // radioButtonDist1
            // 
            this.radioButtonDist1.AutoSize = true;
            this.radioButtonDist1.Location = new System.Drawing.Point(18, 42);
            this.radioButtonDist1.Name = "radioButtonDist1";
            this.radioButtonDist1.Size = new System.Drawing.Size(40, 17);
            this.radioButtonDist1.TabIndex = 1;
            this.radioButtonDist1.Text = "0.1";
            this.radioButtonDist1.UseVisualStyleBackColor = true;
            // 
            // radioButtonDist0
            // 
            this.radioButtonDist0.AutoSize = true;
            this.radioButtonDist0.Checked = true;
            this.radioButtonDist0.Location = new System.Drawing.Point(18, 19);
            this.radioButtonDist0.Name = "radioButtonDist0";
            this.radioButtonDist0.Size = new System.Drawing.Size(31, 17);
            this.radioButtonDist0.TabIndex = 0;
            this.radioButtonDist0.TabStop = true;
            this.radioButtonDist0.Text = "1";
            this.radioButtonDist0.UseVisualStyleBackColor = true;
            // 
            // textBoxP1X
            // 
            this.textBoxP1X.Location = new System.Drawing.Point(43, 98);
            this.textBoxP1X.Name = "textBoxP1X";
            this.textBoxP1X.Size = new System.Drawing.Size(100, 20);
            this.textBoxP1X.TabIndex = 18;
            // 
            // textBoxP1Y
            // 
            this.textBoxP1Y.Location = new System.Drawing.Point(43, 124);
            this.textBoxP1Y.Name = "textBoxP1Y";
            this.textBoxP1Y.Size = new System.Drawing.Size(100, 20);
            this.textBoxP1Y.TabIndex = 19;
            // 
            // textBoxPfX
            // 
            this.textBoxPfX.Location = new System.Drawing.Point(168, 98);
            this.textBoxPfX.Name = "textBoxPfX";
            this.textBoxPfX.Size = new System.Drawing.Size(100, 20);
            this.textBoxPfX.TabIndex = 20;
            // 
            // textBoxPfY
            // 
            this.textBoxPfY.Location = new System.Drawing.Point(168, 124);
            this.textBoxPfY.Name = "textBoxPfY";
            this.textBoxPfY.Size = new System.Drawing.Size(100, 20);
            this.textBoxPfY.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Point Initial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Point Final";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 792);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPfY);
            this.Controls.Add(this.textBoxPfX);
            this.Controls.Add(this.textBoxP1Y);
            this.Controls.Add(this.textBoxP1X);
            this.Controls.Add(this.groupBox1);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupCas.ResumeLayout(false);
            this.groupCas.PerformLayout();
            this.groupBoxPavage.ResumeLayout(false);
            this.groupBoxPavage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonDist4;
        private System.Windows.Forms.RadioButton radioButtonDist1;
        private System.Windows.Forms.RadioButton radioButtonDist0;
        private System.Windows.Forms.RadioButton radioButtonPavage3;
        private System.Windows.Forms.RadioButton radioButtonDist2;
        private System.Windows.Forms.RadioButton radioButtonDist3;
        private System.Windows.Forms.TextBox textBoxP1X;
        private System.Windows.Forms.TextBox textBoxP1Y;
        private System.Windows.Forms.TextBox textBoxPfX;
        private System.Windows.Forms.TextBox textBoxPfY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

