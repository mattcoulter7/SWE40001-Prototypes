using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// must be placed on the renderer object.
// updates the collision
public class CinematicBarCollider : MonoBehaviour
{
    public Collider colliderObject;
    int _originalLayer;
    public int targetLayer = 9;
    // Start is called before the first frame update
    void Start()
    {
        if (colliderObject == null)
        {
            colliderObject = GetComponent<Collider>();
        }
        _originalLayer = colliderObject.gameObject.layer;
    }

    private void OnBecameVisible()
    {
        colliderObject.gameObject.layer = targetLayer;
    }

    private void OnBecameInvisible()
    {
        colliderObject.gameObject.layer = _originalLayer;
    }
}
