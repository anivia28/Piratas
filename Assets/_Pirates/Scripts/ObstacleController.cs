using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour 
{
    [SerializeField] private float speed;
    [SerializeField] private bool destructable;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "Player")
        {
            if (destructable)
                Destroy(this.gameObject);
            else
                Destroy(collision.gameObject);
        }
    }

    void Start () 
    {
		
	}
	
	void Update () 
    {
        this.transform.position -= new Vector3(0, 0, Time.deltaTime * this.speed);	
	}
}
