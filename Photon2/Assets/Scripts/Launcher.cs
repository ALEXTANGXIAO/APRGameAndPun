using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Launcher : MonoBehaviourPunCallbacks
{
    void Start()
    {
       
        PhotonNetwork.ConnectUsingSettings();
   
    }

    public override void OnConnectedToMaster()
    {
        //1.链接
        base.OnConnectedToMaster();
        Debug.Log("WelCome Michael");
        //2.创建房间
        PhotonNetwork.JoinOrCreateRoom("Room233",new Photon.Realtime.RoomOptions(){ MaxPlayers = 4},default);

    }

    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();

        PhotonNetwork.Instantiate("Player", new Vector3(1, 1, 1), Quaternion.identity, 0);
    }
}
