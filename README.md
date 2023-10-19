# EmailSender
A class that recieves a message and sends to an email specificated in that specific class.

Data:
      Global:
            emailPath: In this example of the emailWorker i use a txt file to save the email in the user's PC. But you can get the string from anywhere, maybe set a Environment variable o from a DataBase.
      SetEmail:
            Same as emailPath, i write the email in a txtFile, this method can be modified to write in a database or a EnvVariable.
      GetEmail:
            Same as emailPath, i write the email in a txtFile, this method can be modified to write in a database or a EnvVariable.
      SendEmail(message/body of the email)
            vars:
                Subject: The subject of the email.
                fromAddress: there will be the email that sends the message, change it to the mail you will send messages automatically. and as the 2nd parameter you will put the display name of the email that is sending the message.
                to: This will be the reciever of the Email that you will automatically send.
                fromPassword: This isn't the password of your email/the email that you will use to send the messages, this is a key given by google, look at this article to get that key:                                                             https://support.google.com/accounts/answer/185833?hl=en-419&authuser=4

                
                
                
