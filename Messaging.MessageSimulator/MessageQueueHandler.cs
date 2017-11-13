using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Messaging.MessageSimulator
{   
    public class MessageQueueHandler : IMessageQueueHandler
    {
        private IMessageQueue<string> _inComingMessages;
        private string _overallCommunication;
        private string _singleResponse;

        public string getSingleResponse(string inComingMessage)
        {
            string response = "";
            switch (inComingMessage)
            {
                case "Hi, How are you doing?":
                    response = "Not too bad.. Hope you're all doing OK";
                    break;
                case "Hi, How's your day going so far today!":
                    response = "Not that bad, quite busy with customers";
                    break;
                case "What time you will be back home":
                    response = "I'll try to leave on time!";
                    break;
                case "We are all missing you":
                    response = "Missing you too, see you soon";
                    break;
                default:
                    response = "Busy with customers, get back to you soon";
                    break;
            }
            return response;
        }


        public void FillQueueWithMessages(IMessageQueue<string> inComingMessages)
        {
            inComingMessages.Enqueue("Hi, How are you doing?");
            inComingMessages.Enqueue("Hi, How's your day going so far!");
            inComingMessages.Enqueue("What time you will be back home");
            inComingMessages.Enqueue("We are all missing you");
            inComingMessages.Enqueue("Random Message");
            _inComingMessages = inComingMessages;
        }

        public void ShowCommunication()
        {
            int i = 1;            
            string separator = "\n......\n"; 

            foreach (string inComingMessage in _inComingMessages)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Message Recieved {0}: {1}", i++, inComingMessage);
                Console.Write("Response Writing: ");
                Thread.Sleep(2000);
                _singleResponse = getSingleResponse(inComingMessage);
                foreach (char c in _singleResponse)
                {
                    Console.Write(c);
                    Thread.Sleep(50);
                }
                Console.WriteLine(separator);
                _overallCommunication += "Message Recieved " + i + ": " + inComingMessage + "\n" + "Response Writing: " + _singleResponse + "\n\n";
            }
        }

        public string GetCommunicationResults
        {
            get
            {
                return _overallCommunication;
            }
        }

    }

    
}
