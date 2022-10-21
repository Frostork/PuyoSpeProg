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
    [SerializeField] public Vector3 puyoPos;
    [SerializeField] public int color;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private List<Sprite> state;

    [Header("Movement")]
    [SerializeField] public float timeBeforeMove;
    [SerializeField] public bool canMove;
    public List<Vector2> movements;
    public GameManager gameManager;
    
    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        InitColor();
    }

    private void Update()
    {
        timeBeforeMove += Time.deltaTime;

        if (timeBeforeMove >= 0.7f)
        {
            canMove = true;
        }
    }

    public void InitColor()
    {
        Random r = new Random();
        color = r.Next(0, 5);
        _spriteRenderer.sprite = state[color];
    }
}
