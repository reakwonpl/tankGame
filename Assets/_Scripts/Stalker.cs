using UnityEngine;
using System.Collections;

public class Stalker : MonoBehaviour {

    public GameObject czolg;
    private Vector3 offset;


	// Use this for initialization
	void Start () {
        offset = transform.position - czolg.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = czolg.transform.position + offset;
	}
}
