# CalculadoraCientifica
![El Salvador](https://img.shields.io/badge/Country-El%20Salvador-0047AB?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![Offline](https://img.shields.io/badge/Works-Offline-success?style=for-the-badge)

Aplicación de escritorio completamente local para realizar operaciones aritméticas elementales y cálculos científicos avanzados mediante **Windows Forms** y **C#**.

La aplicación calcula:

- Operaciones básicas (Suma, Resta, Multiplicación, División)
- Funciones trigonométricas (Seno, Coseno, Tangente)
- Logaritmos (Natural `Ln` y Base 10 `Log10`)
- Potencias y Raíces (Cuadrada y Cúbica)
- Funciones especiales (Factorial, Exponencial, Valor Absoluto, Módulo)

No requiere conexión a Internet, bases de datos ni dependencias externas. Se ejecuta directamente en el entorno de escritorio de Windows.

---

# Características

- Separación clara entre la interfaz gráfica y la lógica interna mediante Programación Orientada a Objetos.
- Procesamiento en tiempo real con conversión automática de unidades (ej. grados a radianes en trigonometría).
- Control estricto de excepciones matemáticas y campos vacíos mediante alertas interactivas.
- Páneles organizados (`GroupBox`) para clasificar operaciones básicas y científicas.
- Botones de control rápido para limpiar campos de texto y salir del sistema.
- Ayudas visuales mediante mensajes contextuales (`ToolTip`).
- Entrada de datos intuitiva y resultado con protección de solo lectura (`ReadOnly`).

---

# Diseño

La interfaz fue desarrollada utilizando un esquema claro en **Windows Forms**, priorizando la usabilidad y la facilidad de navegación para el usuario.

Entre sus características destacan:

- Encabezado principal con título descriptivo del sistema.
- Páneles independientes (`GroupBox`) para organizar las entradas de datos y los botones.
- Caja de texto de resultados protegida contra modificaciones directas.
- Icono y textos organizados para un aspecto ordenado de escritorio.
- Sistema de mensajería emergente (`MessageBox.Show()`) para la gestión de alertas.

Todo el diseño visual y la alineación de componentes se encuentra centralizado en:
```text
frmCalculadora.Designer.cs
```

---

# Operaciones disponibles

Por defecto, la aplicación permite ejecutar operaciones de dos tipos:

### Operaciones Básicas
- Suma (`+`)
- Resta (`-`)
- Multiplicación (`*`)
- División (`/`)

### Operaciones Científicas
- Potencia ($x^y$)
- Raíz cuadrada ($\sqrt{x}$)
- Raíz cúbica ($\sqrt[3]{x}$)
- Valor absoluto ($|x|$)
- Logaritmo natural ($\ln x$)
- Logaritmo base 10 ($\log_{10} x$)
- Seno ($\sin x$)
- Coseno ($\cos x$)
- Tangente ($\tan x$)
- Exponencial ($e^x$)
- Factorial ($x!$)
- Módulo / Residuo ($\%$)

---

# Ejecutar el proyecto

Requisitos previos:

- Tener instalado **Visual Studio** (2019 o superior) con la carga de trabajo de **Desarrollo de escritorio de .NET**.

Instrucciones:

1. Clone o descargue este repositorio.
2. Abra el archivo de solución:

`CalculadoraCientifica.sln`

3. Presione `F5` o haga clic en el botón **Iniciar** dentro de Visual Studio para compilar y ejecutar la aplicación.

---

# Estructura del proyecto

```text
.
├── Calculadora.cs
├── frmCalculadora.cs
├── frmCalculadora.Designer.cs
├── Program.cs
└── CalculadoraCientifica.csproj
```
---

# Reglas de cálculo y validaciones

La aplicación aplica validaciones estrictas en un solo flujo antes de ejecutar cualquier operación para prevenir errores de ejecución:

```csharp
// 1. Validación de entradas numéricas
if (!double.TryParse(txtNum1.Text, out double n1) || !double.TryParse(txtNum2.Text, out double n2))
{
    MessageBox.Show("Por favor, ingrese valores numéricos válidos.");
    return;
}

// 2. Control de excepciones según la operación
if (operacion == "Dividir" && n2 == 0)
    MessageBox.Show("No se permite la división entre cero.");

else if (operacion == "RaizCuadrada" && n1 < 0)
    MessageBox.Show("No existe raíz cuadrada de números negativos.");

else if ((operacion == "Logaritmo" || operacion == "Log10") && n1 <= 0)
    MessageBox.Show("El logaritmo solo se calcula para números mayores a cero.");

else if (operacion == "Factorial" && n1 < 0)
    MessageBox.Show("No existe el factorial de números negativos.");
```

## Validación de entradas

Se comprueba que los campos no estén vacíos y sean puramente numéricos

```csharp
double numero;
if (!double.TryParse(txtNum1.Text, out numero))
{
    MessageBox.Show("Por favor, ingrese un número válido.");
    return;
}
```
# Privacidad
La aplicación opera 100% en modo local sin conexión a Internet.

No recopila, almacena ni transmite ningún dato personal o cálculo realizado a servidores externos.

# Aviso
Esta aplicación tiene fines strictly académicos y educativos.

Los resultados representan cálculos matemáticos estándar y sirven de apoyo para la resolución de ejercicios técnicos o prácticos.



