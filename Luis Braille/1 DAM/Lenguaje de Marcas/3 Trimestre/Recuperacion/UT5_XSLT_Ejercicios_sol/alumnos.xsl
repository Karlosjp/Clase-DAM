<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="/">
    <html>
      <head>
        <title> Notas de los alumnos Junio</title>
      </head>
      <body>
        <h1>Notas de los alumnos</h1>
        <h3>Convocatoria de Junio</h3>
        <table border="1">
          <tr>
            <th colspan="2"> DATOS</th>
            <th colspan="5"> NOTAS</th>
          </tr>
          <tr>
            <td>Nombre</td>
            <td>Apellidos</td>
            <td>Tareas</td>
            <td>Cuestionario</td>
            <td>Examen</td>
            <td>Final</td>
            <td>Nota en letra</td>
          </tr>
          <xsl:for-each select="notas/alumno">
            <tr>
              <xsl:if test="@convocatoria='Junio'">
                <td>
                  <xsl:value-of select="nombre" />
                </td>
                <td>
                  <xsl:value-of select="apellidos" />
                </td>
                <td>
                  <xsl:value-of select="tareas" />
                </td>
                <td>
                  <xsl:value-of select="cuestionarios" />
                </td>
                <td>
                  <xsl:value-of select="examen" />
                </td>
                <td>
                  <xsl:value-of select="final" />
                </td>
                <td>
                  <xsl:choose>
                    <xsl:when test="final>=9">
                      <xsl:text>Sobresaliente</xsl:text>
                    </xsl:when>
                    <xsl:when test="final>=7">
                      <xsl:text>Notable</xsl:text>
                    </xsl:when>
                    <xsl:when test="final>=6">
                      <xsl:text>Bien</xsl:text>
                    </xsl:when>
                    <xsl:when test="final>=5">
                      <xsl:text>Suficiente</xsl:text>
                    </xsl:when>
                    <xsl:otherwise>
                      <xsl:text>Insuficiente</xsl:text>
                    </xsl:otherwise>
                  </xsl:choose>
                </td>
              </xsl:if>
            </tr>
          </xsl:for-each>


        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
