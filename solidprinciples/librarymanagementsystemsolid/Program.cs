using System;

class Program
{
    static void Main()
    {
        FacultyMembership faculty =
            new FacultyMembership("Anu");

        faculty.Display();

        IAlertService email =
            new EmailAlert();

        email.SendAlert(
            "Book return due tomorrow");

        IAlertService sms =
            new SmsAlert();

        sms.SendAlert(
            "Membership renewed successfully");
    }
}