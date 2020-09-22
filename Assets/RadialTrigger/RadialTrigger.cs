using System;
using UnityEditor;
using UnityEngine;

public class RadialTrigger : MonoBehaviour {
    [SerializeField] private Transform triggeringObject;
    [SerializeField, Range(0f, 10f)] private float radius;

    private Vector3 towardsCamera = Vector3.back;

    private void OnDrawGizmos() {
        Vector3 position = transform.position;
        try {
            Vector3 offset = triggeringObject.position - position;
            float sqrDistance = offset.x * offset.x + offset.y * offset.y;
            if (sqrDistance <= radius * radius) {
                Handles.color = Color.green;
            }
            else {
                Handles.color = Color.red;
            }
            Handles.DrawWireDisc(position, Vector3.back, radius);
        }
        catch (Exception e) {
            Debug.LogException(e, this);
            throw;
        }
    }
}
