using UnityEngine;
using System.Collections;

public class minaScript : MonoBehaviour {

    public int dmg = 100;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            other.GetComponent<ZycieGracza>().TakeDamage(dmg);
        if (other.CompareTag("Enemy"))
            other.GetComponent<ZycieWroga>().setDmg(dmg);

        Destroy(gameObject);
    }    
}
   


