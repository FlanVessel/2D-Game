using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] GameObject puerta;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (puerta != null)
                Destroy(puerta);

            Destroy(gameObject);
        }
    }
}
