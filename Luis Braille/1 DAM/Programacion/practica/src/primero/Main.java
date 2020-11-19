package primero;

import javax.swing.JLabel;
import javax.swing.JOptionPane;

public class Main {

	public Main() {
		JOptionPane op = new JOptionPane();
		JLabel lblMensaje = new JLabel("Mensaje");
		
		op.add(lblMensaje);
		op.showMessageDialog(null, "Hola Gentuzos");
	}
	
	public static void main (String[] args) {
		// Todo Auto-generated method stub
		
		Main objMain = new Main();
	}
}
