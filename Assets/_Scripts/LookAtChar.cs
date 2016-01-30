using UnityEngine;
using System.Collections;

public class LookAtChar : MonoBehaviour
{
    private GameObject player;

	void Start ()
    {
        player = GameObject.Find("Player");
    }
	

	void Update ()
    {
        if (player.transform.position.x > transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);   
        }
        else
        {
            transform.rotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
        }
    }
}
