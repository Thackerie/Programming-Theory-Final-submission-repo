using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private float jumpHeight;
    public bool gameOver;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        gameOver = false;
        jumpHeight = 4;
    }

    // Update is called once per frame
    void Update()
    {
        Jump();//ABSTRACTION
    }
    void Jump()//ABSTRACTION
    {
        if (Input.GetKeyDown(KeyCode.Space) && !gameOver)
        {
            Vector3 jumpVel = Vector3.up * jumpHeight;
            playerRB.velocity = jumpVel;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pillar") && !gameOver)
        {
            gameOver = true;
        }
    }
}
