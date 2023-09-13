using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    Rigidbody2D rigidBody2D;
    [SerializeField] float torqueAmount = 2f;

    bool isAlive = true;

    public void playerCrashed()
    {
        isAlive = false;
    }

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isAlive)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rigidBody2D.AddTorque(torqueAmount);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                rigidBody2D.AddTorque(-torqueAmount);
            }
        }
    }
}
