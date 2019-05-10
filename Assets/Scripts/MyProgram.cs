
using UnityEngine;
using Rol;
using UnityEngine.UI;

public class MyProgram : MonoBehaviour
{

    public InputField inputField;

    public void Show()
    {
        string classSelected = inputField.text;

        Class clase = null;
        switch (classSelected)
        {
            case "1":
                clase = new Wizard("Wizard");
                break;

            case "2":
                clase = new Warrior("Warrior");
                break;
            case "3":
                clase = new Healer("Healer");
                break;
        }

        if (clase != null)
            Debug.Log("You choose " + clase.Clase());
    }

}
