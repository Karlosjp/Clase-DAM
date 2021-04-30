package practica.ejercicio3;

import java.util.HashMap;
import java.util.List;

public class Carrito {
	private HashMap<String, Producto> hmProductos;
	private double dooImporteTotal;

	public Carrito() {
		super();
		this.hmProductos = new HashMap<String, Producto>();
		this.dooImporteTotal = 0;
	}

	public void agregarProducto(Producto objNuevoProducto) {
		if (hmProductos.get(objNuevoProducto.getStrNombre()) == null) {
			hmProductos.put(objNuevoProducto.getStrNombre(), objNuevoProducto);
			hmProductos.get(objNuevoProducto.getStrNombre()).incrementarIntCantidad();
			this.dooImporteTotal += (objNuevoProducto.getDouPrecio() * objNuevoProducto.getIntCantidad());
		}
		else {
			hmProductos.get(objNuevoProducto.getStrNombre()).incrementarIntCantidad();
			this.dooImporteTotal += objNuevoProducto.getDouPrecio();
		}		
	}

	public void eliminarProducto(Producto objNuevoProducto) {
		hmProductos.get(objNuevoProducto.getStrNombre()).reducirIntCantidad();
		this.dooImporteTotal -= objNuevoProducto.getDouPrecio();
	}

	@Override
	public String toString() {
		return "Carrito [hmProductos=" + hmProductos + ", dooImporteTotal=" + dooImporteTotal + "]";
	}
}
