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
        Lobby_Network.isNetMap = false;

    }

    public void LoadLevel(int sceneIndex)

    {
        StartCoroutine(LoadAsynchronously(sceneIndex));

    }

    IEnumerator LoadAsynchronously(int sceneIndex)
    {

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        yield return null;
    }
}