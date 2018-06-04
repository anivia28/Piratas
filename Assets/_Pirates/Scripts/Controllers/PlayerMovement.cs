using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
	[SerializeField] private float laneOffset;
	[SerializeField] private int lane;
	// [SerializeField] private AudioClip jumpAudioFX;
	// [SerializeField] private AudioClip dashAudioFX;
	private Rigidbody rigidbody;
	// Use this for initialization
	void Start () 
	{
		this.lane = 0;
		this.rigidbody = GetComponent<Rigidbody>();
	}

	public void Jump() 
	{
		// AudioManager.Instance.PlayOneShoot2D(jumpAudioFX);
		this.rigidbody.AddForce(new Vector3(0, 1));	
	}

	public void Dash() 
	{
		// AudioManager.Instance.PlayOneShoot2D(dashAudioFX);
	}

	public void MoveLeft()
	{
		if (lane > -1)
		{
			this.lane--;
			this.transform.Translate(new Vector3(-this.laneOffset, 0, 0));
		}
	}

	public void MoveRight()
	{
		if (lane < 1)
		{
			this.lane++;
			this.transform.Translate(new Vector3(this.laneOffset, 0, 0));
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
