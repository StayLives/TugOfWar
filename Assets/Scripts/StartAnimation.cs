using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimation : MonoBehaviour {
    public GameObject[] obj;
	// Use this for initialization
	void Start () {
        StartCoroutine(StartGame());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator StartGame()
    {
        foreach (var item in obj)
        {

        var cloneBomb=Instantiate(item, item.transform.position, Quaternion.identity);
            Destroy(cloneBomb, 1);  
        yield return new WaitForSeconds(1);          
        }
       
    }
}
