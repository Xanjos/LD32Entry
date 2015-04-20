using UnityEngine;
using System.Collections;

public class SheepSpawner : MonoBehaviour {

    private PlayerHealth playerHealth;
    public GameObject sheepObject;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;

    void Awake()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnSheep", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void SpawnSheep()
    {
        if(playerHealth.currentHealth<=0)
        {
            return;
        }

        int spawnIndex = Random.Range(0, spawnPoints.Length);

        GameObject.Instantiate(sheepObject, spawnPoints[spawnIndex].position, Quaternion.identity);
    }
}
