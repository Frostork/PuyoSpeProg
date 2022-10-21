using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] public int height;
    [SerializeField] public int width;
    [SerializeField] public Vector2 offSet;
    [SerializeField] public List<GameObject> puyos;
    private int[,] grid;
    
    private void Start()
    {
        grid = new int[height,width];
        GridSetup();
        ShowGrid();
    }

    private void GridSetup()
    {
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                
                Instantiate(puyos[0], new Vector3(x+offSet.x, y+offSet.y, 0), Quaternion.identity);
            }
        }
    }

    private void ShowGrid()
    {
        string gridShow = "GRID : \n";
        
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                gridShow += grid[y, x];
            }
            gridShow += "\n";
        }
        print(gridShow);
    }
}