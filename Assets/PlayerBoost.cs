using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoost : MonoBehaviour
{
    SurfaceEffector2D surfaceEffector;

    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float normalSpeed = 18f;

    bool isAlive = true;

    public void playerCrashed()
    {
        isAlive = false;
    }

    void Start()
    {
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        if (isAlive)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                surfaceEffector.speed = boostSpeed;
            }
            else if (!(Input.GetKey(KeyCode.UpArrow)))
            {
                surfaceEffector.speed = normalSpeed;
            }
        }
    }
}
