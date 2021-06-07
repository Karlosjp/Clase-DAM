<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:xd="http://www.oxygenxml.com/ns/doc/xsl" exclude-result-prefixes="xd"
    version="1.0">
    <xsl:template match="/departamento">
        
        <html>
            <head>
                <link rel="stylesheet" type="text/css" href="departamento.css"/>
            </head>
            <body>
                <table>
                    <tr><th>Profesor</th><th>Módulos impartidos</th></tr> 
                    <xsl:apply-templates select="profesores/profesor">
                        <xsl:sort select="apellido1"/>
                    </xsl:apply-templates>
                    
                </table>
            </body>
            </html>
    </xsl:template>
    
    <xsl:template match="profesor">
        <tr>
            <td> <xsl:value-of select="apellido1"/>, <xsl:value-of select="apellido2"/>, <xsl:value-of select="nombre"/>  </td>
            
            
            <td>
                <xsl:apply-templates select="modulosImpartidos/modulo"/>
            </td>
        </tr>
        
    </xsl:template>
    
    <xsl:template match="modulo">
        
        <xsl:variable name="moduloSiglas" select="."/>
        <xsl:value-of select="/departamento/modulos/modulo[@codigo=$moduloSiglas]/denominacion"/>
        (<xsl:value-of select="."/>)
        <xsl:if test="@modalidad='P'">- Presencial-</xsl:if>
        <xsl:if test="@modalidad='D'">- Distancia-</xsl:if>
        <br />
    </xsl:template>
</xsl:stylesheet>