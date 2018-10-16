using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Drawing;

public class DungonGenerator : MonoBehaviour
{
    private enum ObjectType
    {
        nothing,

        tree,
        chest,
        cliff
    }

    private enum GroundType
    {
        water,
        snow,
        grass,
        sand,
        stone
    }

    Dictionary<GroundType, Vector3> groundColors;

    //[z][y][x]
    private bool[][][] canPlaceObject;
    private GroundType[][][] ground;
    private ObjectType[][][] objects;


    private Vector3 dimensions;

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

            for (int y = 0; z < dimensions.y; y++)
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

        groundColors.Add(GroundType.grass, new Vector3(1,1,1));
    }


    public void ExportBitmap()
    {
        Bitmap bmp = new Bitmap(100, 100);
    }
}
