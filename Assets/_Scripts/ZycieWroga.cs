using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ZycieWroga : MonoBehaviour {

    public int health = 50;
    public int scoreValue = 100;
    public Slider healthSlider;
    public GameObject wybuch;


    public void setDmg(int dmg)
    {
        health -= dmg;
        healthSlider.value = health;
        if (health <= 0)
        {
            scoreManager.score += scoreValue;
            Instantiate(wybuch, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject,0.1f);

        }
    }
}
