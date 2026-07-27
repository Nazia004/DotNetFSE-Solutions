using Confluent.Kafka;

namespace KafkaDemoApi.Services
{
    public class KafkaConsumerService
    {
        private readonly IConfiguration _configuration;

        public KafkaConsumerService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Consume()
        {
            var config = new ConsumerConfig
            {
                BootstrapServers = _configuration["Kafka:BootstrapServers"],
                GroupId = "demo-group",
                AutoOffsetReset = AutoOffsetReset.Earliest
            };

            using var consumer = new ConsumerBuilder<Ignore, string>(config).Build();

            consumer.Subscribe(_configuration["Kafka:Topic"]);

            Console.WriteLine("Waiting for messages...");

            while (true)
            {
                var result = consumer.Consume();

                Console.WriteLine($"Received: {result.Message.Value}");
            }
        }
    }
}