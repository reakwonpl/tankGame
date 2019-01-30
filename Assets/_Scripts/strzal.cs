using UnityEngine;
using System.Collections;

public class strzal : MonoBehaviour {

    public GameObject Bullet_Emitter;

    public GameObject Bullet;

    public float Bullet_Forward_Force;

    public float fireInterval = 0.5f;
    private float nextFire;
    public AudioSource aushot;

    void Start()
    {
        //jest to czas w sekundach od początku gry plus przedział pomiędzy kolejnym wystrzałem
        nextFire = Time.time + fireInterval;
        aushot = GetComponent<AudioSource>();

    }

    void Update()
    {   //jeżeli nacisniemy x i czas od początku gry jest większy od następnego wystrzału to można wystrzelić 
        if (Input.GetKeyDown("x") && Time.time > nextFire)
        {

            nextFire = Time.time + fireInterval;
            //metoda wystrzału
            fire();
            aushot.Play();
            
            
        }
    }
    public void fire()
    {
        
        GameObject Temporary_Bullet_Handler;
        Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;

        
        Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);

        Rigidbody Temporary_RigidBody;
        Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

        Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);
    } 
}
