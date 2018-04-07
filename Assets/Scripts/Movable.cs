using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour
{

    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _speedFactor;
    [SerializeField] private float _turnFactor;

    public void Turn(TurnDir dir)
    {
        switch (dir)
        {
            case TurnDir.None:
                break;
            case TurnDir.CcwLeft:
                _rigidbody2D.MoveRotation(_rigidbody2D.rotation + _turnFactor * Time.deltaTime);
                break;
            case TurnDir.CwRight:
                _rigidbody2D.MoveRotation(_rigidbody2D.rotation - _turnFactor * Time.deltaTime);
                break;
            default:
                throw new ArgumentOutOfRangeException("dir", dir, null);
        }
    }

    public void Move(MoveDir dir)
    {
        var sin = (float)Math.Sin(_rigidbody2D.rotation * Math.PI / 180);
        var cos = (float)Math.Cos(_rigidbody2D.rotation * Math.PI / 180);
        var len = _speedFactor * Time.deltaTime;

        switch (dir)
        {
            case MoveDir.None:
                break;
            case MoveDir.Forward:       
                _rigidbody2D.MovePosition(_rigidbody2D.position - new Vector2(len * sin, - len * cos));
                break;
            case MoveDir.Backward:
                _rigidbody2D.MovePosition(_rigidbody2D.position + new Vector2(len * sin, - len * cos));
                break;
            default:
                throw new ArgumentOutOfRangeException("dir", dir, null);
        }
    }
}
