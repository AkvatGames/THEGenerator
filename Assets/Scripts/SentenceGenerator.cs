using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SentenceGenerator : MonoBehaviour
{

    public Text thePerspective;
    public Text theGenre;
    public Text theRules;
    public Text thePlace;
    public Text theObjective;
    public Text theWildcard;

    public GameObject theGenreGO;
    public GameObject theRulesGO;
    public GameObject thePlaceGO;
    public GameObject theObjectiveGO;
    public GameObject theWildcardGO;

    public Button theGenreButton;
    public Button theRulesButton;
    public Button thePlaceButton;
    public Button theObjectiveButton;
    public Button theWildcardButton;

    public Button generateButton;
    public Button panelButton;
    public Button copyButton;
    public Button sentenceButton;

    public InputField sentenceField;

    public Text theSentence;

    //string generatedIdea;

    private void Update()
    {
        sentenceField.text = "A " + (thePerspective.text) + " " + (theGenre.text) + " " + (theRules.text) + " set " + (thePlace.text) + ". The player must " + (theObjective.text) + ". They " + (theWildcard.text) + ".";
    }

    public void CopyText()
    {
        TextEditor te = new TextEditor();
        te.text = theSentence.text;
        te.SelectAll();
        te.Copy();
        string.Copy("A " + (thePerspective.text) + " " + (theGenre.text) + " " + (theRules.text) + " set " + (thePlace.text) + ". The player must " + (theObjective.text) + ". They " + (theWildcard.text) + ".");
        GUIUtility.systemCopyBuffer = ("A " + (thePerspective.text) + " " + (theGenre.text) + " " + (theRules.text) + " set " + (thePlace.text) + ". The player must " + (theObjective.text) + ". They " + (theWildcard.text) + ".");
    }

    public void SentenceWriter()
    {
        Offer();
        StartCoroutine(GeneratingText());
        StartCoroutine(Onner());

    }

    public void LockOn()
    {
        StartCoroutine(TurnOnLocks());
    }

    public IEnumerator GeneratingText()
    {
        //yield return new WaitForSeconds(3.0f);
        theSentence.text = "Generating   ";
        yield return new WaitForSeconds(.25f);
        theSentence.text = "Generating.  ";
        yield return new WaitForSeconds(.25f);
        theSentence.text = "Generating.. ";
        yield return new WaitForSeconds(.25f);
        theSentence.text = "Generating...";
        yield return new WaitForSeconds(.25f);
        theSentence.text = "Generating   ";
        yield return new WaitForSeconds(.25f);
        theSentence.text = "Generating.  ";
        yield return new WaitForSeconds(.25f);
        theSentence.text = "Generating.. ";
        yield return new WaitForSeconds(.25f);
        theSentence.text = "Generating...";
        yield return new WaitForSeconds(.25f);
        theSentence.text = "Generating   ";
        yield return new WaitForSeconds(.25f);
        theSentence.text = "Generating.  ";
        yield return new WaitForSeconds(.25f);
        theSentence.text = "Generating.. ";
        yield return new WaitForSeconds(.25f);
        theSentence.text = "Generating...";
        yield return new WaitForSeconds(0.25f);
        theSentence.text = ("A " + (thePerspective.text) + " " + (theGenre.text) + " " + (theRules.text) + " set " + (thePlace.text) + ". The player must " + (theObjective.text) + ". They " + (theWildcard.text) + ".");
        //yield return new WaitForSeconds(3.0f);
    }

    public void Offer()
    {
        sentenceButton.interactable = false;
        copyButton.interactable = false;
        theWildcardButton.interactable = false;
        theObjectiveButton.interactable = false;
        thePlaceButton.interactable = false;
        theRulesButton.interactable = false;
        theGenreButton.interactable = false;
        generateButton.interactable = false;
        panelButton.interactable = false;
        //yield return new WaitForSeconds(5);
    }

    public IEnumerator Onner()
    {
        yield return new WaitForSeconds(2.0f);
        generateButton.interactable = true;
        panelButton.interactable = true;
        theGenreButton.interactable = true;
        theRulesButton.interactable = true;
        thePlaceButton.interactable = true;
        theObjectiveButton.interactable = true;
        theWildcardButton.interactable = true;
        copyButton.interactable = true;
        sentenceButton.interactable = true;
    }

    public void QuickWrite()
    {

        Offer();
        theSentence.text = ("A " + (thePerspective.text) + " " + (theGenre.text) + " " + (theRules.text) + " set " + (thePlace.text) + ". The player must " + (theObjective.text) + ". They " + (theWildcard.text) + ".");
        StartCoroutine(Onner());    
    }


    public IEnumerator TurnOnLocks()
    {
        yield return new WaitForSeconds(0.75f);
        theGenreGO.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        theRulesGO.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        thePlaceGO.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        theObjectiveGO.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        theWildcardGO.SetActive(true);
    }
}
