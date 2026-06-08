using System;

class Program
{
    static void Main()
    {
        INotificationService notification =
            new WhatsAppNotification();

        notification.Send(
            "Doctor Consultation Completed");

        IPaymentService payment =
            new CreditCardPayment();

        payment.Pay(1500);

        MedicalReportService report =
            new MedicalReportService();

        report.GenerateReport("Anu");
    }
}