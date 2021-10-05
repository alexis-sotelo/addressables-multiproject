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

    string playerPreference;

    public void Init_UIField (
        string description, UnityAction<string> confirmAction )
    {
        m_DescriptionLabel.text = description;
        m_OnClickConfirm = confirmAction;

        m_ConfirmButton.onClick.AddListener( OnClick );
    }

    public void Init_UIField(
    string description, UnityAction<string> confirmAction, string playerPref)
    {
        m_DescriptionLabel.text = description;
        m_OnClickConfirm = confirmAction;
        playerPreference = playerPref;

        m_ConfirmButton.onClick.AddListener(OnClick);

        if (false == string.IsNullOrEmpty(playerPreference))
            m_InputField.text = PlayerPrefs.GetString(playerPreference, null);
    }

    void OnClick ()
    {
        if (m_OnClickConfirm != null)
        {
            m_OnClickConfirm.Invoke(m_InputField.text);

            if (false == string.IsNullOrEmpty(playerPreference))
                PlayerPrefs.SetString(playerPreference, m_InputField.text);
        }
    }

}
