package tema10.ejemplos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

import com.mysql.cj.jdbc.DatabaseMetaData;
import com.mysql.cj.jdbc.result.ResultSetMetaData;

public class Ejemplo1 {

	public static void main(String[] args) {
		Connection conexion = null;

		try {
			/*
			 * En versiones antiguas anteriores al jdk6 ten�a que indicar el driver en
			 * oracle ser�a Class.forName("oracle.jdbc.driver.OracleDriver") en mysqul ser�a
			 * Class.forName("com.mysql.cj.jdbc.Driver"); Se puede capturar la excepci�n
			 * ClassNotFoundException
			 */

			/*
			 * 1� establecer la conexi�n: url: driver->jdbc: protocolo del driver->mysql://
			 * + ubicai�n de la bd +:puerto/+nombre bd la url para oracle ser�a
			 * jdbc:oracle:thin:@localhost:1521:java usuario: usuario par conectarnos. Tiene
			 * que tener permiso de conexi�n como m�nimo password: password del usuario
			 */
			conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/java", "java", "clave");// se establece
																										// la conexi�n
			System.out.println("Conexi�n OK\n");

		} catch (SQLException e) {
			System.out.println("Error en la conexi�n");
			e.printStackTrace();
		}
		// sacar la informaci�n de la base de datos
		try {
			DatabaseMetaData infoBD = (DatabaseMetaData) conexion.getMetaData();
			System.out.println("Base de datos: " + infoBD.getDatabaseProductName());
			System.out.println("Version: " + infoBD.getDatabaseProductVersion() + "\n");
			// tablas contenidas en la base de datos
			// indico en getTables(BD, esquema, tabla, tipo_de_tabla)
			ResultSet rs = infoBD.getTables("java", null, null, null);

			while (rs.next()) {
				System.out.println(rs.getString("table_name"));

			}
			rs.close();
		} catch (Exception ex) {
			System.out.println(ex.getMessage());
		}
	}

}