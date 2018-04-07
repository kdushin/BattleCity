using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAiController : MonoBehaviour {

    private System.Random r = new System.Random();
    private TurnDir dir = TurnDir.CcwLeft;

    [SerializeField] Movable Mover;

	// Use this for initialization
	void Start () {
        r = new System.Random();
	}
	
	// Update is called once per frame
	void Update () {
        
        if (r.NextDouble() <= .8)        // 80% of time - move, 20% - do nothing
        {
            if (r.NextDouble() <= .80)     // 80% - move forward, 15% - move bw, 5% dont move
            {
                Mover.Move(MoveDir.Forward);
            }
            else if (r.NextDouble() <= .75) 
            {
                Mover.Move(MoveDir.Backward);
            }
        }

	    if (r.NextDouble() < .3) // 30% of time turn somewhere, 70% dont turn
	    {
	        if (r.NextDouble() < .1)    // in rare case (10%) change direction, 90% - keep previous
	        {
	            dir = dir == TurnDir.CcwLeft ? TurnDir.CwRight : TurnDir.CcwLeft;
                
	        }

	        Mover.Turn(dir);
        }
	}
}
