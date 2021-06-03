package dbejemplos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Ejercicio3 {

	public static void main(String[] args) {
		try {
			Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/java", "java", "clave");//se establece la conexión
			Statement consulta = conexion.createStatement();
			String strCadena = "DELETE FROM emple WHERE COMISION is null and SALARIO < 1200 AND DEPT_NO = (SELECT DEPT_NO FROM depart WHERE dnombre='INVESTIGACION')";
			System.out.println(consulta.executeUpdate(strCadena) + " registros eliminados"); 
		} catch (SQLException e) {
			// TODO Bloque catch generado automáticamente
			e.printStackTrace();
		}

	}

}
