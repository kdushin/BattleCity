using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour {

    [SerializeField] float speedFactor;

    public void Turn(Directions dir)
    {
        switch (dir)
        {
            case Directions.None:
                break;
            case Directions.Up:
                gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
                break;
            case Directions.Left:
                gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
                break;
            case Directions.Down:
                gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 180));
                break;
            case Directions.Right:
                gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 270));
                break;
            default:
                break;
        }
    }

    public void Move(Directions dir)
    {
        switch (dir)
        {
            case Directions.None:
                break;
            case Directions.Up:
                gameObject.transform.position = gameObject.transform.position + new Vector3(0, speedFactor * Time.deltaTime);
                break;
            case Directions.Left:
                gameObject.transform.position = gameObject.transform.position + new Vector3(-speedFactor * Time.deltaTime, 0);
                break;
            case Directions.Down:
                gameObject.transform.position = gameObject.transform.position + new Vector3(0, -speedFactor * Time.deltaTime);
                break;
            case Directions.Right:
                gameObject.transform.position = gameObject.transform.position + new Vector3(speedFactor * Time.deltaTime, 0);
                break;
            default:
                break;
        }
    }
}
