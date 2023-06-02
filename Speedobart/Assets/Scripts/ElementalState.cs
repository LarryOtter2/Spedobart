using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementalState : MonoBehaviour
{
    #region
    public void Start()
    {
        DefaultState();
    }

    public enum Element
    {
        Fire,
        Water,
        Earth,
        Lightning
    }

    public Element CurrentState
    {
        get;
        set;
    }

    public void DefaultState()
    {
        SwitchState(Element.Fire);
    }

    public void SwitchState(Element newState)
    {
        if (CurrentState == newState)
        {
            Debug.Log(message: "Cant enter-" + newState.ToString() + "-Allready in this State");
            return;
        }

        CurrentState = newState;

        switch (newState)
        {
            case Element.Fire:
                {
                    break;
                }

            case Element.Water:
                {
                    break;
                }

            case Element.Earth:
                {
                    break;
                }

            case Element.Lightning:
                {
                    break;
                }

        }

    }
#endregion

    public void ChangeElement()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            SwitchState(Element.Water);
        }

    }

    public void Update()
    {
        ChangeElement();
    }

}
