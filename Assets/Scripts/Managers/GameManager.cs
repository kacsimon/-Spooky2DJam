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
}
