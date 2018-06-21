using Robocode;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Larissa_Anderson
{
    public class Larirobo : AdvancedRobot
    {
        public override void Run()
        {
            SetColors(Color.Blue, Color.Black, Color.Yellow);
            while (true)
            {
                SetAhead(100);
                SetTurnRight(90);
                SetTurnGunRight(360);
                Execute();

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
            // Se o outro robô está próximo, e ele tem bastante vida, metralha o robo.
            if (e.Distance < 50 && Energy > 50)
            {
                Fire(5);
            } // caso contrário, atira com intensidade 2.
            else
            {
                Fire(3);
            }
            TurnRight(e.Bearing);
            Ahead(e.Distance + 5);
            // Depois de atirar chama o radar novamente,
            // antes de girar o canhão
            Scan();
        }        public override void OnHitRobot(HitRobotEvent e)
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
            Ahead(50); // E avança para se chocar com ele
        }       
    }
}


