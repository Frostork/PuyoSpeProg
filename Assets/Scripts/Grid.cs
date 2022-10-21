using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] public int height;
    [SerializeField] public int width;

    [SerializeField] public List<GameObject> puyos;

    private void Start()
    {
        GridSetup();
    }

    private void GridSetup()
    {
        int[,] grid = new int[height, width];

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Instantiate(puyos[0], new Vector3(y, x, 0), Quaternion.identity);
            }
        }
    }

}
