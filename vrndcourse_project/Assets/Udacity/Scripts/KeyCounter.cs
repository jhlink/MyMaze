using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyCounter: MonoBehaviour
{

	public Text keyCounterScore;

	// Use this for initialization
	void Start ()
	{
		keyCounterScore.text = "Key Found: No";
	}

	public void foundKey() {
		keyCounterScore.text = "Key Found: Yes";
	}

}
