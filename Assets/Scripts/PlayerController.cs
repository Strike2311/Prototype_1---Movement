using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    public float turnSpeed = 25.0f;
    public float horizontalInput;
    public float verticalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        if (verticalInput != 0f) {
            horizontalInput = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput * verticalInput);
        }
    }
}
