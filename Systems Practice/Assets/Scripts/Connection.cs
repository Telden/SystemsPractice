using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connection : MonoBehaviour {
	[SerializeField]
	Node mFrom;
	[SerializeField]
	Node mTo;
	[SerializeField]
	float mConnectionCost;

	// Use this for initialization
	void Start () {
		
	}


	public Node getFrom()
	{
		return mFrom;
	}

	public Node getTo()
	{
		return mTo;
	}

	public float getConnectionCost()
	{
		return mConnectionCost;
	}
}
