using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour 
{
	[SerializeField] private PlayerMovement playerMovement;
	// TODO: Change notifier for C# native events
	private Notifier notifier;

	// Use this for initialization
	void Start () 
	{
		notifier = new Notifier();
		notifier.Subscribe(SwipeInput.ON_SWIPE, HandleOnInput);
		notifier.Subscribe(KeyboardInput.ON_PRESSED, HandleOnInput);
	}

	private void HandleOnInput(params object[] args)
	{
		char direction = (char)args[0];
		switch(direction)
		{
			case 'w':
				this.playerMovement.Jump();
				Debug.Log("Jump");
				break;
			case 'd':
				this.playerMovement.MoveRight();
				Debug.Log("Move Left");
				break;
			case 's':
				this.playerMovement.Dash();
				Debug.Log("Dash");
				break;
			case 'a':
				this.playerMovement.MoveLeft();
				Debug.Log("Move Right");
				break;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnDestroy()
    {
        notifier.UnsubcribeAll();
    }
}
