

Select e.nombre, e.defaultText, t.Traduccion FROM Etiqueta as e
LEFT JOIN (
	SELECT * FROM Traducciones as subt
	INNER JOIN Idioma as i ON (subt.FK_id_idioma = i.id)
	WHERE i.nombre = 'Italiano'
) as t ON e.id = t.FK_id_etiqueta
