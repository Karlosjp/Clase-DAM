package practica.ejercicio3;

import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Main {
	/**
	 * 3.- Generar una tienda con un carrito de la compra. Vamos a permitir mostrar
	 * todos los elementos de la tienda (se puede ampliar indicando categorías).
	 * Vamos a poder incluir o eliminar de nuestro carrito productos. De un producto
	 * se puede comprar más de una unidad, siendo el mismo producto. Sacar un
	 * listado de los productos del carrito, indicando el total por producto y de la
	 * compras. Si un producto tiene más de una unidad se mostrará (cable hdmi x2
	 * 10€). Si damos a la opción de pagar nos muestra el total y vacía la cesta
	 *
	 * @param args
	 */
	public static void main(String[] args) {
		HashMap<String, Producto> hmProductos = new HashMap<String, Producto>();
		Carrito objCarrito = new Carrito();
		Scanner scn = new Scanner(System.in);
		String strRespuesta;
		hmProductos.put("Cable HDMI", new Producto("Cable HDMI", 5));
		hmProductos.put("Cable USB", new Producto("Cable USB", 10));
		hmProductos.put("Cable VGA", new Producto("Cable VGA", 2));
		hmProductos.put("Adaptador", new Producto("Adaptador", 1));
		hmProductos.put("Lector Tarjetas", new Producto("Lector Tarjetas", 20));
		hmProductos.put("Memoria USB", new Producto("Memoria USB", 20));
		hmProductos.put("Producto 12", new Producto("Producto 12", 50));
		hmProductos.put("Producto 11", new Producto("Producto 11", 40));
		hmProductos.put("Producto 13", new Producto("Producto 13", 30));
		
		System.out.println("Que quieres hacer? 1- Mostrar 2- Comprar -3 Eliminar un producto");
		strRespuesta = scn.nextLine();
		
		switch (strRespuesta) {
		case "1":
			mostrarProductos(hmProductos);
			break;
		case "2":
			agregarProducto(hmProductos, objCarrito);
			break;
		case "3":
			break;

		default:
			break;
		}

		System.out.println(objCarrito);
	}

	public static void mostrarProductos(HashMap<String, Producto> hmProductos) {
		for (Map.Entry<String, Producto> entry : hmProductos.entrySet())
			System.out.println("*- Producto: " + entry.getKey());
	}

	public static void agregarProducto(HashMap<String, Producto> hmProductos, Carrito objCarrito) {
		boolean booTemrinar = false;
		Scanner scn = new Scanner(System.in);
		String strRespuesta;

		do {
			System.out.println("Que quieres comprar?");
			strRespuesta = scn.nextLine();
			Producto objNuevoProducto = hmProductos.get(strRespuesta);

			if (objNuevoProducto == null) {
				System.out.println("Ese producto no existe");
				continue;
			}

			else
				objCarrito.agregarProducto(objNuevoProducto);

			System.out.println("Quieres terminar si/no");
			strRespuesta = scn.nextLine();

			if (strRespuesta.equals("si"))
				booTemrinar = true;

		} while (!booTemrinar);
	}
}
