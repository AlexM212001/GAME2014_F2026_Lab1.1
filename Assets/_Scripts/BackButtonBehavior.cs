using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButtonBehavior : MonoBehaviour
{

    public void OnBackButtonClick()
    {
        // Load the previous scene or perform any other action you want when the back button is clicked
        Debug.Log("Back button clicked!");
        SceneManager.LoadScene("Start");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
