using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
	public GameObject keyPoofInstance;
	public Door doorInstance;
	public Text keyFoundUI;

	private bool keyCollected = false;

	void Update ()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked ()
	{
		// Instatiate the KeyPoof Prefab where this key is located
		// Make sure the poof animates vertically
		// Call the Unlock() method on the Door
		// Set the Key Collected Variable to true
		// Destroy the key. Check the Unity documentation on how to use Destroy

		if (!keyCollected) {
			updateKeyScoreUI ();
			copyObjectStateTo (keyPoofInstance);
			GameObject.Instantiate (keyPoofInstance);
			Unlock ();
			keyCollected = true;
			Destroy (this.gameObject);
		}

	}

	public void updateKeyScoreUI() {
		KeyCounter coinCountingScript = keyFoundUI.GetComponent<KeyCounter> ();
		coinCountingScript.foundKey ();
	}


	private void copyObjectStateTo (GameObject targetGameObject)
	{
		targetGameObject.transform.position = this.transform.position;
		targetGameObject.transform.rotation = this.transform.rotation;
	}

	public void Unlock ()
	{
		doorInstance.Unlock ();
	}

}
