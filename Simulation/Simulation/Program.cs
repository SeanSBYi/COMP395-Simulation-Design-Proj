using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Simulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Patients patient = new Patients();

            for(int i = 0; i < 10; i++){
                patient.GeneratePatient();
                patient.patientList[i] = patient.GeneratePatient();
            }
            patient.MakeLine();

            for(int i=0; i<patient.patientList.Count;i++)
            {
                patient.GeneratePatient();//generate patients
                Console.Out.WriteLine(patient);
                Console.ReadKey();
            }
        }

    }
    public class Patients
    {

        int patientID = 0;
        string patientType;
        bool firstInLine = false;
    
        int countPatient; //How many patients in the waiting room

        //Decided to use list instead of array in case the length of the queue is not always equal to 10.
        //Patients[] patientArray = new Patients[10];
        public List<Patients> patientList = new List<Patients>();


        //The line moves forward one by one if the first in line is gone
        public void MoveForward()
        {
            int i=0;
            foreach (Patients patient in patientList)
            {
                patientList[i] = patientList[i + 1];
            }
        }
        //The line moves backward one by one if the first in line is gone
        public void MoveBackward()
        {
            int i = 0;
            
            foreach (Patients patient in patientList)
            {
                patientList[i] = patientList[i - 1];
            }
        }

        //generate a new patient with different chances to be green, red or yellow
        public  Patients GeneratePatient()
        {
            Patients newPatient = new Patients();
            patientID++;

            Random rand = new Random();
            int num = rand.Next(1, 100);
            if (num < 10)
            {
                patientType = "red";
            }
            if (num >= 10 && num < 40)
            {
                patientType = "red";
            }
            else
                patientType = "green";
            return newPatient;
        }

        //put 10 patients in a line
        public void MakeLine()
        {
            for (int i = 0; i < patientList.Count; i++)
            {
                patientList[i] = GeneratePatient();
            }
        }



        //generate a new patient and get him in line base on his type
        public void NewPatientInLine()
        {
            Patients newPatient = new Patients();
            newPatient = GeneratePatient();

            if (newPatient.patientType == "green" || newPatient.patientType == "yellow")
            {
                patientList[patientList.Count-1] = newPatient;
            }
            if (newPatient.patientType == "red")
            {
                patientList[0] = newPatient;
            }
            countPatient++;
        }

    }
}
