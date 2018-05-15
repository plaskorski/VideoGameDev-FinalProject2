using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {
    
    public float speed;
    
    void Update() {
        
        // Rotate the object around its local X axis at 1 degree per second
        transform.Rotate(Vector3.back, speed * Time.deltaTime);
    }
}
