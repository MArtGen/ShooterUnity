using UnityEngine;

public class GetOutTheMashine : MonoBehaviour {

    public GameObject player, spawn;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && Sitinthemashine.inTheTank)
        {
            player.transform.position = spawn.transform.position;
            player.SetActive(true);
            transform.GetComponentInParent<MoveMashine>().enabled = false;
            this.enabled = false;
            Sitinthemashine.inTheTank = false;
            gameObject.SetActive(false);
        }
    }
}
