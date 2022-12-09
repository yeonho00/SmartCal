--------------------------------------------------------
--  파일이 생성됨 - 목요일-12월-19-2019   
--------------------------------------------------------
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.통신사 객체에 대한 TABLE DDL을 렌더링할 수 없습니다.
CREATE TABLE 통신사 
(
  통신사번호 VARCHAR2(5 BYTE) NOT NULL 
, 통신사이름 VARCHAR2(5 BYTE) 
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
NOPARALLELCREATE UNIQUE INDEX 통신사_PK ON 통신사 (통신사번호 ASC) 
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
NOPARALLELALTER TABLE 통신사
ADD CONSTRAINT 통신사_PK PRIMARY KEY 
(
  통신사번호 
)
USING INDEX 통신사_PK
ENABLE
REM INSERTING into SCAL."통신사"
SET DEFINE OFF;
Insert into SCAL."통신사" ("통신사번호","통신사이름") values ('0001','SKT');
Insert into SCAL."통신사" ("통신사번호","통신사이름") values ('0002','KT');
Insert into SCAL."통신사" ("통신사번호","통신사이름") values ('0003','LGU+');
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.통신사_PK 객체에 대한 INDEX DDL을 렌더링할 수 없습니다.
CREATE UNIQUE INDEX 통신사_PK ON 통신사 (통신사번호 ASC) 
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
