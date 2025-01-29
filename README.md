# 🐰 RabbitMQ .NET Producer & Consumer 🎯

![RabbitMQ](https://upload.wikimedia.org/wikipedia/commons/7/71/RabbitMQ_logo.svg)

Este proyecto es una solución en **.NET** que implementa un **Producer** y un **Consumer** utilizando **RabbitMQ**. Su propósito es demostrar la funcionalidad principal del intercambio de mensajes mediante colas, facilitando la comunicación entre servicios de manera eficiente y escalable. 🚀

## 📌 Características

✅ Implementación de **RabbitMQ** en **.NET**  
✅ **Producer**: Envía mensajes a la cola  
✅ **Consumer**: Escucha y procesa los mensajes de la cola  
✅ Uso de **Docker** para levantar un servidor RabbitMQ en segundos  
✅ Ejemplo práctico y modular para pruebas y aprendizaje  

---

## 🛠️ Tecnologías Utilizadas

- 🟣 **.NET 6/7/8**
- 🐰 **RabbitMQ**
- 🐳 **Docker (Opcional)**

---

## 📦 Instalación y Ejecución

### 🚀 Paso 1: Clonar el Repositorio
```bash
git clone https://github.com/tuusuario/rabbitmq-dotnet-example.git
cd rabbitmq-dotnet-example
```

### 🐳 Paso 2: Levantar RabbitMQ con Docker (Opcional)
Si no tienes un servidor RabbitMQ instalado, puedes usar **Docker**:
```bash
docker run -d --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:management
```
Accede a la interfaz web de administración en:  
🔗 **http://localhost:15672** (Usuario: `guest`, Contraseña: `guest`)

### ⚙️ Paso 3: Configurar RabbitMQ en el Proyecto
En `appsettings.json`, ajusta la configuración de RabbitMQ según tu entorno:
```json
"RabbitMQ": {
  "Host": "localhost",
  "Username": "guest",
  "Password": "guest"
}
```

### ▶️ Paso 4: Ejecutar el Producer y el Consumer
Compila y ejecuta cada servicio en instancias separadas:

#### Producer (Envía mensajes)
```bash
dotnet run --project Producer
```
#### Consumer (Recibe y procesa mensajes)
```bash
dotnet run --project Consumer
```

---

## 📜 Ejemplo de Mensaje Enviado por el Producer
```json
{
  "id": "12345",
  "timestamp": "2025-01-29T10:00:00Z",
  "message": "Hola desde RabbitMQ Producer en .NET!"
}
```

---

## 📖 Explicación del Flujo
1️⃣ **Producer** publica un mensaje en RabbitMQ.  
2️⃣ **RabbitMQ** encola el mensaje en una **queue**.  
3️⃣ **Consumer** se suscribe a la queue y recibe el mensaje automáticamente.  
4️⃣ **Consumer** procesa el mensaje y lo muestra en consola.  

---

## 📌 Roadmap Futuro 🚀
- [ ] Agregar **mecanismos de reintento** en el Consumer.  
- [ ] Incluir **mensajes persistentes** para evitar pérdida de datos.  
- [ ] Mejorar el logging y monitoreo del sistema.  

---

## 👨‍💻 Contribución y Contacto
Si deseas mejorar el proyecto o reportar un problema, ¡los Pull Requests son bienvenidos! 🎉  
📩 Contacto: [TuEmail@example.com](mailto:TuEmail@example.com)  

---

¡Prueba la comunicación asíncrona con **RabbitMQ y .NET** de forma sencilla y práctica! 🐰🎯
