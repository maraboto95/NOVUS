using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript_Bolas : MonoBehaviour {

    [SerializeField]
    private GameObject bullet;
    [SerializeField]
    private GameObject bullet1;
    [SerializeField]
    private GameObject bullet2;



    private float speed = 8f;
    private float maxVelocity = 4f;

    private Rigidbody2D myBody;


    private bool canShoot;
    private bool canWalk;

    private int lives;

	// Use this for initialization
	void Awake () {
        initializeVariables();
		
	}
	
	// Update is called once per frame
	void Update () {
        Shoot();
		
	}

    void FixedUpdate()
    {
        PlayerWalk();
    }

    void Shoot()
    {
        if (Input.GetKey("z"))
        {
            if (canShoot)
            {
                canShoot = false;
                StartCoroutine(ShootTheBullet());
            }
        }

        if (Input.GetKey("x"))
        {
            if (canShoot)
            {
                canShoot = false;
                StartCoroutine(ShootTheBullet1());
            }
        }

        if (Input.GetKey("c"))
        {
            if (canShoot)
            {
                canShoot = false;
                StartCoroutine(ShootTheBullet2());
            }
        }
    }

    IEnumerator ShootTheBullet()
    {
        canWalk = false;
        Vector3 temp = transform.position;
        temp.y += 1.1f;
        Instantiate(bullet, temp, Quaternion.identity);

        yield return new WaitForSeconds(0.2f);
        canWalk = true;

        yield return new WaitForSeconds(0.3f);
        canShoot = true;
    }

    IEnumerator ShootTheBullet1()
    {
        canWalk = false;
        Vector3 temp = transform.position;
        temp.y += 1.1f;
        Instantiate(bullet1, temp, Quaternion.identity);

        yield return new WaitForSeconds(0.2f);
        canWalk = true;

        yield return new WaitForSeconds(0.3f);
        canShoot = true;
    }

    IEnumerator ShootTheBullet2()
    {
        canWalk = false;
        Vector3 temp = transform.position;
        temp.y += 1.1f;
        Instantiate(bullet2, temp, Quaternion.identity);

        yield return new WaitForSeconds(0.2f);
        canWalk = true;

        yield return new WaitForSeconds(0.3f);
        canShoot = true;
    }

    void initializeVariables()
    {
        myBody = GetComponent<Rigidbody2D>();
        canShoot = true;
        canWalk = true;
        lives = 4;

    }

    void PlayerWalk()
    {
        var force = 0f;
        var velocity = Mathf.Abs (myBody.velocity.x);

        float h = Input.GetAxis("Horizontal");


        if (canWalk)
        {
            if (h > 0)
            {
                if (velocity < maxVelocity)
                {
                    force = speed;
                }

                Vector3 scale = transform.localScale;
                scale.x = -0.8f;
                transform.localScale = scale;
            }
            else if (h < 0)
            {

                if (velocity < maxVelocity)
                {
                    force = -speed;
                }

                Vector3 scale = transform.localScale;
                scale.x = 0.8f;
                transform.localScale = scale;


            }
            else if (h == 0)
            {

            }
        }

        myBody.AddForce(new Vector2(force, 0));

    }

    IEnumerator KillThePlayerAndRestartTheGame()
    {

        if (lives <= 4)
        {

            transform.position = new Vector3(200, 200, 0);

            yield return new WaitForSeconds(1.5f);


            /* AQUI VA EL SCRIPT DE SALIR DEL JUEGO */
            PasarNivelScript.script.GanoPerd(false, "bolas");
        }
        else
        {
            lives--;
        }
       

    }


    void OnTriggerEnter2D(Collider2D target)
    {
        string[] name = target.name.Split();

        if(name.Length > 1)
        {
            if(name[1] == "Ball")
            {
                StartCoroutine(KillThePlayerAndRestartTheGame());
            }
        }
    }

}
