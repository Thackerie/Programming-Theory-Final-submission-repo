using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float leftBound = -20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckBounds();
    }
    void CheckBounds()
    {
        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}
