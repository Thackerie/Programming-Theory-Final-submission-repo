using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    protected float speed;//ENCAPSULATION
    protected PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.15f;
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Moveleft();
    }

    public virtual void Moveleft()//POLYMORPHISM
    {
        if(playerControllerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed); 
        }
    }
}
