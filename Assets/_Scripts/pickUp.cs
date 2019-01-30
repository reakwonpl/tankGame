using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pickUp : MonoBehaviour {

    public int scoreValue = 100;
    public AudioSource audioPick;
    public AudioClip aupick;

    


    void Start()
    {
        audioPick = GetComponent<AudioSource>();
        
        
    }

    //po wejsciu w wyzwalacz przez obiekt  z tagiem player nasz obiekt się deaktywuje,w punkcie obiektu audiosorce puszcza dzwiek  o raz do scoremanagera zostaje dodana wartość punktowa.
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            scoreManager.score += scoreValue;
           
            AudioSource.PlayClipAtPoint(aupick, transform.position);
            gameObject.SetActive(false);
            
        }
    }

   
    
}
