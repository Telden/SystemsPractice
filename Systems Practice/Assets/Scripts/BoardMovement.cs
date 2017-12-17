using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI
using UnityEngine;

public class BoardMovement : MonoBehaviour {

	int mDiceCounter;
	public TextMesh mDice;
	// Use this for initialization
	void Start () {
		mDiceCounter = 0;
		
	}
	
	// Update is called once per frame
	void Update () {
		increaseDice();



	}



	void increaseDice()
	{
		if(mDiceCounter < 6)
		{
			mDiceCounter++;
		}
		else
		{
			mDiceCounter = 0;
		}

		mDice.text = mDiceCounter;
	}
}
