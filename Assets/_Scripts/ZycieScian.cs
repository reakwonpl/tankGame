using UnityEngine;
using System.Collections;

public class ZycieScian : MonoBehaviour
{

   public int health = 50;
   public int scoreValue = 50;
   public GameObject explosion;

    public void setDmg(int dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            scoreManager.score += scoreValue;
            Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
            Destroy(gameObject);
        }
    }
}