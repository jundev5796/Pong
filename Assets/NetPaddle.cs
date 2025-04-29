using Photon.Pun;
using UnityEngine;

public class NetPaddle : MonoBehaviourPun
{   
    public float speed = 10f;


    void Update()
    {
        if(photonView.IsMine) // only 1 controller (one player)
        {
            float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
            transform.Translate(0, move, 0);
        }
    }
}
