ALTER TABLE Datos_Personales
ADD COLUMN PromedioCalificaciones DECIMAL(3,2);

CREATE TABLE CalificacionUsuario (
    ID_Calificacion_Usuario INT AUTO_INCREMENT PRIMARY KEY,
    ID_Persona INT NOT NULL,
    Punteo TINYINT UNSIGNED CHECK (Punteo BETWEEN 0 AND 5),
    Comentario TEXT,
    ID_Piloto INT NOT NULL,
    ID_Pedido INT NOT NULL,
    ID_Producto INT NOT NULL,
    FOREIGN KEY (ID_Persona) REFERENCES Datos_Personales(ID_Persona),
    FOREIGN KEY (ID_Piloto) REFERENCES Piloto(ID_Piloto),
    FOREIGN KEY (ID_Pedido) REFERENCES Pedido(ID_Pedido),
    FOREIGN KEY (ID_Producto) REFERENCES Producto(ID_Producto)
);

CREATE TABLE CalificacionPiloto (
    ID_Calificacion_Piloto INT AUTO_INCREMENT PRIMARY KEY,
    ID_Piloto INT NOT NULL,
    Punteo TINYINT UNSIGNED CHECK (Punteo BETWEEN 0 AND 5),
    Comentario TEXT,
    ID_Persona INT NOT NULL,
    ID_Pedido INT NOT NULL,
    ID_Producto INT NOT NULL,
    FOREIGN KEY (ID_Piloto) REFERENCES Piloto(ID_Piloto),
    FOREIGN KEY (ID_Persona) REFERENCES Datos_Personales(ID_Persona),
    FOREIGN KEY (ID_Pedido) REFERENCES Pedido(ID_Pedido),
    FOREIGN KEY (ID_Producto) REFERENCES Producto(ID_Producto)
);
