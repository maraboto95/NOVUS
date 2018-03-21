using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript_Bolas : MonoBehaviour {

    private float forceX, forceY;

    private Rigidbody2D myBody;

    [SerializeField]
    private bool moveLeft, moveRight;

    [SerializeField]
    private GameObject linealBall;

    [SerializeField]
    private GameObject cuadraticaBall;

    [SerializeField]
    private GameObject constanteBall;

    [SerializeField]
    private GameObject errorLinealBall;

    [SerializeField]
    private GameObject errorCuadraticaBall;

    [SerializeField]
    private GameObject errorConstanteBall;





    private GameObject ball1, ball2;
    private BallScript_Bolas ball1Script, ball2Script;
    private TextMesh ball1Text, ball2Text;

    // Use this for initialization
    void Awake () {
        myBody = GetComponent<Rigidbody2D>();
        SetBallSpeed();
		
	}
	
	// Update is called once per frame
	void Update () {
        MoveBall();
	}

    void InstantiateBalls()
    {

         string[] lineArr = new string[10];

        lineArr[0] = "f(x)=x+3";
        lineArr[1] = "f(x)=4x+1";
        lineArr[2] = "f(x)=y+6";
        lineArr[3] = "f(x)=z+3+5²";
        lineArr[4] = "f(x)=2(6x+2)";
        lineArr[5] = "f(x)=2x";
        lineArr[6] = "f(x)=x";
        lineArr[7] = "f(x)=4²+x";
        lineArr[8] = "f(x)=8+3x";
        lineArr[9] = "f(x)=2x+1";


        string[] cuadrArr = new string[10];
        cuadrArr[0] = "f(x)=3x²+3";
        cuadrArr[1] = "f(x)=5(x²+x+1)";
        cuadrArr[2] = "f(x)=x²+6x";
        cuadrArr[3] = "f(x)=x+8x²";
        cuadrArr[4] = "f(x)=(x)²";
        cuadrArr[5] = "f(x)=x²+3x+4";
        cuadrArr[6] = "f(x)=5x²";
        cuadrArr[7] = "f(x)=x²+4x+3x²";
        cuadrArr[8] = "f(x)=x²+5";
        cuadrArr[9] = "f(x)=2x²+2x+2";


        if (this.gameObject.tag != "Small Ball" && this.gameObject.tag != "Small Ball 1" && this.gameObject.tag != "Small Ball 2")
        {


            int jue = Random.Range(0, 3);

            if (jue == 0)
            {

                ball1 = Instantiate(linealBall);

                ball1.name = linealBall.name;

                ball1Script = ball1.GetComponent<BallScript_Bolas>();

                ball1Text = ball1.GetComponentInChildren<TextMesh>();

                ball1Text.text = lineArr[Random.Range(0, 10)];

                

            }
            else if (jue == 1)
            {

                ball1 = Instantiate(constanteBall);

                ball1.name = constanteBall.name;

                ball1Script = ball1.GetComponent<BallScript_Bolas>();

                ball1Text = ball1.GetComponentInChildren<TextMesh>();

                ball1Text.text = "f(x)=" + Random.Range(-20, 20).ToString();

            }
            else if (jue == 2)
            {

                ball1 = Instantiate(cuadraticaBall);

                ball1.name = cuadraticaBall.name;

                ball1Script = ball1.GetComponent<BallScript_Bolas>();

                ball1Text = ball1.GetComponentInChildren<TextMesh>();

                ball1Text.text = cuadrArr[Random.Range(0, 10)];

            }


            int jua = Random.Range(0, 3);

            if (jua == 0)
            {

                ball2 = Instantiate(linealBall);

                ball2.name = linealBall.name;

                ball2Script = ball2.GetComponent<BallScript_Bolas>();

                ball2Text = ball2.GetComponentInChildren<TextMesh>();

                ball2Text.text = lineArr[Random.Range(0, 10)];



            }
            else if (jua == 1)
            {

                ball2 = Instantiate(constanteBall);

                ball2.name = constanteBall.name;

                ball2Script = ball2.GetComponent<BallScript_Bolas>();

                ball2Text = ball2.GetComponentInChildren<TextMesh>();

                ball2Text.text = "f(x)=" + Random.Range(-20, 20).ToString();

            }
            else if (jua == 2)
            {

                ball2 = Instantiate(cuadraticaBall);

                ball2.name = cuadraticaBall.name;

                ball2Script = ball2.GetComponent<BallScript_Bolas>();

                ball2Text = ball2.GetComponentInChildren<TextMesh>();

                ball2Text.text = cuadrArr[Random.Range(0, 10)];

            }


        }
    }

    void InstantiateWrongBalls()
    {

        string[] lineArr = new string[10];

        lineArr[0] = "f(x)=x+3";
        lineArr[1] = "f(x)=4x+1";
        lineArr[2] = "f(x)=y+6";
        lineArr[3] = "f(x)=z+3+5²";
        lineArr[4] = "f(x)=2(6x+2)";
        lineArr[5] = "f(x)=2x";
        lineArr[6] = "f(x)=x";
        lineArr[7] = "f(x)=4²+x";
        lineArr[8] = "f(x)=8+3x";
        lineArr[9] = "f(x)=2x+1";


        string[] cuadrArr = new string[10];
        cuadrArr[0] = "f(x)=3x²+3";
        cuadrArr[1] = "f(x)=5(x²+x+1)";
        cuadrArr[2] = "f(x)=x²+6x";
        cuadrArr[3] = "f(x)=x+8x²";
        cuadrArr[4] = "f(x)=(x)²";
        cuadrArr[5] = "f(x)=x²+3x+4";
        cuadrArr[6] = "f(x)=5x²";
        cuadrArr[7] = "f(x)=x²+4x+3x²";
        cuadrArr[8] = "f(x)=x²+5";
        cuadrArr[9] = "f(x)=2x²+2x+2";


        int jue = Random.Range(0, 3);

            if (jue == 0)
            {

                ball1 = Instantiate(errorLinealBall);

                ball1.name = errorLinealBall.name;

                ball1Script = ball1.GetComponent<BallScript_Bolas>();

            ball1Text = ball1.GetComponentInChildren<TextMesh>();

            ball1Text.text = lineArr[Random.Range(0, 10)];

        }
            else if (jue == 1)
            {

                ball1 = Instantiate(errorConstanteBall);

                ball1.name = errorConstanteBall.name;

                ball1Script = ball1.GetComponent<BallScript_Bolas>();

            ball1Text = ball1.GetComponentInChildren<TextMesh>();

            ball1Text.text = "f(x)=" + Random.Range(1, 20).ToString();

        }
            else if (jue == 2)
            {

                ball1 = Instantiate(errorCuadraticaBall);

                ball1.name = errorCuadraticaBall.name;

                ball1Script = ball1.GetComponent<BallScript_Bolas>();

            ball1Text = ball1.GetComponentInChildren<TextMesh>();

            ball1Text.text = cuadrArr[Random.Range(0, 10)];


        }


        int jua = Random.Range(0, 3);

        if (jua == 0)
        {

            ball2 = Instantiate(errorLinealBall);

            ball2.name = errorLinealBall.name;

            ball2Script = ball2.GetComponent<BallScript_Bolas>();

            ball2Text = ball2.GetComponentInChildren<TextMesh>();

            ball2Text.text = lineArr[Random.Range(0, 10)];

        }
        else if (jua == 1)
        {

            ball2 = Instantiate(errorConstanteBall);

            ball2.name = errorConstanteBall.name;

            ball2Script = ball2.GetComponent<BallScript_Bolas>();

            ball2Text = ball2.GetComponentInChildren<TextMesh>();

            ball2Text.text = "f(x)=" + Random.Range(1, 20).ToString();

        }
        else if (jua == 2)
        {

            ball2 = Instantiate(errorCuadraticaBall);

            ball2.name = errorCuadraticaBall.name;

            ball2Script = ball2.GetComponent<BallScript_Bolas>();

            ball2Text = ball2.GetComponentInChildren<TextMesh>();

            ball2Text.text = cuadrArr[Random.Range(0, 10)];




        }



    }

    void InitializeBallsAndTurnOffCurrentBall()
    {
        InstantiateBalls();

        Vector3 temp = transform.position;
        ball1.transform.position = temp;
        ball1Script.SetMoveLeft(true);


        ball2.transform.position = temp;
        ball2Script.SetMoveRight(true);

        ball1.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 2f);
        ball2.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 2f);

        gameObject.SetActive(false);
    }

    void InitializeWrongBallsAndTurnOffCurrentBall()
    {
        InstantiateWrongBalls();

        Vector3 temp = transform.position;
        ball1.transform.position = temp;
        ball1Script.SetMoveLeft(true);


        ball2.transform.position = temp;
        ball2Script.SetMoveRight(true);

        ball1.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 2f);
        ball2.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 2f);

        gameObject.SetActive(false);
    }

    public void SetMoveLeft(bool canMoveLeft)
    {
        this.moveLeft = canMoveLeft;
        this.moveRight = !canMoveLeft;
    }

    public void SetMoveRight(bool canMoveRight)
    {
        this.moveRight = canMoveRight;
        this.moveLeft = !canMoveRight;
    }



    void MoveBall()
    {
        if (moveLeft)
        {
            Vector3 temp = transform.position;
            temp.x -= forceX * Time.deltaTime;
            transform.position = temp;
        }

        if (moveRight)
        {
            Vector3 temp = transform.position;
            temp.x += forceX * Time.deltaTime;
            transform.position = temp;
        }
    }

    void SetBallSpeed()
    {
        forceX = 2.5f;

        switch (this.gameObject.tag)
        {

            case "Largest Ball":
                forceY = 11.5f;
                break;
            case "Large Ball":
                forceY = 11f;

                break;
            case "Medium Ball":
                forceY = 10.5f;

                break;
            case "Small Ball":
                forceY = 10f;

                break;
            case "Smallest Ball":
                forceY = 9.5f;
                break;

            case "Largest Ball 1":
                forceY = 11.5f;
                break;
            case "Large Ball 1":
                forceY = 11f;

                break;
            case "Medium Ball 1":
                forceY = 10.5f;

                break;
            case "Small Ball 1":
                forceY = 10f;

                break;
            case "Smallest Ball 1":
                forceY = 9.5f;
                break;

            case "Largest Ball 2":
                forceY = 11.5f;
                break;
            case "Large Ball 2":
                forceY = 11f;

                break;
            case "Medium Ball 2":
                forceY = 10.5f;

                break;
            case "Small Ball 2":
                forceY = 10f;

                break;
            case "Smallest Ball 2":
                forceY = 9.5f;
                break;

        }

    }


    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Ground")
        {
            myBody.velocity = new Vector2(0, forceY);
        }

        if (target.tag == "Left Wall")
        {
            SetMoveRight(true);
        }

        if (target.tag == "Right Wall")
        {
            SetMoveLeft(true);
        }

        if (target.tag == "Bullet")
        {

            if (gameObject.tag == "Largest Ball" || gameObject.tag == "Large Ball" || gameObject.tag == "Medium Ball" || gameObject.tag == "Small Ball" || gameObject.tag == "Smallest Ball")
            { 
                
                if (gameObject.tag != "Small Ball")
                {
                    InitializeBallsAndTurnOffCurrentBall();

                }
                else
                {
                    gameObject.SetActive(false);
                }
            }  else
            {
                InitializeWrongBallsAndTurnOffCurrentBall();
            } 
        }//bullet0

        if (target.tag == "Bullet 1")
        {

            if (gameObject.tag == "Largest Ball 1" || gameObject.tag == "Large Ball 1" || gameObject.tag == "Medium Ball 1" || gameObject.tag == "Small Ball 1" || gameObject.tag == "Smallest Ball 1")
            {

                if (gameObject.tag != "Small Ball 1")
                {
                    InitializeBallsAndTurnOffCurrentBall();

                }
                else
                {
                    gameObject.SetActive(false);
                }
            }
            else
            {
                InitializeWrongBallsAndTurnOffCurrentBall();
            }
        }//bullet1


        if (target.tag == "Bullet 2")
        {

            if (gameObject.tag == "Largest Ball 2" || gameObject.tag == "Large Ball 2" || gameObject.tag == "Medium Ball 2" || gameObject.tag == "Small Ball 2" || gameObject.tag == "Smallest Ball 2")
            {

                if (gameObject.tag != "Small Ball 2")
                {
                    InitializeBallsAndTurnOffCurrentBall();

                }
                else
                {
                    gameObject.SetActive(false);
                }
            }
            else
            {
                InitializeWrongBallsAndTurnOffCurrentBall();
            }
        }//bullet0

    }//on trigger



    





}
