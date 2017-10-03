
public class BinarioGuille {

	static int convertir(int num, int n){
		if(num/2 == 1)
			return (int) (num%2 * Math.pow(10, n++) + 1*Math.pow(10, n));
		return (int) (num%2 * Math.pow(10, n++) + convertir(num/2, n));
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int resultado = 0;
		resultado = convertir(6,0);
		System.out.println("Resultado: " + resultado);
	}

}
