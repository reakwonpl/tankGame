using UnityEngine;
using System.Collections;

public class enemyAI : MonoBehaviour {

    public Transform player;
    public float playerDistance;
    public float fireDistance = 5f;


    public AudioSource auShot;
    public float fireInterval = 0.5f;
    private float nextFire;
    NavMeshAgent nav;

    strzal shot;

	// Use this for initialization
	void Start () 
    {
        shot = GetComponent<strzal>();
        nextFire = Time.time + fireInterval;
        auShot = GetComponent<AudioSource>();
        
	}
   
	
	// Update is called once per frame
	void Update ()
    {
        if (!gameObject.transform)
        {
            return;
            
        }
        else 
        playerDistance = Vector3.Distance(player.position, transform.position);


        if (playerDistance < fireDistance && Time.time > nextFire && GameObject.FindGameObjectWithTag("Player"))
        {
            
            nextFire = Time.time + fireInterval;
             attack();
   
        }
        
   }
	

    
    
    void attack()
    {
        transform.LookAt(player);
        shot.fire();
        auShot.Play();
    }
}

