using UnityEngine;

public class MemoryFragment : MonoBehaviour
{
    [SerializeField] string soundName;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
            AudioManager.Instance.Play(soundName);
    }
}
