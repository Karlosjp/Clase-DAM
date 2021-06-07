<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
<xsl:output method="html" encoding="UTF-8" />
  <xsl:template match="/">
      <xsl:element name="html">
        <xsl:element name="head">
            <xsl:element name="title">Tablas de notas.</xsl:element>
            <xsl:element name="link">
              <xsl:attribute name="rel">stylesheet</xsl:attribute>
              <xsl:attribute name="type">text/css</xsl:attribute>
              <xsl:attribute name="href">alumnos.css</xsl:attribute>
            </xsl:element>
        </xsl:element>
       <!--Body--> 
        <xsl:element name="body">
            <xsl:element name="h1">Convocatoria junio</xsl:element>
            <xsl:if test="count(notas/alumno[@convocatoria='Junio']) > 0">  
              <xsl:element name="table">
                  <xsl:copy-of select="$cabecera" />
                  <xsl:apply-templates select="notas/alumno[@convocatoria='Junio']">
                    <xsl:sort select="apellidos" />
                    <xsl:sort select="nombre" />
                  </xsl:apply-templates>
              </xsl:element>
            </xsl:if>
      
       
            <xsl:element name="h1">Convocatoria septiembre</xsl:element>
            <xsl:if test="count(notas/alumno[@convocatoria='Septiembre']) > 0">  
              <xsl:element name="table">
                  <xsl:copy-of select="$cabecera" />
                  <xsl:apply-templates select="notas/alumno[@convocatoria='Septiembre']">
                    <xsl:sort select="apellidos" />
                    <xsl:sort select="nombre" />
                  </xsl:apply-templates>
              </xsl:element>
            </xsl:if>
  
            <xsl:element name="p"> ¿Cuántos alumnos hay inscritos en este curso? 
                <xsl:value-of select="count(/notas/alumno)"/>
           </xsl:element>
             </xsl:element>
      </xsl:element>
  </xsl:template>
  
    <xsl:variable name="cabecera">
          <xsl:element name="tr">
                  <xsl:element name="th">
                        <xsl:attribute name="colspan">2</xsl:attribute>
                        <xsl:text>DATOS</xsl:text>
                  </xsl:element>
                  <xsl:element name="th">
                        <xsl:attribute name="colspan">4</xsl:attribute>
                        <xsl:text>NOTAS</xsl:text>
                  </xsl:element>
            </xsl:element>
            <xsl:element name="tr">
                <xsl:element name="td"> Apellidos</xsl:element>
                <xsl:element name="td"> Nombre</xsl:element>        
                <xsl:element name="td"> Tareas</xsl:element>        
                <xsl:element name="td"> Cuestionario</xsl:element>
                <xsl:element name="td"> Examen</xsl:element>        
                <xsl:element name="td">Nota en letra</xsl:element>        
            </xsl:element>  
  </xsl:variable>
  
  
  <xsl:template match="notas/alumno">
        <xsl:element name="tr">
                <xsl:element name="td"><xsl:value-of select="apellidos"/></xsl:element>   
                <xsl:element name="td"><xsl:value-of select="nombre"/></xsl:element>                   
                <xsl:element name="td"><xsl:value-of select="tareas"/></xsl:element>   
                <xsl:element name="td"><xsl:value-of select="cuestionarios"/></xsl:element>   
                <xsl:element name="td"><xsl:value-of select="examen" /></xsl:element>   
                
                    <xsl:choose>
                        <xsl:when test="final>=9">
                            <xsl:element name="td">
                                <xsl:text>Sobresaliente</xsl:text>
                             </xsl:element> 
                        </xsl:when>
                        <xsl:when test="final>=7">
                            <xsl:element name="td">                      
                                <xsl:text>Notable</xsl:text>
                             </xsl:element> 
                       </xsl:when>
                        <xsl:when test="final>=6">
                            <xsl:element name="td">
                                 <xsl:text>Bien</xsl:text>
                             </xsl:element> 
                        </xsl:when>
                         <xsl:when test="final>=5">
                             <xsl:element name="td">
                                <xsl:text>Suficiente</xsl:text>
                             </xsl:element> 
                        </xsl:when>
                        <xsl:otherwise>
                            <xsl:element name="td">
                              <xsl:attribute name="class">suspenso</xsl:attribute>
                              <xsl:text>Insuficiente</xsl:text>                              
                             </xsl:element> 

                        </xsl:otherwise>            
                    </xsl:choose>
                  
             </xsl:element>   
  </xsl:template>

</xsl:stylesheet>
