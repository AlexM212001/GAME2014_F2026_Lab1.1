using UnityEngine;
using UnityEngine.SceneManagement;
public class NextButtonBehavior : MonoBehaviour
{
    public void OnNextButtonPressed()
    {
        Debug.Log("Next Button Pressed");
        SceneManager.LoadScene("End");
    }
}// Start is called once before the first execution of Update after the MonoBehaviour is created
