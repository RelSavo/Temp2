<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl">
  
  <xsl:output method="xml" indent="yes"/>

  <xsl:template match="Students">
      <Students>
          <xsl:apply-templates select="Student"/>
      </Students>
  </xsl:template>
  
  <xsl:template match="Student">
    <Student>
      <xsl:attribute name="StudentID">
        <xsl:value-of select="StudentID"/>
      </xsl:attribute>
      <xsl:attribute name="FirstName">
        <xsl:value-of select="FirstName"/>
      </xsl:attribute>
      <xsl:attribute name="LastName">
        <xsl:value-of select="LastName"/>
      </xsl:attribute>
      <xsl:attribute name="DisplayName">
        <xsl:value-of select="DisplayName"/>
      </xsl:attribute>
      <xsl:attribute name="Gender">
        <xsl:value-of select="Gender"/>
      </xsl:attribute>
      <xsl:attribute name="Address">
        <xsl:value-of select="Address"/>
      </xsl:attribute>
      <xsl:attribute name="City">
        <xsl:value-of select="City"/>
      </xsl:attribute>
      <xsl:attribute name="ProvinceState">
        <xsl:value-of select="ProvinceState"/>
      </xsl:attribute>
      <xsl:attribute name="Country">
        <xsl:value-of select="Country"/>
      </xsl:attribute>
      <xsl:attribute name="PostalCodeZip">
        <xsl:value-of select="PostalCodeZip"/>
      </xsl:attribute>
      <xsl:attribute name="BirthDate">
        <xsl:value-of select="BirthDate"/>
      </xsl:attribute>
    </Student>
  </xsl:template>
</xsl:stylesheet>
