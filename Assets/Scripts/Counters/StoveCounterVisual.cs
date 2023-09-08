using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveCounterVisual : MonoBehaviour
{
    [SerializeField] private GameObject stoveOnGameObject;
    [SerializeField] private GameObject particlesGameObject;

    [SerializeField] private StoveCounter stoveCounter;

    private void Start()
    {
        stoveCounter.OnStateChanged += StoveCounter_OnStateChanged;
    }

    private void StoveCounter_OnStateChanged(object sender, StoveCounter.OnStateChangedEventArgs e)
    {
        if (e.state == StoveCounter.StateStove.Fried || e.state == StoveCounter.StateStove.Frying)
        {
            Show(); 
        }
        else
        {
            Hide();
        }
    }

    private void Show()
    {
        stoveOnGameObject.SetActive(true);
        particlesGameObject.SetActive(true);
    }
    private void Hide()
    {
        stoveOnGameObject.SetActive(false);
        particlesGameObject.SetActive(false);
    }
}
