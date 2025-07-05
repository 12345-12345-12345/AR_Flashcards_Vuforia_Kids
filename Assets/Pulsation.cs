using UnityEngine;

public class ScalePulse : MonoBehaviour
{
    public float pulseSpeed = 1f;
    public float pulseAmount = 0.02f;
    private Vector3 originalScale;

    void Start()
    {
        originalScale = transform.localScale;
    }

    void Update()
    {
        float scaleFactor = 1f + Mathf.Sin(Time.time * pulseSpeed) * pulseAmount;
        transform.localScale = originalScale * scaleFactor;
    }
}