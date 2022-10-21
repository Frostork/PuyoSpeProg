using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList;
using UnityEngine;
using UnityEngine.EventSystems;

public class PuyoManager : MonoBehaviour
{
    [SerializeField] private List<Sprite> _states;
    [SerializeField] public float timeBeforeMove;

    public List<Vector2> movements;

    private void Update()
    {
        timeBeforeMove -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Moving(movements[1]);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Moving(movements[2]);
        }
        if (timeBeforeMove <= 0)
        {
            Moving(movements[0]);
        }
    }

    private void Moving(Vector3 movement)
    {
        transform.position += movement;
    }
    
}
