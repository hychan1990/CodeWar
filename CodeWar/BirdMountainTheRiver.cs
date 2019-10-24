using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWar
{

    class BirdMountainTheRiver
    {
        static char[][] terrain =
        {
            "  ^^^^^^             ".ToCharArray(),
            "^^^^^^^^       ^^^   ".ToCharArray(),
            "^^^^^^^  ^^^         ".ToCharArray(),
            "^^^^^^^  ^^^         ".ToCharArray(),
            "^^^^^^^  ^^^         ".ToCharArray(),
            "---------------------".ToCharArray(),
            "^^^^^                ".ToCharArray(),
            "   ^^^^^^^^  ^^^^^^^ ".ToCharArray(),
            "^^^^^^^^     ^     ^ ".ToCharArray(),
            "^^^^^        ^^^^^^^ ".ToCharArray()
        };
        public static int[] DryGround(char[][] terrain)
        {
            HashSet<int[]> FlowingWater = new HashSet<int[]>();

            return new int[] { 0, 0, 0, 0 };
        }
        private bool CheckFlowSpace(int[] pos, char[][] terrain)
        {

        }
    }
}
