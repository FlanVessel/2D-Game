using UnityEngine;
using UnityEngine.UI;

public class DamageDialogue : MonoBehaviour
{
    // Desired duration of the shake effect
    private float shakeDuration = 0f;

    // A measure of magnitude for the shake. Tweak based on your preference
    private float shakeMagnitude = 0.25f;

    // A measure of how quickly the shake effect should evaporate
    private float dampingSpeed = 1f;

    // The initial position of the GameObject
    Vector3 initialPosition;

    public Image PanelDialogue;

    void Awake()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        if (shakeDuration > 0)
        {
            transform.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;

            shakeDuration -= Time.deltaTime * dampingSpeed;

            PanelDialogue.enabled = true;
        }
        else
        {
            shakeDuration = 0f;
            transform.localPosition = initialPosition;
        }
    }

}
