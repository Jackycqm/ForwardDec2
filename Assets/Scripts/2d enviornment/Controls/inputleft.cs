using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputleft : MonoBehaviour
{
    // Start is called before the first frame update
    private Renderer _t;
    public Color colorBe;
    public GameObject _lc;

    void Start()
    {
      _t = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
      if (_t.material.color == colorBe && Input.GetKeyDown("left")) {
        _lc.SetActive(true);
      }
      if (Input.GetKeyUp("left")) {
        _lc.SetActive(false);
      }
    }
}
