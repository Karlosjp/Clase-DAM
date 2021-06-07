<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <xsl:template match="/">
        <xsl:element name="html">
            <xsl:element name="body">
                <xsl:element name="h2">Ranking</xsl:element>
                <xsl:element name="table">
                    <xsl:attribute name="border">1</xsl:attribute>
                    <xsl:element name="tr">
                        <xsl:element name="th">Nombre</xsl:element>
                        <xsl:element name="th">Copias veneidas</xsl:element>
                        <xsl:element name="th">Lanzamiento</xsl:element>
                        <xsl:element name="th">Actualizacion de los datos</xsl:element>
                        <xsl:element name="th">Genero(s)</xsl:element>
                        <xsl:element name="th">Desarrollador(es)</xsl:element>
                        <xsl:element name="th">Distribuidor(es)</xsl:element>
                    </xsl:element>
                    <xsl:for-each select="//juego">
                        <xsl:sort select="copias_vendidas" order="descending" />
                        <xsl:if test="copias_vendidas > 6">
                            <xsl:element name="tr">
                                <xsl:element name="td">
                                    <xsl:value-of select="nombre" />
                                </xsl:element>
                                <xsl:element name="td">
                                    <xsl:apply-templates select="copias_vendidas" />
                                </xsl:element>
                                <xsl:element name="td">
                                    <xsl:value-of select="fecha_lanzamiento" />
                                </xsl:element>
                                <xsl:element name="td">
                                    <xsl:value-of select="actualizacion_datos" />
                                </xsl:element>
                                <xsl:element name="td">
                                    <xsl:value-of select="generos" />
                                </xsl:element>
                                <xsl:element name="td">
                                    <xsl:value-of select="desarrolladores" />
                                </xsl:element>
                                <xsl:element name="td">
                                    <xsl:value-of select="distribuidores" />
                                </xsl:element>
                            </xsl:element>
                        </xsl:if>
                    </xsl:for-each>
                    <xsl:element name="tr">
                        <xsl:element name="td">
                            <xsl:attribute name="rowspan">5</xsl:attribute>
                            <xsl:value-of select="count(//copias_vendidas)"></xsl:value-of>
                        </xsl:element>
                    </xsl:element>
                </xsl:element>
            </xsl:element>
        </xsl:element>
    </xsl:template>
    <xsl:template match="/juego">
        <xsl:apply-templates select="copias_vendidas" />
    </xsl:template>
    <xsl:template match="copias_vendidas">
        <span style="color:grey;">
            <xsl:value-of select="." />
            M
        </span>
    </xsl:template>
</xsl:stylesheet>