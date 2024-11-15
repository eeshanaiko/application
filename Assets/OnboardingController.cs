using UnityEngine;
using UnityEngine.SceneManagement;

public class OnboardingController : MonoBehaviour
{
    // Called when "Skip" button is pressed
    public void SkipOnboarding()
    {
        // Load the main scene
        SceneManager.LoadScene("MainScene");
    }

    // Called when "Next" button is pressed
    public void NextStep()
    {
        // Load the next onboarding screen (OnboardingScreen2)
        SceneManager.LoadScene("OnboardingScreen2");
    }
}
