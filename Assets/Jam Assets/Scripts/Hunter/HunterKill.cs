using UnityEngine;
using System.Collections;

public class HunterKill : MonoBehaviour {

    public GameObject zombieObject;

    private AudioSource hunterAudio;

    void Awake()
    {
        hunterAudio = GetComponent<AudioSource>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag=="Food")
        {
            hunterAudio.Play();
            Vector3 spawnPos = other.transform.position;

            spawnPos.y=0f;

            GameObject.Destroy(other.gameObject);

            GameObject.Instantiate(zombieObject, spawnPos, Quaternion.identity);
        }
    }
}
