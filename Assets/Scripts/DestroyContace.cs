using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyContace : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Boundary")
	{
		return;
	}
		Destroy (other.gameObject);
		Destroy (gameObject);
		
	}
}
