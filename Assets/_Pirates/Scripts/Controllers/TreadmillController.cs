using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreadmillController : MonoBehaviour 
{
	[SerializeField] private float dockOffset;
	[SerializeField] private float speed;
	private Transform[] docks;
	private Vector3 spawnPosition;

	private int piecesCount;

	void Start () 
	{
		this.dockOffset = Vector3.Distance(this.transform.GetChild(0).localPosition, this.transform.GetChild(1).localPosition);
		Debug.Log(this.dockOffset);
		this.docks = new Transform[this.transform.childCount];
		for (int i = 0; i < this.transform.childCount; i++) 
		{
			this.docks[i] = this.transform.GetChild(i);
		}
		this.piecesCount = this.docks.Length;
		Debug.Log(this.piecesCount);
		this.spawnPosition = this.docks[this.piecesCount - 1].localPosition;
	}
	
	void Update () 
	{
		for (int i = 0; i < this.piecesCount; i++)
		{
			this.docks[i].localPosition -= new Vector3(0, 0, Time.deltaTime * this.speed);
			if (this.docks[i].localPosition.z <= -this.dockOffset) 
			{
				this.docks[i].localPosition = this.spawnPosition;
			}
		}
	}
}
