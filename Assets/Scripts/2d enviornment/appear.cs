using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class appear : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera _theCamera;
    private float _HalfHeight;
  	private float _HalfWidth;
    public float xxx;
    //private Vector3 newlocation;
    void Start()
    {
      //get camera width
      _HalfHeight = _theCamera.orthographicSize;
  		_HalfWidth = _HalfHeight * Screen.width / Screen.height;
      _theCamera = GetComponent<Camera> ();
    }

    // Update is called once per frame
    void Update(){

    }

    void OnTriggerEnter2D()
    {
      transform.position = new Vector3 (transform.position.x + _HalfWidth*2 + xxx, transform.position.y, transform.position.z);
      //newlocation = new Vector3(transform.position.x + _HalfWidth*2 + xxx, transform.position.y, transform.position.z);
    }

}
