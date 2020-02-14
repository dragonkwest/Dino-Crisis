using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C#Notes : MonoBehaviour
{
    //Kellen Wardwell
    //Two forward slashes allows for comments these are not read  by the engine
    //the top part of the script is generally where we store the variables. Things like 
    //numbers, references to objects or references to other scripts
    //variables have three parts, the first part is public or private, 2nd is the type of variables,
    //third part is whatever we decide to name the variable

    // NUMBER VARIABLES
    // There are two common types of number variables- floats and ints
    public float number; //float stands for floating point number which means the number has a decimal point 1.25 is a float
    public int wholenumber; // 1,2,3, are ints
    private float myhiddennumber; // a private variable is not visible in the inspector

    //BOOLS (true/false statements)
    public bool yesorno; // a bool is a yes or no statement, a binary, think of it like a light switch, either on or off, no in between

    //Other common variables
    public GameObject mygameObject; //we can reference any object in our scene. all items in the heirachy are considered gameobjects
    public CSharpNotes CSN; // we can also reference any script that we have written as long as it's public
    public Rigidbody2D myRB2d; // we use rigid bodies on players and enemies and anything we want to have physics
    public BoxCollider2D myboxcollider; //we can reference colliders of all types
    public CircleCollider2D mycirclecollider; //we usually put these references at top of script we need to call them here first if we want to manipulate them later in the script

    //start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        //anything we want to happen when the game starts goes in here 
        //sometimes we don't want to have to manually drag and drop items in the inspector
        //sometimes we want to spawn new items during gameplay. In this case we can use a few simple commands to have the script automatically find objects

        myRB2d = GetComponent<Rigidbody2D>(); //this will get the rigid body but only if its on the sameobject as our script
        myRB2d = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody2D>();
        //this will find any object in our scene that has the tag player and get its rigidbody
        myRB2d = GameObject.FindObjectOfType<Rigidbody2D>();
        //this only works when there is no more than one rigidbody

        //when the game starts we also might want to look at a few different properties of our gameobjects, transform, position, rotation, and scale
        transform.position = new Vector2(0, 0);
        //the transform position is our location on x and y. transforms are read by unity as something called a vector(vector 2 or vector 3). Think of a vector like a bar graph 
        //X is horizontal, Y vertical axis
        //the vector 2 above is at the origin position another example would be
        Transform.position = new Vector2(24, 128); //this would move us 24 units right and 128 units up
        //We can also manipulate scale this way
        Transform.localScale = new Vector2(0, 0); //2D
        Transform.localScale = new Vector3(0, 0, 0); //3d both these scales would be invisible rotation is a little more complicated we use quaternion and EULER(pronounced oiler)
        Transform.rotation = Quaternion.Euler(0, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        //inside the update function we call things that we want to update in real time as we play the game

        //IF STATEMENTS
        if (yesorno == true)
        {
            //we say yes
            //the player lives
        }

        if (yesorno == false)
        {
            //we say no
            //the player dies
        }

        //this is an example of how bools can work. if the bool is true one thing happens
        //if the bool is false something else happens
        //for the if statement to work we need a double equal sign. A single equal sign means that the bool IS true or IS false whereas a double equal sign checks to see if it IS true or false

        if(number >=10)
        {
            //we do something
        }

        //we can also use statements to control the player
        if(Input.GetAxis("horizontal")>0)
        {
            //we move the player
            myRB2d.velocity = new Vector2(25, 0);
        }
        if (Input.GetAxis("Horizontal") == 0)
            //we want to stop the player
            myRB2d.velocity = new Vector2(0, 0); //this is 0 velocity to see all the different rigidbody options we have to just start typing my RB2d

        myRB2d.gravityScale = .5f; //gives me half gravity
        myRB2d.simulated = false; //this means the rigidbody is no longer affected by the physics engine
        myRB2d.isKinematic = true; // kinematic rigidbody only moves if the code tells it to 
        myRB2d.isKinematic = false; //non kinematic is the same as a dynamic which means its affected by the physics engine

        //IF ELSE STATEMENTS
        //if statements get read one after another which can sometimes cause weird behavior, we can avoid this by using IF ELSE Statements

        if (yesorno == true)
        {
            //we say yes
            //the player lives
            //if this turns out to be true we won't read the below statement
        }

        else if (yesorno == false)
        {
            //we say no
            //the player dies
            //if the above statement is not true we will read this statement
        }

        //because this code is in the update loop changes can happen quickly and we can cycle through multiple if statements faster than we want to. this is why we use else
    }

    public void FixedUpdate()
    {
        //regular update is based on frame rate which means a newer computer will run the code faster than an older computer will run the code slower. this is not ideal
        //for the most part graphical elements can live inside the update loop without any issue. the fixed update loop is used for physics calculations as it's called on a
        //set interval which means that all computers run the code at the same speed.
    }
}
