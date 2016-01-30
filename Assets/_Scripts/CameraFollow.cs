using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(player.transform.position.x, Mathf.Clamp(player.transform.position.y,1.0f,20.0f), -2.0f);
	}
}
