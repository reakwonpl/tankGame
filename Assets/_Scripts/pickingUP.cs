using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class pickingUP : MonoBehaviour
{

    public Text countText;
    private int count;
    // Use this for initialization
    void Start()
    {
        count = 0;
        setCountText();

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickUp"))
        {
            count = count + 1;
            setCountText();
        }
    }
    void setCountText()
    {
        countText.text = "Find all nuke bombs!" + " " + count.ToString() + "/6";

    }
}
