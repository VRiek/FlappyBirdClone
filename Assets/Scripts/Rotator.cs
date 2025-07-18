using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotationSpeed = 50f;

    // Update is called once per frame
    void Update()
    {
        float rotationDirection = -1f; //1f toinen vaihtoehto
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime * rotationDirection);
    }
}
