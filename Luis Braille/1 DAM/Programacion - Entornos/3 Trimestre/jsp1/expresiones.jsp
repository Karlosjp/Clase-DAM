<%@page import="clasesJsp.es.codigo.Colorea"%>
<%@page import=" java.util.Enumeration" %>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
    pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>expresiones</title>
</head>
<body>
Operación: <%= 5+8*2 %><br />
número aleatorio <%= (int)(Math.random()*10) %><br />
operación lógica <%= 9>7 %>
<%!
public String color(){
	String strColor="";
	int intValor;
	for(int intCont=0;intCont<3;intCont++){
		intValor=(int)(Math.random()*255);
		strColor+=intValor+",";
	}
	return strColor.substring(0,strColor.length()-2);
}
%>

<p style="color:rgb(<%= color() %>);">texto con color aleatorio</p><br />

<p style="color:rgb(<%= Colorea.color() %>);">Color de clase externa</p><br />

<table>
<caption>Lista Colores</caption>
<% 
	for(int intCont=0;intCont<256;intCont+=25){
		out.println("<tr>");
		for(int intCont2=0;intCont2<256;intCont2+=25){
			out.println("</tr><tr>");
			for(int intCont3=0;intCont3<256;intCont3+=25)
				out.println("<td style='background-color:rgb("+intCont3+","+intCont2+","+intCont+");'>"+intCont+","+intCont2+","+intCont3+"</td>");
		}
		out.println("</tr>");
	}
%>
</table>
Host <%= request.getHeader("Host") %> <br />
Navegador <%= request.getHeader("user-Agent") %><br />
</body>
</html>