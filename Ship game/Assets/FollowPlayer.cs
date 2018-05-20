using UnityEngine;

public class FollowPlayer : MonoBehaviour {


    public GameObject player;
    [SerializeField]
    private Vector3 offset = new Vector3(0, 30, -30);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = player.transform.position + offset;
	}
}
