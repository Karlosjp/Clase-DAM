<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:output method="html" encoding="UTF-8" />
  <xsl:template match="/">
      <xsl:element name="html">
        <xsl:element name="head">
            <xsl:element name="title">Resultado HTML</xsl:element>
        </xsl:element>
        <xsl:element name="body">
            <xsl:element name="ul">
            <xsl:for-each select="/inventario/producto">
                <xsl:element name="li">
                  <xsl:text>Elemento: </xsl:text>
                  <xsl:value-of select="@codigo"/>
                  <xsl:element name="ul">
                          <xsl:element name="li">
                            <xsl:text>Nombre: </xsl:text>
                            <xsl:value-of select="nombre"/>
                          </xsl:element>
                          <xsl:element name="li">
                            <xsl:text>Peso: </xsl:text>
                            <xsl:value-of select="peso"/> 
                            <xsl:value-of select="peso/@unidad"/>
                          </xsl:element>
                   </xsl:element>
                </xsl:element>         
              </xsl:for-each>
            </xsl:element>        
          </xsl:element>      
      </xsl:element>
  </xsl:template>
</xsl:stylesheet>
