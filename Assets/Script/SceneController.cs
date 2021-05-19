using System.Collections;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    public bool isGazed;

    private float timeLimit = 2f;
    
    private float lookTimer = 0f;
    public void ChangeScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    void btnClick()
    {
            GetComponent<Button>().onClick.Invoke();
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    void Update()
    {
        if (isGazed)
        {
            lookTimer += Time.deltaTime;

            if (lookTimer >= timeLimit)
            {
               btnClick();
               lookTimer = 0f;
            }
        }
    }

    public void ChangeGaze(bool gaze)
    {
        isGazed = gaze;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
            ChangeScene("Menu");
    }
}
