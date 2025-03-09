using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class OverrideBounds : MonoBehaviour
{
    private Renderer targetRenderer;
    public bool doOverride;
    public Bounds boundsOverride = new Bounds(Vector3.zero, Vector3.one);
    void Start()
    {
        OverrideRendererBounds();
    }
    private void OverrideRendererBounds()
    {
        if (doOverride)
        {
            if (targetRenderer == null)
            {
                targetRenderer = gameObject.GetComponent<Renderer>();
            }
            if (targetRenderer != null)
            {
                targetRenderer.bounds = boundsOverride;
            }

        }
    }

#if UNITY_EDITOR
    private void OnValidate()
    {
        OverrideRendererBounds();
    }
#endif
}
