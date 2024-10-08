using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 2;
    public float deathZone = -60;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < deathZone)
        {
            Debug.Log("Pipe Destroyed!");
            Destroy(gameObject);
        }
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }
}
