using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
    // Start is called before the first frame update
    private Button difficultyBtn;
    public int difficultyIndex;
    private GameManager gameManager;
    void Start()
    {
        difficultyBtn = GetComponent<Button>();
        difficultyBtn.onClick.AddListener(setDifficulty);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void setDifficulty(){
        Debug.Log(difficultyBtn.gameObject.name + " was clicked");
        gameManager.startGame(difficultyIndex);
    }
}
