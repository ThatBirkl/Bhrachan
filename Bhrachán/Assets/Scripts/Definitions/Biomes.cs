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
        public int seaCountMin;
        public int seaCountMax;
        public int seaSizeMin;
        public int seaSizeMax;

        public Biome(int _riverCountMin, int _riverCountMax, int _riverWidthMin, int _riverWidthMax, DungeonGenerator.GroundType _mainTerrain,
            float _vegetationSmallChance, float _vegetationMiddleChance, float _vegetationLargeChance,
            int _seaCountMin, int _seaCountMax, int _seaSizeMin, int _seaSizeMax)
        {
            riverCountMin = _riverCountMin;
            riverCountMax = _riverCountMax;
            riverWidthMax = _riverWidthMax;
            riverWidthMin = _riverWidthMin;
            mainTerrain = _mainTerrain;
            vegetationSmallChance = _vegetationSmallChance;
            vegetationMiddleChance = _vegetationMiddleChance;
            vegetationLargeChance = _vegetationLargeChance;
            seaCountMin = _seaCountMin;
            seaCountMax = _seaCountMax;
            seaSizeMin = _seaSizeMin;
            seaSizeMax = _seaSizeMax;
        }
    }

    public static Biome Grassland = new Biome( 0, 1, 2, 3, DungeonGenerator.GroundType.grass, 0f, 0f, 0f, 0, 1, 2, 8 );
    public static Biome Sea = new Biome( 0, 1, 2, 4, DungeonGenerator.GroundType.grass, 0f, 0f, 0f, 1, 1, 7, 10 );
    public static Biome Marsh = new Biome( 0, 0, 0, 0, DungeonGenerator.GroundType.grass_dark, 0f, 0f, 0f, 10, 20, 2, 4 );
    public static Biome Desert = new Biome( 0, 0, 0, 0, DungeonGenerator.GroundType.sand, 0f, 0f, 0f, 0, 2, 1, 2 );
}
