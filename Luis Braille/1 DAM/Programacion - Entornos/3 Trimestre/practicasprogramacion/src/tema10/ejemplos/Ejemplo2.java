package tema10.ejemplos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import com.mysql.cj.jdbc.DatabaseMetaData;
import com.mysql.cj.jdbc.result.ResultSetMetaData;

public class Ejemplo2 {

	public static void main(String[] args) {
		Connection conexion = null;

		try {
			// 1� establecer la conexi�n
			conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/java", "java", "clave");// se establece
																										// la conexi�n

			// 2� Crear objeto Statement
			Statement instruccion = conexion.createStatement();

			// 3� Ejecutar la instrucci�n
			ResultSet rs = instruccion.executeQuery("Select * from depart");

			/*
			 * / 4� Utilizar los datos devueltos
			 * System.out.println("dept_no\tdnombre\t\tloc"); while(rs.next())
			 * System.out.println(rs.getString("dept_no")+"\t"+tamCadena(rs.getString(
			 * "dnombre"),14)+"\t"+rs.getString("loc"));
			 */ResultSetMetaData rsmd = (ResultSetMetaData) rs.getMetaData();
			int intCols = rsmd.getColumnCount();// columnas de mi resulset
			for (int intCont = 1; intCont <= intCols; intCont++)
				System.out.print(tamCadena(rsmd.getColumnLabel(intCont), 14) + "\t");
			System.out.println();// terminados los encabezados
			while (rs.next()) {
				for (int intCont = 1; intCont <= intCols; intCont++)
					System.out.print(tamCadena(rs.getString(intCont), 14) + "\t");// */
				System.out.println();// pasa a la siguiente l�nea
			}
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