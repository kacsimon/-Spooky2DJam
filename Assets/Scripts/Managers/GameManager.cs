using UnityEngine;
using BaseUtilities;

public class GameManager : SingletonBase<GameManager>
{
    int shardCollected;
    float sanityLevel;

    public void GetShard()
    {
        shardCollected++;
    }
    public void GetEnd()
    {
        if (shardCollected < 4) BadEnding();
        else GoodEnding();
    }
    void BadEnding()
    {
        Debug.Log("You got the bad ending.");
    }
    void GoodEnding()
    {
        Debug.Log("You got the good ending.");
    }
}