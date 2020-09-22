using UnityEngine;

public class WorldToLocal : MonoBehaviour {
    public Transform point;
    public Vector2 localSpace;

    public void CalculateLocalSpace() {
        Vector2 worldSpace = point.position;

        float localSpaceY = Vector2.Dot(transform.up, worldSpace - (Vector2)transform.position);
        float localSpaceX = Vector2.Dot(transform.right, worldSpace - (Vector2)transform.position);
        
        localSpace = new Vector2(localSpaceX, localSpaceY);
    }
}
