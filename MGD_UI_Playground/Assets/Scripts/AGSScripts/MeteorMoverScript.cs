using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMoverScript : MonoBehaviour
{ 
    //float time = 0;
    public float speed = 25f;
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        // getSpeed = FindObjectOfType<AGSGameManagerScript>();

        rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = new Vector2(0, -speed); //Initial velocity for the meteor
    }

    // Update is called once per frame
    void Update()
    {
        /*time += Time.deltaTime;

        if(time == 1f)
        {
            speed += speed * 2;
            time = 0f;
        }*/
    }
}
