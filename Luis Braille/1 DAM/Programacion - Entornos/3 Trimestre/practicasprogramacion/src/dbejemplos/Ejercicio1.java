package dbejemplos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Ejercicio1 {

	public static void main(String[] args) {
		try {
			Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/java", "java", "clave");//se establece la conexión
			Statement consulta = conexion.createStatement();
			ResultSet rs = consulta.executeQuery("select apellido from emple e where salario=(select max(salario) from emple where dept_no=e.dept_no)");
			while(rs.next())
				System.out.println(rs.getString("apellido"));
		} catch (SQLException e) {
			// TODO Bloque catch generado automáticamente
			e.printStackTrace();
		}

	}

}
