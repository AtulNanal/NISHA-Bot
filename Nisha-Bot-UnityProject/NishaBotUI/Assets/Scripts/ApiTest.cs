using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UIElements;

public class ApiTest : MonoBehaviour
{
    public bool ShowTestUI = false;
    
    public VisualElement Root;
    
    private Button _getMethodTest, _postMethodTest;

    public UIDocument _UIDocument;

    private string message="hello";

    public Action<bool, string> BotResponseReceived; 
        
    // Start is called before the first frame update
    void Start()
    {
        if (ShowTestUI == false) return;
        
       Root= _UIDocument.rootVisualElement;
            
        /*_getMethodTest = new Button()
        {
            text = "Get Method"
        };
        _getMethodTest.RegisterCallback<ClickEvent>(GetMethodTest);
        
        Root.Add(_getMethodTest);*/
        
        _postMethodTest = new Button()
        {
            text = "Post Method"
        };
        _postMethodTest.RegisterCallback<ClickEvent>(PostMessage);
        
        Root.Add(_postMethodTest);
    }

    private void PostMessage(ClickEvent evt)
    {
        StartCoroutine(SendMessageToBackend(message));
    }

    public void SendPostMessage(string message)
    {
        StartCoroutine(SendMessageToBackend(message));
    }

    private string apiUrl = "http://127.0.0.1:8000/chatbot/";
    private IEnumerator SendMessageToBackend(string message)
    {
        // Create a JSON object to send
        string jsonMessage = "{\"message\": \"" + message + "\"}";

        // Create a UnityWebRequest to send a POST request
        using (UnityWebRequest request = new UnityWebRequest(apiUrl, "POST"))
        {
            byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(jsonMessage);  // Convert the message to bytes
            request.uploadHandler = new UploadHandlerRaw(bodyRaw);
            request.downloadHandler = new DownloadHandlerBuffer();
            request.SetRequestHeader("Content-Type", "application/json");

            // Wait for the response from the server
            yield return request.SendWebRequest();

            // Check for errors
            if (request.result != UnityWebRequest.Result.Success)
            {
                BotResponseReceived?.Invoke(false, request.error);
                // responseText.text = "Error: " + request.error;
                Debug.Log("Error: " + request.error);
            }
            else
            {
                // Parse the response and update the UI
                string response = request.downloadHandler.text;
                BotResponseReceived?.Invoke(true, response);
                // responseText.text = "Bot: " + response;
                Debug.Log("Bot: " + response);
            }
        }
    }
    
    /*private void PostMethodTest(ClickEvent evt)
    {
        Debug.Log("Testing PostMethod");
        StartCoroutine(postRequest("http://localhost:8000/post-message?name=hey-rohan"));
    }

    IEnumerator postRequest(string url)
    {
        WWWForm form = new WWWForm();
       form.AddField("content-type", "application/json");

       UnityWebRequest uwr = UnityWebRequest.Post(url, form);
        yield return uwr.SendWebRequest();

        if (uwr.isNetworkError)
        {
            Debug.Log("Error While Sending: " + uwr.error);
        }
        else
        {
            Debug.Log("Received POST: " + uwr.downloadHandler.text);
        }
    }
    
    private void GetMethodTest(ClickEvent evt)
    {
        Debug.Log("Testing GetMethod");
        StartCoroutine(getRequest("http://localhost:8000/get-message?name=Rohan"));
    }
    
    IEnumerator getRequest(string uri)
    {
        UnityWebRequest uwr = UnityWebRequest.Get(uri);
        yield return uwr.SendWebRequest();

        if (uwr.isNetworkError)
        {
            Debug.Log("Error While Sending: " + uwr.error);
        }
        else
        {
            Debug.Log("Received GET: " + uwr.downloadHandler.text);
        }
    }*/
    

}
