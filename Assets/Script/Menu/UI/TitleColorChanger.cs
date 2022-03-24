using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TitleColorChanger : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private Material textColor;

    private void Update()
    {
        titleText.color = textColor.color;
    }


}
