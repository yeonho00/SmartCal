--------------------------------------------------------
--  파일이 생성됨 - 목요일-12월-19-2019   
--------------------------------------------------------
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.회원종류 객체에 대한 TABLE DDL을 렌더링할 수 없습니다.
CREATE TABLE 회원종류 
(
  회원종류번호 VARCHAR2(5 BYTE) NOT NULL 
, 회원종류이름 VARCHAR2(20 BYTE) 
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
NOPARALLELCREATE UNIQUE INDEX 회원종류_PK ON 회원종류 (회원종류번호 ASC) 
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
NOPARALLELALTER TABLE 회원종류
ADD CONSTRAINT 회원종류_PK PRIMARY KEY 
(
  회원종류번호 
)
USING INDEX 회원종류_PK
ENABLE
REM INSERTING into SCAL."회원종류"
SET DEFINE OFF;
Insert into SCAL."회원종류" ("회원종류번호","회원종류이름") values ('0001','일반');
Insert into SCAL."회원종류" ("회원종류번호","회원종류이름") values ('0002','관리자');
Insert into SCAL."회원종류" ("회원종류번호","회원종류이름") values ('0003','제조사');
Insert into SCAL."회원종류" ("회원종류번호","회원종류이름") values ('0004','통신사');
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.회원종류_PK 객체에 대한 INDEX DDL을 렌더링할 수 없습니다.
CREATE UNIQUE INDEX 회원종류_PK ON 회원종류 (회원종류번호 ASC) 
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
