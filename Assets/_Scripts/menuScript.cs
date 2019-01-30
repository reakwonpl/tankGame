using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour {

    public Canvas exitMenu;
    public Button startText;
    public Button exitText;
    public Button loadText;
    
    public Canvas creditsMenu;

	// Use this for initialization
	void Start () 
    {
        //dostęp do innych komponentów w tym przypadku canvas i przyciski 
        exitMenu = exitMenu.GetComponent<Canvas>();
        startText = startText.GetComponent<Button>();
        exitText = exitText.GetComponent<Button>();
        loadText = loadText.GetComponent<Button>();
        //exit menu domyślnie jest nieaktywne 
        exitMenu.enabled = false;
        creditsMenu = creditsMenu.GetComponent<Canvas>();
        //Tak samo credisty
        creditsMenu.enabled = false;
        
	
	}

    public void exitPress()
    {
        //kiedy nacisniemy exit canvas z menu wyjscia staje się aktywny,cała reszta zostaje dezaktywowana
        exitMenu.enabled = true;
        startText.enabled = false;
        exitText.enabled = false;
        loadText.enabled = false;
        creditsMenu.enabled = false;

    }
    //jak nacisniemy no w excie to cała reszta sie aktywuje a menu exit deaktywuje
    public void noPrss()
    {
        exitMenu.enabled = false;
        startText.enabled = true;
        exitText.enabled = true;
        loadText.enabled = true;
        creditsMenu.enabled = false;

    }

    //metoda aktywacji creditsu
    public void pressCred()
    {
        exitMenu.enabled = false;
        startText.enabled = false;
        exitText.enabled = false;
        loadText.enabled = false;
        creditsMenu.enabled = true;
    }
    
    //klikając na start  za  pomocą scene managera odpalamy 1 scene w indexie 
    public void startLevel()
    {
        SceneManager.LoadScene(1);
    }

    //klikając na load scenemanager ładuje scene zapisaną podczas użycia save w menu pauzy za pomocą playerpresf getint
    public void load()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("currentscenesave"));
    }
    //ta metoda wychodzi z aplikacji 
    public void exitGame()
    {
        Application.Quit();
    }
}
