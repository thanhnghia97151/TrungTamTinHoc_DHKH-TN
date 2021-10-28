 

 --drop proc GetProfessorsByMoudleId
 --go
create proc GetProfessorsByMoudleId(@Id int)
as

Select * from Professor join ModuleProfessor
on Professor.Professor_Id = ModuleProfessor.ProfessorId
and ModuleId = @Id;
go

Exec GetProfessorsByMoudleId @Id =1;
select * from Professor
select * from ModuleProfessor

--drop proc GetProfessorsNotInMoudle
--go
create proc GetProfessorsNotInMoudle(@Id int)
as
select * from Professor where Professor_Id not in 
	(select ProfessorId from ModuleProfessor where  ModuleId = @Id);
go

exec GetProfessorsNotInMoudle @Id = 1;


select * from Professor where Professor_Id not in 
	(select ProfessorId from ModuleProfessor where  ModuleId != 1);



create proc GetProfessorsChecked(@Id int)
as
	select Professor.*, CAST(IIF(ModuleId is null,0,1)as bit) Checked from Professor
	left join ModuleProfessor
	on Professor.Professor_Id = ModuleProfessor.ProfessorId
	and ModuleId = @Id;
go

exec GetProfessorsChecked @Id =1;