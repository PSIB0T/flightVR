using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class renderHeadPos : MonoBehaviour {

	// Use this for initialization
	GameObject head;
	public TextMesh text;
	void Start () {
		head = FindObjectOfType<GvrEditorEmulator>().gameObject;
		text = GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = head.transform.rotation.x + "";
	}
}
