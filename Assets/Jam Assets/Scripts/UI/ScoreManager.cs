using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public static int score;

    Text scoreText;

    void Awake()
    {
        scoreText = GetComponent<Text>();

        score = 0;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score;
	}
}
