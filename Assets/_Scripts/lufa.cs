using UnityEngine;
using System.Collections;

public class lufa : MonoBehaviour {

    public float rate = 2.0f;
	
	
	void Update () {
        if (Input.GetKey("z"))
        {
            transform.Rotate(0, -5 * rate, 0);
            
        }
        if (Input.GetKey("c"))
        {
            transform.Rotate(0, 5 * rate, 0);
        }
       
	}
}
