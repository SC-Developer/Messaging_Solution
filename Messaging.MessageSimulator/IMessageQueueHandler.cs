using System;
using System.Collections.Generic;
using System.Text;

namespace Messaging.MessageSimulator
{
    public interface IMessageQueueHandler
    {
        string getSingleResponse(string inComingMessage);
        void FillQueueWithMessages(IMessageQueue<string> inComingMessages);
        void ShowCommunication();
        string GetCommunicationResults { get; }
    }
}
