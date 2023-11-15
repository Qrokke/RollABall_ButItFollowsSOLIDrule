using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftOverScript : MonoBehaviour
{
    [SerializeField] Text text;
    public void UpDateText(int leftOver)
    {
        text.text = "Count: " + leftOver;
    }
}
