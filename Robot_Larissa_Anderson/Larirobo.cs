﻿using Robocode;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Larissa_Anderson
{
    public class Larirobo : Robot
    {
        public override void Run()
        {
            SetColors(Color.Blue, Color.Black, Color.Yellow);
            while (true)
            {
                Ahead(100);
                TurnRight(90);
                TurnGunRight(360);
                
                //TurnLeft(180);
                //TurnLeft(180);
                //TurnGunLeft(180);
            }
        }
        //public override void OnScannedRobot(ScannedRobotEvent evnt)
        //{
        //    Fire(1);
        //}
        public override void OnScannedRobot(ScannedRobotEvent e)
        {
            // Se o outro robô está próximo, e ele tem bastante vida,
            // dispara intensamente!
            if (e.Distance < 50 && Energy > 50)
            {
                Fire(3);
            } // caso contrário, atira com intensidade 1.
            else
            {
                Fire(1);
            }
            TurnRight(e.Bearing);
            Ahead(e.Distance + 5);
            // Depois de atirar chama o radar novamente,
            // antes de girar o canhão
            Scan();
        }        public void onHitRobot(HitRobotEvent e)
        {
            TurnRight(e.Bearing);
            // Faz o cálculo da intensidade necessária para enfraquecer o oponente
            if (e.Energy > 16)
            {
                Fire(3);
            }
            else if (e.Energy > 10)
            {
                Fire(2);
            }
            else if (e.Energy > 4)
            {
                Fire(1);
            }
            else if (e.Energy > 2)
            {
                Fire(.5);
            }
            else if (e.Energy > .4)
            {
                Fire(.1);
            }
            Ahead(40); // E avança para se chocar com ele
        }
    }
}


