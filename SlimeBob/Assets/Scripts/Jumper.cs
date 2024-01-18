using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField] GameObject platform;
    [SerializeField] float xSpeed = 1;
    [SerializeField] float ySpeed = 5;
    float jumpTime = 100;
    [SerializeField] float delay;

    private void Update()
    {
        if(Time.time >= jumpTime + delay)
        {
            Destroy(platform.gameObject);
        }
    }

    private void OnMouseDown()
    {
        platform.GetComponent<Rigidbody2D>().velocity = new Vector2 (xSpeed, ySpeed);
        jumpTime = Time.time;
    }
}
