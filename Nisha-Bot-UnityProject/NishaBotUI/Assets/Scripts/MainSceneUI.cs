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

    private VisualElement sideBtnPanel;
    // Start is called before the first frame update
    void Start()
    {
        _root = MainSceneUIDocument.rootVisualElement;
        AdminLoadBtn=  _root.Q<Button>("AdminLoadBtn");
        GuestLoginBtn = _root.Q<Button>("UserLoadBtn");

        sideBtnPanel = _root.Q<VisualElement>("SideBtnPanel");
        
        AdminLoadBtn.RegisterCallback<ClickEvent>(LoadAdminScene);
        GuestLoginBtn.RegisterCallback<ClickEvent>(LoadAUserScene);

        //CreateSideBtns();
    }

    /*void CreateSideBtns()
    {
        for (int i = 0; i < 5; i++)
        {
            var btn = new Button()
            {
                text = "Button "+i
            };
            btn.RegisterCallback<ClickEvent>(SideBtnClick);
        
            sideBtnPanel.Add(btn);
        }
    }*/

    private void SideBtnClick(ClickEvent evt)
    {
        
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
