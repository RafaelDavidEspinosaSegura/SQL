//cuantas citas completadas, cuantas canceladas y cuandas pendientes
select status, count(*) as totalcitas
from medicalappointment m 
group by status;

// cuantas citas hay en cada dia 
select  appointmentDate, count(*) as CitasHoy
from medicalappointment m 
group by appointmentdate;