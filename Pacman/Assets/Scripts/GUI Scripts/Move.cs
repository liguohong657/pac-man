using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float speed;
	
	// To update te movements of the game
	void Update () 
	{
		transform.Translate(Vector3.left * speed * Time.deltaTime);
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		Destroy(gameObject);
	}
}
