--------------------------------------------------------
--  파일이 생성됨 - 목요일-12월-19-2019   
--------------------------------------------------------
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.즐겨찾기 객체에 대한 TABLE DDL을 렌더링할 수 없습니다.
CREATE TABLE 즐겨찾기 
(
  회원번호 VARCHAR2(5 BYTE) NOT NULL 
, 기종번호 VARCHAR2(5 BYTE) NOT NULL 
, 용량 NUMBER NOT NULL 
, 등록일자 DATE 
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
NOPARALLELCREATE UNIQUE INDEX 즐겨찾기_PK ON 즐겨찾기 (회원번호 ASC, 기종번호 ASC, 용량 ASC) 
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
NOPARALLELALTER TABLE 즐겨찾기
ADD CONSTRAINT 즐겨찾기_PK PRIMARY KEY 
(
  회원번호 
, 기종번호 
, 용량 
)
USING INDEX 즐겨찾기_PK
ENABLE
REM INSERTING into SCAL."즐겨찾기"
SET DEFINE OFF;
Insert into SCAL."즐겨찾기" ("회원번호","기종번호","용량","등록일자") values ('0001','0016',512,to_date('19/12/18','RR/MM/DD'));
Insert into SCAL."즐겨찾기" ("회원번호","기종번호","용량","등록일자") values ('0001','0020',32,to_date('19/12/19','RR/MM/DD'));
Insert into SCAL."즐겨찾기" ("회원번호","기종번호","용량","등록일자") values ('0001','0016',128,to_date('19/12/18','RR/MM/DD'));
Insert into SCAL."즐겨찾기" ("회원번호","기종번호","용량","등록일자") values ('0001','0017',512,to_date('19/12/18','RR/MM/DD'));
Insert into SCAL."즐겨찾기" ("회원번호","기종번호","용량","등록일자") values ('0001','0004',128,to_date('19/12/18','RR/MM/DD'));
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.즐겨찾기_PK 객체에 대한 INDEX DDL을 렌더링할 수 없습니다.
CREATE UNIQUE INDEX 즐겨찾기_PK ON 즐겨찾기 (회원번호 ASC, 기종번호 ASC, 용량 ASC) 
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
