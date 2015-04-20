using UnityEngine;
using System.Collections;

public class ZombieAttack : MonoBehaviour {

    public float attackTime = 0.5f;
    public int damage = 10;

    GameObject player;
    PlayerHealth playerHealth;
    bool canAttack;
    float timer;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        if(player!=null)
            playerHealth = player.GetComponent<PlayerHealth>();
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        if(timer>=attackTime&&canAttack)
        {
            AttackPlayer();
        }
	
	}

    private void AttackPlayer()
    {
        timer = 0f;

        if (playerHealth.currentHealth > 0)
            playerHealth.TakeDamage(damage);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject == player)
        {
            canAttack = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject == player)
        {
            canAttack = false;
        }
    }
}
