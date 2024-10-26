using UnityEngine;

public class END : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        collision.CompareTag("Player");
        GameManager.Instance.GetEnd();
    }
}
