using UnityEngine;
using System.Collections;

public class BeaconSpawner : MonoBehaviour {

    public float timeToNextSpawn = 5f;

    public GameObject beaconObject;

    private float timer = 5f;

    //private int floorMask;

    float camRayLength = 50f; 

    void Awake()
    {
        //floorMask = LayerMask.GetMask("Floor");
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        if(Input.GetButtonUp("Fire1")&&timer>=timeToNextSpawn)
        {
            SpawnBeacon();
        }

	}

    private void SpawnBeacon()
    {
        

        // Create a ray from the mouse cursor on screen in the direction of the camera.
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Create a RaycastHit variable to store information about what was hit by the ray.
        RaycastHit floorHit;

        // Perform the raycast and if it hits something on the floor layer...
        if (Physics.Raycast(camRay, out floorHit, camRayLength))
        {
            if (floorHit.collider.tag!="Wall")
            {
                timer = 0f;
                Vector3 spawnPoint = floorHit.point;//-transform.position;

                // Ensure the vector is entirely along the floor plane.
                spawnPoint.y = 0f;

                GameObject.Instantiate(beaconObject, spawnPoint, Quaternion.identity);
            }
        }
    }
}
