using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour 
{
	[SerializeField] private AudioClip sceneLoop;
	
	// Use this for initialization
	void Start () 
	{
		AudioManager.Instance.PlayLoop2D("Scene Loop", sceneLoop, 0.5f);
	}	
	
	// Update is called once per frame
	void Update () {
		
	}
}
