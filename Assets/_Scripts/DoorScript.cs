using UnityEngine;
using System.Collections;

public class DoorScript : MonoBehaviour
{
    public Sprite doorOpen;
	void Activate()
    {
        GetComponent<SpriteRenderer>().sprite = doorOpen;
    }
}
