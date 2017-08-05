using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
	public GameObject coinPoofInstance;
	public Text coinCountScore;

	public void OnCoinClicked ()
	{
		CopyObjectStateTo (coinPoofInstance);
		IncrementCoinCounter ();
		GameObject.Instantiate (coinPoofInstance);
		Destroy (this.gameObject);
	}

	public void IncrementCoinCounter ()
	{
		CoinCounter coinCountingScript = coinCountScore.GetComponent<CoinCounter> ();
		coinCountingScript.IncrementCoinCount ();
	}

	private void CopyObjectStateTo (GameObject targetGameObject)
	{
		targetGameObject.transform.position = this.transform.position;
		targetGameObject.transform.rotation = this.transform.rotation;
	}

}
