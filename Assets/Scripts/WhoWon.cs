using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhoWon : MonoBehaviour
{
    public bool stop = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.tag="Loser";
    }
}
