using UnityEngine;
using System.Collections;

public class Lever : MonoBehaviour
{
    public GameObject activator;
    public Sprite pulled;
    private bool pulledLever;
	// Use this for initialization
	void Start ()
    {
        pulledLever = false;
    }
	
	void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player")&&!pulledLever)
        {
            activator.SendMessage("Activate");
            pulledLever = true;
            GetComponent<SpriteRenderer>().sprite = pulled;
        }
            
    }
}
