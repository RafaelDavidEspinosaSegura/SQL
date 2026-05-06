-- Insertar Doctores (6 registros)
INSERT INTO Doctor (Name, Specialty, LicenseNumber) VALUES
  ('Dra. Camila Ríos',    'Cardiología',   'LIC-001'),
  ('Dr. Andrés Mora',     'Pediatría',     'LIC-002'),
  ('Dra. Sofía Vargas',   'Dermatología',  'LIC-003'),
  ('Dr. Felipe Torres',   'Neurología',    'LIC-004'),
  ('Dra. Natalia López',  'Ginecología',   'LIC-005'),
  ('Dr. Javier Castillo', 'Ortopedia',     'LIC-006');

-- Insertar Pacientes (6 registros)
INSERT INTO Patient (Name, PhoneNumber, DateOfBirth, DocumentNumber) VALUES
  ('Juan Pérez',     '3001234567', '1985-03-12', 'CC-111'),
  ('Laura Gómez',    '3109876543', '1992-07-25', 'CC-222'),
  ('Carlos Díaz',    '3205551234', '1978-11-03', 'CC-333'),
  ('María Soto',     '3006667788', '2001-01-18', 'CC-444'),
  ('Ana Martínez',   '3112233445', '1988-09-14', 'CC-555'),
  ('Pedro Ramírez',  '3129988776', '1975-05-30', 'CC-666');

-- Insertar Citas Médicas (6 registros)
INSERT INTO MedicalAppointment (PatientId, DoctorId, AppointmentDate, ReasonConsultation, Status) VALUES
  (1, 1, '2025-08-01 09:00', 'Control tensión',     'Pendiente'),
  (2, 2, '2025-08-02 10:00', 'Revisión pediátrica', 'Completada'),
  (3, 4, '2025-08-03 08:30', 'Dolor de cabeza',     'Pendiente'),
  (4, 3, '2025-08-04 11:00', 'Dermatitis',          'Cancelada'),
  (5, 5, '2025-08-05 14:00', 'Chequeo ginecológico','Pendiente'),
  (6, 6, '2025-08-06 09:30', 'Dolor de rodilla',    'Completada');
