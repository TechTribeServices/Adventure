using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : PhysicsObject
{
    [SerializeField] private float maxSpeed = 4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        targetVelocity = new Vector2(Input.GetAxis("Horizontal") * maxSpeed, 0);
        // if the player press "jump", set the velocity to a jump prower value
        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            velocity.y = 10;
        }
    }
}
