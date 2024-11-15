using UnityEngine;
using System.Collections; // Add this line to avoid the error

public class SimpleLogoFadeIn : MonoBehaviour
{
    public float fadeDuration = 2.0f; // Duration of the fade-in effect

    private CanvasGroup canvasGroup;

    void Start()
    {
        // Get the CanvasGroup component
        canvasGroup = GetComponent<CanvasGroup>();
        
        // Start with the logo fully transparent
        canvasGroup.alpha = 0; 

        // Start the fade-in effect
        StartCoroutine(FadeIn());
    }

    private IEnumerator FadeIn()
    {
        float timeElapsed = 0;

        while (timeElapsed < fadeDuration)
        {
            timeElapsed += Time.deltaTime;
            // Gradually increase the alpha value
            canvasGroup.alpha = timeElapsed / fadeDuration;
            yield return null; // Wait for the next frame
        }

        // Ensure the final alpha is fully visible
        canvasGroup.alpha = 1;
    }
}
