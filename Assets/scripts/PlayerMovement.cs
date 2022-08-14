using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed=0.1f;
    public FloatingJoystick floatingJoystick;

    // Update is called once per frame
    void Update()
    {
            transform.Translate(new Vector3(0,floatingJoystick.Vertical*Speed,floatingJoystick.Horizontal*Speed));        

    }

    private const string EnemyTag="EnemyTag";

    private void OnCollisionEnter(Collision collision){
        Debug.LogError($"Cube: OnCollisionEnter() || {collision.gameObject.name}");

        if(collision.gameObject.tag==EnemyTag){
            Debug.LogError("Object Collided with enemy!");
        }
    }

    private void OnCollisionExit(Collision other){
        Debug.LogError("Cube: OnCollisionExit()");
        
    }

}
