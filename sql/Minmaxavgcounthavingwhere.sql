-- Min max avg count
select sitestscore from externalcandidate

select max(sitestscore), min(sitestscore), avg(sitestscore), count=sitestscore from externalcandidate

select count(ccandidatecode), count(cEmailId) from externalcandidate
select count(*) from externalcandidate
select count(ccandidatecode) from externalcandidate

--group by

select cstate, 'No of Candidates'=count(ccandidatecode)
from externalcandidate

select * from externalcandidate
order by cstate

select cstate, 'No of Candidates'=count(ccandidatecode)
from externalcandidate
group by cstate

select cstate, 'No of Candidates'=count(ccandidatecode), max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from externalcandidate
group by cstate

select cstate, 'No of Candidates'=count(ccandidatecode), max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from externalcandidate
group by cstate

-- need for having
select cstate, 'No of Candidates'=count(ccandidatecode), max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from externalcandidate
where sitestscore > 80
group by cstate
having count(ccandidatecode) >= 2

select cstate, 'No of Candidates'=count(ccandidatecode), max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from externalcandidate
group by cstate
having avg(sitestscore) >= 70


-- for the above report consider only those candidates whose sitestscore is greater than 70
select cstate, 'No of Candidates'=count(ccandidatecode), max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from externalcandidate
where cstate in ('Nevada', 'ohio', 'texas') and sitestscore > 70
group by cstate

select cstate, 'No of Candidates'=count(ccandidatecode), max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from externalcandidate
where sitestscore > 70
group by cstate
having cstate in ('Nevada', 'ohio', 'texas')

-- for the above report only consider those states which have candidate count > 2
select cstate, 'No of Candidates'=count(ccandidatecode), max=max(sitestscore), min=min(sitestscore), avg=avg(sitestscore)
from externalcandidate
where cstate in ('Nevada', 'ohio', 'texas')
group by cstate
having count(ccandidatecode) > 2

