using UnityEngine;
using System.Collections;

public class Ruch : MonoBehaviour {

    public float forwardRate = 3f;
    public float turnRate = 2f;

	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float v = Input.GetAxis("Vertical") * forwardRate;
        float h = Input.GetAxis("Horizontal") * turnRate;
        transform.Rotate(0, h, 0);
        transform.position += transform.forward * v * Time.deltaTime;
	}
}
