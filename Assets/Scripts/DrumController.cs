using UnityEngine;

public class DrumController : MonoBehaviour
{
    // Start is called before the first frame update
    public float xNewValue;

    public float xOrigional;

    public float yNewValue;
    public float yOrigional;

    public float zNewValue;
    public float zOrigional;

    public GameObject LTrigger;
    public GameObject RTrigger;

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        LTriggerControl();
        RTriggerControl();
    }

    private void LTriggerControl()
    //Trigger set to "YLowValue" when L arrow is down; Set to "YOrigional" when released
    {
        if (Input.GetKeyDown("left"))
        {
            LTrigger.transform.localScale = new Vector3(xNewValue, yNewValue, zNewValue);
        }
        else if (Input.GetKeyUp("left"))
        {
            LTrigger.transform.localScale = new Vector3(xOrigional, yOrigional, zOrigional);
        }
    }

    private void RTriggerControl()
    //Trigger set to "YLowValue" when R arrow is down; Set to "YOrigional" when released
    {
        if (Input.GetKeyDown("right"))
        {
            RTrigger.transform.localScale = new Vector3(xNewValue, yNewValue, zNewValue);
        }
        else if (Input.GetKeyUp("right"))
        {
            RTrigger.transform.localScale = new Vector3(xOrigional, yOrigional, zOrigional);
        }
    }
}