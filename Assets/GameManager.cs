using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public TMP_Text tmpText;

    // Update is called once per frame
    void Update()
    {
        tmpText.text = System.DateTime.Now.ToLongTimeString();
    }
}
