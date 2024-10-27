using UnityEngine;
using BaseUtilities;

public class GameManager : SingletonBase<GameManager>
{
    [SerializeField] int shardToHave;
    [SerializeField] GameObject endCanvas;
    [SerializeField] GameObject[] endings;

    int shardCollected;
    int maxShard = 7;
    //float sanityLevel;
    bool flowerKey, plushKey, shadowKey, swingKey;

    public void GetShard()
    {
        shardCollected++;
        //sanityLevel--;
    }
    public void GetEnd(bool bad)
    {
        endCanvas.SetActive(true);
        if (bad) BadEnding();
        else if (shardCollected < shardToHave) BadEnding();
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
    void BadEnding()
    {
        Debug.Log("You got the bad ending.");
        endings[0].SetActive(true);
    }
    void GoodEnding()
    {
        Debug.Log("You got the good ending.");
        endings[1].SetActive(true);
    }
    void TrueEnding()
    {
        Debug.Log("You got the true ending.");
        endings[2].SetActive(true);
    }
}