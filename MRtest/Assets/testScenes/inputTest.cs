using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputTest : MonoBehaviour {
    public GameObject sphere;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void DoSome() {
        sphere.GetComponent<Transform>().position = new Vector3(0, 0, 0);
    }
}
