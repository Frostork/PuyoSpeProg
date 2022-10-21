using System;
using System.Collections;
using System.Collections.Generic;using Unity.VisualScripting;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;
using UnityEngine.EventSystems;
using Random = System.Random;

public class Puyo : MonoBehaviour
{
    [Header("Init Variables")]
    [SerializeField] public Vector2 puyoPos;
    [SerializeField] public int color;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private List<Sprite> state;

    [Header("Movement")]
    [SerializeField] public float timeBeforeMove;
    public List<Vector2> movements;
    public GridManager gridManager;
    
    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        InitColor();
    }

    private void Update()
    {
        timeBeforeMove += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Q))
            Moving(movements[1]);
        
        if (Input.GetKeyDown(KeyCode.D))
            Moving(movements[2]);
         

        if (timeBeforeMove >= 0.7f)
        {
            Moving(movements[0]);
            timeBeforeMove = 0;
        }

    }

    public void InitColor()
    {
        Random r = new Random();
        color = r.Next(0, 5);
        _spriteRenderer.sprite = state[color];
    }
    private void Moving(Vector3 movement)
    {
        
    }
}
