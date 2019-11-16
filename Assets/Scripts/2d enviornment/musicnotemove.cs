using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicnotemove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
  	private Transform _center;
    private  float speed = 2;
  	private Vector3 _c;

    void Start()
    {
      _c = new Vector3 (_center.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
      transform.position = Vector3.MoveTowards(transform.position, _c, speed*Time.deltaTime);
    }
}
