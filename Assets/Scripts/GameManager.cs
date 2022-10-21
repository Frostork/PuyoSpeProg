using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using Random = System.Random;

public class GameManager : MonoBehaviour
{
    [Header("Init")]
    
    [SerializeField] public int height;
    [SerializeField] public int width;
    [SerializeField] public GameObject slot;
    [SerializeField] public GameObject puyo;
    private Slot[,] grid;

    [Header("Puyo")] 
    
    [SerializeField] public List<GameObject> puyos;
    private GameObject _actifPuyo;
    [SerializeField] private bool _canInvoke;
    [SerializeField] public float timeBeforeMove;
    [SerializeField] private bool _canMove;
    [SerializeField] private List<Vector2> _direction;

    private void Start()
    {
        grid = new Slot[height,width];
        GridSetup();
    }

    private void Update()
    {
        if (_canInvoke)
            SpawnPuyo();
    }

    private void GridSetup()
    {
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                var actualSlotSpawn = Instantiate(slot, new Vector3(x, y, 0), Quaternion.identity);
                actualSlotSpawn.transform.SetParent(gameObject.transform);
            }
        }
    }


    private void SpawnPuyo()
    {
        _canInvoke = false;
        _actifPuyo = Instantiate(puyo, new Vector3(0, 0, 0),Quaternion.identity);
        puyos.Add(_actifPuyo);
        Vector2 spawnPoint;
        Random r = new Random();
        spawnPoint.x = r.Next(0, 7);
        spawnPoint.y = 7;
        _actifPuyo.transform.position += (Vector3) _direction[0];
    }

    private void MovePuyo()
    {
        timeBeforeMove += Time.deltaTime;
        if (timeBeforeMove >= 0.7f)
        {
            timeBeforeMove = 0;
        }
        
        if (_canMove)
        {
            if (Input.GetKeyDown(KeyCode.Q))
                _actifPuyo.transform.position += (Vector3) _direction[1];
            
            if (Input.GetKeyDown(KeyCode.D))
                _actifPuyo.transform.position += (Vector3) _direction[2];
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