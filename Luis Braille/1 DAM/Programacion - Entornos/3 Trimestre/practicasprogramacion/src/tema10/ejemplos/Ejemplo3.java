package tema10.ejemplos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import com.mysql.cj.jdbc.DatabaseMetaData;
import com.mysql.cj.jdbc.result.ResultSetMetaData;

/**
 * Clase que muestra como hacer inserciones
 * 
 * @author elkin
 *
 */
public class Ejemplo3 {

	public static void main(String[] args) {
		Connection conexion = null;

		try {
			// 1� establecer la conexi�n
			conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/java", "java", "clave");// se establece
																										// la conexi�n

			// 2� Crear objeto Statement
			Statement instruccion = conexion.createStatement();

			// 3� Ejecutar la instrucci�n
			// en el sql los datos de tipo string meterlos entre ' '
			String strInsercion = "insert into depart(dept_no, dnombre, loc) values (50,'PROGRAMACION', 'COSLADA')";
			instruccion.executeUpdate(strInsercion); // la ejecuci�n es un executeUpdate no executeQuery

		} catch (SQLException e) {
			System.out.println("Error en la conexi�n");
			e.printStackTrace();
		}

	}

	// devuelve una cadena en una longitud indicada
	private static String tamCadena(String strCadena, int intTamanno) {
		while (strCadena.length() < intTamanno)
			strCadena += " ";
		return strCadena;
	}

}