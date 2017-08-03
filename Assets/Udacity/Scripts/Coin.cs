using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
	public GameObject coinPoofInstance;

    public void OnCoinClicked() {
		copyObjectStateTo (coinPoofInstance);
		GameObject.Instantiate (coinPoofInstance);
		Destroy (this.gameObject);
    }

	private void copyObjectStateTo(GameObject targetGameObject) {
		targetGameObject.transform.position = this.transform.position;
		targetGameObject.transform.rotation = this.transform.rotation;
	}

}
