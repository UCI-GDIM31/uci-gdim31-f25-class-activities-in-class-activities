using TMPro;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsText;
    [SerializeField] private TMP_Text _timeText;
    [SerializeField] private ParticleSystem _goalVFX;

    // STEP 1 -----------------------------------------------------------------
    private int _points = 0;
    private float _timeSinceLastGoal = 0f;
    private void Update()
    {
        _timeSinceLastGoal += Time.deltaTime;
        _timeText.text = "Time: " + _timeSinceLastGoal.ToString("0.0") + "s";
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Goal"))
        {
            MadeGoal();
        }
    }

    // STEP 1 -----------------------------------------------------------------

    private void MadeGoal()
    {
        Debug.Log("GOAL! SoccerBall entered the goal trigger.");

        _goalVFX.Play();


        // STEP 5 -----------------------------------------------------------------
            _points++;
            _pointsText.text = "Points: " + _points;
            _timeSinceLastGoal = 0f;
    }
}
