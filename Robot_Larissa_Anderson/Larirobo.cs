using Robocode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_Larissa_Anderson
{
    public class Larirobo : Robot
    {
        public override void Run()
        {
            while(true)
            {
                
                Ahead(200);
                TurnLeft(90);
                Fire(1);
            }
        }
    }
}
