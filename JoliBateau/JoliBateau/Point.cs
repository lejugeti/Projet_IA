using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoliBateau
{
    public class Point : GenericNode
    {
        public double X { get; set; }
        public double Y { get; set; }
        public static char cas;
        public double distNoeud = 1; //constante définissant la distance en km entre les noeuds
         
        public Point()
        {

        }

        //constructeur du point initial du graph en fonction du cas a, b ou c
        public Point(char inputCas)
        {
            cas = inputCas;
            switch (inputCas)
            {
                case 'a':
                    X = 100;
                    Y = 200;
                    break;
                
                case 'b':
                    X = 100;
                    Y = 200;
                    break;
                
                case 'c':
                    X = 200;
                    Y = 100;
                    break;
            }
            
            ParentNode = null;          
            Enfants = new List<GenericNode>();
        }

        //constructeur général de la classe Point
        public Point(double x, double y)
        {
            X = x;
            Y = y;

            //Vérifications pour pas que le point parte trop loin du repaire
            if (X < 0) X = 0;
            else if (X > 300) X = 300;
            if (Y < 0) Y = 0;
            else if (Y > 300) Y = 300;
            
            Enfants = new List<GenericNode>();
        }

        // méthode qui crée le point final à atteindre Pf
        public static Point PointFinal()
        {
            int Xf = 0;
            int Yf = 0;
            switch (cas)
            {
                case 'a':
                    Xf = 200;
                    Yf = 100;
                    break;

                case 'b':
                    Xf = 200;
                    Yf = 100;
                    break;

                case 'c':
                    Xf = 100;
                    Yf = 200;
                    break;

            }

            Point pointFinal = new Point(Xf, Yf);
            
            return pointFinal;
        }

        //estime le temps que met le bateau pour aller de P1 à P2 en fonction du vent et de l'angle du bateau
        public static double EstimationTemps(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (distance > 10) return 1000000;
            double windspeed = Vent.GetWindSpeed((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double winddirection = Vent.GetWindDirection((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double boatspeed;
            double boatdirection = Math.Atan2(y2 - y1, x2 - x1) * 180 / Math.PI;
            // On ramène entre 0 et 360
            if (boatdirection < 0) boatdirection = boatdirection + 360;
            // calcul de la différence angulaire
            double alpha = Math.Abs(boatdirection - winddirection);
            // On se ramène à une différence entre 0 et 180 :
            if (alpha > 180) alpha = 360 - alpha;
            if (alpha <= 45)
            {
                /* (0.6 + 0.3α / 45) v_v */
                boatspeed = (0.6 + 0.3 * alpha / 45) * windspeed;
            }
            else if (alpha <= 90)
            {
                /*v_b=(0.9-0.2(α-45)/45) v_v */
                boatspeed = (0.9 - 0.2 * (alpha - 45) / 45) * windspeed;
            }
            else if (alpha < 150)
            {
                /* v_b=0.7(1-(α-90)/60) v_v */
                boatspeed = 0.7 * (1 - (alpha - 90) / 60) * windspeed;
            }
            else
                return 1000000;
            // estimation du temps de navigation entre p1 et p2
            return (distance / boatspeed);
        }

        public override bool IsEqual(GenericNode p)
        {
            Point tempP = (Point)p;
            if (this.X == tempP.X && this.Y == tempP.Y)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        //renvoie le coût pour passer d'un point P1 à P2, càd le temps que le bateau met
        public override double GetArcCost(GenericNode N2)
        {
            Point P2 = (Point)N2;
            return EstimationTemps(X, Y, P2.X, P2.Y);
        }

        //renvoie si le Point p est l'état final à atteindre
        public override bool EndState()
        {
            int Xf = 0; 
            int Yf = 0;
            switch (cas)
            {
                case 'a':
                    Xf = 200;
                    Yf = 100;
                    break;

                case 'b':
                    Xf = 200;
                    Yf = 100;
                    break;

                case 'c':
                    Xf = 100;
                    Yf = 200;
                    break;

            }

            if (X == Xf && Y == Yf) return true;
            return false;
        }

        // renvoie la liste des 8 noeuds autour du point P1. Un pavage différent pourra être essayé après
        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> newNodes = new List<GenericNode>();

            // distNoeud est la distance en km entre les noeuds. On utilise une variable ici pour 
            // tester si il y a des modifications de performances en la changeant
            double xDebut = X - distNoeud;
            double xFin = X + distNoeud;
            double yDebut = Y - distNoeud;
            double yFin = Y + distNoeud;

            // on doit gérer les cas particuliers avec la bordure pour la recherche des noeuds environnants
            if (X == 0) 
            {
                xDebut = X;
                xFin = X + distNoeud;
            } 
            else if(X == 300)
            {
                xDebut = X - distNoeud;
                xFin = X;   
            }
            
            if (Y == 0)
            {
                yDebut = Y;
                yFin = Y + distNoeud;
            }
            else if (Y == 300)
            {
                yDebut = Y - distNoeud;
                yFin = Y;
            }


            // on prend les noeuds autour de P1
            for (double x = xDebut; x <= xFin; x += distNoeud)
            {
                for (double  y = yDebut; y <= yFin; y += distNoeud)
                {
                    if(x != X || y != Y)
                    {
                        Point tempPoint = new Point(x, y);
                        newNodes.Add(tempPoint);
                    }
                }
            }

            return newNodes;
        }

        public override double CalculeHCost()
        {
            // on pourrait prendre comme heuristique le temps qu'on mettrait pour voyager entre P1 et Pf sans les contraites de vent
            // càd qu'on met toujours le vent dans la meilleure direction par rapport à notre bateau, c'est à dire à 45°.
            // en plus on enlève la restriction des 10km ça rend le calcul plus facile plutôt que de calculer la trajectoire optimale avec 
            // les diagonales.

            Point Pf = Point.PointFinal();
            double x1 = X;
            double y1 = Y;
            double x2 = Pf.X;
            double y2 = Pf.Y;

            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            double windspeed = 50;
            double alpha = 45;
            double boatspeed = (0.9 - 0.2 * (alpha - 45) / 45) * windspeed;
           
            return (distance / boatspeed);
        }
        // On peut aussi penser à surcharger ToString() pour afficher correctement un état
        // c'est utile pour l'affichage du treenode

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
