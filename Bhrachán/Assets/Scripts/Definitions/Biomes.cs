using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biomes
{
    public struct Biome
    {
        int riverCountMin;
        int riverCountMax;
        int riverWidthMax;
        int riverWidthMin;
        DungeonGenerator.GroundType mainTerrain;
        float vegetationSmallChance;
        float vegetationMiddleChance;
        float vegetationLargeChance;
    }
}
