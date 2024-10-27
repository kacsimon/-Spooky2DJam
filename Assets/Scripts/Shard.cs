using UnityEngine;

public class Shard : MonoBehaviour
{
    [SerializeField] GameObject gameObjectToShow;
    [SerializeField] GameObject gameObjectToShowWithKey;
    [SerializeField] string key;
    void Start()
    {
        if (gameObjectToShow == null) return;
        Hide(gameObjectToShow);
        if (gameObjectToShowWithKey == null) return;
        Hide(gameObjectToShowWithKey);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.Instance.GetShard();
            Hide(gameObject);
            Show(gameObjectToShow);
            ShowGameObjectWithKey();
            Destroy(gameObject);
        }
    }
    void Show(GameObject gameObject)
    {
        gameObject.SetActive(true);
    }
    void Hide(GameObject gameObject)
    {
        gameObject.SetActive(false);
    }
    void ShowGameObjectWithKey()
    {
        if (key != null && GameManager.Instance.GetKey(key)) Show(gameObjectToShowWithKey);
    }
}