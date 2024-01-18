using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField] GameObject destination;
    [SerializeField] float xMove = -1;
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.transform.position = new Vector3 (destination.transform.position.x + xMove, destination.transform.position.y, 0);
        }
    }
}
