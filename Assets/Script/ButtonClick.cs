using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonClick : MonoBehaviour
{
    public SpriteRenderer cat;
    public float time = 2.0f;
    public Button button;
    public AudioSource audio;

    void Start()
    {
        Button btn = button.GetComponent<Button>();
        btn.onClick.AddListener(Presionado);
        cat.enabled = false;
    }

    public void Presionado()
    {
        Debug.Log("*Miaulla");
        audio.Play();
        StartCoroutine(Aparece(time));
    }

    IEnumerator Aparece(float segundos)
    {
        cat.enabled = true;
        yield return new WaitForSeconds(segundos);
        cat.enabled = false;
    }
}
