package dbejemplos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Ejercicio2 {

	public static void main(String[] args) {
		try {
			Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/java", "java", "clave");//se establece la conexión
			Statement consulta = conexion.createStatement();
			String strCadena = "UPDATE EMPLE SET SALARIO=SALARIO*1.05 where dir=(SELECT EMP_NO FROM emple WHERE APELLIDO='FERNANDEZ')";
			System.out.println(consulta.executeUpdate(strCadena) + " registros actualizados"); 
		} catch (SQLException e) {
			// TODO Bloque catch generado automáticamente
			e.printStackTrace();
		}

	}

}
