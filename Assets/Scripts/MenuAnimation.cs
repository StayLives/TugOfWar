using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuAnimation : MonoBehaviour
{
    
    public float distance;
    public Vector3 direction;
    public float speed;
    private Vector3 startPosition;
    bool back = false;
    // Use this for initialization
    void Start () {
        startPosition = transform.position;
    }

    public void GoPlay(){
        SceneManager.LoadScene("TugOfWar", LoadSceneMode.Single);
        
    }
	
	void FixedUpdate (){
        if (Vector3.Distance(transform.position, startPosition) < distance && !back)
        {
            transform.position += direction.normalized * 0.5f * Time.deltaTime;
        }
        else
            back = true;

        if (back)
        {
            float tmp = Vector3.Distance(transform.position, startPosition);

            transform.position -= direction.normalized * 0.5f * Time.deltaTime;

            if (Vector3.Distance(transform.position, startPosition) > tmp)
            {
                back = false;
            }
        }
        //if (transform.position.x<=2){
        //        transform.position = Vector3.MoveTowards(transform.position, transform.position + direct, 0.5f * Time.deltaTime);
        //    }


    }
}
