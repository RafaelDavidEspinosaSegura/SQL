//LEFT JOIN, RIGHT JOIN

select*
from doctor d 
left join medicalappointment m 
on d.DoctorId = m.DoctorId;


select *
from medicalappointment m 
right join patient p 
on m.patientid =m.patientid ;



