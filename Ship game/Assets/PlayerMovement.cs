using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public new Rigidbody rigidbody;
    private Vector3 moveUp = new Vector3(10, 0, 10);
    private Vector3 moveDown = new Vector3(-10, 0, -10);
    private Vector3 moveLeft = new Vector3(-10, 0, 10);
    private Vector3 moveRight = new Vector3(10, 0, -10);
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        if(Input.GetKey(KeyCode.UpArrow) )
        {
            //rigidbody.AddForce(100,0,0);
            transform.Translate(moveUp * Time.deltaTime);
            //playerPosition.position = playerPosition.position + moveUp * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(moveDown * Time.deltaTime);
            //playerPosition.position = playerPosition.position + moveDown * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(moveLeft * Time.deltaTime);
            //playerPosition.position = playerPosition.position + moveLeft * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(moveRight * Time.deltaTime);
            //playerPosition.position = playerPosition.position + moveRight * Time.deltaTime;
        }

    }
}
