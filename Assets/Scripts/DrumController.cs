using UnityEngine;

public class DrumController : MonoBehaviour
{
    // Start is called before the first frame update

    public float YLowValue = 0.2f;
    public float YOrigional = 1.0f;
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
            LTrigger.transform.localScale = new Vector3(1, YLowValue, 1);
        }
        else if (Input.GetKeyUp("left"))
        {
            LTrigger.transform.localScale = new Vector3(1, YOrigional, 1);
        }
    }

    private void RTriggerControl()
    //Trigger set to "YLowValue" when R arrow is down; Set to "YOrigional" when released
    {
        if (Input.GetKeyDown("right"))
        {
            RTrigger.transform.localScale = new Vector3(1, YLowValue, 1);
        }
        else if (Input.GetKeyUp("right"))
        {
            RTrigger.transform.localScale = new Vector3(1, YOrigional, 1);
        }
    }
}