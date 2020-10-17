using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoliBateau
{
    class Point : GenericNode
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char cas = 'a';

        //constructeur du point initial du graph en fonction du cas a, b ou c
        public Point()
        {
            switch (cas)
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
        public Point(int x, int y, Point parent)
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

        //permet de calculer la vitesse du vent en fonction de P(x, y) le point au milieu de P1 et P2 
        public double GetWindSpeed(double x, double y)
        {
            if (cas == 'a')
                return 50;
            else if (cas == 'b')
                if (y > 150)
                    return 50;
                else return 20;
            else if (y > 150)
                return 50;
            else return 20;
        }
        public double GetWindDirection(double x, double y)
        {
            if (cas == 'a')
                return 30;
            else if (cas == 'b')
                if (y > 150)
                    return 180;
                else return 90;
            else if (y > 150)
                return 170;
            else return 65;
        }

        //estime le temps que met le bateau pour aller de P1 à P2 en fonction du vent et de l'angle du bateau
        public static double EstimationTemps(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            if (distance > 10) return 1000000;
            double windspeed = GetWindSpeed((x1 + x2) / 2.0, (y1 + y2) / 2.0);
            double winddirection = GetWindDirection((x1 + x2) / 2.0, (y1 + y2) / 2.0);
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

        public bool IsEqual(Point p)
        {
            if (this.X == p.X && this.Y == p.Y)
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
        public override List<GenericNode> GetListSucc()
        {
            // ici on va faire un pavage de 8 autour du point actuel P1
        }
        public override double CalculeHCost()
        {
            // on pourrait prendre comme heuristique le temps qu'on mettrait pour voyager entre P1 et Pf sans les contraites de vent
            // càd qu'on met toujours le vent dans la meilleure direction par rapport à notre bateau, c'est à dire à 50°.
            // en plus on enlève la restriction des 10km ça rend le calcul plus facile plutôt que de calculer la trajectoire optimale avec 
            // les diagonales.
        }
        // On peut aussi penser à surcharger ToString() pour afficher correctement un état
        // c'est utile pour l'affichage du treenode
    }
}
