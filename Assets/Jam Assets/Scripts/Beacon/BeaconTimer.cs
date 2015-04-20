using UnityEngine;
using System.Collections;

public class BeaconTimer : MonoBehaviour {

    public float timeToDestruction = 10f;

	// Use this for initialization
	void Start () {
        GameObject.Destroy(gameObject, timeToDestruction);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
