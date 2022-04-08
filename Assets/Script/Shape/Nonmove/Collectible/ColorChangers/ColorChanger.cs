using UnityEngine;

public class ColorChanger : NonMove
{
    void Update()
    {
        RotateAround();
    }
    private void OnTriggerEnter(Collider other)
    {
        ChangeColorOfObject(other.gameObject);
    }
    private void RotateAround()
    {
        transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
    }
    void ChangeColorOfObject(GameObject objectToBePainted)
    {
        objectToBePainted.GetComponent<Renderer>().material.color = gameObject.GetComponent<Renderer>().material.color;
    }
}
