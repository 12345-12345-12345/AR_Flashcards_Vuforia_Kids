using UnityEngine;

public class RotationController : MonoBehaviour
{
    public Vector3 RotationVector = new Vector3(0f, 20f, 0f); // Example: Slow rotation around the Y-axis

    private void Update()
    {
        transform.Rotate(RotationVector * Time.deltaTime);
    }
}