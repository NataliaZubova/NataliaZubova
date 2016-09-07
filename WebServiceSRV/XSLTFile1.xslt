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
              <th> Штраф</th>
              <th> Получен</th>
              <th> Погашен</th>
              <th> Сумма</th>
            </tr>
            <xsl:for-each select="NewDataSet/Table">

              <tr>
                
                <td>
                  <xsl:value-of select="ФИО"/>
                </td>
                
                <td>
                  <xsl:value-of select="Паспорт" />
                </td>
                
                <td>
                  <xsl:value-of select="Штраф" />
                </td>
               
                <td>
                  <xsl:value-of select="Получен"/>
                </td>
                
                <td>
                  <xsl:value-of select="Погашен"/>
                </td>
                
                <td>
                  <xsl:value-of select="Сумма"/>
                </td>
                
              </tr>
            </xsl:for-each>
          </table>
        </body>
      </html>
    </head>
  </xsl:template>
</xsl:stylesheet>
