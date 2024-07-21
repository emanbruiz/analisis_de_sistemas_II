INSERT INTO Empleado (
    Tipo_Empleado,
    Horario,
    Permitir_Editar,
    Permitir_Eliminar,
    Permitir_Añadir_Usuario
) VALUES (
    'Administrador',
    '7:00-16:00',
    'V',
    'V',
    'V'
);

-- Obtener el ID de Empleado insertado
SET @last_id_empleado = LAST_INSERT_ID();
INSERT INTO Datos_Personales (
    Genero,
    Nombres,
    Apellidos,
    Direccion_Personal,
    Correo_Personal,
    DPI,
    Contrasena,
    ID_Cliente,
    ID_Proveedor,
    ID_Empleado,
    ID_Piloto
) VALUES (
    'Masculino',
    'Emanuel',
    'Barahona',
    '12 avenida Zona 7',
    'admin@correo.com',
    '0901214035',
    '12345',
    NULL,
    NULL,
    @last_id_empleado,
    NULL
);




