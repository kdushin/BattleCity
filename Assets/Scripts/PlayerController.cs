using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField] KeyCode keyUp;
    [SerializeField] KeyCode keyLeft;
    [SerializeField] KeyCode keyDown;
    [SerializeField] KeyCode keyRight;
    
    [SerializeField] Movable Mover;

    void Update () {
        Directions dir = Directions.None;
        bool shouldTurn = true;
        if (Input.GetKeyDown(keyUp))
        {
            dir = Directions.Up;
        }
        else if (Input.GetKeyDown(keyLeft))
        {
            dir = Directions.Left;
        }
        else if (Input.GetKeyDown(keyDown))
        {
            dir = Directions.Down;
        }
        else if (Input.GetKeyDown(keyRight))
        {
            dir = Directions.Right;
        }
        else
        {
            shouldTurn = false;
        }

        if (shouldTurn)
        {
            Mover.Turn(dir);
            Mover.Move(dir);
            return;
        }

        if (Input.GetKey(keyUp))
        {
            dir = Directions.Up;
        }
        else if (Input.GetKey(keyLeft))
        {
            dir = Directions.Left;
        }
        else if (Input.GetKey(keyDown))
        {
            dir = Directions.Down;
        }
        else if (Input.GetKey(keyRight))
        {
            dir = Directions.Right;
        }

        if (dir != Directions.None)
        {
            Mover.Move(dir);
        }
    }
}
