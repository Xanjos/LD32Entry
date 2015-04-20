using UnityEngine;
using System.Collections;

public class GoalSpawner : MonoBehaviour {

    private PlayerHealth playerHealth;
    public GameObject goalObject;
    public float spawnTime = 30f;
    public Transform[] spawnPoints;
    int currentSpawnPoint;

    void Awake()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

	// Use this for initialization
	void Start () {

        InvokeRepeating("SpawnGoal", spawnTime, spawnTime);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SpawnGoal()
    {
        if (playerHealth.currentHealth <= 0)
        {
            return;
        }

        bool isGenerating=true;

        do
        {
            int spawnIndex = Random.Range(0, spawnPoints.Length);
            if (spawnIndex != currentSpawnPoint)
            {
                currentSpawnPoint = spawnIndex;
                isGenerating = false;
            }
        }
        while (isGenerating);


        GameObject goal = GameObject.FindGameObjectWithTag("Goal");

        if (goal != null)
        {
            goal.transform.position = spawnPoints[currentSpawnPoint].position;
        }
        else
        {
            GameObject.Instantiate(goalObject, spawnPoints[currentSpawnPoint].position, Quaternion.identity);
        }
    }
}
