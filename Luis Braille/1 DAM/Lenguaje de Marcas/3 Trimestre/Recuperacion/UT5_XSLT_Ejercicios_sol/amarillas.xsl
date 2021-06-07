<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
 
  <xsl:template match="/">
   <xsl:apply-templates select="/rusia2018/partidos" />
   <xsl:apply-templates select="/rusia2018/equipos" />
  </xsl:template>
  
  <xsl:template match="/rusia2018/partidos">
    <xsl:element name="resultados">
      <xsl:element name="jornada">
        <xsl:attribute name="numero">
          <xsl:value-of select="/rusia2018/partidos/@jornada" />
        </xsl:attribute>
          <xsl:for-each select="//partidos/partido">
          <xsl:element name="partido">
            <xsl:element name="selecciones">
              <xsl:value-of select="@equi1" /> <xsl:text>-</xsl:text> <xsl:value-of select="@equi2" />
            </xsl:element> 
            <!--
            <xsl:variable name="equipo1" select="@equi1" />
            <xsl:variable name="equipo2" select="@equi2" />
            -->
            <xsl:element name="resultados">
              <xsl:value-of select="count(amarilla[@equipo=../@equi1])" /> <xsl:text>-</xsl:text> <xsl:value-of select="count(amarilla[@equipo=../@equi2])" />
            </xsl:element>        
          </xsl:element>
          </xsl:for-each>
        </xsl:element>
    
    </xsl:element>
  
  </xsl:template>  
  
  <xsl:template match="/rusia2018/equipos">
  </xsl:template>
</xsl:stylesheet>
