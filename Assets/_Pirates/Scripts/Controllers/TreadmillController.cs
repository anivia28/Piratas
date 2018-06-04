using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreadmillController : MonoBehaviour 
{
	// [SerializeField] private Transform dockPiecePrefab;
	// [SerializeField] private int piecesCount;
	[SerializeField] private float dockOffset;
	[SerializeField] private float speed;
	private Transform[] docks;
	private Vector3 spawnPosition;

	private int piecesCount;

	// Use this for initialization
	void Start () 
	{
		// this.docks = new Transform[this.piecesCount];
		this.dockOffset = Vector3.Distance(this.transform.GetChild(0).position, this.transform.GetChild(1).position);
		Debug.Log(this.dockOffset);
		this.docks = new Transform[this.transform.childCount];
		for (int i = 0; i < this.transform.childCount; i++) 
		{
			this.docks[i] = this.transform.GetChild(i);
		}
		this.piecesCount = this.docks.Length;
		Debug.Log(this.piecesCount);
		// Vector3 dockPos = new Vector3();
		// for (int i = 0; i < this.piecesCount; i++)
		// {
		// 	dockPos = new Vector3(0, 0, i * this.dockOffset);
		// 	this.docks[i] = Instantiate(this.dockPiecePrefab, dockPos, Quaternion.identity);
		// }
		this.spawnPosition = this.docks[this.piecesCount - 1].position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		for (int i = 0; i < this.piecesCount; i++)
		{
			this.docks[i].position -= new Vector3(0, 0, Time.deltaTime * this.speed);
			if (this.docks[i].position.z <= -this.dockOffset) 
			{
				this.docks[i].position = this.spawnPosition;
			}
		}
	}
}
