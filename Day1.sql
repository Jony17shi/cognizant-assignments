--Literal concatenated with col values
SELECT 'names'+vFirstName+vLastName
FROM externalcandidate

--Arithmetic operations on col data
SELECT cCandidateCode, vFirstName+vLastName, siTestScore, 'NewMarks'=siTestScore+10
FROM externalcandidate

SELECT cCandidateCode, vFirstName+vLastName, siTestScore, 'NewMarks'=siTestScore+10
FROM externalcandidate

--Syntax check
--Resource check
--Performance optimization resources --Index
--Execution plan
--Execute

--WHERE clause
--Note MSSQL is case insensitive by default
SELECT cCandidateCode, vFirstName, vLastName, siTestScore
FROM externalcandidate
WHERE vFirstName='angela'
SELECT cCandidateCode, vFirstName, vLastName, siTestScore
FROM externalcandidate
WHERE cCandidateCode='000020'

SELECT cCandidateCode, vFirstName, vLastName, siTestScore
FROM externalcandidate
WHERE siTestScore=80

-- >,<,>=,<=,!=,<>,= 
-- Only one value is allowed on right-hand side of the comparison operator
SELECT cCandidateCode, vFirstName, vLastName, siTestScore
FROM externalcandidate
WHERE siTestScore=80 AND siTestScore=90

SELECT * FROM externalcandidate

-- Get all candidates from the city Norton and Mentor
SELECT * FROM externalcandidate
WHERE vCity='Norton' OR vCity='Mentor'

-- Get all candidates from Norton city with score greater than 90
-- 22+19=


use Recruitment
select * 
from ExternalCandidate

select cCandidateCode,vFirstName,vLastName,sitestscore
from ExternalCandidate

select cCandidateCode,vFirstName+vLastName,sitestscore
from ExternalCandidate
-- computed col with col heading
SELECT ccandidateCode, 'Name'=vFirstName+space(1)+vLastNAme, siTestScore
FROM externalcandidate

SELECT ccandidateCode, CandidateName=vFirstName+space(1)+vLastNAme, siTestScore
FROM externalcandidate

SELECT ccandidateCode, 'Candidate Name'=vFirstName+space(1)+vLastNAme, siTestScore
FROM externalcandidate

SELECT ccandidateCode, vFirstName+space(1)+vLastNAme 'Candidate Name' , siTestScore
FROM externalcandidate


--literal concatinated with col values
select 'names' + vfirstname,vlastname
from ExternalCandidate

--Arthmatic operations on col data
select ccandidatecode,vfirstname,vfirstname+vlastname,sitestscore,'newmarks'=sitestscore+10
from ExternalCandidate

---syntax check
---resource check
---performance optimization resources --index
---execution plan
---execute


---where clause
--note mssql is caseinsesitive by default
select ccandidatecode,vfirstname,vlastname,sitestscore
from ExternalCandidate
where vfirstname ='angela'

select ccandidatecode,vfirstname,vlastname,sitestscore
from ExternalCandidate
where ccandidatecode='000101'

select ccandidatecode,vfirstname,vlastname,sitestscore
from ExternalCandidate
where sitestscore=80

<,>, <= ,>=,=, != ,<>
-- only one value is allowed on right hand side of the comparison operator
SELECT ccandidateCode, vFirstName, vLastNAme, siTestScore
FROM externalcandidate
where sitestscore>80 and sitestscore<90

select * from ExternalCandidate

-- get all candidates from the city Norton and Mentor

select * from ExternalCandidate
where ccity='Mentor' or ccity='Norton' 

select * from ExternalCandidate
where ccity='Norton' or ccity='Mentor'

--get all candidates from norton city with score grater than 90

select * from ExternalCandidate
where cCity='norton' and sitestscore<=90


-- 22+1
select * from ExternalCandidate
where ccity='Norton' and sitestscore<90

select * from ExternalCandidate
where not ccity='Norton'

select * from ExternalCandidate
where ccity != 'Norton'

-- between , in
select * from ExternalCandidate
where ccity='Norton' or ccity='Mentor' or ccity='Dublin' or ccity='seattle'

select * from ExternalCandidate
where ccity in( 'Norton' , 'Mentor' , 'Dublin' , 'seattle' )

select * from ExternalCandidate
where sitestscore>=80 and sitestscore <= 90

select * from ExternalCandidate
where sitestscore between 80 and 90

--like

select * from ExternalCandidate
where vaddress like '%street%'

select * from ExternalCandidate
where vaddress like '%street'

--candidates whose firstname starts wwith any letter
select * from ExternalCandidate
where vfirstname like 'a%'

--candidates whose code starts or ends with any number

select * from ExternalCandidate
where cCandidateCode like '%1_'

select * from ExternalCandidate
where cCandidateCode like '%1[268]'

select * from ExternalCandidate
where cCandidateCode like '%1[2-3]'

--candidates

select * from ExternalCandidate
where vfirstname like '[jab]%[ayh]'
