using UnityEngine;
using BaseUtilities;

public class GameManager : SingletonBase<GameManager>
{
    [SerializeField] int shardToHave;

    int shardCollected;
    int maxShard = 7;
    //float sanityLevel;
    bool flowerKey, plushKey, shadowKey, swingKey;

    public void GetShard()
    {
        shardCollected++;
        //sanityLevel--;
    }
    public void GetEnd()
    {
        if (shardCollected < shardToHave) BadEnding();
        else if (shardCollected == maxShard && swingKey) TrueEnding();
        else GoodEnding();
    }
    public void PickUp(string key)
    {
        switch (key)
        {
            case "flower":
                flowerKey = true;
                break;
            case "plush":
                plushKey = true;
                break;
            case "shadow":
                shadowKey = true;
                break;
            case "swing":
                swingKey = true;
                break;
        }
    }
    public bool GetKey(string key)
    {
        switch (key)
        {
            default:
            case "flower":
                return flowerKey;
            case "plush":
                return plushKey;
            case "shadow":
                return shadowKey;
            case "swing":
                return swingKey;
        }
    }
    public void BadEnding()
    {
        Debug.Log("You got the bad ending.");
    }
    void GoodEnding()
    {
        Debug.Log("You got the good ending.");
    }
    void TrueEnding()
    {
        Debug.Log("You got the true ending.");
    }
}