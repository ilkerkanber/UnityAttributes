using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[HelpURL("https://github.com/ilkerkanber")]
public class Player : MonoBehaviour
{
    [Header("Personal Informations")]
    [SerializeField] string Name;
    [SerializeField] string surName;
    [Space]
    [Tooltip("0-100 Arasý deðer giriniz")]
    [SerializeField] int Point;

    [UnityEditor.MenuItem("Tools/Red")]
    public static void SetColorRed()
    {
        Debug.Log("Renk Kýrmýzý Yap");
    }
}
