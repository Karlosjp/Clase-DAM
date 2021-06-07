<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="/">
    <xsl:element name="html">
      <xsl:element name="head">
        <xsl:element name="title">Notas de los alumnos Junio</xsl:element>
      </xsl:element>
      <xsl:element name="body">
        <xsl:element name="h1">Notas de los alumnos</xsl:element>
        <xsl:element name="h3">Convocatoria de Junio</xsl:element>
        <xsl:element name="table">
          <xsl:attribute name="border">1</xsl:attribute>
          <xsl:element name="tr">
            <xsl:element name="th">
              <xsl:attribute name="colspan">2</xsl:attribute>
              <xsl:text>DATOS</xsl:text>
            </xsl:element>
            <xsl:element name="th">
              <xsl:attribute name="colspan">5</xsl:attribute>
              <xsl:text>NOTAS</xsl:text>
            </xsl:element>
          </xsl:element>
          <xsl:element name="tr">
            <xsl:element name="td"> Nombre</xsl:element>
            <xsl:element name="td"> Apellidos</xsl:element>
            <xsl:element name="td"> Tareas</xsl:element>
            <xsl:element name="td"> Cuestionario</xsl:element>
            <xsl:element name="td"> Examen</xsl:element>
            <xsl:element name="td"> Final</xsl:element>
            <xsl:element name="td">Nota en letra</xsl:element>
          </xsl:element>
          <xsl:for-each select="notas/alumno">
            <xsl:element name="tr">
              <xsl:if test="@convocatoria='Junio'">
                <xsl:element name="td">
                  <xsl:value-of select="nombre" />
                </xsl:element>
                <xsl:element name="td">
                  <xsl:value-of select="apellidos" />
                </xsl:element>
                <xsl:element name="td">
                  <xsl:value-of select="tareas" />
                </xsl:element>
                <xsl:element name="td">
                  <xsl:value-of select="cuestionarios" />
                </xsl:element>
                <xsl:element name="td">
                  <xsl:value-of select="examen" />
                </xsl:element>
                <xsl:element name="td">
                  <xsl:value-of select="final" />
                </xsl:element>
                <xsl:element name="td">
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
                </xsl:element>
              </xsl:if>
            </xsl:element>
          </xsl:for-each>


        </xsl:element>
      </xsl:element>
    </xsl:element>
  </xsl:template>
</xsl:stylesheet>
