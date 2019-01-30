using UnityEngine;
using System.Collections;

public class SmoothStalker : MonoBehaviour {

    public Transform czolg;

    public float distance = 10.0f;
    public float height = 5.0f;
    public float heightDamping = 2.0f;
    public float rotationDamping = 3.0f;

	// Use this for initialization

	void Start () {
	
	}
	
    //uzywamy lateupdate gdyż chcemy aby kamera podążała za obiektem który się porusza  w funkcji update 
	void LateUpdate () 
    {
        if (!czolg)
        {
            return;
        }

        // reprezentuje rotacje osi  y jaką chcemy otrzymać 
        float wantedRotationAngle = czolg.eulerAngles.y;
        // od pozycji czołgu dodajemy wysokość 
        float wantedHeight = czolg.position.y + height;
        //kąty naszej kamery
        float currentRotationAngle = transform.eulerAngles.y;
        //pozycja naszej kamery 
        float currentHeight = transform.position.y;

        //rotacja osi,rotacje osi jaką chcemy uzyskać,tłumienie rotacji razy czas
        currentRotationAngle = Mathf.LerpAngle(currentRotationAngle,wantedRotationAngle,rotationDamping * Time.deltaTime);

        //pozycja naszej kamer,wysokość jaka chcemy uzyskać i tłumienie razy czas  w sekundach od ostatniej klatki
        currentHeight = Mathf.Lerp(currentHeight,wantedHeight,heightDamping * Time.deltaTime);
        //bierzemy istniejące kąty w tym wypadku nasza oś rotacji kąta i tworzymy nowe rotacje  które są płynniejsze
        Quaternion currentRotation = Quaternion.Euler(0,currentRotationAngle,0);

        
        transform.position = czolg.position;
        transform.position -= currentRotation * Vector3.forward * distance;

        transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
        //patrzymy w kierunku czołgu.
        transform.LookAt(czolg);
	}
}
