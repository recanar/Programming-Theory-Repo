using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : Shape
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void GiveColor(Color color)
    {
        var ballRenderer = gameObject.GetComponent<Renderer>();
        ballRenderer.material.SetColor("_color", Color.red);
    }
}
