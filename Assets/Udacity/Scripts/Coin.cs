using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour 
{
	public GameObject coinPoofInstance;
	public Text coinCountScore;

    public void OnCoinClicked() {
		copyObjectStateTo (coinPoofInstance);
		incrementCoinCounter ();
		GameObject.Instantiate (coinPoofInstance);
		Destroy (this.gameObject);
    }

	public void incrementCoinCounter() {
		CoinCounter coinCountingScript = coinCountScore.GetComponent<CoinCounter> ();
		coinCountingScript.incrementCoinCount ();
	}

	private void copyObjectStateTo(GameObject targetGameObject) {
		targetGameObject.transform.position = this.transform.position;
		targetGameObject.transform.rotation = this.transform.rotation;
	}

}
