using UnityEngine;
using UnityEngine.SceneManagement;


public class StartButtonBehavior : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void OnStartButtonClick()
    {
        // Load the next scene or perform any other action you want when the start button is clicked
        Debug.Log("Start button clicked!");
        SceneManager.LoadScene("Play");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
