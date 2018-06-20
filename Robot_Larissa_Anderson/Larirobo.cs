using Robocode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Larissa_Anderson
{
    public class Larirobo : AdvancedRobot
    {
        Boolean Angulo = true;
        public override void Run()
        {            
            while(true)
            {
                if (Angulo == true)
                {


                    for (int voltasDir = 0; voltasDir < 5; voltasDir++)
                    {
                        Ahead(100);
                        TurnRight(90);
                        TurnGunRight(90);
                        Fire(1);

                    }
                    for (int voltasEsq = 5; voltasEsq > 0; voltasEsq++)
                    {
                        Ahead(200);
                        TurnLeft(90);
                        TurnGunLeft(180);
                        Fire(1);

                    }
                    Angulo = false;

                }
                else
                {
                    for (int voltasDir45 = 0; voltasDir45 < 8; voltasDir45++)
                    {
                        Ahead(50);
                        TurnRight(45);
                        TurnGunRight(90);
                        Fire(1);

                    }
                    for (int voltasEsq = 8; voltasEsq > 0; voltasEsq++)
                    {
                        Ahead(50);
                        TurnLeft(45);
                        TurnGunLeft(180);
                        Fire(1);

                    }
                    Angulo = true;
                }

            }
        }
    }
}
