-- Tabla Cliente
CREATE TABLE Cliente (
    ID_Cliente INT AUTO_INCREMENT PRIMARY KEY
    -- Otras columnas según el diagrama
);

-- Tabla Proveedor
CREATE TABLE Proveedor (
    ID_Proveedor INT AUTO_INCREMENT PRIMARY KEY,
    Localidad_Proveedor VARCHAR(255),
    Web_Proveedor VARCHAR(255),
    Tel_Proveedor VARCHAR(20)
);

-- Tabla Empleado
CREATE TABLE Empleado (
    ID_Empleado INT AUTO_INCREMENT PRIMARY KEY,
    Tipo_Empleado VARCHAR(50),
    Horario VARCHAR(50),
    Permitir_Editar VARCHAR(1),
    Permitir_Eliminar VARCHAR(1),
    Permitir_Añadir_Usuario VARCHAR(1)
);

-- Tabla Piloto
CREATE TABLE Piloto (
    ID_Piloto INT AUTO_INCREMENT PRIMARY KEY
);

-- Tabla Datos_Personales
CREATE TABLE Datos_Personales (
    ID_Persona INT AUTO_INCREMENT PRIMARY KEY,
    Genero VARCHAR(10),
    Nombres VARCHAR(100),
    Apellidos VARCHAR(100),
    Direccion_Personal VARCHAR(255),
    Correo_Personal VARCHAR(100),
    DPI VARCHAR(20),
    Contrasena VARCHAR(255),
    ID_Cliente INT,
    ID_Proveedor INT,
    ID_Empleado INT,
    ID_Piloto INT,
    FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente),
    FOREIGN KEY (ID_Proveedor) REFERENCES Proveedor(ID_Proveedor),
    FOREIGN KEY (ID_Empleado) REFERENCES Empleado(ID_Empleado),
    FOREIGN KEY (ID_Piloto) REFERENCES Piloto(ID_Piloto)
);

-- Tabla Pedido
CREATE TABLE Pedido (
    ID_Pedido INT AUTO_INCREMENT PRIMARY KEY,
    Tipo_Pedido VARCHAR(50),
    No_Factura VARCHAR(50),
    Fecha_Solicitud DATE,
    Cantidad INT,
    Monto DECIMAL(10, 2),
    Empresa VARCHAR(100),
    Envio VARCHAR(100),
    ID_Persona INT,
    FOREIGN KEY (ID_Persona) REFERENCES Datos_Personales(ID_Persona)
);

-- Tabla Detalle
CREATE TABLE Detalle (
    ID_Detalle INT AUTO_INCREMENT PRIMARY KEY,
    Cantidad INT,
    Precio_U DECIMAL(10, 2),
    Total DECIMAL(10, 2),
    ID_Pedido INT,
    FOREIGN KEY (ID_Pedido) REFERENCES Pedido(ID_Pedido)
);

-- Tabla Producto
CREATE TABLE Producto (
    ID_Producto INT AUTO_INCREMENT PRIMARY KEY,
    Nombre_Producto VARCHAR(100),
    Detalle_Producto TEXT,
    Precio_Producto DECIMAL(10, 2),
    Foto_Producto VARCHAR(255),
    Pais_Fabricante VARCHAR(100),
    IVA DECIMAL(10, 2),
    Comentarios_Producto TEXT,
    Marca VARCHAR(100),
    Pais_Marca VARCHAR(100),
    Contacto_Marca VARCHAR(100),
    Tipo_UM VARCHAR(50),
    Nombre_Presentacion VARCHAR(100),
    Descripcion_Presentacion TEXT,
    ID_Detalle INT,
    FOREIGN KEY (ID_Detalle) REFERENCES Detalle(ID_Detalle)
);

-- Tabla Envio
CREATE TABLE Envio (
    ID_Envio INT AUTO_INCREMENT PRIMARY KEY,
    Direccion_Entrega VARCHAR(255),
    Direccion_Recolecta VARCHAR(255),
    Estado_Envio VARCHAR(50),
    ID_Pedido INT,
    FOREIGN KEY (ID_Pedido) REFERENCES Pedido(ID_Pedido)
);

-- Tabla Vehiculo
CREATE TABLE Vehiculo (
    ID_Vehiculo INT AUTO_INCREMENT PRIMARY KEY,
    Tipo_Vehiculo VARCHAR(50),
    Detalles_Vehiculo TEXT,
    Contacto_Marca VARCHAR(100),
    ID_Piloto INT,
    ID_Envio INT,
    FOREIGN KEY (ID_Piloto) REFERENCES Piloto(ID_Piloto),
    FOREIGN KEY (ID_Envio) REFERENCES Envio(ID_Envio)
);

-- Insertar en la tabla Datos_Personales
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
    'M',
    'Admin',
    'Admin',
    'Direccion Admin',
    'admin@example.com',
    '1234567890123',
    'admin_password',
    NULL,
    NULL,
    NULL,
    NULL
);

-- Obtener el ID de Datos_Personales insertado
SET @last_id_persona = LAST_INSERT_ID();

-- Insertar en la tabla Empleado
INSERT INTO Empleado (
    Tipo_Empleado,
    Horario,
    Permitir_Editar,
    Permitir_Eliminar,
    Permitir_Añadir_Usuario
) VALUES (
    'admin',
    '12345',
    'V',
    'V',
    'V'
);

-- Obtener el ID de Empleado insertado
SET @last_id_empleado = LAST_INSERT_ID();

-- Actualizar el ID_Empleado en Datos_Personales
UPDATE Datos_Personales SET ID_Empleado = @last_id_empleado WHERE ID_Persona = @last_id_persona;
