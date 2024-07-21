CREATE TABLE LogActividades (
    ID_Log INT AUTO_INCREMENT PRIMARY KEY,
    ID_Empleado INT,
    Accion JSON,
    FechaHora DATETIME NOT NULL,
    FOREIGN KEY (ID_Empleado) REFERENCES Empleado(ID_Empleado)
);

SELECT * FROM LogActividades