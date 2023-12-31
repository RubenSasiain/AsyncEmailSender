    public class EmailWorker
    {
        public static string emailPath = "C:/User/Document/Where/The/Email/Is/Saved";

        public async void SendEmail(string body)
        {
            try
            {
                string toAddress = GetEmail();
                string subject = "Subject";

                var fromAddress = new MailAddress("EmailThatSendsMessages@gmail.com", "Display Name In The Mail");
                var to = new MailAddress(toAddress, toAddress);
                const string fromPassword = "123456789qwerty"; // Isn't the password of the email, is a key given by Google Mail, see "readme.md" file

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                using (var message = new MailMessage(fromAddress, to)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    await smtp.SendMailAsync(message);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public static async void SetEmail(string newMail)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(emailPath))
                {
                    await writer.WriteLineAsync($"{newMail}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while saving the email: {ex.Message}");
            }
        }
        public static string GetEmail()
        {
            string retEmail = "";
            try
            {
                if (File.Exists(emailPath))
                {
                    retEmail = File.ReadLines(emailPath).Last();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while reading email from the file: {ex.Message}");
            }

            return retEmail;
        }
    }
