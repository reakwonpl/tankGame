using UnityEngine;
using System.Collections;

public class znajdz1 : MonoBehaviour {

    public AudioSource audiopick;
    public AudioClip aupick;
	// Use this for initialization
	void Start () {
        audiopick = GetComponent<AudioSource>();
	}

        public void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(aupick, transform.position);
        gameObject.SetActive(false);
    }
}
