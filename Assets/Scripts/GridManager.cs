using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] public int height;
    [SerializeField] public int width;
    [SerializeField] public Vector2 offSet;
    [SerializeField] public GameObject slot;
    private Slot[,] grid;
    
    private void Start()
    {
        grid = new Slot[height,width];
        GridSetup();
    }

    private void GridSetup()
    {
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                var actualSlotSpawn = Instantiate(slot, new Vector3(x + offSet.x, y + offSet.y, 0), Quaternion.identity);
                actualSlotSpawn.transform.SetParent(gameObject.transform);
            }
        }
    }

    
    
    // // Dans la console
    // private void ShowGrid()
    // {
    //     string gridShow = "GRID : \n";
    //     
    //     for (int y = 0; y < height; y++)
    //     {
    //         for (int x = 0; x < width; x++)
    //         {
    //             gridShow += grid[y, x];
    //         }
    //         gridShow += "\n";
    //     }
    //     print(gridShow);
    // }
}