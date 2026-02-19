using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonClick : MonoBehaviour
{
    public SpriteRenderer cat;
    public float time = 0.5f;
    public Button button;
    public AudioSource audio;

    public RectTransform buttonRect;
    public RectTransform[] positions;
    private int lastIndex = -1;

    public GameManager gameManager;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(Presionado);
        cat.enabled = false;
    }

    public void Presionado()
    {
        MoverBoton();
        Debug.Log("*Miaulla");
        audio.Play();
        StartCoroutine(Aparece(time));

        gameManager.AddPoint();
    }

    IEnumerator Aparece(float segundos)
    {
        cat.enabled = true;
        yield return new WaitForSeconds(segundos);
        cat.enabled = false;
    }

    void MoverBoton()
    {
        if (positions.Length == 0) return;

        int index = Random.Range(0, positions.Length);

        while (index == lastIndex && positions.Length > 1)
        {
            index = Random.Range(0, positions.Length);
        }

        lastIndex = index;

        buttonRect.anchoredPosition = positions[index].anchoredPosition;
    }
}
