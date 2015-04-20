using UnityEngine;
using System.Collections;

public class GoalScorer : MonoBehaviour {

    public int scoreValue = 10;

    //private PlayerHealth playerHealth;

    private AudioSource goalAudio;

    void Awake()
    {
        //playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();

        goalAudio = GetComponent<AudioSource>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            if(GameObject.FindGameObjectWithTag("Player")!=null)
            {
                ScoreManager.score += scoreValue;
            }

            GameObject.Destroy(other.gameObject);

            goalAudio.Play();
        }
    }
}
