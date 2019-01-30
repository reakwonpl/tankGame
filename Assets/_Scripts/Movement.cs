using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    public float rotateSpeed = 90.0f;
    public float speed = 5.0f;
    
    // Update is called once per frame
    void Update()
    {
        float transAmount = speed * Time.deltaTime;
     float rotateAmount = rotateSpeed * Time.deltaTime;

        if (Input.GetKey("up"))
        {
            transform.Translate(0, 0, transAmount);
          
        }
        if (Input.GetKey("down"))
        {
            transform.Translate(0, 0, -transAmount);
            
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -rotateAmount, 0);
            
        }
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, rotateAmount, 0);
        }
        
       
    }

    
}
