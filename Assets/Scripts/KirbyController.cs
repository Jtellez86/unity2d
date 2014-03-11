using UnityEngine;
using System.Collections;

public class KirbyController : MonoBehaviour {

	public float maxSpeed = 1.0f;
	bool isFacingRight = true;

	Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float move = Input.GetAxis("Horizontal");

		animator.SetFloat("Speed", Mathf.Abs(move));

		rigidbody2D.velocity = new Vector2 (move * maxSpeed, rigidbody2D.velocity.y);

		if (move > 0 && !isFacingRight) {
			flip ();		
		} else if (move < 0 && isFacingRight) {
			flip ();		
		}
	
	}

	void flip(){
		isFacingRight = !isFacingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;

	}
}
