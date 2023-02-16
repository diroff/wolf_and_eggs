using TMPro;
using UnityEngine;

public class LifeDisplay : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TextMeshProUGUI _lifeText;

    private void OnEnable()
    {
        _player.HealthChanged += DisplayHealth;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= DisplayHealth;
    }

    private void DisplayHealth(int count)
    {
        _lifeText.text = "x" + count;
    }
}
