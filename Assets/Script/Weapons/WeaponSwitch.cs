using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public int currentWeapon;

    void Start()
    {
        SelectWeapon();
    }

    void SelectWeapon()
    {
        int i = 0;
        foreach (Transform weapon in transform)
        {
            if (i == currentWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }

    public void SwitchWeapon()
    {
        int previousSelected = currentWeapon;

        if (currentWeapon >= transform.childCount - 1)
            currentWeapon = 0;
        else
            currentWeapon++;

        if (previousSelected != currentWeapon)
            SelectWeapon();
    }
}
