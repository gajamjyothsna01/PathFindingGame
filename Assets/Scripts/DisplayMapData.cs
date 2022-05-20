using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayMapData : MonoBehaviour
{
    public int width = 10; //no.of rows
    public int height = 5; //no of columns

    private void Start()
    {
        int[,] sampleMap = MakeMap();
      
    }

    public int[,] MakeMap()
    {
        int[,] map = new int[width, height];
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                map[x, y] = 0;
                Debug.Log(map[x, y]);
            }
        }

        map[1, 0] = 1;
        map[1, 1] = 1;
        map[1, 2] = 1;
        map[3, 2] = 1;
        map[3, 3] = 1;
        map[3, 4] = 1;
        map[4, 2] = 1;
        map[5, 1] = 1;
        map[5, 2] = 1;
        map[6, 2] = 1;
        map[6, 3] = 1;
        map[8, 0] = 1;
        map[8, 1] = 1;
        map[8, 2] = 1;
        map[8, 4] = 1;

        return map;

    }
}
