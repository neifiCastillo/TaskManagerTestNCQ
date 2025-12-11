<p align="center">
  <img src="https://svg-banners.vercel.app/api?type=origin&text1=TaskManager&text2=Administrador%20de%20Tareas&width=900&height=260" alt="TaskManager Banner"/>
</p>

TaskManager – Sistema de Gestión de Tareas

TaskManager es una aplicación de escritorio desarrollada en C# (.NET 6) con WinForms y DevExpress, diseñada para facilitar la administración de tareas.

Permite gestionar tareas, asignarlas a usuarios, establecer prioridades, controlar estados, aplicar filtros avanzados y trabajar con una interfaz limpia y moderna.
La aplicación utiliza SQLite como base de datos, lo que simplifica su distribución y portabilidad.

 📌Características principales:

    ✔️ Gestión completa de tareas (crear, editar, eliminar),

    🔄 Estados dinámicos: Pendiente, En proceso, Completada,

    📅 Control de fechas con validaciones automáticas,

    👤 Asignación de tareas por usuario,

    🔎 Filtros avanzados por usuario, prioridad, estado, rango de fechas y búsqueda general,

    🔐 Manejo seguro de sesiones: login, expiración, inactividad,

    🎨 UI moderna con DevExpress y restricciones según estado,

    ⚠️ Validación visual (ErrorProvider + reglas de negocio),

    🗄️ Base de datos SQLite integrada y auto-creada

🗂️ Estructura del Proyecto

    TaskManager/
    
    │── TaskManager.WinForms.UI/        # Capa de Presentación (UI)
    
    │── TaskManager.Application/        # Lógica de negocio
    
    │── TaskManager.Domain/             # Entidades, Enums, reglas de dominio
    
    │── TaskManager.Infrastructure/     # Repositorios y acceso a SQLite

🖥️ Requisitos del Sistema :

    -.NET	6.0 o superior 

    -DevExpress	23.1+ 

    -SQLite	Incluido automáticamente

    -Windows 10 / 11

⚙️ Configuración del entorno de desarrollo

1️⃣ Clona el repositorio

    git clone https://github.com/usuario/TaskManager.git
    
    cd TaskManager
2️⃣ Restaura las dependencias

    Desde Visual Studio:
    
    Build → Restore NuGet Packages O desde CLI: dotnet restore
3️⃣ Configura DevExpress (si aplica)

    Asegúrate de tener DevExpress WinForms instalado.
    
    Si falta algún paquete, Visual Studio mostrará advertencias para instalarlos.
4️⃣ Base de datos SQLite

    No requiere configuración externa.
    
    La aplicación crea automáticamente TaskManager.db en la carpeta bin si no existe.

5️⃣ Ejecutar la aplicación

    dotnet run --project TaskManager.WinForms.UI

🧠 Decisiones técnicas del proyecto

1. Arquitectura por capas (N-Capas / Clean Architecture)

       Separación clara de responsabilidades:

       Domain -> Entidades, enums y reglas del negocio
   
       Application ->	Servicios, validaciones, lógica
   
       Infrastructure ->  Acceso a SQLite
   
       UI (WinForms) ->	Interfaz visual usando DevExpress

✔️ Esto permite escalabilidad, mantenibilidad y testeo modular.

2. 🗄️ Uso de SQLite como base de datos 

Motivos:

     -No requiere instalación externa.

     -Ligera y altamente portable.

     -Perfecta para aplicaciones de escritorio.

     -Ideal para despliegues internos y pruebas.

3. 🎨 DevExpress para una UI moderna

Usado para:

    -Controles avanzados.
    
    -Grids con filtrado y edición dinámica.
    
    -Mejora UX profesional.

    -DateEditors con formato dd/MM/yyyy.

4. 🔐 Manejo de sesión y seguridad

Incluye:

    -Expiración configurable.
    
    -Logout manual y automático.
    
    -Validación de sesión al abrir la aplicación.
    
    -Restricciones de edición basadas en el estado de la tarea.

5. ✔️ Validaciones estrictas en formularios

Incluyen:

    -ErrorProvider con retroalimentación inmediata.
    
    -Reglas de contraseña (longitud + mayúsculas).
    
    -Bloqueo de espacios en contraseñas (helper reutilizable).
    
    -Fechas no permitidas menores al día actual.
 
🧩 Guía de estilo de código

Convenciones generales:

    PascalCase → clases, propiedades, métodos
    (TaskService, LoadTasks(), AssignedUserId)

    camelCase → variables locales y parámetros
    (taskList, userId, filter)

Métodos con una sola responsabilidad (SRP)

📝 Estructura sugerida de métodos

    private void MethodName()
    {
    // 1. Validaciones
    
    // 2. Lógica principal
    
    // 3. Actualización UI / retorno
    }

⚠️ Manejo de excepciones

    -Nunca capturar excepciones genéricas sin procesarlas. 

    -Se utiliza un ErrorHandler centralizado para mostrar mensajes amigables. 

💬 Comentarios

    -Únicamente cuando agreguen valor.

    -Evitar comentarios redundantes.

🚀 Mejoras futuras (opcional)

    -Sistema de roles (Administrador / Usuario)
    
    -Notificaciones por correo
    
    -Dashboard con estadísticas avanzadas
    
    -Exportación a Excel / PDF
    
    -Multilenguaje (ES/EN)

🤝 Contribuciones

¡Las sugerencias y mejoras son bienvenidas!
