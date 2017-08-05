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

	public void OnKeyClicked ()
	{
		// Instatiate the KeyPoof Prefab where this key is located
		// Make sure the poof animates vertically
		// Call the Unlock() method on the Door
		// Set the Key Collected Variable to true
		// Destroy the key. Check the Unity documentation on how to use Destroy

		if (!keyCollected) {
			UpdateKeyScoreUI ();
			CopyObjectStateTo (keyPoofInstance);
			GameObject.Instantiate (keyPoofInstance);
			Unlock ();
			keyCollected = true;
			Destroy (this.gameObject);
		}

	}

	public void UpdateKeyScoreUI ()
	{
		KeyCounter coinCountingScript = keyFoundUI.GetComponent<KeyCounter> ();
		coinCountingScript.FoundKey ();
	}


	private void CopyObjectStateTo (GameObject targetGameObject)
	{
		targetGameObject.transform.position = this.transform.position;
		targetGameObject.transform.rotation = this.transform.rotation;
	}

	public void Unlock ()
	{
		doorInstance.Unlock ();
	}

}
