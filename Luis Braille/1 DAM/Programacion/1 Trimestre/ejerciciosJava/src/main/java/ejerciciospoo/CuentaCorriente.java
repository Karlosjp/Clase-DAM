package ejerciciospoo;

import java.util.Random;
import java.util.Date;

public class CuentaCorriente {
	private double saldo;
	private final int numCuenta;
	
	/*
	 * Crear cuenta corriente con saldo inicial 0
	 */
	public CuentaCorriente() {
		this.saldo = 0;
		this.numCuenta = this.GeneraNumCuenta();
	}
	
	/*
	 * Crear cuenta corriente con saldo inicial
	 */
	public CuentaCorriente(double saldo) {
		// TODO Auto-generated constructor stub
		this.saldo = saldo;
		this.numCuenta = this.GeneraNumCuenta();
	}
	
	/*
	 * Devuelve los datos de la cuenta
	 */
	public String datos() {return "Número de cta: " + numCuenta + " Saldo: " + saldo + " €";}
	public void cargo(double cargo) {this.saldo -= cargo;}
	public void ingreso(double ingreso) {this.saldo += ingreso;}
	
	public void transferencia(CuentaCorriente cuenta, double trans) {
		cuenta.ingreso(trans);
		saldo -= trans;
	}
	
	private int GeneraNumCuenta() {
		Date fecha = new Date();
		Random r = new Random();
		return r.nextInt((int) fecha.getTime());
	}
}
