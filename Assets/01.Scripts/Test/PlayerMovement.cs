using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private SpriteRenderer _sprite;
    [SerializeField] private float speed = 5f;

    public PhotonView photonView;

    private void Start()
    {
        _sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        if (photonView.IsMine)
        {
            float h = Input.GetAxisRaw("Horizontal");
            transform.position += new Vector3(h * speed * Time.deltaTime, 0, 0);
            photonView.RPC("Flip", RpcTarget.AllBuffered, h);
        }
    }

    [PunRPC]
    private void Flip(float h)
    {
        if (h >= 0 && h <= 1)
        {
            _sprite.flipX = false;
        }
        else if (h >= -1 && h < 0)
        {
            _sprite.flipX = true;
        }
    }
}
