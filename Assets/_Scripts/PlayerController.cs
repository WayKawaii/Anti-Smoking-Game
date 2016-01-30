using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	public int hp,score;
	public float speed;
	private Rigidbody rb;
    private bool canJump;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
        canJump = true;
	}
        
    void CanJump()
    {
        canJump = true;
    }

	void Update()
	{


        //Vector3 movement = new Vector3(horizontal * speed, transform.position.y, 0.0f);
        //rb.velocity = movement;
        if (Input.GetKey(KeyCode.A))
            rb.AddForce(-speed, 0.0f, 0.0f);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(speed, 0.0f, 0.0f);
        //Debug.Log(rb.velocity.y);
        /*if (canJump == false && rb.velocity.y < 0.00000000000000001f)
        {
            canJump = true;
        }*/
        if (canJump && (Input.GetButton("Jump")||Input.GetKey(KeyCode.W)))
        {
            rb.AddForce(0, 400, 0);
            canJump = false;
        }
        rb.velocity = new Vector3(Mathf.Clamp(rb.velocity.x, -1.0f, 1.0f), Mathf.Clamp(rb.velocity.y, -5.0f, 5.0f), 0.0f);
        rb.position = new Vector3(transform.position.x, transform.position.y, -0.2f);
        transform.rotation = Quaternion.Euler(0.0f,0.0f,0.0f);
        //Debug.Log(canJump);
    }
    /*void OnCollisionEnter(Collision other)
    {
        Debug.Log("Hit");
        if(other.tag==("Platform"))
        {
            canJump = true;
        }
    }*/

    void ScoreIncrease(int s)
    {
        score += s;
    }
}
