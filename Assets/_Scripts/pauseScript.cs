using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseScript : MonoBehaviour {

    GameObject pauseMenu;
    bool paused;

	// Use this for initialization
	void Start () 
    {
        //na starcie zaznaczamy ze pauza jest nieaktywna a tym samym gameObject szuka obiektu zwanego PauseMenu w hierarchi 
        paused = false;
        pauseMenu = GameObject.Find("PauseMenu");
	}
	
	// Update is called once per frame
	void Update () 
    {       //po nacisnięciu escape nasz boolean zmienia sie w prawdę a po kolejnym zamienia sie w nieprawdę 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }

        if (paused) //jezeli pauza jest uruchomiana nasz gameObject aktywuje pause i zatrzymuje czas 
        {   
            
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else if (!paused) //jezeli ponownie nacisniemy escape pauza się deaktywuje a czas wraca do normalnosci 
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
	}
    // przycisk powoduje odpauzowanie 
    public void Resume()
    {
        paused = false;
    }
    //scenemanager ładuje scene pierwszą w indexie 0 czyli głowne menu 
    public void MainMenu()
    {
        SceneManager.LoadScene(0);

    }
    //ta metoda po naciśnięciu ,zapisuje scene aktywną do pliku po przes playerPresf.setint
    public void save()
    {
        PlayerPrefs.SetInt("currentscenesave", SceneManager.GetActiveScene().buildIndex);

    }
    //ta metoda ładuje scene zapisaną w playerPrefs działa tak samo jak w menu głównym
    public void load()
    {
       SceneManager.LoadScene( PlayerPrefs.GetInt("currentscenesave"));
    }
    //wyjscie  z aplikacji 
    public void quit()
    {
        Application.Quit();
    }
}
