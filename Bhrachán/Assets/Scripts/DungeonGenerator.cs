using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Drawing;
using Meta;

public class DungeonGenerator// : MonoBehaviour
{
    //(0,0)         (x,0)
    //
    //
    //
    //(0,y)         (x,y)

    public enum ObjectType
    {
        nothing,

        tree,
        chest,
        cliff
    }

    public enum GroundType
    {
        water,
        snow,
        grass,
        grass_dark,
        sand,
        stone
    }

    private enum Direction
    {
        up,
        down,
        left,
        right

    }

    public struct Map
    {
        public GroundType[][][] ground;
        public ObjectType[][][] objects;
        public Map(GroundType[][][] _ground, ObjectType[][][] _objects)
        {
            ground = _ground;
            objects = _objects;
        }
    }

    private struct DirNum
    {
        public int num;
        public Direction dir;

        public DirNum(Direction _dir, int _num)
        {
            dir = _dir;
            num = _num;
        }
    }

    Dictionary<GroundType, System.Drawing.Color> groundColors;

    //[z][y][x]
    private bool[][][] canPlaceObject;
    private GroundType[][][] ground;
    private ObjectType[][][] objects;

    private Vector3 dimensions;
    private Biomes.Biome biome;

    private int riverCount;

    public DungeonGenerator()
    { }

    private void Initiate(Vector3 _dimensions, Biomes.Biome _biome)
    {
        dimensions = _dimensions;
        biome = _biome;
        canPlaceObject = new bool[Mathf.FloorToInt(dimensions.z)][][];
        ground = new GroundType[Mathf.FloorToInt(dimensions.z)][][];
        objects = new ObjectType[Mathf.FloorToInt(dimensions.z)][][];


        for (int z = 0; z < dimensions.z; z++)
        {
            canPlaceObject[z] = new bool[Mathf.FloorToInt(dimensions.y)][];
            ground[z] = new GroundType[Mathf.FloorToInt(dimensions.y)][];
            objects[z] = new ObjectType[Mathf.FloorToInt(dimensions.y)][];

            for (int y = 0; y < dimensions.y; y++)
            {
                canPlaceObject[z][y] = new bool[Mathf.FloorToInt(dimensions.x)];
                ground[z][y] = new GroundType[Mathf.FloorToInt(dimensions.x)];
                objects[z][y] = new ObjectType[Mathf.FloorToInt(dimensions.x)];

                for (int x = 0; x < dimensions.x; x++)
                {
                    canPlaceObject[z][y][x] = true;
                    ground[z][y][x] = biome.mainTerrain;
                    objects[z][y][x] = ObjectType.nothing;
                }
            }
        }
        groundColors = new Dictionary<GroundType, System.Drawing.Color>();
        groundColors.Add(GroundType.grass, System.Drawing.Color.Green);
        groundColors.Add(GroundType.water, System.Drawing.Color.Blue);
        groundColors.Add(GroundType.grass_dark, System.Drawing.Color.DarkGreen);
        groundColors.Add(GroundType.sand, System.Drawing.Color.Gold);
        //TODO add more ground types
    }

    public Map GenerateDungeon(Vector3 _dimensions, Biomes.Biome _biome)
    {
        Initiate(_dimensions, _biome);
        Map map = new Map(null, null);

        //TODO generate a dungeon

        List<Vector2> seaMarkers = GenerateSea(0);
        GenerateRiver(0, seaMarkers);
        


        map.ground = ground;
        map.objects = objects;

        //TODO remove this again
        ExportBitmap();

        return map;
    }

