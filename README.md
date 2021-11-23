# [Projeto-Console-HabbitMQ](http://www.macoratti.net/21/04/vda140421.htm) - RabbitMQ Macoratti

## Visão Geral do projeto
 A aplicação feita em console aplication, tem o intuito de mostra de forma de modo simple o funcionamento de fluxo de mensageria através do RabbitMQ em aplicação console

**Ambiente de Desenvolvimento**
- *Tipo:* Backend
- *Plataforma:* Console
- *Linguagem:* C#
- *Framework:* .NET Core

**Requisitos**:
    - Visual Studio ou Visual Code 
    - versão .net 5
    - Chocolatey

# Procedimento
**Instalação do Chocolatey:**
- link: https://chocolatey.org/install 
- Executar o comando no PowerShell modo adminstrador: Set-ExecutionPolicy Bypass -Scope Process -Force; [System.Net.ServicePointManager]::SecurityProtocol = [System.Net.ServicePointManager]::SecurityProtocol -bor 3072; iex ((New-Object System.Net.WebClient).DownloadString('https://community.chocolatey.org/install.ps1'))
- Em seguida, Executar o comando: choco install rabbitmq
- Habilitar o plugin de gerenciamento do RabbitMQ - Dashboard
  usando o prompt de comando entre no seguinte caminho : C:\Program Files\RabbitMQ Server\rabbitmq_server-3.9.8\sbin
   execute o comando: rabbitmq-plugins enable rabbitmq_management
- no navegador digete o endereço : http://localhost:15672/#/
 Usename: guest
 Password: guest

# Instalação do RabbitMQ no Projeto:
- Package Manager: Install-Package RabbitMQ.Client -Version 6.2.1
- NET CLI : dotnet add package RabbitMQ.Client --version 6.2.1

    
         

