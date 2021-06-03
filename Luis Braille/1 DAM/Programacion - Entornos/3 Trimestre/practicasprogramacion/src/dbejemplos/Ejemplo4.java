package dbejemplos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

import com.mysql.cj.jdbc.DatabaseMetaData;
import com.mysql.cj.jdbc.result.ResultSetMetaData;
/**
 * Clase que muestra como hacer consultas preparadas
 * Son más rápidas si se repiten varias veces con distintos datos y 
 * evitan los ataques por inyección sql
 * @author elkin
 *
 */
	public class Ejemplo4 {

		
		public static void main(String[] args) {
			Connection conexion = null;
			
			try {				
				// 1º establecer la conexión
				conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/java", "java", "clave");//se establece la conexión

				// 2º Crear objeto Statement
				//sacar los empleados con su salario de un departamento y un oficio concreto
				PreparedStatement instruccion = conexion.prepareStatement("SELECT apellido, salario "
																		+ "FROM emple e INNER JOIN depart d "
																		+ "ON e.dept_no=d.dept_no "
																		+ "WHERE d.dnombre=? AND oficio=?");
				
				// 3º Ejecutar la instrucción 
				System.out.println("Analistas del departamento INVESTIGACION");
				instruccion.setString(1, "INVESTIGACION");
				instruccion.setString(2, "ANALISTA");
				ResultSet rs = instruccion.executeQuery();
				
				// 4º Recorrido
				while(rs.next()) 
					System.out.println(tamCadena(rs.getString(1),12));// + rs.getString(2));
				
				// 3º Ejecutar la instrucción 
				System.out.println("\nVendedores del departamento Ventas");
				instruccion.setString(1, "VENTAS");
				instruccion.setString(2, "VENDEDOR");
				rs = instruccion.executeQuery();
				
				// 4º Recorrido
				while(rs.next()) 
					System.out.println(tamCadena(rs.getString(1),12));// + rs.getString(2));
				rs.close();
			} catch (SQLException e) {
				System.out.println("Error en la conexión");
				e.printStackTrace();
			}
			
		}
		
		//devuelve una cadena en una longitud indicada
		private static String tamCadena(String strCadena, int intTamanno) {
			while(strCadena.length()<intTamanno)
				strCadena+=" ";
			return strCadena;
		}

	}