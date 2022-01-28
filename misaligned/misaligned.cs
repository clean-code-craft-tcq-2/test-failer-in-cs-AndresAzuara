using System;
using System.Diagnostics;

namespace MisalignedSpace {
    class Misaligned {
        
        static bool testColors(string[] majorColors, string[] minorColors)
        {
            int i = 0;
            int j = 0;
            for (int p = 0; p < 5; p++)
            {
                j = 0;
                for (int o = 0; o < 5; o++)
                {
                    if (majorColors[p] != majorColors[i] || minorColors[o] != minorColors[i])
                    {
                        return true;
                    }
                    j++;
                }
                i++;
            }
            return false;
        }

        static int printColorMap() {
            string[] majorColors = {"White", "Red", "Black", "Yellow", "Violet"};
            string[] minorColors = {"Blue", "Orange", "Green", "Brown", "Slate"};
            int i = 0, j = 0;
            for(i = 0; i < 5; i++) {
                for(j = 0; j < 5; j++) {
                    Console.WriteLine("{0,10} | {1, 10} | {2, 10}", i * 5 + j, majorColors[i], minorColors[i]);
                }
            }

            if(testColors(majorColors, minorColors))
            {
                return 0;
            }

            return i * j;
        }
        static void Main(string[] args) {
            int result = printColorMap();
            Debug.Assert(result == 25);
            Console.WriteLine("All is well (maybe!)");
        }
    }
}
