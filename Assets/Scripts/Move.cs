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
    public GameObject exitButton;
    public GameObject resumeButton;
    public GameObject pauseButton;
    void Start(){
        Time.timeScale = 1.0f;
        stopGame = false;
        restartButton.SetActive(false);
        exitButton.SetActive(false);
        resumeButton.SetActive(false);
        pauseButton.SetActive(true);
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
        Time.timeScale = 1.0f;
    }
    public void TogglePause(){
        Time.timeScale = Mathf.Approximately(Time.timeScale, 0.0f) ? 1.0f : 0.0f;
        restartButton.SetActive(Time.timeScale != 1.0f);
        exitButton.SetActive(Time.timeScale != 1.0f);
        exitButton.SetActive(Time.timeScale != 1.0f);
        resumeButton.SetActive(Time.timeScale != 1.0f);
        pauseButton.SetActive(Time.timeScale == 1.0f);
    }

    public void Exit(){
        Application.Quit();
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
