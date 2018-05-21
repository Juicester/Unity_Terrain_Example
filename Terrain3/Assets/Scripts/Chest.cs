using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Chest : MonoBehaviour {

	public Text winText;
	public Text nextText;

	// Use this for initialization
	void Start () {
		winText.enabled = false;
	}

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.tag == "FPSPlayer") {
			nextText.enabled = false;
			winText.enabled = true;

			Destroy (gameObject);
		}
			
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
