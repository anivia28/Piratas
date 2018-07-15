using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureDisplacer : MonoBehaviour 
{
	[SerializeField] Vector2 speed;

	private Material material;

	void Start () 
	{
		this.material = GetComponent<Renderer>().material;
	}
	
	void Update () 
	{
		float d = Time.deltaTime;
		float x = this.material.mainTextureOffset.x + this.speed.x * d;
		float y = this.material.mainTextureOffset.y + this.speed.y * d;
		this.material.mainTextureOffset = new Vector2(x, y);
	}
}
