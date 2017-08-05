using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter: MonoBehaviour
{

	public Text coinCountScore;
	private int coinCount = 0;

	// Use this for initialization
	void Start ()
	{
		coinCountScore.text = "Coins: 0";
	}

	public void IncrementCoinCount ()
	{
		coinCount++;
	}

	void Update ()
	{
		coinCountScore.text = "Coins: " + coinCount;
	}

}
