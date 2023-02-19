using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 1f;
    public float boostSpeed = 2f;
    public float defaultSpeed = 1f;
    public float maxEnergy = 100f;
    public float energyRegenRate = 10f;
    public float boostEnergyCost = 20f;
    private float currentEnergy;
    public Text energyText;



    // Start is called before the first frame update
    void Start()
    {
        currentEnergy = maxEnergy;
        // Find the Text component of the energyText object
        energyText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(moveHorizontal, 0f, speed);

        if (Input.GetKeyDown(KeyCode.Space) && currentEnergy >= boostEnergyCost)
        {
            currentEnergy -= boostEnergyCost;
            speed += boostSpeed;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            speed = defaultSpeed;
        }

        if (currentEnergy < maxEnergy)
        {
            currentEnergy += energyRegenRate * Time.deltaTime;
            currentEnergy = Mathf.Min(currentEnergy, maxEnergy);
        }

        transform.position += movement * speed * Time.deltaTime;

        // Update the text of the energyText object with the current energy value
        energyText.text = "Energy: " + Mathf.Round(currentEnergy);
    }
}
