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
        if (loser != null && restartButton.activeInHierarchy==false)
        {
            stopGame = true;
            pauseButton.SetActive(false);
            exitButton.SetActive(true);
            if ( loser.transform.position.x > 0) { 
            var yourWin = Instantiate(winL, winL.transform.position, Quaternion.identity);
            }
            if (loser.transform.position.x < 0)
            {
                var yourWin = Instantiate(winR, winR.transform.position, Quaternion.identity);
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
        pauseButton.SetActive(true);
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
        if (Time.timeScale != 1.0f){
            GetComponent<AudioSource>().Pause();
        }
        if(Time.timeScale == 1.0f && timer < 4) { GetComponent<AudioSource>().Play();
    }
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
