package dbejemplos;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class Ejercicio4 {

	public static void main(String[] args) {
		Scanner scnLeer = new Scanner(System.in);
		String strDepartamento;
		String strSalario;

		System.out.println("Indica la localidad del departamento");
		strDepartamento = scnLeer.nextLine().toUpperCase();
		
		try {
			Connection conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/java", "java", "clave");//se establece la conexión
			Statement consulta = conexion.createStatement();
			String strCadena = "SELECT apellido from emple where COMISION>SALARIO*0.1 and DEPT_NO IN (select DEPT_NO FROM depart where loc='"+ strDepartamento + "')";
			ResultSet rs = consulta.executeQuery(strCadena); 
			while(rs.next())
				System.out.println(rs.getString("apellido"));
		} catch (SQLException e) {
			// TODO Bloque catch generado automáticamente
			e.printStackTrace();
		}

	}

}
