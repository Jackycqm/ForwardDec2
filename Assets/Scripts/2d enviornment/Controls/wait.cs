using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wait : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _this;
    void Start()
    {
      Invoke("www",0.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void www(){
      _this.SetActive(false);
    }
}
