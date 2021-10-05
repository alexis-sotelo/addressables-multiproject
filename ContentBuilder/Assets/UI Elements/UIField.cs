using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class UIField : MonoBehaviour
{
    [SerializeField] Text m_DescriptionLabel;
    [SerializeField] InputField m_InputField;
    [SerializeField] Button m_ConfirmButton;

    UnityAction<string> m_OnClickConfirm;

    public void Init_UIField (
        string description, UnityAction<string> confirmAction)
    {
        m_DescriptionLabel.text = description;
        m_OnClickConfirm = confirmAction;

        m_ConfirmButton.onClick.AddListener( OnClick );
    }

    void OnClick ()
    {
        m_OnClickConfirm?.Invoke( m_InputField.text );
    }
}
