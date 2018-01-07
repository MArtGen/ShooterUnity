using UnityEngine;

public class RotationPelvis : MonoBehaviour {

    [SerializeField]
    private float lookSpeed = 30f;

    // Update is called once per frame
    void Update () {
        float xMov = Input.GetAxisRaw("Horizontal");

        transform.Rotate(Vector3.up * xMov * lookSpeed * Time.deltaTime, Space.World);
    }
}
