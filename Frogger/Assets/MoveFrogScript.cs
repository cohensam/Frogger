using UnityEngine;
using System.Collections;

public class MoveFrogScript : MonoBehaviour {

	public float move;
	public int stepsForward;
	public int stepsSideways;

	// Use this for initialization
	void Start () {
		move = .5f;
		stepsForward = 0;
		stepsSideways = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow) && stepsForward < 100) {
			gameObject.transform.Translate (0, 0, move);
			stepsForward++;
		} else if (Input.GetKey (KeyCode.DownArrow) && stepsForward > 0) {
			gameObject.transform.Translate (0, 0, -move);
			stepsForward--;
		} else if (Input.GetKey (KeyCode.LeftArrow) && stepsSideways > -70) {
			gameObject.transform.Translate (-move, 0, 0);
			stepsSideways--;
		} else if (Input.GetKey (KeyCode.RightArrow) && stepsSideways < 70) {
			gameObject.transform.Translate (move, 0, 0);
			stepsSideways++;
		}
	}
 }
