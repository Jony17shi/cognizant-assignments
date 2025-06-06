-- right join
-- self join

select * from externalcandidate

select * from RecruitmentAgencies

Select cCandidatecode, vFirstname, vLastname, cAgencycode  
from Externalcandidate  
where cAgencyCode is not Null

select * from RecruitmentAgencies

select ccandidatecode, vfirstname, cname  
from ExternalCandidate  
inner join RecruitmentAgencies  
on ExternalCandidate.cAgencyCode = RecruitmentAgencies.cAgencyCode

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
