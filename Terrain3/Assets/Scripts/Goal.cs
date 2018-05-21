using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Goal : MonoBehaviour {

	public Text collectText;
	public Text nextText;
	public bool hammer;

	// Use this for initialization
	void Start () {
		hammer = false;
		collectText.enabled = true;
		nextText.enabled = false;
	}

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.tag == "Hammer") {
			collectText.enabled = false;
			nextText.enabled = true;

			hammer = true;

			Destroy (other.gameObject);
		}

		if (other.gameObject.tag == "Gate" && hammer) {
			Destroy (other.gameObject);
			//other.transform.localRotation = Quaternion.Euler (0, 1, 0) * other.transform.localRotation;
		}
	}

	// Update is called once per frame
	void Update () {

		//this.transform.localRotation = Quaternion.Euler (0, 1, 0) * this.transform.localRotation;
	}
}
