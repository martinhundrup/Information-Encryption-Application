using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Mail;

using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Authentication
{
    // responsible for sending emails to the user's email
    internal static class Emailer
    {

        public static void Email(string email)
        {

            // for the code, hash the email, hash the UTC, bitwise & them, then convert to string
            // use the last 6 chars of this string for verification

            var hash1 = Hashing.Hash(email);
            var hash2 = Hashing.Hash(DateTime.Now.ToString());

            var result = Hashing.Combine(hash1, hash2);

            string hash = Hashing.HashToString(result);
            Console.WriteLine($"generated hash: {hash}");

            try
            {
                // Set up the email details
                string fromEmail = "EncryptionDoNotReply@gmail.com"; // Sender email address
                string toEmail = email; // Recipient email address
                string subject = "Test Email";
                string body = $"Hello, your code is {hash.Substring(hash.Length - 7, 6)}";
                string smtpServer = "smtp.gmail.com"; // Gmail SMTP server
                int smtpPort = 587; // Gmail uses port 587 for TLS
                string? emailPassword = Environment.GetEnvironmentVariable("ENCRYPTION_APP_PASSWORD");

                // Create the email message
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromEmail);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;

                // Set up the SMTP client
                SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort)
                {
                    Credentials = new NetworkCredential(fromEmail, emailPassword),
                    EnableSsl = true // Enable SSL for secure connection
                };

                // Send the email
                smtpClient.Send(mail);
                Console.WriteLine("Email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
            }

        }

        
    }
}
