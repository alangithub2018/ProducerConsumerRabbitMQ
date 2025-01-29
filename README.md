# 🐰 RabbitMQ .NET Producer & Consumer 🎯

![RabbitMQ](https://upload.wikimedia.org/wikipedia/commons/7/71/RabbitMQ_logo.svg)

This project is a **.NET** solution that implements a **Producer** and a **Consumer** using **RabbitMQ**. Its purpose is to demonstrate the core functionality of message exchange via queues, facilitating efficient and scalable communication between services. 🚀

## 📌 Features

✅ **RabbitMQ** implementation in **.NET**  
✅ **Producer**: Sends messages to the queue  
✅ **Consumer**: Listens and processes messages from the queue  
✅ Uses **Docker** to quickly set up a RabbitMQ server  
✅ Practical and modular example for testing and learning  

---

## 🛠️ Technologies Used

- 🟣 **.NET 6/7/8**
- 🐰 **RabbitMQ**
- 🐳 **Docker (Optional)**

---

## 📦 Installation and Execution

### 🚀 Step 1: Clone the Repository
```bash
git clone https://github.com/youruser/rabbitmq-dotnet-example.git
cd rabbitmq-dotnet-example
```

### 🐳 Step 2: Start RabbitMQ with Docker (Optional)
If you do not have a RabbitMQ server installed, you can use **Docker**:
```bash
docker run -d --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:management
```
Access the web administration panel at:  
🔗 **http://localhost:15672** (Username: `guest`, Password: `guest`)

### ⚙️ Step 3: Configure RabbitMQ in the Project
Modify `appsettings.json` to match your environment:
```json
"RabbitMQ": {
  "Host": "localhost",
  "Username": "guest",
  "Password": "guest"
}
```

### ▶️ Step 4: Run the Producer and Consumer
Compile and run each service in separate instances:

#### Producer (Sends messages)
```bash
dotnet run --project Producer
```
#### Consumer (Receives and processes messages)
```bash
dotnet run --project Consumer
```

---

## 📜 Example of a Message Sent by the Producer
```json
{
  "id": "12345",
  "timestamp": "2025-01-29T10:00:00Z",
  "message": "Hello from RabbitMQ Producer in .NET!"
}
```

---

## 📖 Workflow Explanation
1️⃣ **Producer** publishes a message to RabbitMQ.  
2️⃣ **RabbitMQ** queues the message.  
3️⃣ **Consumer** subscribes to the queue and automatically receives the message.  
4️⃣ **Consumer** processes the message and prints it to the console.  

---

## 📌 Future Roadmap 🚀
- [ ] Add **retry mechanisms** in the Consumer.  
- [ ] Implement **persistent messages** to prevent data loss.  
- [ ] Improve logging and system monitoring.  

---
Try asynchronous communication with **RabbitMQ and .NET** in a simple and practical way! 🐰🎯

## 👨‍💻 Contribution and Contact
If you want to improve the project or report an issue, pull requests are welcome! 🎉  
📩 Contact: [licalan.sistemas@gmail.com](mailto:licalan.sistemas@gmail.com)  
