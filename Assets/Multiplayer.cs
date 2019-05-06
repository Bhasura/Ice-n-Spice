using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplayer
{
    public int getplayers(bool inroom, bool connectedtomaster, int roomid)
    {
       /* inroom = false;
        connectedtomaster = false;
        roomid = 1;*/
        int amountofplayers = 0;

        if(connectedtomaster==true && inroom==true)
        {
            amountofplayers = searchroom(roomid);
        }
        else
        {
            amountofplayers = 0;

        }

        return amountofplayers;
    }
    public int searchroom(int roomid)
    {
        if(roomid==1)
        {
            return 2;
        }
        else
        {
            return 0;
        }
        
    }
    

    public string getname(bool inroom, bool connectedtomaster, int roomid, int playerid)
    {
        /*inroom = true;
        connectedtomaster = true;
        roomid = 2;
        playerid = 1;*/
        if(inroom==true && connectedtomaster==true && roomid==2 && playerid==1)
        {
            return "player1";
        }
        else
        {
            return "no player with that id";
        }
    
    }
}
