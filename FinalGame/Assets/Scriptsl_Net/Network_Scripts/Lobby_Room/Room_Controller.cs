    using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Room_Controller : MonoBehaviourPunCallbacks
{
    [SerializeField]
    public GameObject player1;
    public GameObject player2;
    public Transform spawnpoint1;
    public Transform spawnpoint2;
    public GameObject levelCamera;
    public GameObject leaveRoomButton;
    public GameObject accelerateButton;
    public GameObject decelerateButton;
    public GameObject endPanel;
    public GameObject startCube;
    public static GameObject child1;
    public static GameObject child2;

    public Text info;

    // Start is called before the first frame update
    PhotonView pv;
    void Start()
    {
        Lobby_Network.isNetMap = true;
        print(PhotonNetwork.CurrentRoom.Name);
        PhotonNetwork.AutomaticallySyncScene = true;
        endPanel.SetActive(false);
        startCube.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        child1 = player1.transform.Find("Turret").gameObject;
        child2 = player2.transform.Find("Turret").gameObject;
        info.text = "Current Room name: " + PhotonNetwork.CurrentRoom.Name + " Number of players in the room: " + PhotonNetwork.CurrentRoom.PlayerCount;
        if(PhotonNetwork.CurrentRoom.PlayerCount==2)
        {
            startCube.SetActive(false);
        }
    }


    public override void OnJoinedRoom()
    {
        levelCamera.SetActive(true);
        base.OnJoinedRoom();
        /*  if (PhotonNetwork.CurrentRoom.PlayerCount > 1)
          {
              levelCamera.SetActive(false);
              player2=PhotonNetwork.Instantiate(player2.name, spawnpoint2.position, spawnpoint2.rotation, 0);

              print("I am the second player.....");

          }
          else
          {
              levelCamera.SetActive(false);
              player1=PhotonNetwork.Instantiate(player1.name, spawnpoint1.position, spawnpoint1.rotation, 0);

              print("I am the first player...");

          }*/
        if (PhotonNetwork.CurrentRoom.PlayerCount > 1)
        {
            levelCamera.SetActive(false);
            player2 = PhotonNetwork.Instantiate(player2.name, spawnpoint2.position, spawnpoint2.rotation, 0);
           
           // accelerateButton.SetActive(true);
            print("I am the second player.....");
           
            
        }
        else
        {
            levelCamera.SetActive(false);
            player1 = PhotonNetwork.Instantiate(player1.name, spawnpoint1.position, spawnpoint1.rotation, 0);
            // accelerateButton.SetActive(false);
            
            print("I am the first player...");

        }


    }


    public void onLeaveButtonClicked()
    {
       // Time.timeScale = 1f;
        PhotonNetwork.LeaveRoom();
        //PhotonNetwork.LoadLevel("Co-op_Lobby");
        PhotonNetwork.LeaveLobby();
        PhotonNetwork.Disconnect();

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


    public override void OnLeftRoom()
    {
        if(player1.gameObject==null)
        {

        }
        if(player2.gameObject==null)
        {

        }
        base.OnLeftRoom();
      
    }
}
