using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfGameOver();
    }

    void CheckIfGameOver()
    {
        if(playerControllerScript.gameOver == true)
        {
            SetGameOverScene();
        }
    }
    void SetGameOverScene()
    {
        SceneManager.LoadScene(2);
    }
}
