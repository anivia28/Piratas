using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInstanciate : MonoBehaviour 
{
    [SerializeField] GameObject cratePrefab;
    //[SerializeField] float initTime;
    //[SerializeField] float offsetTime;
    [SerializeField] float waitTime;
    [SerializeField] float laneOffset = 0.9f;

    private float startTime;

	// Use this for initialization
	void Start () 
    {
        startTime = Time.time;
        Debug.Log(startTime);
        //StartCoroutine(CreateCoroutine());
	}

    //private IEnumerator CreateCoroutine()
    //{
    //    while(true)
    //    {
    //        int lane = Random.Range(-1, 1);
    //        Debug.Log(lane);
    //        Vector3 position = this.transform.position + new Vector3(laneOffset * lane, 0, 0);
    //        Instantiate(cratePrefab, position, Quaternion.identity);    
    //        float waitTime = (initTime / 2) + (initTime / 2 * Random.Range(0, offsetTime));
    //        yield return new WaitForSeconds(waitTime);
    //    }
    //}
	
	// Update is called once per frame
	void Update () 
    {
        if (Time.time - startTime > waitTime)
        {
            startTime = Time.time;
            int lane = Random.Range(-1, 2);
            Debug.Log(lane);
            Vector3 position = this.transform.position + new Vector3(laneOffset * lane, 0, 0);
            Instantiate(cratePrefab, position, Quaternion.identity);    
        }
	}
}
