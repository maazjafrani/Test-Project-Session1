using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float Speed=0.1f;
    public FixedJoystick FixedJoystick;

    // Update is called once per frame
    void Update()
    {
            transform.Translate(new Vector3(0,FixedJoystick.Vertical*Speed,FixedJoystick.Horizontal*Speed));        

    }
}
