<%@ page import="java.sql.*" %>
<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8">
		<title>Nuevo Usuario jsp</title>
	</head>
	<body>
		<%  //cojo los parámetros que me manda el formulario
			String strUserName = request.getParameter("username");
			String strPassword = request.getParameter("password");
			//Busqueda en la base de datos
		//	try{
				Class.forName("com.mysql.cj.jdbc.Driver");
				Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/java", "java", "clave");//se establece la conexión
				//Statement consulta = conexion.createStatement();
				//String strCadena = "SELECT * FROM usuario WHERE USERNAME='"+ strUserName +"' and PASSWORD='"+ strPassword +"'";
				String strCadena = "SELECT * FROM usuario WHERE USERNAME=? and PASSWORD=?";
				PreparedStatement consulta = conexion.prepareStatement(strCadena);
				consulta.setString(1,strUserName);
				consulta.setString(2,strPassword);
				ResultSet rs = consulta.executeQuery();
				if(rs.next()){
					out.println("logado <a href='Login2.jsp'>comprobar</a>");
					session.setAttribute("usuario", strUserName);
				}else
					out.println("usuario o password incorrectos <a href='NuevoUsuario.html'>volver</a>");
			//} catch (SQLException e) {out.println("Error en el SQL"+e.getStackTrace());}
			
		%>
		<br />
	</body>
</html>