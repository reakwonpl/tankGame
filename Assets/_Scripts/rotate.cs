using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {
  
	void Update () 
    {
        //vector 3 przekazuje pozycje i kierunki w 3D
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);

	}
}
