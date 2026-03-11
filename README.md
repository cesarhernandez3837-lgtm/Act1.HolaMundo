# Act1.HolaMundo - Validador de Contraseñas con Regex – Windows Forms

## Descripción
Este proyecto consiste en una aplicación de escritorio desarrollada en **C#** utilizando **Windows Forms** en **Visual Studio**.

El programa permite validar una contraseña ingresada por el usuario verificando que cumpla con ciertos requisitos de seguridad mediante el uso de **expresiones regulares (Regex)**.

Además, el usuario debe repetir la contraseña para confirmar que ambas coincidan.

# Requisitos de la contraseña

La contraseña debe cumplir con las siguientes condiciones:

- Contener al menos **una letra mayúscula**
- Contener al menos **una letra minúscula**
- Contener al menos **un número**
- Contener al menos **un símbolo**

Además, el segundo campo debe contener **la misma contraseña**.


# Funcionamiento del programa

La aplicación contiene los siguientes elementos:

- Un **TextBox** para ingresar la contraseña
- Un **TextBox** para repetir la contraseña
- Un **Botón** para validar la contraseña
- Un **ToolTip** que muestra los requisitos de la contraseña   (este elemento es extra a lo que se solicito pero creo que es funcional para el usuario)
- Un **CheckBox** para mostrar u ocultar la contraseña          (de igual manera este elemento es extra)
- Un **MessageBox** que muestra el resultado de la validación

# Capturas de funcionamiento

## Interfaz del programa
<img width="532" height="235" alt="image" src="https://github.com/user-attachments/assets/bc0f0fc3-8c91-485c-a396-25daa661e676" />


## Contraseña válida
<img width="528" height="225" alt="image" src="https://github.com/user-attachments/assets/608e80a8-1b0e-45a6-b741-c9b7ca2e0f35" />


## Error cuando la contraseña no cumple requisitos
<img width="521" height="232" alt="image" src="https://github.com/user-attachments/assets/f2968fe0-0dc3-41ed-a043-f0458c18612c" />

## Error cuando las contraseñas no coinciden
<img width="526" height="227" alt="image" src="https://github.com/user-attachments/assets/00351639-ba20-4e00-acc6-bfde6c9cb4b3" />



# Expresión regular utilizada

```regex
^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$
```

## Explicación

| Expresión | Significado |
|-----------|-------------|
| `(?=.*[a-z])` | Debe contener al menos una letra minúscula |
| `(?=.*[A-Z])` | Debe contener al menos una letra mayúscula |
| `(?=.*\d)` | Debe contener al menos un número |
| `(?=.*[\W_])` | Debe contener al menos un símbolo |


# Código principal del programa

```csharp
string contraseña1 = txt1.Text;
string contraseña2 = txt2.Text;

string patron = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).+$";

if (Regex.IsMatch(contraseña1, patron))
{
    if (contraseña1 == contraseña2)
    {
        MessageBox.Show("La contraseña ha sido validada");
    }
    else
    {
        MessageBox.Show("Las contraseñas no coinciden");
    }
}
else
{
    MessageBox.Show("La contraseña debe tener:\n- Una mayúscula\n- Una minúscula\n- Un número\n- Un símbolo");
}
```

# ToolTip implementado

Se agregó un **ToolTip** para mostrar los requisitos de la contraseña cuando el usuario coloca el cursor sobre el campo de texto.

```csharp
toolTip1.SetToolTip(txt1,
"La contraseña debe contener:\n" +
"- Una letra mayúscula\n" +
"- Una letra minúscula\n" +
"- Un número\n" +
"- Un símbolo");
```

Esto permite que el usuario conozca los requisitos antes de ingresar la contraseña.

# Mostrar u ocultar contraseña

Se implementó un **CheckBox** para permitir al usuario mostrar u ocultar la contraseña por motivos de privacidad.

```csharp
if (visibilidad.Checked)
{
    txt1.UseSystemPasswordChar = false;
    txt2.UseSystemPasswordChar = false;
}
else
{
    txt1.UseSystemPasswordChar = true;
    txt2.UseSystemPasswordChar = true;
}
```

Cuando la opción está desactivada, la contraseña se muestra como puntos para proteger la privacidad del usuario.


# Validación detallada de requisitos (versión alternativa)

Otra implementación posible consiste en verificar cada requisito por separado para indicar exactamente qué condición falta en la contraseña.

```csharp
string contraseña1 = txt1.Text;
string contraseña2 = txt2.Text;

string mensaje = "";

// Mayusculas
if (!Regex.IsMatch(contraseña1, "[A-Z]"))
{
    mensaje += "Falta una letra mayúscula\n";
}

// minusculas
if (!Regex.IsMatch(contraseña1, "[a-z]"))
{
    mensaje += "Falta una letra minúscula\n";
}

//Numero
if (!Regex.IsMatch(contraseña1, "[0-9]"))
{
    mensaje += "Falta un número\n";
}

// Simbolo
if (!Regex.IsMatch(contraseña1, "[^a-zA-Z0-9]"))
{
    mensaje += "Falta un símbolo\n";
}

// Validar que coincidan
if (contraseña1 != contraseña2)
{
    MessageBox.Show("Las contraseñas no coinciden");
    return;
}

// Si faltó algo
if (mensaje != "")
{
    MessageBox.Show(mensaje, "Error en la contraseña");
    return;
}
           
// Si todo está correcto
MessageBox.Show("La contraseña ha sido validada");
```

Esta implementación permite que el usuario identifique exactamente qué requisito necesita agregar.



# Autor

César Hernández Díaz
