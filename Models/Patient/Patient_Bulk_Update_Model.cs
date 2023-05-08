﻿namespace HospitalDemo.Models.Patient
{
    public class Patient_Bulk_Update_Model
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }

        public DateTime date_of_birth { get; set; }
        public int age { get; set; }
        public string address { get; set; }
        public string contact_details { get; set; }
    }
}
