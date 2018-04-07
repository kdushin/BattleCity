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

        if (Input.GetKey(keyUp))
        {
            Mover.Move(MoveDir.Forward);
        }
        else if (Input.GetKey(keyDown))
        {
            Mover.Move(MoveDir.Backward);
        }

        if (Input.GetKey(keyLeft) && Input.GetKey(keyRight))
        {
        }
        else if (Input.GetKey(keyLeft))
        {
            Mover.Turn(TurnDir.CcwLeft);
        }
        else if (Input.GetKey(keyRight))
        {
            Mover.Turn(TurnDir.CwRight);
        }
    }
}
