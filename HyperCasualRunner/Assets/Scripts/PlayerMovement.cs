using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    bool right = true;
    public float speed;
    public float jumpHeight;
    public GameObject GameManager;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    
    void Update()
    {
        

        if(Input.GetKeyDown(KeyCode.D)){
            right = true;
        }

        if(Input.GetKeyDown(KeyCode.A)){

            right = false; 
        }

        if(right){

            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x,transform.position.y,-2.6f),Time.deltaTime*2.0f);
        }

        else
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x,transform.position.y,2.6f),Time.deltaTime * 2.0f);
        }
         if(Input.GetKeyDown(KeyCode.Space) ){

            rb.AddForce(new Vector3(0,5,0),ForceMode.Impulse);
        }


        transform.Translate(0,0,1 * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "finish")
        {
            GameManager.SetActive(true);
            Time.timeScale=0;
        }
        
    }

    
}
