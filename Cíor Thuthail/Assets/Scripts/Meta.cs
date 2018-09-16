using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Meta
{
    namespace World
    {
        public class Movement
        {
            public static float TICK = 0.5f; //0.5 seconds
            public static float SPEED = 1f;
            public static float CAMERA_SPEED = 0.99f;
            public static float CAMERA_DISTANCE = -5f;

            public enum Facing
            {
                up,
                down,
                left,
                right
            }
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
}
