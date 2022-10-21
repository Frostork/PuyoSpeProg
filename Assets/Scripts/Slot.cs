using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    [SerializeField] public Vector2 slotPos;
    [SerializeField] public bool isOccuped;
    public GameManager gameManager;

    private void Start()
    {
        slotPos = transform.position;
    }

    private void CheckSlot()
    {
        foreach (var puyo in gameManager.puyos)
        {
            if (transform.position == puyo.GetComponent<Puyo>().puyoPos)
            {
                isOccuped = true;
            }
        }
    }
}
