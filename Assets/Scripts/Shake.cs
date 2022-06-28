using System.Collections;
using System.Collections.Generic;
using Unity.Profiling;
using UnityEngine;

public class Shake : MonoBehaviour
{
    private  PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveUpDown();
    }

    void MoveUpDown()
    {
        if (playerControllerScript.gameOver == false)
        {
            float shakingSpeed = Random.Range(-0.15f, 0.15f);
            transform.Translate(Vector3.up * shakingSpeed);
        }
    }
}
