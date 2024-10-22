using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject[] candyPrefabs; 
    public float spawnInterval = 1f; 
    public float spawnRangeX = 8f;
    public float fallSpeed = 5f; 
    public float despawnY = -6f;
    
    void Start()
    {
        InvokeRepeating("SpawnCandy", 0f, spawnInterval);
    }

   
    void Update()
    {
        if (transform.position.y < despawnY)
        {
            Destroy(gameObject); 
        }
    }

    void SpawnCandy()
    {
        
        int randomIndex = Random.Range(0, candyPrefabs.Length);
        GameObject candy = Instantiate(candyPrefabs[randomIndex]);

        
        float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        candy.transform.position = new Vector3(spawnPosX, 6f, 0); 
        
        Rigidbody2D rb = candy.AddComponent<Rigidbody2D>();
        rb.gravityScale = 1f; 
        rb.velocity = new Vector2(0, -fallSpeed);
    }
}
