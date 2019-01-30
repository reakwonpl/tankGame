using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

    DestroyAtEnter power;

    public int dmgpowerup = 100;

    // Use this for initialization
    void Start()
    {
        power = GameObject.FindGameObjectWithTag("Player").GetComponent<DestroyAtEnter>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Destroy(gameObject);
        }
    }
}
