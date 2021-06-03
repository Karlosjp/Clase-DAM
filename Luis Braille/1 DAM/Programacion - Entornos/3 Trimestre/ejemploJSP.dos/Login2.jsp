<%@ page import="java.sql.*" %>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title>Nuevo Usuario jsp</title>
	</head>
	<body>
		<%  //cojo los parámetros que me manda el formulario
					out.println("logado como: ");
					out.println(session.getAttribute("usuario"));
					out.println("<br /><a href='NuevoUsuario.html'>volver</a>");
			
		%>
		<br />
	</body>
</html>