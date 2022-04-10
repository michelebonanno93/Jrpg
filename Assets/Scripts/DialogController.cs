using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogController : MonoBehaviour
{
   [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private Image image;

    private void Start()
    {
        dialogueText.enabled = false;
        image.enabled = false;
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Prova")
        {
            dialogueText.SetText("PROVA DIALOGO TRIGGER");
            dialogueText.enabled = true;
            image.enabled = true;
        }
        wait();
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
        dialogueText.enabled = false;
        image.enabled = false;
    }
}
