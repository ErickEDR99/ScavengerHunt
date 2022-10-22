/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.UI;
using UnityEngine.Events;


public class Notas : MonoBehaviour
{

    [SerializeField] private VirtualButtonBehaviour virtualButton;
    public UnityEvent OnButtonPressed;
    public UnityEvent OnButtonReleased;


    private void OnEnable()
    {
        virtualButton.RegisterOnButtonPressed(ButtonPressed);
        virtualButton.RegisterOnButtonReleased(ButtonReleased);


    }

    public void OnDestroy()
    {
        virtualButton.UnregisterOnButtonPressed(ButtonPressed);
        virtualButton.UnregisterOnButtonReleased(ButtonReleased);
    }

    private void ButtonPressed(VirtualButtonBehaviour button)
    {
        OnButtonPressed?.Invoke();
        Debug.Log("Button Pressed");
    }

    private void ButtonReleased(VirtualButtonBehaviour button)
    {
        OnButtonReleased?.Invoke();
        Debug.Log("Button Released");

    }

}
*/