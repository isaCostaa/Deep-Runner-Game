using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public AudioSource musicJump;
    public float jumpForce; //decide quando o player pode pular
    bool canJump; //decide se o player pode pular ou nao

    

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }



    void Start()
    {
        
    }

    // funcao do click do mouse 
    void Update()
    {
       if(Input.GetMouseButtonDown(0) && canJump) 
       {
          //pular
          rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
          musicJump.Play();
       }
    }

    // funcao a ser chamada quando player colidir com qualquer objeto na cena
    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.tag == "Chao")
        {
            canJump = true;
            
            
        }
    }

    // funcao a ser chamada quando player vai pular 
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Chao")
        {
            canJump = false;
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstaculo")
        {
            SceneManager.LoadScene("GameOver"); //COLOCAR AQUI A CENA GAME OVER
        }
    }

    
}
