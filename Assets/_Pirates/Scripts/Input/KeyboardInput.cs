using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour 
{
	private Notifier notifier;
	public const string ON_PRESSED = "OnPressed";

	// Use this for initialization
	void Start () 
	{
		notifier = new Notifier();
	}
	
	// Update is called once per frame
	void Update () 
	{
		this.CheckKeys();		
	}

	private void CheckKeys() 
	{
		if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
		{
			notifier.Notify(ON_PRESSED, 'w');
			// Debug.Log("Pressed Up");
		}
		else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
		{
			notifier.Notify(ON_PRESSED, 's');
			// Debug.Log("Pressed Down");
		}
		else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
		{
			notifier.Notify(ON_PRESSED, 'a');
			// Debug.Log("Pressed Left");
		}
		else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
		{
			notifier.Notify(ON_PRESSED, 'd');
			// Debug.Log("Pressed Right");
		}
	}
	
	void OnDestroy()
    {
        notifier.UnsubcribeAll();
    }
}
