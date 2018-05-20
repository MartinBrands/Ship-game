using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRender : MonoBehaviour {


    public Transform target;
    public Vector3 orientation;
    public Vector3 position;

	void Start () {
        
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.rotation = Quaternion.Euler(orientation);
        transform.position = target.position + position;
    }
}
