<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Examen2_2.Inicio" %>

<!DOCTYPE html>

<link href="Cagregar.css" rel="stylesheet" />

<html lang="es">

<link href="CCS/Estilos.css" rel="stylesheet" />

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulario de Encuestas</title>
    
    <link rel="stylesheet" href="Estilos.css">
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h2>Formulario de Encuestas</h2>

        <h3>Ivar David Solera Quesada</h3>

            <label for="nombre">Nombre:</label>
            <input type="text" id="nombre" name="nombre" runat="server" required>
            
            <label for="apellido">Apellido:</label>
            <input type="text" id="apellido" name="apellido" runat="server" required>
            
            <label for="fechaNacimiento">Fecha de Nacimiento:</label>
            <input type="date" id="fechaNacimiento" name="fechaNacimiento" runat="server" required>
            
            <label for="edad">Edad:</label>
            <input type="number" id="edad" name="edad" runat="server" required>
            
            <label for="email">Email:</label>
            <input type="email" id="email" name="email" runat="server" required>
            
            <label for="poseeAutomovil">¿Posee Automóvil?</label>
            <select id="poseeAutomovil" name="poseeAutomovil" runat="server" required>
                <option value="1">Sí</option>
                <option value="0">No</option>
            </select>
            
            <div class="btn-container">
                <asp:Button ID="Button1" runat="server" Text="Enviar" OnClick="Button1_Click" />
                          
               <asp:Label ID="lblMensaje" runat="server" Text="" Visible="false"></asp:Label>
           

                <!-- esto es para que se pueda modificar la encuesta:-->

                <label for="numeroEncuesta">Número de Encuesta:</label>
                <input type="number" id="numeroEncuesta" name="numeroEncuesta" required runat="server">
                <asp:Button ID="Button2" runat="server" Text="Modificar" OnClick="Button1_Click" />
                <asp:Button ID="Button3" runat="server" Text="Eliminar" OnClick="Button1_Click" />
                     <!-- Esto lo dejo acá porque son los botones que les aplique el color neon
                    <button type="submit" id="submitBtn">Enviar</button>
                <button type="button" id="modificarBtn">Modificar</button>
                <button type="button" id="eliminarBtn">Eliminar</button> -->

                <br />
                <br />
            </div>
    </div>

    <script src="Cagregar.cs"></script>

    <div>
    
    </div>


    </form>
</body>
</html>
<!-- Este proyecto profe si está para sacar las canitas un poco, pero de verdad quiero agradecerte 
    porque sinto que si se aprende con usted, muchas gracias por querer enseñarnos de esa manera-->