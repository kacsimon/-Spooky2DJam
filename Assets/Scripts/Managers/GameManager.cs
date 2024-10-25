using UnityEngine;
using BaseUtilities;

public class GameManager : SingletonBase<GameManager>
{
    int shardCollected;

    public void GetShard()
    {
        shardCollected++;
    }
}
