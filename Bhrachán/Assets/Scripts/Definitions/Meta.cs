using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Meta
{
    namespace World
    {
        public class Movement
        {
            public static float SPEED = 5f;
            public static float CAMERA_SPEED = 10f;
            public static float CAMERA_DISTANCE = -20f;
            public static float CAMERA_ORTHIGRAPHIC_SIZE = 9f;

            public enum Facing
            {
                up,
                down,
                left,
                right
            }
        }

        public class Automation
        {
            public static float TICK = 60f;
        }
    };

    namespace Weapon
    {
        public class Damage
        {
            public static int COMMON_MIN = 0;
            public static int COMMON_MAX = 15;
            public static int UNCOMMON_MIN = 5;
            public static int UNCOMMON_MAX = 25;
            public static int RARE_MIN = 15;
            public static int RARE_MAX = 40;
            public static int ULTRARARE_MIN = 30;
            public static int ULTRARARE_MAX = 60;
            public static int EPIC_MIN = 50;
            public static int EPIC_MAX = 75;
        }
    };
    
    namespace MISC
    {
        public class Texts
        {
            public static int CHAR_COUNT = 1000;
        }
    }

    public class DungeonGeneration
    {
        public static int RIVER_MARKERS_MIN = 0;
        public static int RIVER_MARKERS_MAX = 10;
        public static int RIVER_NOISE = 30;
    }
}
