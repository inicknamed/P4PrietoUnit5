using NUnit.Framework.Internal;
using UnityEngine;
using UnityEngine.UI;
public class DifficultButton : MonoBehaviour
{
    private Button button;
    private GameManager GameManager;
    public int difficulty;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        GameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " was clicked");
        GameManager.StartGame(difficulty);
    }
}
