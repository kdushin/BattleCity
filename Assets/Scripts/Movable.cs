using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour
{

    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _speedFactor;

    public void Turn(Directions dir)
    {
        switch (dir)
        {
            case Directions.None:
                break;
            case Directions.Up:
                _rigidbody2D.rotation = 0;
                break;
            case Directions.Left:
                _rigidbody2D.rotation = 90;
                break;
            case Directions.Down:
                _rigidbody2D.rotation = 180;
                break;
            case Directions.Right:
                _rigidbody2D.rotation = 270;
                break;
            default:
                throw new ArgumentOutOfRangeException("dir", dir, null);
        }
    }

    public void Move(Directions dir)
    {
        switch (dir)
        {
            case Directions.None:
                break;
            case Directions.Up:
                _rigidbody2D.MovePosition(_rigidbody2D.position + new Vector2(0, _speedFactor * Time.deltaTime));
                break;
            case Directions.Left:
                _rigidbody2D.MovePosition(_rigidbody2D.position + new Vector2(-_speedFactor * Time.deltaTime, 0));
                break;
            case Directions.Down:
                _rigidbody2D.MovePosition(_rigidbody2D.position + new Vector2(0, -_speedFactor * Time.deltaTime));
                break;
            case Directions.Right:
                _rigidbody2D.MovePosition(_rigidbody2D.position + new Vector2(_speedFactor * Time.deltaTime, 0));
                break;
            default:
                throw new ArgumentOutOfRangeException("dir", dir, null);
        }
    }
}
