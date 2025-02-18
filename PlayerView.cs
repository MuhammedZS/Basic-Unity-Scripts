using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; //( Time.deltaTime is the amount of time that is spent since the last update function was called)
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; //( Time.deltaTime is the amount of time that is spent since the last update function was called)

        xRotation += mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}











// public class PlayerMovement : MonoBehaviour
// {
//     Start is called once before the first execution of Update after the MonoBehaviour is created
//     public Rigidbody rb;
//     public Vector3 forward,backward, right, left, jump;

//     public bool toJump = true;
//     public Keyboard keyboard;
//     void Start()
//     {
//         Debug.Log("Game Started!!");
//         keyboard = Keyboard.current;
//     }
//     Update is called once per frame
//     void Update()
//     {
//         if(keyboard == null){
//             Debug.Log("No Keyboard");
//             return;
//         }
//         if(keyboard.wKey.isPressed){
//             rb.AddForce(forward);
//         }
//         if(keyboard.dKey.isPressed){
//             rb.AddForce(right);
//         }
//         if(keyboard.aKey.isPressed){
//             rb.AddForce(left);
//         }
//         if(keyboard.sKey.isPressed){
//             rb.AddForce(backward);
//         }

//         if(keyboard.spaceKey.isPressed && toJump){
//             rb.AddForce(jump, ForceMode.Impulse);
//             toJump = false;
//         }
        
//         if(keyboard.lKey.isPressed){
//             rb.AddForce(0, -500, 0 * Time.deltaTime);
//         }
//     }
//     private void OnCollisionEnter(Collision other) {
//         if(other.gameObject.tag == "Ground" || other.gameObject.tag == "Crate"){
//             toJump = true;
//         }
//     }
//     }
// }