using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAiController : MonoBehaviour {

    private System.Random r = new System.Random();
    private Directions dir = Directions.Up;

    [SerializeField] Movable Mover;

	// Use this for initialization
	void Start () {
        r = new System.Random();
	}
	
	// Update is called once per frame
	void Update () {
        
        if (r.NextDouble() <= .8)        // 80% of time - move, 20% - do nothing
        {
            if (r.NextDouble() <= .95)     // in 70% cases - keep direction, 30% - choose new one
            {
                Mover.Move(dir);
            }
            else
            {
                dir = (Directions)r.Next(1, 5);
                Mover.Turn(dir);
                Mover.Move(dir);
            }
        }
	}
}
