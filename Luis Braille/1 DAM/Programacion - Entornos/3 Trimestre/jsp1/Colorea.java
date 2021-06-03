package clasesJsp.es.codigo;

public class Colorea {
	public static String color(){
		String strColor="";
		int intValor;
		for(int intCont=0;intCont<3;intCont++){
			intValor=(int)(Math.random()*255);
			strColor+=intValor+",";
		}
		return strColor.substring(0,strColor.length()-2);
	}
}
