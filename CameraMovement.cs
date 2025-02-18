using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform t;
    public Vector3 offset, rotation;
    // Update is called once per frame
    void Update()
    {
        transform.position = t.position + offset;
        transform.rotation = Quaternion.Euler(rotation);
    }
}
