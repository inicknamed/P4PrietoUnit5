using UnityEngine;

public class GameManagerDestroyer : MonoBehaviour
{
    public GameObject SpawnManager;
    private GameManager gameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
