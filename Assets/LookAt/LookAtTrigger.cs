
using UnityEditor;
using UnityEngine;

public class LookAtTrigger : MonoBehaviour {
    [SerializeField] private Transform trigger;
    [SerializeField, Range(0f, 1f)] float treshold;

    private void OnDrawGizmos() {
        Vector2 toTrigger = trigger.position - transform.position;
        float dotProduct = Vector2.Dot(transform.up.normalized, toTrigger.normalized);
        Debug.Log(dotProduct);
        if (dotProduct >= treshold) {
            Handles.color = Color.green;
        }
        else {
            Handles.color = Color.red;
        }

        Handles.DrawLine(transform.position, trigger.position);
        DrawArc();
    }

    void DrawArc() {
        float angle = Mathf.Acos(treshold) * Mathf.Rad2Deg;
        
        Quaternion rotateStartPoint = Quaternion.AngleAxis(angle, Vector3.forward);
        Handles.DrawSolidArc(transform.position, Vector3.back, rotateStartPoint * transform.up, angle * 2, 2f);
    }
}
