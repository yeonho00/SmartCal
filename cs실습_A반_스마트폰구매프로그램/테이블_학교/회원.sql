--------------------------------------------------------
--  파일이 생성됨 - 목요일-12월-19-2019   
--------------------------------------------------------
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.회원 객체에 대한 TABLE DDL을 렌더링할 수 없습니다.
CREATE TABLE 회원 
(
  회원번호 VARCHAR2(5 BYTE) NOT NULL 
, 회원종류번호 VARCHAR2(5 BYTE) 
, 회원이름 VARCHAR2(20 BYTE) 
, 회원아이디 VARCHAR2(20 BYTE) 
, 회원비밀번호 VARCHAR2(20 BYTE) 
, 이전접속일 VARCHAR2(20 BYTE) 
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
NOPARALLELCREATE UNIQUE INDEX 회원_PK ON 회원 (회원번호 ASC) 
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
NOPARALLELCOMMENT ON COLUMN 회원.회원종류번호 IS '일반, 관리자, 제조사, 통신사';ALTER TABLE 회원
ADD CONSTRAINT FK_회원_회원종류 FOREIGN KEY
(
  회원종류번호 
)
REFERENCES 회원종류
(
  회원종류번호 
)
ENABLEALTER TABLE 회원
ADD CONSTRAINT 회원_PK PRIMARY KEY 
(
  회원번호 
)
USING INDEX 회원_PK
ENABLE
REM INSERTING into SCAL."회원"
SET DEFINE OFF;
Insert into SCAL."회원" ("회원번호","회원종류번호","회원이름","회원아이디","회원비밀번호","이전접속일") values ('0001','0001','일일동','1','1',null);
Insert into SCAL."회원" ("회원번호","회원종류번호","회원이름","회원아이디","회원비밀번호","이전접속일") values ('0002','0001','일이동','ntester2','1',null);
Insert into SCAL."회원" ("회원번호","회원종류번호","회원이름","회원아이디","회원비밀번호","이전접속일") values ('0003','0001','일삼동','ntester3','1',null);
Insert into SCAL."회원" ("회원번호","회원종류번호","회원이름","회원아이디","회원비밀번호","이전접속일") values ('0004','0002','관일동','master1','1',null);
Insert into SCAL."회원" ("회원번호","회원종류번호","회원이름","회원아이디","회원비밀번호","이전접속일") values ('0005','0003','삼일동','stester1','1',null);
Insert into SCAL."회원" ("회원번호","회원종류번호","회원이름","회원아이디","회원비밀번호","이전접속일") values ('0006','0003','애일동','atester1','1',null);
Insert into SCAL."회원" ("회원번호","회원종류번호","회원이름","회원아이디","회원비밀번호","이전접속일") values ('0007','0003','엘일동','ltester1','1',null);
Insert into SCAL."회원" ("회원번호","회원종류번호","회원이름","회원아이디","회원비밀번호","이전접속일") values ('0008','0004','에일동','skt1','1',null);
Insert into SCAL."회원" ("회원번호","회원종류번호","회원이름","회원아이디","회원비밀번호","이전접속일") values ('0009','0004','케일동','kt1','1',null);
Insert into SCAL."회원" ("회원번호","회원종류번호","회원이름","회원아이디","회원비밀번호","이전접속일") values ('0010','0004','유일동','u1','1',null);
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.회원_PK 객체에 대한 INDEX DDL을 렌더링할 수 없습니다.
CREATE UNIQUE INDEX 회원_PK ON 회원 (회원번호 ASC) 
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
