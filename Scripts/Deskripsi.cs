using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deskripsi : MonoBehaviour
{
    [Header("Deskripsi Elektronik")]
    public Trackable[] tr;
    public string[] nama;
    [TextArea]
    public string[] deskripsi;

    [Header("UI Deskripsi")]
    public Text txtNama;
    public Text txtDeskripsi;

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i < tr.Length; i++)
        {
            if (tr[i].GetMarker())
            {
                txtNama.text = nama[i];
                txtDeskripsi.text = deskripsi[i];
            }
        }
    }
}