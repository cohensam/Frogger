using UnityEngine;
using System.Collections;

public class MoveLeftScript : MonoBehaviour {

	public float move;

	// Use this for initialization
	void Start () {
		move = -.05f;
	}
	
	// Update is called once per frame
	void Update () {
		//if (gameObject.hits screen end collider, then put at x position -39.38337
		gameObject.transform.Translate (0, 0, move);
	}
}
