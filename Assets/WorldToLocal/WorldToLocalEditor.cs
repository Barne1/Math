using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(WorldToLocal))]
public class WorldToLocalEditor : Editor
{
    public override void OnInspectorGUI() {
        WorldToLocal myTarget = (WorldToLocal) target;

        myTarget.point = EditorGUILayout.ObjectField("Transform", myTarget.point, typeof(Transform), true) as Transform;
        
        if (GUILayout.Button("Transform value to Local")) {
            myTarget.CalculateLocalSpace();
        }
        
        myTarget.localSpace = EditorGUILayout.Vector2Field("Local Position", myTarget.localSpace);
    }
}
