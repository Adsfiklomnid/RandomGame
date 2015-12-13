using UnityEngine;
using System.Collections;

public class testing2dMech : MonoBehaviour {

	public bool onGround;
	public GameObject sprite;
	public GameObject spriteThreeD;
	
	public GameObject cameraTwoD;
	public GameObject cameraThreeD;
	
	public bool isThreeD;
	
	void Start () {
		//Init everything here.
		isThreeD = false;
	}
	

	void Update () {
		sprite.transform.position.x = 0;
		
		if (Input.GetKeyDown ("space")){
			if(onGround){
				sprite.rigidbody.AddForce(Vector2.up * 500);
				onGround = false;
			}
		}
		
		if(Input.GetKeyDown ("a")){
		print("a");
			sprite.rigidbody.AddForce(Vector2.right * -100);
		}
		if(Input.GetKeyDown ("d")){
		print("a");
			sprite.rigidbody.AddForce(Vector2.right * 100);
		}
		
		if(Input.GetKeyDown ("c")){
			if(isThreeD){
				cameraTwoD.SetActive(true);
				cameraThreeD.SetActive(false);
				
				spriteThreeD.SetActive(false);
				spriteTwoD.SetActive(true);
				
			}else{
				cameraTwoD.SetActive(false);
				cameraThreeD.SetActive(true);
				
				spriteTwoD.SetActive(false);
				spriteThreeD.SetActive(true);
			}
		}
		
	}
	
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "ground"){
			onGround = true;
		}
	}
}
