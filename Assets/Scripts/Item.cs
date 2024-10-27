using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] string key;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.PickUp(key);
            Destroy(gameObject);
        }
    }
}
