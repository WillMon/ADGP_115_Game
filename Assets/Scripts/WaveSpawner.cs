using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WaveSpawner : MonoBehaviour {


    public enum SpawnState { SPAWNING, WAITING, COUNTING};

    //This allows you to interact with the script data inside the inspector in unity
	[System.Serializable]
    public class Wave
    {//This is optional...use this to announce which wave is coming
        public string name;

        //Reference to the prefab we want to instantiate
        public Transform enemy;

        //Number of enemies to spawn
        public int count;

        //The Rate at which the enemies spawn
        public float rate;

    }

    //Store the wave number
    public Text disWave;

    //Array of waves
    public Wave[] waves;

    //Stores the index of the wave we want to be creating next
    private int nextWave = 0;

    //Stores the current wave number to be displayed to the screen
    private int waveNum = 1;

    //Spawnpoint Locations
    public Transform[] spawnPoints;

    //Stores the time between waves
    public float timeBetweenWaves = 5f;

    //Counts down to the wave
    private float waveCountdown;

    //Set a timer to search through enemy tags per second
    private float searchCountdown = 1f;


    private SpawnState state = SpawnState.COUNTING;

    // Use this for initialization
	void Start ()
    {
        
        //Sets wave countdown to time between waves
        waveCountdown = timeBetweenWaves;
      
    }
	
	// Update is called once per frame
	void Update ()
    {
        //Display this text
        disWave.text = "Wave: " + waveNum;

        if (state == SpawnState.WAITING)
        {//Check to see if enemies are still alive

            //If no enemeies are alive...
            if (!EnemyIsAlive())
            {
                //Begin a new round
                WaveCompleted();

            }
            else
            {//If enemies are still alive
                //Display this text
                disWave.text = "";
                return;
            }

        }

        //if countdown is 0
	if(waveCountdown <= 0)
        {//if the current state is not already to spawning
            if(state != SpawnState.SPAWNING)
            {
                //Start Spawning the wave
                //StartCoroutine is for IEnumerators
                StartCoroutine(SpawnWave(waves[nextWave]));
            }
        }
    else
        {//This makes sure that the count down will go down the appropriate time for each frame
            //As well as makes the waveCountdown as time and not frames
            //This is where the countdown happens
            waveCountdown -= Time.deltaTime;
        }

	}

    //When a wave is completed
    void WaveCompleted()
    {
        //Set the state to start counting down til next wave
        state = SpawnState.COUNTING;
        //Sets countdown to the time between waves
        waveCountdown = timeBetweenWaves;

        //the next wave is greater than the number of the waves
        if(nextWave + 1 > waves.Length - 1)
        {//Set next wave to 0 because all waves have been completed
            nextWave = 0;
        }
        else
        {
            //Next wave
            nextWave++;
            waveNum++;

        }

    }

    //Checks for enemies 
    bool EnemyIsAlive()
    {
        //set searchCountdown to subtracted time
        searchCountdown -= Time.deltaTime;

        //This will only search for enemy tags every second
        //This is more effecient than allowing it to search every frame
        if (searchCountdown <= 0f)
        {
            //Reset the counter
            searchCountdown = 1f;
            //Check gameobjects that are tagged as enemy
            if (GameObject.FindGameObjectsWithTag("Enemy").Length == 0)
            {
                //This means no enemy is alive
                return false;
            }
        }
      
        return true;
    }

    //This allows methods to wait a certain amount of time before continuing...think timer for a method
    IEnumerator SpawnWave(Wave _wave)
    {
        //Now we are in a spawning state
        state = SpawnState.SPAWNING;

        //Spawn
        //Loop through number of enemies to spawn..this will keep happening until it gets to the max number we want spawned
        for (int i = 0; i < _wave.count; i++)
        {//This spawns the enemy
            SpawnEnemy(_wave.enemy);

            //Return WaitForSeconds then give it the amount of time to wait before spawning again
            yield return new WaitForSeconds(1 / _wave.rate);
        }

        //Sets spawnstate to waiting
        state = SpawnState.WAITING;

        //this means return nothing..IEnumerators must reutrn something!
        yield break;
    }

    //Function for spawning
    void SpawnEnemy(Transform _enemy)
    {
        //Random Spawn
        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
  

        //Spawn enemy
        Instantiate(_enemy, _sp.position, _sp.rotation);

    }
}
