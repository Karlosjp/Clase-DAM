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
 * Son m�s r�pidas si se repiten varias veces con distintos datos y 
 * evitan los ataques por inyecci�n sql
 * @author elkin
 *
 */
	public class Ejemplo4 {

		
		public static void main(String[] args) {
			Connection conexion = null;
			
			try {				
				// 1� establecer la conexi�n
				conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/java", "java", "clave");//se establece la conexi�n

				// 2� Crear objeto Statement
				//sacar los empleados con su salario de un departamento y un oficio concreto
				PreparedStatement instruccion = conexion.prepareStatement("SELECT apellido, salario "
																		+ "FROM emple e INNER JOIN depart d "
																		+ "ON e.dept_no=d.dept_no "
																		+ "WHERE d.dnombre=? AND oficio=?");
				
				// 3� Ejecutar la instrucci�n 
				System.out.println("Analistas del departamento INVESTIGACION");
				instruccion.setString(1, "INVESTIGACION");
				instruccion.setString(2, "ANALISTA");
				ResultSet rs = instruccion.executeQuery();
				
				// 4� Recorrido
				while(rs.next()) 
					System.out.println(tamCadena(rs.getString(1),12));// + rs.getString(2));
				
				// 3� Ejecutar la instrucci�n 
				System.out.println("\nVendedores del departamento Ventas");
				instruccion.setString(1, "VENTAS");
				instruccion.setString(2, "VENDEDOR");
				rs = instruccion.executeQuery();
				
				// 4� Recorrido
				while(rs.next()) 
					System.out.println(tamCadena(rs.getString(1),12));// + rs.getString(2));
				rs.close();
			} catch (SQLException e) {
				System.out.println("Error en la conexi�n");
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