<%@ page import="java.sql.*" %>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title>Nuevo Usuario jsp</title>
	</head>
	<body>
		<%  //cojo los parámetros que me manda el formulario
			String strNombre = request.getParameter("nombre");
			String strApellido = request.getParameter("apellido");
			String strUserName = request.getParameter("username");
			String strPassword = request.getParameter("password");
			String strDireccion= request.getParameter("direccion");
			//Inserción en la base de datos
			//Hay que indicarle donde se encuentra el driver
			/*crear en mysql una tabla
			CREATE TABLE USUARIO(
    nombre VARCHAR(20),
    apellido VARCHAR(20),
    username VARCHAR(20),
    password VARCHAR(20),
    direccion VARCHAR(20),
	CONSTRAINT PK_USUARIO PRIMARY KEY (nombre,apellido))*/
			if(strNombre.equals("") || strApellido.equals("")){
				out.println("nombre y apellido tienen que tener valor <a href='NuevoUsuario.html'>volver</a>");
			}else{
				try{
					Class.forName("com.mysql.cj.jdbc.Driver");
					Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/java", "java", "clave");//se establece la conexión
					Statement insercion = conexion.createStatement();
					String strCadena = "INSERT INTO USUARIO(nombre,   apellido, 			username, 			password, 				direccion) " + 
									   "VALUES('"+ strNombre +"', '"+ strApellido +"', '"+ strUserName +"', '"+ strPassword +"', '"+ strDireccion +"')";
					out.println(insercion.executeUpdate(strCadena) + " Usuario insertado");
				} catch (SQLException e) {out.println("Error en el SQL");}
			}
		%>
		<br />
	</body>
</html>