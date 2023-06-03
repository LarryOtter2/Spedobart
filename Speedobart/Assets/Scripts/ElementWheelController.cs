using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class ElementWheelController : MonoBehaviour
{
    public Animator anim;
    private bool weaponEheelSelected = false;
    public Image selectedElement;
    public Sprite noImage;
    public static int elementID;


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            weaponEheelSelected = !weaponEheelSelected;
        }

        if(weaponEheelSelected)
        {
            anim.SetBool("OpenWeaponWheel", true);
        }
        else
        {
            anim.SetBool("OpenWeaponWheel", false);
        }

        switch(elementID)
        {
            case 1:
                ElementalState.ElementInstance.SwitchState(ElementalState.Element.Fire);
                break;
            case 2:
                //selectedElement.sprite = fireIcon;
                ElementalState.ElementInstance.SwitchState(ElementalState.Element.Earth);
                break;
            case 3:
                //selectedElement.sprite = fireIcon;
                ElementalState.ElementInstance.SwitchState(ElementalState.Element.Water);
                break;
            case 4:
                //selectedElement.sprite = fireIcon;
                ElementalState.ElementInstance.SwitchState(ElementalState.Element.Lightning);
                break;

        }

    }
}
