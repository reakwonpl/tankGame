using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class lvl1Manager : MonoBehaviour {

    public Text winnerText;
    private bool winner;

    private ZycieGracza enigne;


	// Use this for initialization
	void Start () {
        winner = false;
        winnerText.text = "";
	
	}
	
	// Update is called once per frame
	void Update () 
    {   //sprawdzamy czy są jeszcze obiekty z takim tagami,jeżeli nie to nasz boolean jest prawdziwy
        if (!GameObject.FindGameObjectWithTag("pickUp"))
        {
            winner = true;

        }

        if (winner == true)
        {
            //zatrzymujemy czas,wyświetlamy komunikat i po naciśnięciu spacji przenosimy sie za pomocą sceneManagera do 2 poziomu
            Time.timeScale = 0;
            winnerText.text = "You beat this level \n hit spacebar to next level!";
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(2);
            }
        }
       
        
	}
}
