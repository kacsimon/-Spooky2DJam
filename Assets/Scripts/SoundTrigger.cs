using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    [SerializeField] string[] soundsToPlay;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            AudioManager.Instance.Play(soundsToPlay[Random.Range(0, soundsToPlay.Length)]);
            Destroy(gameObject);
        }
    }
}
