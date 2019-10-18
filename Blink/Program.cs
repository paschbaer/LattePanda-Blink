using System;
using System.Threading;
using System.IO.Ports;
using LattePanda.Firmata;

namespace Blink
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Arduino ...");

            //user that runs this program must be added to group 'dialout'
            //sudo adduser <user> dialout
            Arduino arduino = new Arduino();

            int pin = 13;   //digital pin 13 is LED
            arduino.pinMode(pin, Arduino.OUTPUT);           //set diqgital pin as output
            while (true)
            {
                arduino.digitalWrite(pin, Arduino.HIGH);    //set LED on
                Thread.Sleep(500);
                arduino.digitalWrite(pin, Arduino.LOW);     //set LED off
                Thread.Sleep(500);
            }

        }
    }
}
