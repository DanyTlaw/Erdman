using UnityEngine;
using System.Collections;

public class CharController : MonoBehaviour {

	public float maxSpeed = 10f;
	public float speed = 0.5f;


	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		anim.SetBool ("isLeft", true);
	}


	void FixedUpdate(){

		if(Input.GetKey("left") && !Input.GetKey("right") && !Input.GetKey("up") && !Input.GetKey("down")){
			anim.SetBool ("isLeft",true);
			anim.SetBool ("isRight", false);
			anim.SetBool ("isTop",false);
			anim.SetBool ("isDown", false);
		
			anim.SetBool("walkLeft", true);
			
			rigidbody2D.velocity = new Vector2(-speed * maxSpeed, rigidbody2D.velocity.y);
			
		}


		else if(Input.GetKey("right") && !Input.GetKey("left") && !Input.GetKey("up") && !Input.GetKey("down")){
			anim.SetBool ("isLeft",false);
			anim.SetBool ("isRight", true);
			anim.SetBool ("isTop",false);
			anim.SetBool ("isDown", false);

			anim.SetBool ("walkRight",true);
			
			rigidbody2D.velocity = new Vector2(speed * maxSpeed, rigidbody2D.velocity.y);
		}

	

		else if(Input.GetKey("up") && !Input.GetKey("left") && !Input.GetKey("right") && !Input.GetKey("down")){
			anim.SetBool ("isLeft",false);
			anim.SetBool ("isRight", false);
			anim.SetBool ("isTop",true);
			anim.SetBool ("isDown", false);

			anim.SetBool ("walkTop",true);
			
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x,speed * maxSpeed);
			
		}


		else if(Input.GetKey("down") && !Input.GetKey("right") && !Input.GetKey("left") && !Input.GetKey("up")){
			anim.SetBool ("isLeft",false);
			anim.SetBool ("isRight", false);
			anim.SetBool ("isTop",false);
			anim.SetBool ("isDown", true);

			anim.SetBool ("walkDown",true);
			
			rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x,-speed * maxSpeed);

		}
		else{
			anim.SetBool ("walkLeft",false);
			anim.SetBool ("walkRight",false);
			anim.SetBool ("walkTop",false);
			anim.SetBool ("walkDown",false);

			rigidbody2D.velocity = new Vector2(0,0);
		}





	}
}