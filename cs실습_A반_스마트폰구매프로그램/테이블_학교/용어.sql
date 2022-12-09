--------------------------------------------------------
--  파일이 생성됨 - 목요일-12월-19-2019   
--------------------------------------------------------
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.용어 객체에 대한 TABLE DDL을 렌더링할 수 없습니다.
CREATE TABLE 용어 
(
  용어번호 VARCHAR2(5 BYTE) NOT NULL 
, 용어이름 VARCHAR2(20 BYTE) 
, 부가설명 VARCHAR2(300 BYTE) 
, 조회수 NUMBER 
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
NOPARALLELCREATE UNIQUE INDEX 용어_PK ON 용어 (용어번호 ASC) 
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
NOPARALLELALTER TABLE 용어
ADD CONSTRAINT 용어_PK PRIMARY KEY 
(
  용어번호 
)
USING INDEX 용어_PK
ENABLE
REM INSERTING into SCAL."용어"
SET DEFINE OFF;
Insert into SCAL."용어" ("용어번호","용어이름","부가설명","조회수") values ('001','RAM','기억된 정보를 읽어내기도 하고 다른 정보를 기억시킬 수도 있는 메모리로써 컴퓨터의 주기억장치, 응용 프로그램의 일시적 로딩(loading), 데이터의 일시적 저장 등에 사용',0);
Insert into SCAL."용어" ("용어번호","용어이름","부가설명","조회수") values ('002','CPU','‘Central Processing Unit’의 약자로써 직역 하면 중앙처리장치이다 단어그대로 컴퓨터의 정중앙에서 모든 데이터를 처리하는 장치',0);
Insert into SCAL."용어" ("용어번호","용어이름","부가설명","조회수") values ('003','내장메모리(ROM)','별도의 외장 메모리카드 없이 기본적으로 사용할 수 있는 저장공간',0);
Insert into SCAL."용어" ("용어번호","용어이름","부가설명","조회수") values ('004','LED','발광 다이오드. Ga(갈륨), P(인), As(비소)를 재료로 하여 만들어진 반도체 전구에 비해 수명이 길고 응답 속도가 빠르고 다양한 모양으로 만들 수 있다는 데 이점',0);
Insert into SCAL."용어" ("용어번호","용어이름","부가설명","조회수") values ('005','LCD','액정표시장치 인가전압에 따른 액정 투과도의 변화를 이용하여 각종 장치에서 발생하는 여러 가지 전기적인 정보를 시각정보로 변화시켜 전달하는 전기소자이다. 자기발광성이 없어 후광이 필요하지만 소비전력이 적다',0);
Insert into SCAL."용어" ("용어번호","용어이름","부가설명","조회수") values ('006','공시지원금','휴대폰 구입 시 통신사로부터 일정한 지원금을 받고 제품을 구매하는 것으로, 일정기간 약정을 통해 단말기 금액을 할인 받는 제도',0);
Insert into SCAL."용어" ("용어번호","용어이름","부가설명","조회수") values ('007','출고가','물품을 출고할 때의 가격',0);
Insert into SCAL."용어" ("용어번호","용어이름","부가설명","조회수") values ('008','mbps','초당 메가비트(백만비트)를 전송할 수 있는 데이터 전송속도를 나타내는 단위',0);
Insert into SCAL."용어" ("용어번호","용어이름","부가설명","조회수") values ('009','GB','GIABYTE(기가바이트)의 약어로 표시되는 자료의 용량 단위로서 1GB=1000MB(MEGABYTE)이다',0);
Insert into SCAL."용어" ("용어번호","용어이름","부가설명","조회수") values ('010','선택약정할인',' 단말기를 지원하는 방식의 공시지원금과 달리, 요금의 25%를 약속하고 할인해 주는것',0);
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.용어_PK 객체에 대한 INDEX DDL을 렌더링할 수 없습니다.
CREATE UNIQUE INDEX 용어_PK ON 용어 (용어번호 ASC) 
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
