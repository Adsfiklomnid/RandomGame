using UnityEngine;
using System.Collections;

public class testing2dMech : MonoBehaviour {


	public GameObject sprite;
	
	void Start () {
	
	}
	

	void Update () {
		if (Input.GetKeyDown ("space")){
		print("jump");
			sprite.rigidbody.AddForce(Vector2.up * 500);
		}
		
		if(Input.GetKeyDown ("a")){
		print("a");
			sprite.rigidbody.AddForce(Vector2.right * -50);
		}
	}
}
