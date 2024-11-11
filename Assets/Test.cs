using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public TMP_InputField inputField;

    void OnEnable()
    {
        inputField.onEndEdit.AddListener(_ =>
        {
            EventSystem.current.SetSelectedGameObject(null);
        });
    }
}
