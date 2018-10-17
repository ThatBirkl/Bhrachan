using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Biomes
{
    public struct Biome
    {
        public int riverCountMin;
        public int riverCountMax;
        public int riverWidthMax;
        public int riverWidthMin;
        public DungeonGenerator.GroundType mainTerrain;
        public float vegetationSmallChance;
        public float vegetationMiddleChance;
        public float vegetationLargeChance;

        public Biome(int _riverCountMin, int _riverCountMax, int _riverWidthMin, int _riverWidthMax, DungeonGenerator.GroundType _mainTerrain,
            float _vegetationSmallChance, float _vegetationMiddleChance, float _vegetationLargeChance)
        {
            riverCountMin = _riverCountMin;
            riverCountMax = _riverCountMax;
            riverWidthMax = _riverWidthMax;
            riverWidthMin = _riverWidthMin;
            mainTerrain = _mainTerrain;
            vegetationSmallChance = _vegetationSmallChance;
            vegetationMiddleChance = _vegetationMiddleChance;
            vegetationLargeChance = _vegetationLargeChance;
        }
    }

    public static Biome Grassland = new Biome( 1, 1, 2, 5, DungeonGenerator.GroundType.grass, 0f, 0f, 0f );
}