    private void GenerateRiver(int _level, List<Vector2> _seaMarkers)
    {
        riverCount = Random.Range(biome.riverCountMin, biome.riverCountMax + 1);

        List<Vector2> riverMarkers;

        //Iterate over rivers and generate each one
        for(int i = 0; i < riverCount; i++)
        {
            riverMarkers = new List<Vector2>();
            Vector2 start = Vector2.zero;
            Vector2 end = Vector2.zero;


            //Pick random position for start
            //For now a river can only go from one edge to another
            //Starting somewhere in the middle will be implemented later

            int max = 4;
            if(_seaMarkers.Count != 0)
                max = 5;

            int startSide = Random.Range(0, max);
            //  0
            //3   1
            //  2
            //4 means connected to a sea
            switch(startSide)
            {
                case 0:
                    start.y = 0;
                    break;
                case 1:
                    start.x = dimensions.x - 1;
                    break;
                case 2:
                    start.y = dimensions.y - 1;
                    break;
                case 3:
                    start.x = 0;
                    break;
                case 4:
                    start = _seaMarkers[Random.Range(0, _seaMarkers.Count)];
                    break;
            }

            if(startSide == 0 || startSide == 2)
            {
                start.x = Random.Range(0, dimensions.x);
            }
            else if(startSide == 1 ||startSide == 3)
            {
                start.y = Random.Range(0, dimensions.y);
            }

            
            //Pick random position for end
            //For now a river can only go from one edge to another
            //Starting somewhere in the middle will be implemented later
            int endSide = startSide;
            while (endSide == startSide)
            {
                endSide = Random.Range(0, max);
            }
            
            //  0
            //3   1
            //  2
            //4 means connected to a sea
            switch(endSide)
            {
                case 0:
                    end.y = 0;
                    break;
                case 1:
                    end.x = dimensions.x - 1;
                    break;
                case 2:
                    end.y = dimensions.y - 1;
                    break;
                case 3:
                    end.x = 0;
                    break;
                case 4:
                    end = _seaMarkers[Random.Range(0, _seaMarkers.Count)];
                    break;
            }

            if(endSide == 0 || endSide == 2)
            {
                end.x = Random.Range(0, dimensions.x);
            }
            else if(endSide == 1 || endSide == 3)
            {
                end.y = Random.Range(0, dimensions.y);
            }

            //Adding start und end onto the riverMarkers array
            riverMarkers.Add(start);
            riverMarkers.Add(end);

            //Generating the outline of the river
            bool stop = false;
            List<Vector2> riverMarkersTemp = new List<Vector2>();
            int loopCounter = 1;

            int stopper = Mathf.FloorToInt(
                            Mathf.Sqrt(Mathf.Pow(start.x - end.x, 2) + 
                            Mathf.Pow(start.y - end.y, 2))
                        ) ;

            while(!stop)
            {               
                riverMarkersTemp.Add(riverMarkers[0]);

                for(int index = 1; index < riverMarkers.Count; index++)
                {
                    //0 2 3
                    //3 5
                    Vector2 marker = Vector2.zero;
                    float weightA = 0;
                    float weightB = 0;
                    
                    if(riverMarkers[index-1] == riverMarkers[index])
                    {}
                    else if(Util.NextToEachOther(riverMarkers[index-1],riverMarkers[index]))
                    {
                        riverMarkersTemp.Add(riverMarkers[index]);
                    }
                    else
                    {
                        //generating marker

                        //int closer = Util.CloserTo(index - 1, index, Mathf.CeilToInt(riverMarkers.Count/2));

                        //if(closer == 0){ weightA = 3; weightB = 1; }
                        //else if(closer == 1){ weightA = 1; weightB = 3; }
                        //else if(closer == 2){ weightA = 2f; weightB = 2f; }
                        weightA = 1;
                        weightB = 1;

                        marker.x = (riverMarkers[index-1].x * weightA + riverMarkers[index].x * weightB)/(weightA + weightB);

                        marker.y = (riverMarkers[index-1].y * weightA + riverMarkers[index].y * weightB)/(weightA + weightB);

                        Vector2 dist = riverMarkers[index] - riverMarkers[index-1];
                        dist = new Vector2(dist.y, - dist.x);
                        dist.Normalize();
                        dist *= (Random.Range(-DungeonGeneration.RIVER_NOISE, DungeonGeneration.RIVER_NOISE + 1) 
                        / Mathf.Pow(DungeonGeneration.RIVER_NOISE_REDUCTION,loopCounter));
                        marker += dist;
                        marker.x = Mathf.FloorToInt(marker.x);
                        marker.y = Mathf.FloorToInt(marker.y);

                        riverMarkersTemp.Add(marker);

                        riverMarkersTemp.Add(riverMarkers[index]);
                    }
                    
                }

                if(loopCounter >= stopper)
                {
                    stop = true;
                }
                    

                riverMarkers = new List<Vector2>(riverMarkersTemp);
                riverMarkersTemp.Clear();
                
                loopCounter++;
            }

            List<DirNum> dirNum = RiverExpansionLookup(Random.Range(biome.riverWidthMin, biome.riverWidthMax + 1));
            Vector2 curPos;


            //expand the river
            riverMarkersTemp.Clear();
            foreach(Vector2 v in riverMarkers)
            {
                curPos = v;
                foreach(DirNum d in dirNum)
                {
                    for(int c = 0; c < d.num; c++)
                    {
                        switch(d.dir)
                        {
                            case Direction.up:
                                curPos.y++;
                                break;
                            case Direction.down:
                                curPos.y--;
                                break;
                            case Direction.left:
                                curPos.x--;
                                break;
                            case Direction.right:
                                curPos.x++;
                                break;
                        }
                        riverMarkersTemp.Add(new Vector2(curPos.x, curPos.y));
                    }
                }
            }

            riverMarkers.AddRange(riverMarkersTemp);

            //plant the river on the map
            for(int j = 0; j < riverMarkers.Count; j++)
            {
                if(Mathf.FloorToInt(riverMarkers[j].y) >= 0 && 
                    Mathf.FloorToInt(riverMarkers[j].y) < dimensions.y && 
                    Mathf.FloorToInt(riverMarkers[j].x) >= 0 &&
                    Mathf.FloorToInt(riverMarkers[j].x) < dimensions.x)
                {     
                    ground[_level][Mathf.FloorToInt(riverMarkers[j].y)][Mathf.FloorToInt(riverMarkers[j].x)] = GroundType.water;
                }
            }
            
        }
    }

