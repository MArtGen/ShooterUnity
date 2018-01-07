using UnityEngine;

public class Sitinthemashine : MonoBehaviour {

    public Camera tankCam;
    public static bool inTheTank;
    private bool ShootT = false;
    Animator shootT;

    private void Start()
    {
        inTheTank = false;
        shootT = GetComponent<Animator>();
    }

    private void Update()
    {
        if (inTheTank)
            shootT.SetBool("ShootT", Input.GetMouseButton(0));
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.F) && !inTheTank)
            {
                tankCam.gameObject.SetActive(true);
                Invoke("Delegate", 1f);
                other.gameObject.SetActive(false);
                GetComponent<MoveMashine>().enabled = true;
                inTheTank = true;
            }
        }
    }
    void Delegate ()
    {
        tankCam.GetComponent<GetOutTheMashine>().enabled = true;
    }
}
