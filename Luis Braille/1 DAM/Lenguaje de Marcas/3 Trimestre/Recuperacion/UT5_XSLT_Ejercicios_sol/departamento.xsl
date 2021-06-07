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
            <td> <xsl:value-of select="nombre"/> <xsl:text disable-output-escaping="yes"> </xsl:text><xsl:value-of select="apellido1"/> <xsl:text disable-output-escaping="yes"> </xsl:text> <xsl:value-of select="apellido2"/>  </td>
            
            <td>
                <xsl:apply-templates select="modulosImpartidos/modulo"/>
                <br />
            </td>
        </tr>
    </xsl:template>
    
    <xsl:template match="modulo">
        <xsl:value-of select="."/>
        <xsl:if test="@modalidad='P'"> (Presencial)</xsl:if>
        <xsl:if test="@modalidad='D'"> (Distancia)</xsl:if>
        <br />
    </xsl:template>
    
</xsl:stylesheet>