using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SoccerBall : MonoBehaviour
{
    [SerializeField] private TMP_Text _pointsText;
    [SerializeField] private TMP_Text _timeText;
    [SerializeField] private ParticleSystem _goalVFX;

    // STEP 5: keep track of points
    private int _points = 0;

    // STEP 6: keep track of time since last goal
    private float _timeSinceLastGoal = 0f;

    // STEP 1 + 2 -------------------------------------------------------------
    private void OnTriggerEnter(Collider other)
    {
        // STEP 2: only trigger if the collider has the tag "Goal"
        if (other.CompareTag("Goal"))
        {
            MadeGoal(); // Call our goal method
        }
    }

    // STEP 3 + 4 -------------------------------------------------------------
    private void MadeGoal()
    {
        // STEP 4: play the goal VFX
        if (_goalVFX != null)
        {
            _goalVFX.Play();
        }

        // STEP 5: increase points and update text
        _points++;
        if (_pointsText != null)
        {
            _pointsText.text = "Points: " + _points;
        }

        // STEP 6: reset timer
        _timeSinceLastGoal = 0f;
    }

    // STEP 6 continued: update timer each frame
    private void Update()
    {
        // Increase the timer
        _timeSinceLastGoal += Time.deltaTime;

        // Update the text display
        if (_timeText != null)
        {
            _timeText.text = "Time Since Last Goal: " + _timeSinceLastGoal.ToString("F2") + "s";
        }
    }
}
