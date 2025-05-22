using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEditor.VersionControl;
using UnityEngine;

public class Monster : MonoBehaviour
{
    Rigidbody2D playerRigidbody;
    ConstantForce2D customGravity;

    void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();
        customGravity = GetComponent<ConstantForce2D>();

        float gravityForceAmount = playerRigidbody.mass * Physics2D.gravity.magnitude;
        customGravity.force = new Vector2(-gravityForceAmount, 0); // gravity to the left
    }

    void Update()
    {
        //if (mass or gravity changes)
        //modify the constant force;
    }

}
