using System;
using Unity.VisualScripting;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody rb;     //naming it as rb
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject,2f);     // is for destroy the object and after 2 floating second


        rb = GetComponent<Rigidbody>();     // take all the power of rigidbody in rb variable
    } 

    // Update is called once per frame
    void Update()
    {

        // add some force 

        if (Input.GetKeyDown(KeyCode.Space))         // happen when user enter any key here it is space
        {
            rb.AddForce(Vector3.up * 300);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * 300);        // force providing fxn
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.AddForce(Vector3.back * 300);        // force providing fxn
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.AddForce(Vector3.left * 300);     // force providing fxn
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.AddForce(Vector3.right * 300);     // force providing fxn
        }

        rb.linearVelocity = Vector3.forward * 20f;        // velocity providing fxn

        /*
         alternet of these
         float xInput and float zInput
         public float motion
        
         use -> xInput = input.getaxis("Horizontal")
         zInput = input.getaxis("Vertical")
         rb.AddForce(xInput * motion , 0 , zInput * motion)*/
    }

    private void OnMouseDown()        // used for mouse clicking function
    {
        //Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)       // collision fxn 
    {
        if(collision.gameObject.tag == "enemy")         // tagged any object then used it 
        {
            //Destroy(gameObject);              // the other game object got destroyed
            Destroy(collision.gameObject);     // objest got destroyed 
        }
    }

    // add multiple scenes
    // file -> build -> addOpenScene -> drag the new scene
    // file addScene

    // load any scene in unity
    // using unity secenemanagement
    // scenemanager.loadscene("sceneName")

    /*
     how to put text 
     public gameObject name
     use as name.setactive(true)
    */


    /*
     spawnPoint
     spawn the object use 
     Instantiate(gameObject , spawnPoint.position , quaternion.identity(rotation))
     */


    /*
     kinda do something happen when we click mouse and all...
    like for example spawn a ball
    use 
    if(Input.getmousebuttondown(0))      ----> for left mouse button
    vector3 mousepos = Input.mousePosition
    mousepos.z - 10f
    vector3 spawnpos = camera.main.screentoworldpoint(mousepos)
    Instantiate(gameObject , spawnPoint.position , quaternion.identity(rotation))
     */
}
