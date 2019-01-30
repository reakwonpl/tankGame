using UnityEngine;
using System.Collections;

public class EnemyRuch : MonoBehaviour {

    Transform player;
    NavMeshAgent nav;
    public float playerDistance;

	void Awake () {

        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = GetComponent<NavMeshAgent>();
	
	}
    
	
	// Update is called once per frame
	void Update () 
    {
        playerDistance = Vector3.Distance(player.position, transform.position);
        if (playerDistance < 30)
        { 
        nav.SetDestination(player.position);
        transform.LookAt(player);
        }
	}
}
