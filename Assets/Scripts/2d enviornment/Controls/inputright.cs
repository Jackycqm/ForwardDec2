using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputright : MonoBehaviour
{
    // Start is called before the first frame update
    private Renderer _t;
    public Color colorBe;
    public GameObject _rc;

    void Start()
    {
      _t = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
      if (_t.material.color == colorBe && Input.GetKeyDown("right")) {
        _rc.SetActive(true);
      }
      if (Input.GetKeyUp("right")) {
        _rc.SetActive(false);
      }
    }
}
