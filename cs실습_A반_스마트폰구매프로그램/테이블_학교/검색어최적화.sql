--------------------------------------------------------
--  파일이 생성됨 - 목요일-12월-19-2019   
--------------------------------------------------------
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.검색어최적화 객체에 대한 TABLE DDL을 렌더링할 수 없습니다.
CREATE TABLE 검색어최적화 
(
  수정전검색어 VARCHAR2(40 BYTE) NOT NULL 
, 수정후검색어 VARCHAR2(40 BYTE) 
) 
LOGGING 
TABLESPACE SYSTEM 
PCTFREE 10 
PCTUSED 40 
INITRANS 1 
STORAGE 
( 
  INITIAL 65536 
  NEXT 1048576 
  MINEXTENTS 1 
  MAXEXTENTS UNLIMITED 
  FREELISTS 1 
  FREELIST GROUPS 1 
  BUFFER_POOL DEFAULT 
) 
NOPARALLELCREATE UNIQUE INDEX 검색어최적화_PK ON 검색어최적화 (수정전검색어 ASC) 
LOGGING 
TABLESPACE SYSTEM 
PCTFREE 10 
INITRANS 2 
STORAGE 
( 
  INITIAL 65536 
  NEXT 1048576 
  MINEXTENTS 1 
  MAXEXTENTS UNLIMITED 
  FREELISTS 1 
  FREELIST GROUPS 1 
  BUFFER_POOL DEFAULT 
) 
NOPARALLELALTER TABLE 검색어최적화
ADD CONSTRAINT 검색어최적화_PK PRIMARY KEY 
(
  수정전검색어 
)
USING INDEX 검색어최적화_PK
ENABLE
REM INSERTING into SCAL."검색어최적화"
SET DEFINE OFF;
Insert into SCAL."검색어최적화" ("수정전검색어","수정후검색어") values ('aaa','e1');
Insert into SCAL."검색어최적화" ("수정전검색어","수정후검색어") values ('roffjrtl','Galaxy');
Insert into SCAL."검색어최적화" ("수정전검색어","수정후검색어") values ('겔럭시','Galaxy');
Insert into SCAL."검색어최적화" ("수정전검색어","수정후검색어") values ('아이폰','IPhone');
Insert into SCAL."검색어최적화" ("수정전검색어","수정후검색어") values ('플러스','+');
Insert into SCAL."검색어최적화" ("수정전검색어","수정후검색어") values ('Plus','+');
Insert into SCAL."검색어최적화" ("수정전검색어","수정후검색어") values ('galaxy','Galaxy');
Insert into SCAL."검색어최적화" ("수정전검색어","수정후검색어") values ('dkdlvhs','IPhone');
Insert into SCAL."검색어최적화" ("수정전검색어","수정후검색어") values ('iphone','IPhone');
Insert into SCAL."검색어최적화" ("수정전검색어","수정후검색어") values ('ㅣㅎ','LG');
Insert into SCAL."검색어최적화" ("수정전검색어","수정후검색어") values ('lg','LG');
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.검색어최적화_PK 객체에 대한 INDEX DDL을 렌더링할 수 없습니다.
CREATE UNIQUE INDEX 검색어최적화_PK ON 검색어최적화 (수정전검색어 ASC) 
LOGGING 
TABLESPACE SYSTEM 
PCTFREE 10 
INITRANS 2 
STORAGE 
( 
  INITIAL 65536 
  NEXT 1048576 
  MINEXTENTS 1 
  MAXEXTENTS UNLIMITED 
  FREELISTS 1 
  FREELIST GROUPS 1 
  BUFFER_POOL DEFAULT 
) 
NOPARALLEL
