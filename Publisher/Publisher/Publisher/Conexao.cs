using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Publisher
{
    class Conexao
    {
        //Configurações

        public static void SendRow<T>(List<T> list)
        {
            string hostName = "localhost";
            string userName = "guest";
            string password = "guest";
            string queueName = "Pmenos";

            //Cria a conexão com o RabbitMq
            var factory = new ConnectionFactory()
            {
                HostName = hostName,
                UserName = userName,
                Password = password,
            };

            //Cria a conexão
            IConnection connection = factory.CreateConnection();

            //cria a canal de comunicação com a rabbit mq
            IModel channel = connection.CreateModel();

            //Cria a fila caso não exista
            channel.QueueDeclare(queue: queueName, durable: true, exclusive: false, autoDelete: false, arguments: null);

            var mensagem = $"Enviando a mensagem";
            byte[] body = Encoding.Default.GetBytes(mensagem);
            
            //Seta a mensagem como persistente
            IBasicProperties properties = channel.CreateBasicProperties();
            properties.Persistent = true;
            
            //Envia a mensagem para fila
            channel.BasicPublish(exchange: String.Empty, routingKey: queueName, basicProperties: properties, body: body);
            Console.WriteLine(mensagem);
        }

    }
}
