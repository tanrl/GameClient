using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// playerData
/// playerName:玩家名字
/// characterName：角色名字
/// </summary>
public class PlayerDatass
{
    public string playerName;
    public string characterName;
    
    public PlayerDatass(string playerName, string characterName)
    {
        this.playerName = playerName;
        this.characterName = characterName;
    }
}

public class PlayerImformation {
    private int playerNumber;
    private static PlayerImformation mInstance;

    public static PlayerImformation Instance
    {
        get
        {
            if (mInstance == null)
            {
                mInstance = new PlayerImformation();
            }
            return mInstance;
        }
    }

    private List<PlayerDatass> mPlayerList;
    public List<PlayerDatass> PlayerList
    {
        get
        {
            return mPlayerList;
        }
    }



    private PlayerImformation() {
        mPlayerList = new List<PlayerDatass>();
    }
    public void AddPlayer(PlayerDatass nPlayer)
    {
        mPlayerList.Add(nPlayer);
    }
}
