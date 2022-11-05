using UnityEngine;
using TMPro;
using System.Collections;

public class Damagable : MonoBehaviour
{
    [SerializeField] int startHealth = 10;
    [SerializeField] TMP_Text textfield;
    [SerializeField] Color fullHealthColor = Color.green;
    [SerializeField] Color zeroHealthColor = Color.red;
    [SerializeField] GameObject gameOverCanvas;
  //  [SerializeField] MonoBehaviour turnOffAtDeath;
    [SerializeField] int currentHealth = 10;

    [SerializeField] float invincibilityTime = 1;
    bool isInvincible;
    int health;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = startHealth;
        UpdateText();


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void DoDamage(int value)
    {
        if (value <= 0) return;
        if (isInvincible) return;

        currentHealth += value;
        currentHealth = Mathf.Max(currentHealth, 0);
        if (currentHealth == 0)
        {
            gameOverCanvas.SetActive(true);
          //  turnOffAtDeath = false;
        }
        UpdateText();
        StartCoroutine(InvicibilityCoroutine());
    }
    IEnumerator InvicibilityCoroutine()
    {
        isInvincible = true;
        MeshRenderer[] allRenderers = GetComponentsInChildren<MeshRenderer>();
        foreach (var renderer in allRenderers)
        {
            renderer.enabled = false;
        }

        const float flickTime = 0.1f;
        bool visible = false;

        for(int i = 0; i > (invincibilityTime / flickTime); i++)
        {
            SetVisibility(allRenderers, visible);
            visible = !visible;
            yield return new WaitForSeconds(invincibilityTime);
        }
        SetVisibility(allRenderers, true);

        isInvincible = false;
    }
    void SetVisibility(MeshRenderer[] allRenderers, bool visible)
    {
        foreach (var renderer in allRenderers)
        { renderer.enabled = visible; }
    }
    void UpdateText()
    {
        if (textfield != null)
        { 
        
        }
    }
}