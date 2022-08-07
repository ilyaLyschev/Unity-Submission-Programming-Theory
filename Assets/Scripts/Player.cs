using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Camera gameCamera;
    public Projectile projectilePrefab;

    private class Constants
    {
        public const int PlayerNameMaxLength = 16;
    }

    private string playerName = null; // ENCAPSULATION
    
    public string PlayerName
    {
        get { return playerName; }
        set 
        { 
            playerName = value.Substring(0, Constants.PlayerNameMaxLength); 
        }
    }

    private void Update()
    {
        // if user preses the button 

        if (Input.GetMouseButtonDown(0))
        {
            // check if user clicked on the enemy or on the blank space

            var ray = gameCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                //the collider should be child of the Enemy class

                var enemy = hit.collider.GetComponentInParent<Enemy>();

                if (enemy != null)
                    this.FireProjectile(enemy);
                else
                    this.FireProjectile(hit.point);
            }
        }
    }

    public void FireProjectile(Vector3 point) // POLYMORPHISM // ABSTRACTION
    {
        SpawnProjectile(point);
    }

    public void FireProjectile(Enemy enemy) // POLYMORPHISM // ABSTRACTION
    {
        SpawnProjectile(enemy.transform.position);
    }

    private void SpawnProjectile(Vector3 point) // ABSTRACTION
    {
        // find the direction

        Vector3 direction = point - transform.position;

        // the direction should be in horizontal XZ-plane only to make the projectile moving horizontaly

        direction.y = 0;
        direction = direction.normalized;

        // spawn the projectile

        //Debug.DrawLine(transform.position, transform.position + direction * 10, Color.red, 5);
        Instantiate(projectilePrefab, transform.position, Quaternion.LookRotation(direction, Vector3.up));
    }
}
