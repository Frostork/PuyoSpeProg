using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    [SerializeField] public Vector2 slotPos;
    [SerializeField] public bool isOccuped;
    public Puyo puyo;

    private void Start()
    {
        slotPos = transform.position;
    }

    private void Update()
    {
        if (puyo.puyoPos == slotPos)
        {
            isOccuped = true;
        }
    }
}
