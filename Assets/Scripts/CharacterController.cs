using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float maxSpeed;
    public float normalSpeed = 10.0f;

    float rotation = 0.0f;
    float camRotation = 0.0f;
    float rotationSpeed = 2.0f;
    float camRotationSpeed = 1.5f;
    GameObject cam;
    Rigidbody myRigidBody;

    bool isOnGround;
    public GameObject groundChecker;
    public LayerMask groundLayer;

    public float jumpForce;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;

        cam = GameObject.Find("Main Camera");
        myRigidBody = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;
        }
        isOnGround = Physics.CheckSphere(groundChecker.transform.position, 0.1f, groundLayer);

        Vector3 newVelocity = (transform.forward * Input.GetAxis("Horizontal") * maxSpeed + (transform.right * -Input.GetAxis("Vertical") * maxSpeed));
        myRigidBody.velocity = new Vector3(newVelocity.x, myRigidBody.velocity.y, newVelocity.z);

        rotation = rotation + Input.GetAxis("Mouse X") * rotationSpeed;
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, rotation, 0.0f));

        camRotation = camRotation + Input.GetAxis("Mouse Y") * camRotationSpeed;
        cam.transform.localRotation = Quaternion.Euler(new Vector3(Mathf.Clamp(-camRotation, -45f, 30f), -90f, 0.0f));

        if(isOnGround && Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody.AddForce(transform.up * jumpForce);
        }
    }
}