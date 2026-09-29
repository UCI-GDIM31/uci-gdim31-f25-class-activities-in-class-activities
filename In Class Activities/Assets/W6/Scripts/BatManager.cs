using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BatManager : MonoBehaviour
{
    [Header("Bat Setup")]
    [SerializeField] private BatW6[] _bats;              // assign all bats in Inspector
    [SerializeField] private Transform _playerTransform;  // player to chase

    [Header("Messages")]
    [SerializeField] private string[] _messages;         // cheeky messages
    [SerializeField] private TMP_Text _reactionUiPrefab; // TMP prefab (child of bat canvas)
    [SerializeField] private float _overlapDistance = 1.0f;    // distance to show message
    [SerializeField] private float _interactDistance = 5.0f;   // distance to chase
    [SerializeField] private float _timeBetweenNewMessages = 0.5f; // delay between messages
    [SerializeField] private Vector3 _textLocalOffset = new Vector3(0, 2, 0); // text above bat

    private float[] _newTextTimers;

    private void Start()
    {
        _newTextTimers = new float[_bats.Length];

        foreach (BatW6 bat in _bats)
        {
            if (bat != null)
                bat.SetPlayer(_playerTransform);
        }
    }

    private void Update()
    {
        for (int i = 0; i < _bats.Length; i++)
        {
            BatW6 bat = _bats[i];
            if (bat == null) continue;

            float distance = Vector3.Distance(bat.transform.position, _playerTransform.position);

            // --- Chase logic ---
            if (distance < _interactDistance)
                bat.StartChasing();
            else
                bat.StopChasing();

            // --- Message logic ---
            _newTextTimers[i] += Time.deltaTime;
            if (distance < _overlapDistance && _newTextTimers[i] >= _timeBetweenNewMessages)
            {
                ShowCheekyMessage(bat);
                _newTextTimers[i] = 0f;
            }
        }
    }

    private void ShowCheekyMessage(BatW6 bat)
    {
        if (_reactionUiPrefab == null || _messages.Length == 0) return;

        string message = _messages[Random.Range(0, _messages.Length)];

        // Ensure there is a world-space canvas on the bat
        Canvas canvas = bat.GetComponentInChildren<Canvas>();
        if (canvas == null)
        {
            GameObject canvasGO = new GameObject("BatCanvas");
            canvasGO.transform.SetParent(bat.transform);
            canvasGO.transform.localPosition = Vector3.zero;
            canvasGO.transform.localRotation = Quaternion.identity;

            canvas = canvasGO.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.WorldSpace;

            CanvasScaler scaler = canvasGO.AddComponent<CanvasScaler>();
            scaler.dynamicPixelsPerUnit = 10f; // Makes text easier to read in world space

            canvasGO.AddComponent<GraphicRaycaster>();
        }

        // Instantiate TMP text
        TMP_Text textObj = Instantiate(_reactionUiPrefab, canvas.transform);
        textObj.transform.localPosition = _textLocalOffset;

        // Set scale to something readable but not giant
        textObj.transform.localScale = Vector3.one * 0.10f; // Adjust between 0.03f - 0.07f as needed

        // Assign message
        textObj.text = message;

        // Auto-destroy after 2 seconds
        Destroy(textObj.gameObject, 2f);
    }
}
