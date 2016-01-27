using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
    Transform P1;
    Transform P2;
    NavMeshAgent nav;
    int rand;
	// Use this for initialization

	void Start () {
        P1 = GameObject.FindGameObjectWithTag("Player").transform;
        P2 = GameObject.FindGameObjectWithTag("Player2").transform;
        
        nav = GetComponent<NavMeshAgent>();
         rand = Random.Range(0, 4);
	}
	
	// Update is called once per frame
	void Update () {
        
        if (rand == 0 || rand == 2)
        {

            nav.SetDestination(P1.position);
        }
        else
        {
            nav.SetDestination(P2.position);
        }
	
	}
}
