using UnityEngine;
using System.Collections;

public class MainMenuUIManager : MonoBehaviour {

    private GameObject main, instructions, credits;

    void Awake()
    {
        main = transform.FindChild("Main").gameObject;
        instructions = transform.FindChild("Instructions").gameObject;
        credits = transform.FindChild("Credits").gameObject;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayGame()
    {
        Application.LoadLevel("game");
    }

    public void Instructions()
    {
        main.SetActive(false);
        instructions.SetActive(true);
    }

    public void Credits()
    {
        main.SetActive(false);
        credits.SetActive(true);
    }

    public void MainMenu()
    {
        instructions.SetActive(false);
        credits.SetActive(false);
        main.SetActive(true);
    }
}
