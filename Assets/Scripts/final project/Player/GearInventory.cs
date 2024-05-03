using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GearInventory : MonoBehaviour
{

    #region Variables

    [Header("Prerequisites // Game Objects")]
    public List<Gear> inventory;
    Gear equippedGear;

    public GameObject flashlightObj;
    public Light flashlightLight;
    public GameObject flashlightUI;

    [Space]

    [Header("Gear #1: \"E-TEK Flashlight\"")]
    public Gear flashlightGear;
    public Slider batteryUI;
    public GameObject superchargeUI;
    [HideInInspector] public float battery;

    bool flashEquipped;
    bool flashCharging;
    bool supercharged;

    public float batteryChargeRate;
    public float batteryCPR; //CPR = Charge Per Rate

    public float batteryDimRate;
    public float batteryDPR; //DPR = Dim Per Rate
    float currentDimRate;
    public float chargedDimRate; //Dim rate when Supercharged, should be lower than normal Dim

    #endregion

    private void Start()
    {

        equippedGear = null;

        #region Flashlight Init

        flashCharging = false;
        supercharged = false;
        currentDimRate = batteryDimRate;
        battery = 100f;
        StartCoroutine(FlashlightDecay());
        StartCoroutine(FlashlightCharge());

        #endregion

    }

    private void Update()
    {

        #region Equipped Gear Checking

        EquipCheck();
        FlashlightCheck();

        #endregion

        #region Gear Actions

        //Flashlight
        if (battery < 0f)
            battery = 0f;

        if (!supercharged && battery > 100f)
            battery = 100f;

        if (battery > 200f)
            battery = 200f;

        if (supercharged)
            currentDimRate = chargedDimRate;
        else
            currentDimRate = batteryDimRate;

        if (supercharged && equippedGear == flashlightGear)
            superchargeUI.SetActive(true);
        else
            superchargeUI.SetActive(false);

        batteryUI.value = battery;
        flashlightLight.intensity = battery / 100f;
        ChargeToggle();
        //Debug.Log(battery);

        if (battery <= 0 && supercharged)
            supercharged = false;

        #endregion

        #region Debug Stuff

        //Flashlight
        if (DebugKeyHit(KeyCode.F))
            Supercharge();

        #endregion

    }

    #region Equipment Checking

    void EquipCheck()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {

            if (inventory[0] != null && equippedGear != inventory[0])
                equippedGear = inventory[0];
            else
            {

                equippedGear = null;
                Debug.Log("There is no gear in this slot!");

            }
                

        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            if (inventory[1] != null && equippedGear != inventory[1])
                equippedGear = inventory[1];
            else
            {

                equippedGear = null;
                Debug.Log("There is no gear in this slot!");

            }

        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {

            if (inventory[2] != null && equippedGear != inventory[2])
                equippedGear = inventory[2];
            else
            {

                equippedGear = null;
                Debug.Log("There is no gear in this slot!");

            }

        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {

            if (inventory[3] != null && equippedGear != inventory[3])
                equippedGear = inventory[3];
            else
            {

                equippedGear = null;
                Debug.Log("There is no gear in this slot!");

            }

        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {

            if (inventory[4] != null && equippedGear != inventory[4])
                equippedGear = inventory[4];
            else
            {

                equippedGear = null;
                Debug.Log("There is no gear in this slot!");

            }

        }

    }

    void FlashlightCheck()
    {

        if(equippedGear == flashlightGear)
        {

            flashlightObj.SetActive(true);
            flashlightUI.SetActive(true);
            

        }
        else if (equippedGear == null || equippedGear != flashlightGear)
        {

            flashlightObj.SetActive(false);
            flashlightUI.SetActive(false);

        }

        if(equippedGear == flashlightGear && !flashCharging)
            flashlightLight.enabled = true;
        else if (equippedGear == flashlightGear && flashCharging || equippedGear != flashlightGear)
            flashlightLight.enabled = false;

        if(battery <= 0f)
            flashlightLight.enabled = false;

    }

    #endregion

    #region #1 - Flashlight

    void ChargeToggle()
    {

        if (Input.GetKey(KeyCode.F) && equippedGear == flashlightGear && !supercharged)
            flashCharging = true;
        else
            flashCharging = false;

    }

    IEnumerator FlashlightDecay()
    {

        while(true)
        {

            yield return new WaitForSeconds(currentDimRate);

            if (!flashCharging && equippedGear == flashlightGear)
            {

                battery -= batteryDPR;
                FlashlightDecay();

            }

        }

    }

    IEnumerator FlashlightCharge()
    {

        while(true)
        {

            yield return new WaitForSeconds(batteryChargeRate);

            if (flashCharging)
            {

                battery += batteryCPR;
                FlashlightCharge();

            }

        }

    }

    public void Supercharge() //What happens when you give an unlimited battery flashlight...a battery...
    {

        supercharged = true;
        battery = 200f;

    }

    #endregion

    #region Debug

    bool DebugKeyHit(KeyCode key)
    {

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.RightControl) && Input.GetKeyDown(key))
            return true;
        else return false;

    }

    #endregion

}
