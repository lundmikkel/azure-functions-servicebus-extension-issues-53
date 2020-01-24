using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace ServiceBusConnection
{
    public static class Function
    {
        [FunctionName("ServiceBusTriggerQueue")]
        public static void ServiceBusTriggerQueue([ServiceBusTrigger("queue")] Message queueMessage, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {queueMessage}");
        }

        [FunctionName("ServiceBusTriggerTopic")]
        public static void ServiceBusTriggerTopic([ServiceBusTrigger("topic", "subscription")] Message topicMessage, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {topicMessage}");
        }
    }
}
