using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Drawing;

public class DungeonGenerator// : MonoBehaviour
{
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
        sand,
        stone
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

    Dictionary<GroundType, System.Drawing.Color> groundColors;

    //[z][y][x]
    private bool[][][] canPlaceObject;
    private GroundType[][][] ground;
    private ObjectType[][][] objects;

    private Vector3 dimensions;

    public DungeonGenerator()
    { }

    private void Initiate(Vector3 _dimensions)
    {
        dimensions = _dimensions;
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
                    ground[z][y][x] = GroundType.grass;
                    objects[z][y][x] = ObjectType.nothing;
                }
            }
        }
        groundColors = new Dictionary<GroundType, System.Drawing.Color>();
        groundColors.Add(GroundType.grass, System.Drawing.Color.Green);
        //TODO add more ground types
    }

    public Map GenerateDungeon(Vector3 _dimensions)
    {
        Initiate(_dimensions);
        Map map = new Map(null, null);

        //TODO generate a dungeon

        map.ground = ground;
        map.objects = objects;

        //TODO remove this again
        ExportBitmap();

        return map;
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
}
