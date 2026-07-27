# Lab 6 - Kafka Integration using ASP.NET Core

## Objective

Integrate Apache Kafka with ASP.NET Core Web API to produce and consume messages.

---

## Technologies Used

- ASP.NET Core Web API (.NET 10)
- Apache Kafka
- Apache ZooKeeper
- Docker Desktop
- Docker Compose
- Confluent.Kafka
- Swagger UI

---

## Project Structure

```
Lab6_KafkaIntegration/
│
├── docker-compose.yml
├── KafkaDemoApi/
│   ├── Controllers/
│   │     └── MessageController.cs
│   ├── Services/
│   │     ├── KafkaProducerService.cs
│   │     └── KafkaConsumerService.cs
│   ├── Models/
│   │     └── MessageModel.cs
│   ├── Program.cs
│   └── appsettings.json
```

---

## Docker Setup

Start Kafka and ZooKeeper

```bash
docker compose up -d
```

Verify

```bash
docker ps
```

---

## Run the API

```bash
cd KafkaDemoApi
dotnet restore
dotnet build
dotnet run
```

Swagger

```
http://localhost:5269/swagger
```

---

## API Endpoint

### POST

```
/api/Message
```

Request

```json
{
  "message": "Hello Kafka"
}
```

Response

```
Message sent successfully
```

---

## Verify Kafka Consumer

Open another terminal

```bash
docker exec -it kafka kafka-console-consumer \
--bootstrap-server localhost:9092 \
--topic demo-topic \
--from-beginning
```

Output

```
Hello Kafka
```

---

## Outcome

Successfully implemented Kafka Producer and Consumer using ASP.NET Core Web API and Docker.