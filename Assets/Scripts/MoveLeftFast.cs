using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveLeftFast : MoveLeft//INHERITANCE
{
    private float fastSpeed = 0.20f;
    private new PlayerController playerControllerScript; 
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Moveleft();
    }

    public override void Moveleft()//POLYMORPHISM
    {
        if (playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * fastSpeed);
        }
    }
}
