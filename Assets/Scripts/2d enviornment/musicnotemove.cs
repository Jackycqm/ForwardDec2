using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicnotemove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform _center;

    public float speed;
    private Vector3 _c;

    private void Start()
    {
        _c = new Vector3(_center.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _c, speed * Time.deltaTime);
    }
}