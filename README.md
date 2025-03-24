<h1>Proyecto CRUD - MVC y APIs REST</h1>

<h2>Descripción</h2>
<p>Este proyecto es una implementación de un CRUD de estudiantes utilizando el patrón de diseño MVC y una API REST. Se interactúa con la base de datos SQL Server mediante <strong>Entity Framework Core</strong>.</p>

<h2>Tecnologías</h2>
<ul>
  <li><strong>.NET 6</strong></li>
  <li><strong>ASP.NET MVC</strong></li>
  <li><strong>SQL Server</strong></li>
  <li><strong>Entity Framework Core</strong></li>
</ul>

<h2>Instalación</h2>
<ol>
  <li>Clona el repositorio:</li>
  <pre><code>git clone https://github.com/tu_usuario/tu_repositorio.git</code></pre>
  <li>Restaura los paquetes NuGet:</li>
  <pre><code>dotnet restore</code></pre>
  <li>Configura la cadena de conexión en <strong>appsettings.json</strong>.</li>
  <li>Realiza las migraciones de la base de datos:</li>
  <pre><code>dotnet ef database update</code></pre>
  <li>Ejecuta el proyecto:</li>
  <pre><code>dotnet run</code></pre>
  <p>Accede a la aplicación en <strong>https://localhost:5001</strong>.</p>
</ol>

<h2>API Endpoints</h2>
<ul>
  <li><strong>GET /api/students</strong> - Obtiene todos los estudiantes.</li>
  <li><strong>GET /api/students/{id}</strong> - Obtiene un estudiante por ID.</li>
  <li><strong>POST /api/students</strong> - Crea un nuevo estudiante.</li>
  <li><strong>PUT /api/students/{id}</strong> - Actualiza un estudiante existente.</li>
  <li><strong>DELETE /api/students/{id}</strong> - Elimina un estudiante por ID.</li>
</ul>

<h2>Licencia</h2>
<p>Licencia MIT</p>
