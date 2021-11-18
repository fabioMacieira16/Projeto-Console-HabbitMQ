using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Consumer
{
    class Conexao
    {
        public static void SendRow()
        {
            string hostName = "localhost";
            string queueName = "Pmenos";

            // Cria a conexão com RabbitMQ
            var factory = new ConnectionFactory()
            {
                HostName = hostName,
            };

            //Cria uma conexçao 
            IConnection connection = factory.CreateConnection();

            //Cria um canal de comunicação com RabbitMQ
            IModel channel = connection.CreateModel();

            //Cria uma Fila 
            channel.QueueDeclare(queue: queueName, durable: true, exclusive: false, autoDelete: false, arguments: null );

            var consumer = new EventingBasicConsumer(channel);

            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray();
                var message = Encoding.UTF8.GetString(body);
            };

            channel.BasicConsume(queue: queueName, autoAck: true, consumer: consumer);
            Console.WriteLine("Msg Recebida");

        }
    }
}
