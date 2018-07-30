using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public ClickedScript[] MoveRope;
    public GameObject Rope;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FixedUpdate(){
        if (MoveRope[0].clickedIs == true){
            Rope.transform.position=new Vector2(Rope.transform.position.x-0.1f, Rope.transform.position.y);
            UpLeft();
        }
        if (MoveRope[1].clickedIs == true)
        {
            Rope.transform.position = new Vector2(Rope.transform.position.x + 0.1f, Rope.transform.position.y);
            UpRight();
        }
    }

    void UpLeft(){
        MoveRope[0].clickedIs = false;
    }void UpRight(){
        MoveRope[1].clickedIs = false;
    }
}
