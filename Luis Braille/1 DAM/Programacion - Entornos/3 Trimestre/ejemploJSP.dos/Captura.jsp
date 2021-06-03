<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title>Registro Jsp</title>
	</head>
	<body>
		<h1>Parámetros capturados:</h1><br />
		Nombre: <%= request.getParameter("nombre") %><br />
		Apellido: <%= request.getParameter("apellido") %><br />
		Nombre Usuario: <%= request.getParameter("username") %><br />
		Password: <%= request.getParameter("password") %><br />
		Dirección: <%= request.getParameter("direccion") %><br />
	</body>
</html>