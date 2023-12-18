using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // velocidade
    public float speed;
    


    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        
    }


    private void OnBecameInvisible()
    {
        
        Destroy(gameObject, 0.1f);

    }
}