    private List<Vector2> GenerateSea(int _level)
    {
        int seaCount = Random.Range(biome.seaCountMin, biome.seaCountMax + 1);
        List<Vector2> allSeaMarkers = new List<Vector2>();

        for(int a = 0; a < seaCount; a++)
        {
            List<Vector2> oceanMarkers = new List<Vector2>();
            HashSet<Vector2> oceanMarkersTemp = new HashSet<Vector2>();
            Vector2 curPos;
            //set random first point for the ocean
            oceanMarkers.Add(new Vector2(
                Random.Range(0, dimensions.x),
                Random.Range(0, dimensions.y)
            ));
            int chance = 0;
            int c = Random.Range(0, 101);
            Direction pd = (Direction)Random.Range(0, 4);
            //from the first point on there is generated a line of semi-random length and semi-random direciton
            while(c > chance)
            {
                chance += 2;
                c = Random.Range(0, 101);

                Direction d = (Direction)Random.Range(0, 5);

                int ch = Random.Range(0, 4);
                if(ch < 4)
                    d = pd;

                
                curPos = oceanMarkers[oceanMarkers.Count - 1];
                
                switch(d)
                {
                    case Direction.up:
                        curPos.y++;
                        break;
                    case Direction.down:
                        curPos.y--;
                        break;
                    case Direction.left:
                        curPos.x--;
                        break;
                    case Direction.right:
                        curPos.x++;
                        break;
                }
                pd = d;
                oceanMarkers.Add(curPos);
            }

            //the size of the sea is determined
            int add = 4 * Random.Range(biome.seaSizeMin, biome.seaSizeMax + 1);

            //all the ocean markers are generated (should actually be called sea markers, but whatevs)
            for(int b = 0; b < add; b++)
            {
                foreach(Vector2 v in oceanMarkers)
                {
                    oceanMarkersTemp.Add(v);
                    Direction d = (Direction)Random.Range(0, 4);
                    curPos = v;

                    switch(d)
                    {
                        case Direction.up:
                            curPos.y++;
                            break;
                        case Direction.down:
                            curPos.y--;
                            break;
                        case Direction.left:
                            curPos.x--;
                            break;
                        case Direction.right:
                            curPos.x++;
                            break;
                    }

                    oceanMarkersTemp.Add(curPos);
                }

                oceanMarkers = new List<Vector2>(oceanMarkersTemp);
                oceanMarkersTemp.Clear();
            }

            //mark sea(s) on map
            for(int j = 0; j < oceanMarkers.Count; j++)
            {
                if(Mathf.FloorToInt(oceanMarkers[j].y) >= 0 && 
                    Mathf.FloorToInt(oceanMarkers[j].y) < dimensions.y && 
                    Mathf.FloorToInt(oceanMarkers[j].x) >= 0 &&
                    Mathf.FloorToInt(oceanMarkers[j].x) < dimensions.x)
                {     
                    ground[_level][Mathf.FloorToInt(oceanMarkers[j].y)][Mathf.FloorToInt(oceanMarkers[j].x)] = GroundType.water;
                }
            }
            allSeaMarkers.AddRange(oceanMarkers);
        }

        return allSeaMarkers;
    }


    public void ExportBitmap()
    {
        Bitmap bmp;
        string uuid = Util.UUID();
        for (int z = 0; z < dimensions.z; z++)
        {
            bmp = new Bitmap(Mathf.CeilToInt(dimensions.x), Mathf.CeilToInt(dimensions.y));
            for (int y = 0; y < dimensions.y; y++)
            {
                for (int x = 0; x < dimensions.x; x++)
                {
                    bmp.SetPixel(x, y, groundColors[ground[z][y][x]]);
                }
            }

            if (!System.IO.Directory.Exists("C:/Bhrachan/temp/Dungeon"))
            {
                System.IO.Directory.CreateDirectory("C:/Bhrachan/temp/Dungeon");
            }

            bmp.Save("C:/Bhrachan/temp/Dungeon/Colormap_"+ uuid +"_"+ z + ".bmp");
        }
    }


    private static List<DirNum> RiverExpansionLookup(int _width)
    {
        List<DirNum> ret = new List<DirNum>();

        for(int i = _width; i > 1; i--)
        {
            if(i % 2 == 1)
            {
                ret.Add(new DirNum(Direction.left, i - 1));
                ret.Add(new DirNum(Direction.down, i - 1));
                ret.Add(new DirNum(Direction.right, 1));
            }
            else
            {
                ret.Add(new DirNum(Direction.right, i - 1));
                ret.Add(new DirNum(Direction.up, i - 1));
                ret.Add(new DirNum(Direction.left, 1));
            }
        }

        return ret;
    }
}