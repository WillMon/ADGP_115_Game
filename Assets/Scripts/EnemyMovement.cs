using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform P1;
    Transform P2;
    NavMeshAgent nav;
    Animator anim;

    GameObject pH1;
    GameObject pH2;
    float rand;
    bool alive = true;
    // Use this for initialization

    void Start()
    {
        P1 = GameObject.FindGameObjectWithTag("Player").transform;
        P2 = GameObject.FindGameObjectWithTag("Player2").transform;

        anim = GetComponent<Animator>();

        //Players are alive when game startsi
        nav = GetComponent<NavMeshAgent>();
        rand = Random.Range(0, 4);
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Locate();

    }




    void Locate()
    { 

        

        if (rand == 0 || rand == 2)
        {
            if (P1 != null)
            {

                if (P1.GetComponent<HealthScript>().currentHealth > 0)
                {
                    nav.SetDestination(P1.position);
                }
            }
        }
        else
        {
            if (P2 != null)
            {
                if (P2.GetComponent<HealthScript>().currentHealth > 0)
                {
                    nav.SetDestination(P2.position);
                }
            }

        }
    }
}
    //bool checkdead(int num)
    //{
    //    if (num <= 0)
    //        return false;

    //    return ;
    //}
    //void Locate()
    //{
    //    int p1cHealth, p2cHealth;
    //    if (P1 != null)
    //    {
    //        p1cHealth = P1.GetComponent<HealthScript>().currentHealth;
    //        alive = checkdead(p1cHealth);
    //    }
    //    if (P2 != null)
    //    {
    //        p2cHealth = P2.GetComponent<HealthScript>().currentHealth;
    //        alive = checkdead(p2cHealth);
    //    }

