using UnityEngine;
using System.Collections;

public class RotateAvatar : MonoBehaviour {

    protected Transform m_transform;

	// Use this for initialization
	void Start () {

        m_transform = this.transform;
	}
	
	// Update is called once per frame
	void Update () {

        m_transform.Rotate(new Vector3(0, 10 * Time.deltaTime, 0));
	
	}
}
