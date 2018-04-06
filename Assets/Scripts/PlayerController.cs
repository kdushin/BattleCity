using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    
    void Update () {

        

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
            gameObject.transform.position = gameObject.transform.position + new Vector3(0, 2 * Time.deltaTime);
            
        }
        else if (Input.GetKey(KeyCode.A))
        {

            gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 90));
            gameObject.transform.position = gameObject.transform.position + new Vector3(-2 * Time.deltaTime, 0);
        }
        else if (Input.GetKey(KeyCode.S))
        {

            gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 180));
            gameObject.transform.position = gameObject.transform.position + new Vector3(0, -2 * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {

            gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 270));
            gameObject.transform.position = gameObject.transform.position + new Vector3(2 * Time.deltaTime, 0);
        }
    }
}
