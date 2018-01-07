using UnityEngine;

public class MoveMashine : MonoBehaviour {

    [SerializeField]
    private float Speed = 7f;
    [SerializeField]
    private float lookSpeed = 30f;

    private void Update()
    {
        float xMov = Input.GetAxisRaw("Horizontal");
        float zMov = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.right * zMov * Speed * Time.deltaTime);
        transform.Rotate(Vector3.up * xMov * lookSpeed * Time.deltaTime, Space.World);
    }
}
