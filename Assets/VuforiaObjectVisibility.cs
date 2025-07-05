using UnityEngine;
using Vuforia;

public class VuforiaObjectVisibility : MonoBehaviour
{
    private void Start()
    {
        // Initially hide all child renderers and colliders
        SetVisible(false);
    }

    private void OnTargetFound()
    {
        SetVisible(true);
    }

    private void OnTargetLost()
    {
        SetVisible(false);
    }

    private void SetVisible(bool visible)
    {
        Renderer[] renderers = GetComponentsInChildren<Renderer>(true);
        Collider[] colliders = GetComponentsInChildren<Collider>(true);

        foreach (Renderer rend in renderers)
        {
            rend.enabled = visible;
        }

        foreach (Collider col in colliders)
        {
            col.enabled = visible;
        }
    }
}