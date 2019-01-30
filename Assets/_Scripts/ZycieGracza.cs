using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ZycieGracza : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public Image damageImage;
    public Image tankdmgImage;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f); //kolor zapisany w RGBA czerwony

    

    public GameObject Boom;

    public AudioSource auEngine;

    void Start()
    {
        

       auEngine = GetComponent<AudioSource>();
       auEngine.Play();


    }

 
   

    bool isDead;
    bool damaged;

   

    

	void Awake ()
    {
        //initializowanie zmiennych zanim gra się zacznie 
     currentHealth = startingHealth;
	}
	
	void Update () {
        
        if (damaged)
        {
            damageImage.color = flashColour;
            
        } else
        {
            //interpolacja pomiędzy kolorami 
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
        if (isDead)
        {   //dzwiek silnika przestaje grac
            auEngine.Stop();
            //instancja podmienia nasz obiekt w pozycji i rotacji w której był nasz obiekt  i w te miejsce daje wywołuje nasz gameobject wybuch
            Instantiate(Boom, gameObject.transform.position, gameObject.transform.rotation);
            gameObject.SetActive(false);
        }
       
		}
    //metoda od obrazen 
    public void TakeDamage(int amount)
    {
        damaged = true;
        //gdy warunek obrażen jest prawdziwy od naszego życia odejmujemy wartość obrażenia

        currentHealth -= amount;
         //przekazujemy wartośc naszego życia do slidera w HUDCanvasie
        healthSlider.value = currentHealth;
        //jeżeli nasze życie jest mniejsze od zera  i isDead jest fałszywe wywołujemy metode death która zmienia is dead na prawde przez co w update nasz obiekt wybucha
        if (currentHealth <= 0 && !isDead)
        {
            Death();
                        
        }
    }

    void Death()
    {
        isDead = true;
       
       
        

    }
    //metoda dodajaca zdrowie 
    public void addHealth(int extraHealth)
    {
        currentHealth += extraHealth;
        //zwraca mniejszą od dwóch czy wiecej wartości
        currentHealth = Mathf.Min(currentHealth, startingHealth);
        healthSlider.value = currentHealth;

    }

    
}
