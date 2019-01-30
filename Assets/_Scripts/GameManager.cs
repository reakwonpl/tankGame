using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public Text restartText;
    public Text gameOver;

    private bool gameover;
    private bool restart;



	// Use this for initialization
	void Start () 
    {
        gameover = false;
        restart = false;
        restartText.text = "";
        gameOver.text = "";
	}
	
	// Update is called once per frame
	void Update () 
    {       //jeżeli nie znajdziemy obiektu z takim tagiem wykonujemy metode death
        if (!GameObject.FindGameObjectWithTag("Player"))
        {
            Death();
        }
        if (gameover)
        {
            restartText.text = "Press 'r' to \n restart";
            restart = true;
        }
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {//ładujemy po przez scenemanagera aktywną już scene
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
	}
    //ta metoda wyświetla komunikat 
    void GameOver()
    {
        gameOver.text ="Your Tank was  \n   destroyed!\n It's a Game Over!";
        gameover = true;

    } 
    void Death()
    {
        GameOver();
    }
    
}
