--------------------------------------------------------
--  파일이 생성됨 - 목요일-12월-19-2019   
--------------------------------------------------------
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.검색기록 객체에 대한 TABLE DDL을 렌더링할 수 없습니다.
CREATE TABLE 검색기록 
(
  검색단어 VARCHAR2(40 BYTE) NOT NULL 
, 검색횟수 NUMBER 
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
NOPARALLELCREATE UNIQUE INDEX 검색기록_PK ON 검색기록 (검색단어 ASC) 
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
NOPARALLELALTER TABLE 검색기록
ADD CONSTRAINT 검색기록_PK PRIMARY KEY 
(
  검색단어 
)
USING INDEX 검색기록_PK
ENABLE
REM INSERTING into SCAL."검색기록"
SET DEFINE OFF;
Insert into SCAL."검색기록" ("검색단어","검색횟수") values ('갤럭시',3);
Insert into SCAL."검색기록" ("검색단어","검색횟수") values ('roffjrtl',1);
Insert into SCAL."검색기록" ("검색단어","검색횟수") values ('IPhone',5);
Insert into SCAL."검색기록" ("검색단어","검색횟수") values ('lg',5);
Insert into SCAL."검색기록" ("검색단어","검색횟수") values ('LG',2);
Insert into SCAL."검색기록" ("검색단어","검색횟수") values ('플러스',3);
Insert into SCAL."검색기록" ("검색단어","검색횟수") values ('+',8);
Insert into SCAL."검색기록" ("검색단어","검색횟수") values ('Plus',3);
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.검색기록_PK 객체에 대한 INDEX DDL을 렌더링할 수 없습니다.
CREATE UNIQUE INDEX 검색기록_PK ON 검색기록 (검색단어 ASC) 
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
