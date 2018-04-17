using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballmovement : MonoBehaviour {

	public Rigidbody rb1;
	public float speed;
	private int count;
	public Text countText;
	public Text winText;


	// Use this for initialization
	void Start () {
		rb1 = GetComponent<Rigidbody> ();
		count = 0;
		countText.text = "Scores :" + count.ToString();
		winText.text = "";
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float mh = Input.GetAxis ("Horizontal");
		float mv = Input.GetAxis ("Vertical");
		Vector3 move = new Vector3 (mh,0.0f,mv);
		rb1.AddForce (move * speed);
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("Pick")) {
			other.gameObject.SetActive (false);
			count = count + 5;
			countText.text = "Scores :" + count.ToString();

		}
	}
}
