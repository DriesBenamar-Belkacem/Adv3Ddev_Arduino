/* Testprog serial port from Arduino threaded
 * Wim Van Weyenberg
 * 18/09/2018
 * In Start() wordt de comport geopend (stel juiste naam in van de Arduino Port!) en wordt ook de thread gestart om data te ontvangen en te zenden
 * Ontvangen en zenden gebeurt in dezelfde thread
 * Ontvangen moet via aparte thread omdat we sp.ReadTimeout = 20 ms lang moeten wachten om te weten of er iets ontvangen is.
 * Als er data ontvangen is wordt deze in update getoond via Debug.Log
 * Om dat te zenden gebruiken we hier de A en U toets op het keyboard
 * You have to set the File -> Build Settings -> Player Settings -> API Compatibility Level to .NET2.0 (NOT the subset).
 */


using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System.Threading;
using System;

public class SerialCommThreaded : MonoBehaviour
{
    public GameManagerArduino gameMgrArd;
    public SerialPort data_stream = new SerialPort("COM3", 9600);
    public string receivedstring;
    public int recv_angl;
    void Start()
    {
        data_stream.Open();
    }

    void Update()
    {
        receivedstring = data_stream.ReadLine();
        string[] datas = receivedstring.Split(',');
        //convert string to float
        recv_angl = Mathf.RoundToInt(float.Parse(datas[0]));
        string inp = datas[1];
       
        HandleInput(inp);
        //Debug.Log(recv_angl + datas[1]);
        if (Input.GetKeyDown(KeyCode.T))
        {
            data_stream.Write("t");//alles opkuisen en booleans gebruiken
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            data_stream.Write("o");//alles opkuisen en booleans gebruiken
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            data_stream.Write("b");//alles opkuisen en booleans gebruiken
        }
    }
    
    void HandleInput(string inputChar)
    {
        if (inputChar == "R")
        {
            moveCube.right = true;
        }
        if (inputChar == "L")
        {
            moveCube.left = true;
        }
        if (inputChar == "F")
        {
            moveCube.forw = true;
        }
        if (inputChar == "B")
        {
            moveCube.backw = true;
        }
    }

}