package exament3.ejercicio3;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		// Ejercicio 3
		highScore(200);
	}

	private static void highScore(int intPuntos) {
		Connection conexion = null;
		int intAux = 0;
		boolean blnInsertar = false;
		Scanner scnLeer = new Scanner(System.in);

		try {
			conexion = DriverManager.getConnection("jdbc:mysql://localhost:3306/java", "java", "clave");// se establece
																										// la conexión
			Statement instruccion = conexion.createStatement();
			
			ResultSet rs = instruccion.executeQuery("Select count(*) from examen");

			if (rs.next())// guardo cuantos registros hay en la tabla
				intAux = rs.getInt(1);
			if (intAux >= 5) {// si hay 20, miro si es mayor que el último
				intAux = 0;
				rs = instruccion.executeQuery("Select count(*) from examen where puntuacion<" + intPuntos);

				if (rs.next())
					intAux = rs.getInt(1);

				if (intAux > 0) {// si hay alguno menor que yo lo borro
					rs = instruccion.executeQuery(
							"SELECT ID FROM examen WHERE PUNTUACION<" + intPuntos + " order by PUNTUACION");

					if (rs.next())// cojo el primer menor
						intAux = rs.getInt(1);

					instruccion.executeUpdate("delete from examen where id=" + intAux);

					blnInsertar = true;
				}
			} else
				blnInsertar = true;

			if (blnInsertar == true) {
				System.out.println("Dame tu nombre");
				String strNombre = scnLeer.nextLine();
				System.out.println("Dame la fecha");
				String strFecha = scnLeer.nextLine();

				instruccion.executeUpdate("insert into examen(nombre,fecha,puntuacion) values('" + strNombre + "','"
						+ strFecha + "'," + intPuntos + ')');
			}
		} catch (SQLException e) {
			System.out.println("Error en la conexión con la BD");
			System.out.println(e);
		}
	}
}
