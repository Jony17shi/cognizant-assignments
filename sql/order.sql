select * from ExternalCandidate

select cstate,ccity,ccandidatecode,vfirstname,vlastname,sitestscore 
from ExternalCandidate
order by cState

sp_help externalcandidate 

create index idxstateexcan on externalcandidate(cstate,ccity)

drop index idxstateexcan on externalcandidate

select cstate,ccity,ccandidatecode,vfirstname,vlastname,sitestscore 
from ExternalCandidate
order by cState,ccity desc

select ccandidatecode,vfirstname,sitestscore 
from ExternalCandidate
order by siTestScore desc

select top 10 percent ccandidatecode,vfirstname,sitestscore
from ExternalCandidate
order by sitestscore desc

select top 5 ccandidatecode,vfirstname,sitestscore
from ExternalCandidate
order by sitestscore desc

select top 5 ccandidatecode,vfirstname,sitestscore
from ExternalCandidate
order by sitestscore