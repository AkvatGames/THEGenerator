using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheLocks : MonoBehaviour
{
    Toggle lockToggle;
    public Text lockText;
    //public bool isLocked;

    void Start()
    {
        //Fetch the Toggle GameObject
        this.lockToggle = GetComponent<Toggle>();
        //Add listener for when the state of the Toggle changes, to take action
        this.lockToggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(this.lockToggle);
        });

        //Initialise the Text to say the first state of the Toggle
        this.lockText.text = "Unlocked";
        this.lockToggle.isOn = false;
        //isLocked = false;
        
    }

    //Output the new state of the Toggle into Text
    public void ToggleValueChanged(Toggle change)
    {
        if (this.lockToggle.isOn == true)
        {
            //isLocked = true;
            lockText.text = "Locked";
        }
        if (this.lockToggle.isOn == false)
        {
            //isLocked = false;
            lockText.text = "Unlocked";
        }
    }

    /*
    private void Update()
    {
        if (lockToggle.isOn == true)
        {
            //isLocked = true;
            lockText.text = "Locked";
        }
        else
        {
            //isLocked = false;
            lockText.text = "Unlocked";
        }
    }
    */
}