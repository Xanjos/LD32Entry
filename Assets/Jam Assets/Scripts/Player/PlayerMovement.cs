using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 6f;

    Rigidbody playerRigidbody;
    Vector3 movementVector;

    void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        MovePlayer(h, v);
	
	}

    private void MovePlayer(float h, float v)
    {
        movementVector.Set(h, 0f, v);

        movementVector = movementVector.normalized * moveSpeed * Time.deltaTime;

        playerRigidbody.MovePosition(transform.position + movementVector);
    }
}
