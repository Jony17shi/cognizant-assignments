-- Day 2
select c.candidatecode, c.vFirstName, c.name 'Recruiter'
from ExternalCandidate, RecruitmentAgencies
where ExternalCandidate.cAgencyCode = RecruitmentAgencies.cAgencyCode

select * from ExternalCandidate

select * from Position

select c.candidatecode, p.CPositioncode
from ExternalCandidate e
cross join Position p
--where p.CPositionCode like '%[12]'
order by cCandidateCode

select 22-15

---new table

select * from ExternalCandidate2;

create table ExternalCandidate2
(
    cCandidateCode     char(6) constraint Pk_ExternalCandidate2_ccandidatecode primary key 
                       constraint eccd_ck check(cCandidateCode like '[0-9][0-9][0-9][0-9][0-9][0-9]'),
    vFirstName         varchar(20) not null,
    vLastName          varchar(20),
    cCity              char(20) default 'Mumbai' 
                       constraint ch_ccity check(cCity in ('Mumbai', 'Delhi', 'Hyderabad', 'Chennai', 'Banglore')),
    cPhone             char(15) constraint ecp_ck1 check(cPhone like '([0-9][0-9][0-9])[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'),
    cPositionCode      char(4) constraint fk_position_cPositioncode references Position(cPositionCode),
    dDateOfApplication datetime,
    siPrevWorkExperience smallint,
    mPrevAnnualSalary  money,
    vEmailId           varchar(20) constraint ec_UK unique
);

insert ExternalCandidate2
values (
    '000001',                 -- cCandidateCode
    'Beena',                  -- vFirstName
    'Shah',                   -- vLastName
    Default,                  -- cCity (uses default value 'Mumbai')
    '(123)123-1234',          -- cPhone
    '0001',                   -- cPositionCode
    '06/06/2025',             -- dDateOfApplication
    1,                        -- siPrevWorkExperience
    1000000,                  -- mPrevAnnualSalary
    'beelnaj@gmail.com'       -- vEmailId
);

-- Select all records from the ExternalCandidate table
select * from ExternalCandidate;

-- Insert a record into ExternalCandidate
insert into ExternalCandidate(cCandidateCode, vFirstname)
values('0001', 'Seema');

-- Delete the record where candidate code is '0001'
delete ExternalCandidate
where cCandidateCode = '0001';

-- Alter table to add a new constraint
alter table ExternalCandidate2
add constraint ec_code_ck000000 check(cCandidateCode not like '000000');

----FUNCTIONS


select upper(vfirstname) from externalcandidate
select lower(vfirstname) from externalcandidate
select val='   123' from externalcandidate
select ltrim('   123') from externalcandidate
select 'a'=rtrim('   123         ') from externalcandidate
 
select len('   1 23         ') from externalcandidate
select len(vfirstname),vfirstname from externalcandidate
select vfirstname,patindex('%an%',vfirstname) from externalcandidate
select vfirstname,charindex('A',vfirstname) from externalcandidate
 
select vfirstname,substring(vfirstname,5,2) from externalcandidate
 
select vfirstname,reverse(substring(reverse(vfirstname),1,2)) 
from ExternalCandidate
select vfirstname,substring(vfirstname,len(vfirstname)-1,2)
from ExternalCandidate

