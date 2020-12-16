using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JoliBateau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radioButtonCasA.CheckedChanged += new EventHandler(radioButtonCas_Changed);
            radioButtonCasB.CheckedChanged += new EventHandler(radioButtonCas_Changed);
            radioButtonCasC.CheckedChanged += new EventHandler(radioButtonCas_Changed);

            comboTailleCarre.SelectedIndex = 7;
            pictureBox1.BackColor = Color.LightBlue;

            ResetAffichage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // on clear les solution si jamais on a lancé auparavant
            ResetAffichage();

            // sélection du cas à traiter
            char cas = 'a';
            groupBoxCas.Controls.OfType<RadioButton>().ToList().ForEach(btn => { if (btn.Checked) cas = Char.Parse(btn.Text); });

            // sélection du type de pavage
            int pavage = 0;
            groupBoxPavage.Controls.OfType<RadioButton>().ToList().ForEach(btn => { if (btn.Checked) pavage = btn.TabIndex; });

            // sélection du type de la distance entre les noeuds. 1km par défaut
            double distance;
            if (radioButtonPavage3.Checked) distance = Int32.Parse(comboTailleCarre.Text);
            else distance = 1;

            Point P0 = new Point(Int32.Parse(textBoxP1X.Text), Int32.Parse(textBoxP1Y.Text), cas, pavage, distance);
            Point.Pf = new Point(Int32.Parse(textBoxPfX.Text), Int32.Parse(textBoxPfY.Text));
            SearchTree tree = new SearchTree();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            List<GenericNode> solution = tree.RechercheSolutionAEtoile(P0); //recherche des solution d'A*
            stopwatch.Stop();

            if (solution.Count == 0)
            {
                labelSolution.Text = "Pas de solution";
            }
            else
            {
                labelSolution.Text = "Une solution a été trouvée";
                foreach (GenericNode N in solution)
                {
                    listeSolution.Items.Add(N);
                }

                //Différents affichages pour les stats de la recherche
                GenericNode Pf = solution.Last();
                string tempsPf = Math.Round(Pf.GetGCost(), 3).ToString();
                tempsSolution.Text = $"Temps total du parcours : {tempsPf} heures";
                nbNoeudsSolution.Text = $"Nb de noeuds dans la solution : {solution.Count()}";
                labelStopwatch.Text = $"Temps écoulé A* : {stopwatch.Elapsed.Minutes} min {stopwatch.Elapsed.Seconds} seconds";
                labelCountOpen.Text = "Nb noeuds des ouverts : " + tree.CountInOpenList().ToString();
                labelCountClosed.Text = "Nb noeuds des fermés : " + tree.CountInClosedList().ToString();
                labelCountAndClosed.Text = $"Nb ouverts + fermés : {tree.CountInOpenList() + tree.CountInClosedList()}";
                tree.GetSearchTree(treeView1);

                //
                // Dessiner les chemins
                //
                Graphics g = pictureBox1.CreateGraphics();
                g.Clear(Color.LightBlue);
                List<Point> ListePoints = solution.Cast<Point>().ToList();
                for (int i = 1; i < ListePoints.Count; i++)
                {
                    // affiche le segment entre le point i-1 et le point i
                    AfficherSegment(g, ListePoints[i - 1].X, ListePoints[i - 1].Y, ListePoints[i].X, ListePoints[i].Y); ;

                    // affichage de u point final sous forme d'une croix verte
                    if (i == ListePoints.Count - 1)
                    {
                        AfficherFin(g, ListePoints[i].X, ListePoints[i].Y);
                    }
                }
            }
        }

        // Dessine le plus court chemin trouvé par l'algorithme sur la carte
        private void AfficherSegment(Graphics g, double x1, double y1, double x2, double y2)
        {
            Pen pen = new Pen(Color.Red);
            pen.Width = 2;
            g.DrawLine(pen, new PointF((int)x1, pictureBox1.Height - (int)y1), new PointF((int)x2, pictureBox1.Height - (int)y2));
        }

        // Dessine une croix verte au point final sur la carte
        private void AfficherFin(Graphics g, double x1, double y1)
        {
            Pen pen = new Pen(Color.Green);
            pen.Width = 2;

            g.DrawLine(pen, new PointF((int)x1 - 10, pictureBox1.Height - (int)(y1 - 10)), new PointF((int)x1 + 10, pictureBox1.Height - (int)(y1 + 10)));
            g.DrawLine(pen, new PointF((int)x1 + 10, pictureBox1.Height - (int)(y1 - 10)), new PointF((int)x1 - 10, pictureBox1.Height - (int)(y1 + 10)));

        }

        private void ResetAffichage()
        {
            labelCountClosed.Text = "";
            labelCountOpen.Text = "";
            labelCountAndClosed.Text = "";
            labelSolution.Text = "";
            labelStopwatch.Text = "";
            labelTreeview.Text = "";
            tempsSolution.Text = "";
            nbNoeudsSolution.Text = "";

            listeSolution.Items.Clear();
            treeView1.ResetText();
        }

        private void radioButtonCas_Changed(object sender, EventArgs e)
        {
            var radio = groupBoxCas.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (radio.Text == "a")
            {
                textBoxP1X.Text = "100";
                textBoxP1Y.Text = "200";
                textBoxPfX.Text = "200";
                textBoxPfY.Text = "100";
            }
            else if (radio.Text == "b")
            {
                textBoxP1X.Text = "100";
                textBoxP1Y.Text = "200";
                textBoxPfX.Text = "200";
                textBoxPfY.Text = "100";
            }
            else if (radio.Text == "c")
            {
                textBoxP1X.Text = "200";
                textBoxP1Y.Text = "100";
                textBoxPfX.Text = "100";
                textBoxPfY.Text = "200";
            }
        }

    }
}
