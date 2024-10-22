using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");

        
        Vector2 moveVelocity = new Vector2(moveInput * moveSpeed, 0);
        transform.Translate(moveVelocity * Time.deltaTime);
    }
}
