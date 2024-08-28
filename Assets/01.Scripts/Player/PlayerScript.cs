using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviourPun, IOnEventCallback
{
    private PhotonView _photonView;

    private void Start()
    {
        _photonView = photonView;
        if(_photonView.IsMine)
        {
            _photonView.RPC("TestRPC", RpcTarget.All, "A", "B");
        }
    }

    [PunRPC]
    private void TestRPC(string value1, string value2, PhotonMessageInfo info)
    {
        Debug.Log(info.Sender.NickName + ", " + info.photonView.Owner.NickName + ", " + info.SentServerTime);
    }

    private void SendEvent()
    {
        object[] content = new object[] { new Vector3(10f, 2f, 5f), 1, 2, 5, 10 };
        PhotonNetwork.RaiseEvent(0, content, RaiseEventOptions.Default, SendOptions.SendUnreliable);
    }

    public void OnEvent(EventData photonEvent)
    {
        if(photonEvent.Code == 0)
        {
            object[] data = (object[])photonEvent.CustomData;
            for(int i = 0; i < data.Length; i++)
            {
                Debug.Log(data[i]);
            }
        }
    }
}
