using UnityEngine;
using System.Collections;

public class EnemyManeger : MonoBehaviour {

    public HealthScript playerHealth;
    public GameObject enemy;
    public float spawnTime = 3f;
    public Transform[] spawnPoint;
	// Use this for initialization
	void Start () {
        InvokeRepeating("Spawn", spawnTime, spawnTime);

	}
    void Spwan()
    {
        if(playerHealth.currentHealth <= 0f)
        {
            return;
        }
        int spawnsPointIndex = Random.Range(0, spawnPoint.Length);
        Instantiate(enemy, spawnPoint[spawnsPointIndex].position, spawnPoint[spawnsPointIndex].rotation);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
