using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plater_move : MonoBehaviour
{
    public Transform transform;
    public float speed=2f;
    public float rotationSpeed=5f;
    public Score_manege score_value;
    public Score_manege score_value2;
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Movment();
       clamp();
    




    }
    void Movment(){
         if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.position +=new Vector3(speed*Time.deltaTime,0,0);
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(0,0,-10), rotationSpeed* Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -=new Vector3(speed*Time.deltaTime,0,0);
              transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(0,0,10), rotationSpeed* Time.deltaTime);
        }
         if(transform.rotation.z !=90){
               transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(0,0,0), rotationSpeed* Time.deltaTime);
        }

    }
    void clamp(){
            if(transform.position.x<-1.70f){
            transform.position=new Vector3(-1.68f, transform.position.y,transform.position.z);
        }
         if(transform.position.x>1.70f){
            transform.position=new Vector3(1.68f, transform.position.y,transform.position.z);
        }
       


    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag=="jets"){
             Time.timeScale = 0;
            
        }
        if(collision.gameObject.tag=="Coin"){
            Destroy(collision.gameObject);
           score_value.score+=10;
            
        }
        if(collision.gameObject.tag=="food"){
            Destroy(collision.gameObject);
           score_value2.score+=20;
            
        }
       
    }
}
