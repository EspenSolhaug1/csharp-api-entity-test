﻿namespace workshop.wwwapi.DTOs
{
    public class AppointmentDoctorDTO
    {
        public DateTime Booking { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
    }
}
