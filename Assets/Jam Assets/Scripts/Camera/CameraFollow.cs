using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    public float smoothing = 5f;

    private Transform player;
    private Vector3 offset;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

	// Use this for initialization
	void Start () {

        offset = transform.position - player.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        Vector3 targetCamPos = player.position + offset;

        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
	
	}
}
