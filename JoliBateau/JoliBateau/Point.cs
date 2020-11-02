﻿using System;
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
        public static double DistNoeuds { get; set; } //constante définissant la distance en km entre les noeuds
        public static double Pavage { get; set; } // indicateur du pavage à prendre 
       
        public Point()
        {

        }

        //constructeur du point initial du graph en fonction du cas a, b ou c
        public Point(char inputCas, int pavage, double dist)
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

            DistNoeuds = dist;
            Pavage = pavage;
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
            double xDebut = X - DistNoeuds;
            double xFin = X + DistNoeuds;
            double yDebut = Y - DistNoeuds;
            double yFin = Y + DistNoeuds;

            // on doit gérer les cas particuliers avec la bordure pour la recherche des noeuds environnants
            if (X == 0)
            {
                xDebut = X;
                xFin = X + DistNoeuds;
            }
            else if (X == 300)
            {
                xDebut = X - DistNoeuds;
                xFin = X;
            }

            if (Y == 0)
            {
                yDebut = Y;
                yFin = Y + DistNoeuds;
            }
            else if (Y == 300)
            {
                yDebut = Y - DistNoeuds;
                yFin = Y;
            }

            if (Pavage == 0) // pavage carré de 8
            {
                // on prend les noeuds autour de P1
                for (double x = xDebut; x <= xFin; x += DistNoeuds)
                {
                    for (double y = yDebut; y <= yFin; y += DistNoeuds)
                    {
                        if (x != X || y != Y)
                        {
                            Point tempPoint = new Point(x, y);
                            newNodes.Add(tempPoint);
                        }
                    }
                }
            }
            else if(Pavage == 1) // pavage tout dans 10km
            {
                DistNoeuds = 10;
                xDebut = X - DistNoeuds;
                xFin = X + DistNoeuds;
                yDebut = Y - DistNoeuds;
                yFin = Y + DistNoeuds; 
                
                // ensemble de conditions pour assurer un pavage cohérent même aux bordures
                if(X <= 10)
                {
                    xDebut = 0;
                }
                else if(X >= 290)
                {
                    xFin = 300;
                }

                if (Y <= 10)
                {
                    xDebut = 0;
                }
                else if (Y >= 290)
                {
                    xFin = 300;
                }

                for (double x = xDebut; x <= xFin; x += 1)
                {
                    for (double y = yDebut; y <= yFin; y += 1)
                    {
                        if (x != X && y != Y)
                        {
                            Point tempPoint = new Point(x, y);
                            newNodes.Add(tempPoint);
                        }
                    }
                }
            }

            else if (Pavage == 2) // pavage diagonal
            {
                // on prend les noeuds autour de P1 en croix de 1
                for (double x = xDebut; x <= xFin; x += DistNoeuds)
                {
                    for (double y = yDebut; y <= yFin; y += DistNoeuds)
                    {
                        if (x != X && y != Y)
                        {
                            Point tempPoint = new Point(x, y);
                            newNodes.Add(tempPoint);
                        }
                    }
                }
            }
            else if (Pavage == 3) // pavage cercle
            {
                // on va prendre des nouveaux noeuds en cercle autour du noeud actuel
                // donc on a des angles multiple de pi d'où les coefficients suivants
                double rayonCercle = DistNoeuds; 
                double coef1 = rayonCercle * Math.Sqrt(3) / 2;
                double coef2 = rayonCercle * (1 / 2);
                double coef3 = rayonCercle * (-1) * Math.Sqrt(3) / 2;
                double coef4 = rayonCercle * (- 1 / 2);
                double coef5 = rayonCercle * Math.Sqrt(2) / 2; // pour avoir diagonales
                List<GenericNode> tempNodes = new List<GenericNode>(); // liste utile pour vérification des coordonnées des points

                //tempNodes.Add(new Point(X + rayonCercle, Y)); // 0
                tempNodes.Add(new Point(X + coef5, Y + coef5)); // pi / 4
               // tempNodes.Add(new Point(X, Y + rayonCercle)); // pi / 2
                tempNodes.Add(new Point(X - coef5, Y + coef5)); // 3pi/4
                //tempNodes.Add(new Point(X - rayonCercle, Y)); // pi
                tempNodes.Add(new Point(X - coef5, Y - coef5)); // -3pi/4
                //tempNodes.Add(new Point(X, Y - rayonCercle)); // -pi/2
                tempNodes.Add(new Point(X + coef5, Y - coef5)); // -pi/4

                foreach(GenericNode node in tempNodes)
                {
                    Point temp = (Point)node;
                    if(temp.X >= 0 && temp.X <= 300 && temp.Y >= 0 && temp.Y <= 300)
                    {
                        newNodes.Add(node);
                    }
                }
            }
            
            /*// on peut essayer de voir si le Pf est à portée pour l'ajouter aux noeux ouverts
            Point Pf = Point.PointFinal();
            double distance = Math.Sqrt((Pf.X - X) * (Pf.X - X) + (Pf.Y - Y) * (Pf.Y - Y));
            if (distance <= 10) newNodes.Add(Pf);*/

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

            /*double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            double windspeed = 50;
            double alpha = 45;
            double boatspeed = (0.9 - 0.2 * (alpha - 45) / 45) * windspeed;
           
            return (distance / boatspeed);*/

            double distance = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
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
        // On peut aussi penser à surcharger ToString() pour afficher correctement un état
        // c'est utile pour l'affichage du treenode

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
