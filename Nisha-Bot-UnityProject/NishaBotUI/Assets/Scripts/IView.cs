using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public interface IView
{
    VisualElement Root { get; }
    
    ControllerBase ControllerBase { get; }
}
