using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basics : MonoBehaviour {

    int player = 1;
    string participant;
    bool x, y;
    float score;
    float damn;
    float swiggy;
    int kleinergleich;
    int groessergleich;
    int kleiner;
    int groesser;


    // Use this for initialization
    void Start () 
    {
        // variablen declariert
        bool muede;
        char category;
        byte none;
        long none1;
        short none2;
        double none3;

        addOne();
        setName();
        testbool();
        getScore();
        getDamn();
        getSwiggy();
        getKleinergleich();
        getGroessergleich();
        getKleiner();
        getGroesser();
        int  test = getNumber();
        Debug.Log(test);
        Debug.Log("------4-2-0------");
        Debug.Log(getNumber());

    }

    void addOne()
    {
        player = player + 1;
        Debug.Log("player =" + player);
    }

    int getNumber()
    {
        return 5;
    }

    void setName()
    {
        participant = "Max Mustermann";
        Debug.Log(participant);
    }

    void testbool()
    {
        x = true;
        y = true;
        Debug.Log("w oder f" + (x&y));
        Debug.Log("bedingt w oder f" + (x && y));
    }

    void getScore()
    {
        score = 420;
        score = score / 187;
        Debug.Log("score =" + score);
    }
	
    void getDamn()
    {
        damn = 420;
        Debug.Log("damn =" + (damn * 2));
    }

    void getSwiggy()
    {
        swiggy = 420;
        swiggy = swiggy % 5;
        Debug.Log("swiggy =" + swiggy);
    }

    void getKleinergleich()
    {
        kleinergleich = 420;
        Debug.Log("420 kleinergleich 187?" + (kleinergleich <= 187));
    }

    void getGroessergleich()
    {
        groessergleich = 420;
        Debug.Log("420 groessegleich 187?" + (groessergleich >= 187));
    }

    void getKleiner()
    {
        kleiner = 420;
        Debug.Log("420 kleiner 187?" + (kleiner < 187));
    }

    void getGroesser()
    {
        groesser = 420;
        Debug.Log("420 groesser 187?" + (groesser > 187));
    }

    // Update is called once per frame
    void Update () 
    {
		
	}
}
