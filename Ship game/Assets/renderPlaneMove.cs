using UnityEngine;

public class renderPlaneMove : MonoBehaviour {

	public float frec = 1f;
	public float heigtOffset = 3f;
	public float scale = 1f;
	private float var = 0;
	private Vector3 newPos = Vector3.zero;
	void Update () {
		
		newPos.Set(this.transform.position.x, heigtOffset + scale * Mathf.Sin(frec * var), this.transform.position.z);
		var += 0.1f * Time.deltaTime;
		transform.position = newPos;
	}
}
