using UnityEngine;
using System.Collections;

public class medicalKit : MonoBehaviour {

    ZycieGracza zycieGracza;

    public int hp = 20;
    public AudioSource pick;
    public AudioClip pickup;

	void Start () {
        
       //szukamy obiektu z takim tagiem i dostajemy sie do jego komponentu zycia
        zycieGracza = GameObject.FindGameObjectWithTag("Player").GetComponent<ZycieGracza>();
        pick = GetComponent<AudioSource>();

	}
	
	
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && zycieGracza.currentHealth != 100)
        {
            //uzywamy metody ze skryptu zycia gracza i dodajemy wartość hp
            zycieGracza.addHealth(hp);
            AudioSource.PlayClipAtPoint(pickup, transform.position);

            Destroy(gameObject);
            
        }
    }
   
}
