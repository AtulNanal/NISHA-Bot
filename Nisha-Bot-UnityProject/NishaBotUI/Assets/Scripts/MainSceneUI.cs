using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainSceneUI : MonoBehaviour
{
    public UIDocument MainSceneUIDocument;
    private VisualElement _root;

    private Button AdminLoadBtn, GuestLoginBtn;
    // Start is called before the first frame update
    void Start()
    {
        _root = MainSceneUIDocument.rootVisualElement;
        AdminLoadBtn=  _root.Q<Button>("AdminLoadBtn");
        GuestLoginBtn = _root.Q<Button>("UserLoadBtn");
        
        AdminLoadBtn.RegisterCallback<ClickEvent>(LoadAdminScene);
        GuestLoginBtn.RegisterCallback<ClickEvent>(LoadAUserScene);
    }

    private void LoadAdminScene(ClickEvent evt)
    {
        SceneManager.LoadScene("Admin");
    }
    
    private void LoadAUserScene(ClickEvent evt)
    {
        SceneManager.LoadScene("User");
    }
}
