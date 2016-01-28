using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
    public int damagePerShot = 20;
    public float timeBetweenBullets = 0.15f;
    public float range = 100f;

    float timer;
    int shootableMask;
    ParticleSystem gunPartical;
    LineRenderer gunLine;
    Light gunLight;
    float effectiveDisplayTime = 0.2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
