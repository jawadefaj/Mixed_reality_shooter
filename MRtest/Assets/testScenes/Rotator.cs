using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public GameObject[] Cube;
    public GameObject PlayerObject;
    public float rad;
	// Use this for initialization
	void Start () {
        

	}
	
	// Update is called once per frame
	void Update () {
        foreach(GameObject cube in Cube)
        {
            cube.transform.RotateAround(PlayerObject.transform.position, Vector3.up, Random.RandomRange(0.1f, 0.5f));
        }
           
    }
}
