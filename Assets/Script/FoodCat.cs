using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FoodCat : MonoBehaviour
{
    public Button foodButton;

    public RectTransform foodRect;
    public RectTransform[] foodPositions;
    private int lastIndex = 1;

    public float time = 0.5f;
    public float timeRep = 5f;

    public void Start()
    {
        Button btn = foodButton.GetComponent<Button>();
        //btn.onClick.AddListener(Comida);
        btn.gameObject.SetActive(false);
        StartCoroutine(Aparece());
    }

    IEnumerator Aparece()
    {

        yield return new WaitForSeconds(time);

        while (true)
        {

            Instantiate(foodButton, transform.position, Quaternion.identity);
            Debug.Log("Objeto creado: " + Time.time);

            yield return new WaitForSeconds(timeRep);
        }

    }

    public void Comida()
    {

    }
}
