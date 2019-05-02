using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using GoogleVR.HelloVR;

//class Program

[AddComponentMenu("Scripts/OSCTestSender")]

public class OSCTestSender :MonoBehaviour{
    
    private Osc oscHandler;

    public float tid;
    public string remoteIp;
    public int sendToPort;
    public int listenerPort;
    /*TimeSpan ts = stopwatch.Elapsed; 
    Stopwatch stopWatch = new Stopwatch();*/
    private ObjectController myScript;

    void Start()
    {

        
        UDPPacketIO udp = GetComponent<UDPPacketIO>();
        udp.init(remoteIp, sendToPort, listenerPort);

        oscHandler = GetComponent<Osc>();
        oscHandler.init(udp);
        
        myScript = GetComponent<ObjectController>();
    }

    ~OSCTestSender()
    {
        if (oscHandler != null)
        {
            oscHandler.Cancel();
        }

        // speed up finalization
        oscHandler = null;
        System.GC.Collect();
    }

    public void SetGazedAt(bool gazedAt)
    {
        //stopWatch.Start();
        tid = Time.time;
        OscMessage oscM = Osc.StringToOscMessage("/looking 1.0");
        oscHandler.Send(oscM);
    }   
        public void SetGazedOut(bool gazedAt)
    {
        if (Time.time - tid >= 5){
            Debug.Log ("Jeg virker ;D");
            
           // myScript.TeleportRandomly();
        }
        /*stopWatch.Stop();
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Millisecons / 10);*/
        //Og nu skal VI PRØVE AT G*RE NOGET MED ELAPSEDTIME.
        OscMessage oscM = Osc.StringToOscMessage("/looking 1.0");
        oscHandler.Send(oscM);
    }


}
