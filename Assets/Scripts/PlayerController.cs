using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    
    void Start()
    {
        
    }

   
    void Update()
    {
        transform.Translate(Vector3.right * speed);
    }
}
