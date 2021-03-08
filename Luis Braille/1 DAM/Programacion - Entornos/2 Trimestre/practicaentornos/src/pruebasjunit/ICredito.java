package pruebasjunit;

public interface ICredito {

	/**
	 * @param x Cantidad a retirar
	 * @return no retorna nada
	 * @throws Si no hay credito disponible, lanza Exepcion
	 */
	void retirar(double x) throws Exception;

	void ingresar(double x) throws Exception;

	void pagoEnEstablecimiento(String datos, double x) throws Exception;

	double getSaldo();

	double getCreditoDisponible();

	void liquidar(int mes, int a“o);

}