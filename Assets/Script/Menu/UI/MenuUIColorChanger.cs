using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuUIColorChanger : MonoBehaviour
{
    public Material menuColorMaterial;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeColorOverTime(5.0f));//change color over time RGB
    }
    private IEnumerator ChangeColorOverTime(float waitTime)
    {
        while (true)
        {
            menuColorMaterial.DOColor(Color.red, 2);
            yield return new WaitForSeconds(waitTime);
            menuColorMaterial.DOColor(Color.green, 2);
            yield return new WaitForSeconds(waitTime);
            menuColorMaterial.DOColor(Color.blue, 2);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
