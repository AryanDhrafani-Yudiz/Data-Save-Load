using UnityEngine;
using TMPro;

public class PlayerTransformScript : MonoBehaviour
{
    public Transform playerTransform;
    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        playerTransform = GetComponent<Transform>();
    }
    void Update()
    {
        text.text = " X: " + playerTransform.position.x.ToString("0.00") + " Y: " + playerTransform.position.y.ToString("0.00") + " Z: " + playerTransform.position.z.ToString("0.00");
    }

    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        Vector3 position;
        position.x = data.position[0]; position.y = data.position[1]; position.z = data.position[2];

        transform.position = position;
    }
}