using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
    public int damagePerShot = 20;
    public float timeBetweenBullets = 0.15f;
    public float range = 100f;

    float timer;
    Ray shootRay;
    RaycastHit shootHit;
    int shootableMask;
    ParticleSystem gunPartical;
    LineRenderer gunLine;
    Light gunLight;
    float effectiveDisplayTime = 0.2f;

	// Use this for initialization
	void Start () {
        shootableMask = LayerMask.GetMask("Shootable");
        gunPartical = GetComponent<ParticleSystem>();
        gunLine = GetComponent<LineRenderer>();
        gunLight = GetComponent<Light>();
	}

    // Update is called once per frame
    void Update() {

        //Add the time since Update was last called to the timer
        timer += Time.deltaTime;

        // if player presses the left shift player 1 will shoot 
        if (Input.GetButton("Fire1") && timer >= timeBetweenBullets)
        {
            Shoot();
        }
        

        if (timer >= timeBetweenBullets * effectiveDisplayTime)
        {
            DisableEffect();
        }
    }

    // Disables the detection line if its not being used 
    public void DisableEffect()
    {
        gunLine.enabled = false;
        gunLight.enabled = false;

    }
    // Detects where it hit something or not
    void Shoot()
    {
        timer = 0f;
        gunLight.enabled = true;
        //shots gun particals 
        gunPartical.Stop();
        gunPartical.Play();

        //enables the gunLine  to detect whether or not it hit something
        gunLine.enabled = true;
        gunLine.SetPosition(0, transform.position);
        shootRay.origin = transform.position;
        shootRay.direction = transform.forward;

        // Looks for the enemy healthscrip and deals the dmg 
        if (Physics.Raycast(shootRay, out shootHit, range, shootableMask))
        {
            EnemyHealth enemyHealth = shootHit.collider.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                enemyHealth.TakeDamage(damagePerShot);
            }
            gunLine.SetPosition(1, shootHit.point);
        }
        // Line stops at where it ends at
        else {
            gunLine.SetPosition(1, shootRay.origin + shootRay.direction * range);
        }
    }
	
}
