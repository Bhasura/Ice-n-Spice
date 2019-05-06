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
        SceneManager.LoadScene(0);
        
    }


}
