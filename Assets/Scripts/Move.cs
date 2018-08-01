using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{

    public ClickedScript[] MoveRope;
    public GameObject Rope;
    private float timer;
    private bool stopGame;
    private GameObject loser;
    public GameObject winL;
    public GameObject winR;
    public GameObject restartButton;
    void Start(){
        restartButton.SetActive(false);
    }

    void Update(){
        loser= GameObject.FindWithTag("Loser");

    }
    void FixedUpdate()
    {
        if (loser != null){
            stopGame = true;
            if( loser.transform.position.x > 0) { 
            var yourWin = Instantiate(winL, winL.transform.position, Quaternion.identity);
            Destroy(yourWin,0.2f);
            }
            if (loser.transform.position.x < 0)
            {
                var yourWin = Instantiate(winR, winR.transform.position, Quaternion.identity);
                Destroy(yourWin, 0.2f);
            }
            restartButton.SetActive(true);
        }
        if (timer < 4){
            timer += Time.deltaTime;
        }
        if (timer > 4 && stopGame == false){
            if (MoveRope[0].clickedIs == true){
                Rope.transform.position = new Vector2(Rope.transform.position.x - 0.1f, Rope.transform.position.y);
                UpLeft();
            }
            if (MoveRope[1].clickedIs == true){
                Rope.transform.position = new Vector2(Rope.transform.position.x + 0.1f, Rope.transform.position.y);
                UpRight();
            }
        }
    }

    public void RestartGame(){
        SceneManager.LoadScene("TugOfWar", LoadSceneMode.Single);
    }
    void UpLeft()
    {
        MoveRope[0].clickedIs = false;
    }
    void UpRight()
    {
        MoveRope[1].clickedIs = false;
    }
}
