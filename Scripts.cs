
CREATE TABLE Doctor
(
    DoctorId SERIAL PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Specialty VARCHAR(50) NOT NULL,
    LicenseNumber VARCHAR(20) NOT NULL UNIQUE
);

CREATE TABLE Patient (

    PatientId SERIAL PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    PhoneNumber VARCHAR(20),
    DateOfBirth DATE NOT NULL,
    DocumentNumber VARCHAR(20) NOT NULL UNIQUE
);

CREATE TABLE MedicalAppointment
(
    AppointmentId SERIAL PRIMARY KEY,
    PatientId INT NOT NULL,
    DoctorId INT NOT NULL,
    AppointmentDate TIMESTAMP NOT NULL,
    ReasonConsultation VARCHAR(200) NOT NULL,
    Status VARCHAR(20) NOT NULL CHECK (Status IN ('Pendiente','Completada','Cancelada')),
    CONSTRAINT FK_Appointment_Patient FOREIGN KEY (PatientId) REFERENCES Patient(PatientId),
    CONSTRAINT FK_Appointment_Doctor FOREIGN KEY (DoctorId) REFERENCES Doctor(DoctorId)
);