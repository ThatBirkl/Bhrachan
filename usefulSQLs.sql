-- Create ID trigger for table

CREATE TRIGGER Generate<Table name>ID
AFTER INSERT ON <Table name>
FOR EACH ROW
WHEN (NEW.<ID Column name> IS NULL)
BEGIN
   UPDATE <Table name> SET <ID Column name> = (select hex( randomblob(4)) || '-' || hex( randomblob(2))
             || '-' || '4' || substr( hex( randomblob(2)), 2) || '-'
             || substr('AB89', 1 + (abs(random()) % 4) , 1)  ||
             substr(hex(randomblob(2)), 2) || '-' || hex(randomblob(6)) ) WHERE rowid = NEW.rowid;
END;



-- Insert Keytype into Keyword
insert into SYS_KEYWORD
(
KEYWORDID,
KEYNAME,
KEYVALUE,
KEYTYPE
) values (
NULL,
'<keytype name in caps>',
<(highest number of keytype 0) + 1>,
0
)

-- Insert Keyword into Keyword
insert into SYS_KEYWORD
(
KEYWORDID,
KEYNAME,
KEYVALUE,
KEYTYPE
) values (
NULL,
'<keyword>',
<int incrementally higher>,
(select KEYVALUE from SYS_KEYWORD where KEYNAME = '<keytype name>')
)

-- Insert Ability
insert into SYS_ABILITY(
ABILITYID, 			--ID
ACTIVE_PASSIVE,		--keyword ABILITY_A_P
TYPE,				--keyword ABILITY_TYPE
NAME,				--ability name
HEALTH_BALANCE,		--positive for healing | negative for damage
RADIUS,				--radius around the player in which the ability can be cast
AOE,				--area of effect around the target position
WHEN_TO_CALL,		--for passive abilities; keyword ABILITY_WHEN_TO_CALL
TIME_INTERVAL_SEC,	--if passive and WHEN_TO_CALL is onTime
ENERGY_COST,		--ability energy cost
PENALTY_SEC,		--amount of seconds the character gets pushed back
DAMAGE_REDUCTION,	--mostly for parry abilities; reduced damage to caster
MAX_NUM_TARGETS,	--the maximum number of targets for this ability
PRIMARY_SKILL,		--keyword PRIMARY_SKILL
SECONDARY_SKILL,	--keyword SECUNDARY_SKILL
DISPLAY_CONDITION	--keyword ABILITY_DISPLAY_CONDITION
) values (
NULL,
(select kw.keyvalue
	from sys_keyword kt 
	join sys_keyword kw on kw.keytype = kt.keyvalue
	where kt.keytype = 0 and kt.keyname='ABILITY_A_P'
	and kw.keyname='<active|passive>'),
(select kw.keyvalue
	from sys_keyword kt 
	join sys_keyword kw on kw.keytype = kt.keyvalue
	where kt.keytype = 0 and kt.keyname='ABILITY_TYPE'
	and kw.keyname='<type>'),
'<name>',
<health_balance>,
<radius>,
<aoe>,
(select kw.keyvalue
	from sys_keyword kt 
	join sys_keyword kw on kw.keytype = kt.keyvalue
	where kt.keytype = 0 and kt.keyname='ABILITY_WHEN_TO_CALL'
	and kw.keyname='<when_to_call>'),
<time interval>,
<energy cost| -1 if irrelevant>,
<penalty in sec| -1 if irrelevant>,
<damage reduction>,
<max num of targets>,
(select kw.keyvalue
	from sys_keyword kt 
	join sys_keyword kw on kw.keytype = kt.keyvalue
	where kt.keytype = 0 and kt.keyname='PRIMARY_SKILL'
	and kw.keyname='<primary skill>'),
(select kw.keyvalue
	from sys_keyword kt 
	join sys_keyword kw on kw.keytype = kt.keyvalue
	where kt.keytype = 0 and kt.keyname='SECONDARY_SKILL'
	and kw.keyname='<secundary skill>'),
(select kw.keyvalue
	from sys_keyword kt 
	join sys_keyword kw on kw.keytype = kt.keyvalue
	where kt.keytype = 0 and kt.keyname='ABILITY_DISPLAY_CONDITION'
	and kw.keyname='<condition>')
)