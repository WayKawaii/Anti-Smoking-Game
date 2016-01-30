using UnityEngine;
using System.Collections;

public class PlatformScript : MonoBehaviour
{
    GameObject player;
    Rigidbody rb;
    Collider collision;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.Find("Player");
        rb = player.GetComponent<Rigidbody>();
        collision = GetComponent<Collider>();
	}   
	
	// Update is called once per frame
	void Update ()
    {
        if (rb.velocity.y < 0 && player.transform.position.y > transform.position.y+0.15f)
            collision.enabled = true;
        else
            collision.enabled = false;
    }
}
