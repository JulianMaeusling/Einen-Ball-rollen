using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PickUp : MonoBehaviour {
    // Eingesammelte Objekte
    private int points;
    // Checkpoints
    private int checkPoints;
    // Anzeige obriger Variablen
    public Text score;
    public Text checkScore;
    // Bool zum betreten des nächsten Level
    private bool nextLvl = false;
    // Bonus Wände
    public GameObject bonusWall;
    // Bonus Licht
    public Light bonusLight;

    // NUR EDITOR: ZUM DEBUGGEN
    public bool editScore;
    public bool editCheckScore;
    public int editorScore;
    public int editorCheckScore;

    // Beim Start
    private void Start()
    {
        // NUR EDITOR: ZUM DEBUGGEN
        if (editScore == true)
            PlayerPrefs.SetInt("Points", editorScore);
        if (editCheckScore == true)
            PlayerPrefs.SetInt("CheckPoints", editorCheckScore);

        // Wenn es den Key "Points" gibt, dann ist die Variable points der Key
        if (PlayerPrefs.HasKey("Points"))
            points = PlayerPrefs.GetInt("Points");
        // Wenn es den Key "CheckPoints" gibt, dann ist die Variable checkPoints der Key
        if (PlayerPrefs.HasKey("CheckPoints"))
            checkPoints = PlayerPrefs.GetInt("CheckPoints");
    }

    // Rufe in jedem Frame auf
    private void Update()
    {
        // Anzeige der Punktzahl
        score.text = "Score: " + points;
        // Anzeige der Checkpoints
        checkScore.text = "CheckScore: " + checkPoints;
    }

    // Bei Berührung eines Triggers
    void OnTriggerEnter(Collider other)
    {
        // Bei Berührung eines pickableObject
        if (other.gameObject.CompareTag("PickUp"))
        {
            // verschwindet es
            other.gameObject.SetActive(false);
            // wird ein Punkt hinzugefügt
            points++;

            //Level 1
            // Wenn die Punktzahl 6 beträgt
            if (points == 6)
            {
                // Füge einen CheckPoint hinzu
                checkPoints++;
                // Setze nextLvl auf wahr
                nextLvl = true;
            }

            // DeleteWall Methode aufrufen
            DeleteWall();
        }

        // Wenn der Tag des berührten Objektes "NextLevel" ist
        if(other.gameObject.CompareTag("NextLevel"))
        {
            // Erhöhe die Checkpoints
            checkPoints += 1;
            // Setze nextLvl auf Wahr
            nextLvl = true;
        }

        // Wenn nextLvl auf wahr steht prüfe ob
        if (nextLvl == true)
        {
            // checkPoints auf 1 steht
            if (checkPoints == 1)
            {
                // Lade das zweite Level
                SceneManager.LoadScene("lvl2");
                // Setze nextLvl auf Falsch
                nextLvl = false;
            }
            
            // checkPoints auf 2 steht
            if(checkPoints == 2)
            {
                // Lade das dritte Level
                SceneManager.LoadScene("lvl3");
                // Setze nextLvl auf Falsch
                nextLvl = false;
            }
        }
    }

    // Wenn das Script zerstört wird
    private void OnDestroy()
    {
        // Setze die Keys
        PlayerPrefs.SetInt("Points", points);
        PlayerPrefs.SetInt("CheckPoints", checkPoints);
    }

    // DeleteWall Methode
    private void DeleteWall()
    {
        // Wenn 10 Punkte erreicht sind
        if (points == 10)
        {
            // Zerstöre die Bonuswand
            bonusWall.SetActive(false);
            // Entferne das PointLight
            bonusLight.intensity = 0;
        }
    }
}