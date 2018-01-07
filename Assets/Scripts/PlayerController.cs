using UnityEngine;

[RequireComponent(typeof(MovePlayer))]
public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float Speed = 2f;
    [SerializeField]
    private float lookSpeed = 2f;
    private bool Shoot = false;
    CharacterController controller;

    private MovePlayer motor;
    Animator animator, shoot;

    void Start()
    {
        motor = GetComponent<MovePlayer>();
        animator = GetComponent<Animator>();
        shoot = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Speed", Input.GetAxis("Vertical"));
        animator.SetFloat("Rotate", Input.GetAxis("Horizontal"));
        shoot.SetBool("Shoot", Input.GetMouseButton(0));

        Vector3 movHor = transform.right * xMov;
        Vector3 movVer = transform.forward * zMov;

        Vector3 velocity = (movHor + movVer).normalized * Speed * Time.deltaTime;
//      motor.Move(velocity);
        controller.Move(velocity);

        float yRot = Input.GetAxis("Mouse X");
        Vector3 rotation = new Vector3(0f, yRot, 0f) * lookSpeed;

        motor.Rotate (rotation);

        float xRot = Input.GetAxis("Mouse Y");
        Vector3 camRotation = new Vector3(xRot, 0f, 0f) * lookSpeed;

        motor.RotateCam(camRotation);
    }
}
