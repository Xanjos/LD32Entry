using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    public int maxHealth = 100;
    public int currentHealth;
    public Slider healthSlider;

    AudioSource playerAudioSource;
    bool isDead;
    private GameObject gameOverUI;

    void Awake()
    {
        playerAudioSource = GetComponent<AudioSource>();
        gameOverUI = GameObject.Find("GameOverUI");
        gameOverUI.SetActive(false);
        currentHealth = maxHealth;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        healthSlider.value = currentHealth;

        playerAudioSource.Play();

        if(currentHealth<=0&&!isDead)
        {
            KillPlayer();
        }
    }

    private void KillPlayer()
    {
        isDead = true;

        CameraFollow camFollow = Camera.main.GetComponent<CameraFollow>();
        camFollow.enabled = false;
              

        GameObject.Destroy(gameObject);

        gameOverUI.SetActive(true);
    }
}
