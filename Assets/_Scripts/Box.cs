using UnityEngine;
using System.Collections;

public class Box : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, -0.1f);
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
    }
}
