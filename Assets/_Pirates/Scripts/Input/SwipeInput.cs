using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeInput : MonoBehaviour 
{
	[SerializeField] private Vector2 threshold;
	[SerializeField] private float disableTime;
	private bool disabled;
	private Notifier notifier;
	public const string ON_SWIPE = "OnSwipe";

	// Use this for initialization
	void Start () 
	{
		notifier = new Notifier();
		// notifier.Subscribe(ON_SWIPE, HandleOnSwipe);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!this.disabled && Input.touchCount > 0) 
		{
			this.CheckSwipe();
		}
	}

	private void HandleOnSwipe(params object[] args)
	{
		this.disabled = true;
		StartCoroutine(EnableCoroutine());	
	}

	private IEnumerator EnableCoroutine() 
	{
		yield return new WaitForSeconds(disableTime);
		this.disabled = false;
	}

	private void CheckSwipe() 
	{
		Vector2 deltaPos = Input.touches[0].deltaPosition;
		if (Mathf.Abs(deltaPos.x) > threshold.x)
		{
			if (deltaPos.x > 0)
			{
				notifier.Notify(ON_SWIPE, 'd');
				// Debug.Log("Swipe Right");
			}
			else 
			{
				notifier.Notify(ON_SWIPE, 'a');
				// Debug.Log("Swipe Left");
			}
		}
		if (Mathf.Abs(deltaPos.y) > threshold.y)
		{
			if (deltaPos.y > 0)
			{
				notifier.Notify(ON_SWIPE, 'w');
				// Debug.Log("Swipe Up");
			}
			else 
			{
				notifier.Notify(ON_SWIPE, 's');
				// Debug.Log("Swipe Down");
			}
		}
	}

	void OnDestroy()
    {
        notifier.UnsubcribeAll();
    }
}
