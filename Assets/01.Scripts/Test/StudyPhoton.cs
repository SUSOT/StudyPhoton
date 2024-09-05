using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using Unity.Mathematics;
using UnityEngine;

public class StudyPhoton : MonoBehaviourPunCallbacks
{
    public void StartMulty()
    {
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("포톤 연결");
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions() { MaxPlayers = 2 }, null );
        Debug.Log("방생성");
    }

    public override void OnJoinedRoom()
    {
        GameObject P1 = PhotonNetwork.Instantiate("Player", Vector3.zero, quaternion.identity);
        Debug.Log("플레이어 생성");
    }
}
