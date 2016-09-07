<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
  <xsl:output method="xml" indent="yes"/>
  <xsl:template match="/">
    <head>

      <html>
        <body>
          <table width="766" border="1" cellspacing="0" cellpadding="0" align="center">
            <tr>
              <th> ФИО</th>
              <th> Паспорт</th>
              <th> Адрес</th>
              <th> Период</th>
              <th> Статус</th>
              
            </tr>
            <xsl:for-each select="NewDataSet/Table">

              <tr>
                
                <td>
                  <xsl:value-of select="NAME" />
                </td>
                
                <td>
                  <xsl:value-of select="PASPORT" />
                </td>
                
                <td>
                  <xsl:value-of select="ADRESS"/>
                </td>
                
                <td>
                  <xsl:value-of select="PERIOD"/>
                </td>
                
                <td>
                  <xsl:value-of select="STATUS"/>
                </td>
                <td>
                </td>
              </tr>
            </xsl:for-each>
          </table>
        </body>
      </html>
    </head>
  </xsl:template>
</xsl:stylesheet>
