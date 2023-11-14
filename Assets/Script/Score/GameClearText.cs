using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClearText : MonoBehaviour
{
    [SerializeField] Text text;
    private void Start()
    {
        text.enabled = false;
    }
    public void OpenText()
    {
        text.enabled = true;
    }
}
