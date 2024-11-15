using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UIElements;

public class ApiTest : MonoBehaviour
{

    public VisualElement Root;
    
    private Button _getMethodTest, _postMethodTest;

    public UIDocument _UIDocument;
    // Start is called before the first frame update
    void Start()
    {
       Root= _UIDocument.rootVisualElement;
            
        _getMethodTest = new Button()
        {
            text = "Get Method"
        };
        _getMethodTest.RegisterCallback<ClickEvent>(GetMethodTest);
        
        Root.Add(_getMethodTest);
        
        _postMethodTest = new Button()
        {
            text = "Post Method"
        };
        _postMethodTest.RegisterCallback<ClickEvent>(PostMethodTest);
        
        Root.Add(_postMethodTest);
    }

    private void PostMethodTest(ClickEvent evt)
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
    }
}
