using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;
public class goBackToMenu : MonoBehaviourPunCallbacks
{
   public void goMenu()
    {
        PhotonNetwork.LeaveLobby();
        PhotonNetwork.Disconnect();
        SceneManager.LoadScene(0);
        Lobby_Network.isNetMap = false;
    }


}
