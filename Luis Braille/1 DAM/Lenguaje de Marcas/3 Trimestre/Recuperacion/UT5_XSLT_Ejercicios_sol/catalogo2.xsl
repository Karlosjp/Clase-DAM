<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:output method="html" encoding="UTF-8" />
  <xsl:template match="/">
  <xsl:element name="html">
    <xsl:element name="head">
      <xsl:element name="title">Tablas de notas.</xsl:element>  
      <!--<xsl:processing-instruction name="stylesheet">
          <xsl:text> href="catalogo.css" type="text/css"</xsl:text>
      </xsl:processing-instruction>
      -->
      <xsl:element name="link">
        <xsl:attribute name="href">catalogo.css</xsl:attribute>
        <xsl:attribute name="type">text/css</xsl:attribute>
      </xsl:element>
  </xsl:element>
    <xsl:element name="body">
      <xsl:element name="h2"> My CD Collection</xsl:element>
        <xsl:element name="table">
          <xsl:element name="tr">
            <xsl:element name="th"> Title</xsl:element>
            <xsl:element name="th">Artist</xsl:element>
          </xsl:element>
           <xsl:for-each select="/catalogo/cd">
                 <xsl:element name="tr">
                        <xsl:element name="td"> 
                            <xsl:value-of select="title" />
                        </xsl:element>
                          <xsl:element name="td">
                              <xsl:value-of select="artist" />
                          </xsl:element>
                    </xsl:element>
              </xsl:for-each>  
          </xsl:element>
      </xsl:element>
    </xsl:element>  
  </xsl:template>
</xsl:stylesheet>
