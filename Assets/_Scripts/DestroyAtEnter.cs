using UnityEngine;
using System.Collections;

public class DestroyAtEnter : MonoBehaviour {


 public int dmg;


   
    void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Przeszkoda"))
            other.GetComponent<ZycieScian>().setDmg(dmg);
            Destroy(gameObject);


        if (other.CompareTag("Enemy"))
            other.GetComponent<ZycieWroga>().setDmg(dmg);
            Destroy(gameObject);

        if (other.CompareTag("Player"))
            other.GetComponent<ZycieGracza>().TakeDamage(dmg);
            Destroy(gameObject);

    }
}
