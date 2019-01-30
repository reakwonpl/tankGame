using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class poziom1 : MonoBehaviour {
    public Text winnerText;
   bool winner;

	// Use this for initialization
	void Start () {

        GetComponent<scoreManager>();
        winner = false;
        winnerText.text = "";
        
	}
	
	// Update is called once per frame
	void Update () {

        if (!GameObject.FindGameObjectWithTag("wyjscie") && scoreManager.score >= 4000)
        {
            winner = true;
        }

        if (winner == true)
        {
            Time.timeScale = 0;
            winnerText.text = "You beat the game! \n  Thank you for playing ! \n Press space to return to main menu :) ";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(0);
            }
        }
	
	}
}
