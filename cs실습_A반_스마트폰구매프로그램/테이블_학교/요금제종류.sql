--------------------------------------------------------
--  파일이 생성됨 - 목요일-12월-19-2019   
--------------------------------------------------------
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.요금제종류 객체에 대한 TABLE DDL을 렌더링할 수 없습니다.
CREATE TABLE 요금제종류 
(
  요금제종류번호 VARCHAR2(5 BYTE) NOT NULL 
, 통신사번호 VARCHAR2(5 BYTE) NOT NULL 
, 요금제종류이름 VARCHAR2(20 BYTE) 
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
NOPARALLELCREATE UNIQUE INDEX 요금제종류_PK ON 요금제종류 (요금제종류번호 ASC, 통신사번호 ASC) 
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
NOPARALLELALTER TABLE 요금제종류
ADD CONSTRAINT FK_요금제종류_통신사 FOREIGN KEY
(
  통신사번호 
)
REFERENCES 통신사
(
  통신사번호 
)
ENABLE
REM INSERTING into SCAL."요금제종류"
SET DEFINE OFF;
Insert into SCAL."요금제종류" ("요금제종류번호","통신사번호","요금제종류이름") values ('1001','0001','5GX플랜');
Insert into SCAL."요금제종류" ("요금제종류번호","통신사번호","요금제종류이름") values ('1002','0001','T플랜');
Insert into SCAL."요금제종류" ("요금제종류번호","통신사번호","요금제종류이름") values ('1003','0001','0플랜');
Insert into SCAL."요금제종류" ("요금제종류번호","통신사번호","요금제종류이름") values ('1004','0001','주말엔 팅');
Insert into SCAL."요금제종류" ("요금제종류번호","통신사번호","요금제종류이름") values ('1005','0001','0플랜 히어로');
Insert into SCAL."요금제종류" ("요금제종류번호","통신사번호","요금제종류이름") values ('2001','0002','KT 5G 슈퍼플랜');
Insert into SCAL."요금제종류" ("요금제종류번호","통신사번호","요금제종류이름") values ('2002','0002','데이터 ON');
Insert into SCAL."요금제종류" ("요금제종류번호","통신사번호","요금제종류이름") values ('2003','0002','Y24 ON');
Insert into SCAL."요금제종류" ("요금제종류번호","통신사번호","요금제종류이름") values ('2004','0002','LTE베이직');
Insert into SCAL."요금제종류" ("요금제종류번호","통신사번호","요금제종류이름") values ('2005','0002','Y군인');
Insert into SCAL."요금제종류" ("요금제종류번호","통신사번호","요금제종류이름") values ('3001','0003','5G요금제');
Insert into SCAL."요금제종류" ("요금제종류번호","통신사번호","요금제종류이름") values ('3002','0003','모바일요금제');
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.요금제종류_PK 객체에 대한 INDEX DDL을 렌더링할 수 없습니다.
CREATE UNIQUE INDEX 요금제종류_PK ON 요금제종류 (요금제종류번호 ASC, 통신사번호 ASC) 
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
