using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameManager instance;

    private void Awake()
    {
        instance = this;   
    }


    //reference
    public Player player;
}
