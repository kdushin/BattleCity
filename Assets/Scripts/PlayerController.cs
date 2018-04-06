using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(0, 2 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(-2 * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(0, -2 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position = gameObject.transform.position + new Vector3(2 * Time.deltaTime, 0);
        }
    }
}
