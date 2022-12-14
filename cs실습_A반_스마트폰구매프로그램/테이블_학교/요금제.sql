--------------------------------------------------------
--  파일이 생성됨 - 목요일-12월-19-2019   
--------------------------------------------------------
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.요금제 객체에 대한 TABLE DDL을 렌더링할 수 없습니다.
CREATE TABLE 요금제 
(
  요금제번호 VARCHAR2(5 BYTE) NOT NULL 
, 요금제종류번호 VARCHAR2(5 BYTE) 
, 데이터 VARCHAR2(100 BYTE) 
, 음성 VARCHAR2(50 BYTE) 
, 문자 VARCHAR2(50 BYTE) 
, 추가혜택 VARCHAR2(250 BYTE) 
, 요금제이름 VARCHAR2(50 BYTE) 
, 요금제가격 NUMBER(30, 0) 
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
NOPARALLELCREATE UNIQUE INDEX 요금제_PK ON 요금제 (요금제번호 ASC) 
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
NOPARALLELALTER TABLE 요금제
ADD CONSTRAINT 요금제_PK PRIMARY KEY 
(
  요금제번호 
)
USING INDEX 요금제_PK
ENABLE
REM INSERTING into SCAL."요금제"
SET DEFINE OFF;
Insert into SCAL."요금제" ("요금제번호","요금제종류번호","데이터","음성","문자","추가혜택","요금제이름","요금제가격") values ('1111','1001','300GB 속도제한없음 (300GB 이후 10Mbps 속도로 계속 사용)','무제한(영상/부가 300분)','무제한','FLO 앤 데이터 - 음악 전용 데이터 매월 3GB 제공(월7,900) Wavve 앤 데이터 - 동영상 등 전용 데이터 1GB 제공 다시보기 무제한(월9,800) (중 택1 무료 제공)','5GX플래티넘',125000);
Insert into SCAL."요금제" ("요금제번호","요금제종류번호","데이터","음성","문자","추가혜택","요금제이름","요금제가격") values ('1112','1002','4GB (이후 1Mbps속도로 계속 사용)','무제한(영상/부가 300분)','무제한','FLO앤데이터-월7,900음악서비스, wavve앤데이터,미디어데이터 팩-월 9,800 TV채널서비스, LTE안심옵션-월5,500원 속도제한 무제한LTE,분실폰찾기-무료 분실 관리','T플랜 안심4G',50000);
Insert into SCAL."요금제" ("요금제번호","요금제종류번호","데이터","음성","문자","추가혜택","요금제이름","요금제가격") values ('1113','1003','4GB (이후 1Mbps속도로 계속 사용)','무제한(영상/부가 300분)','무제한','FLO앤데이터-월7,900음악서비스, wavve앤데이터,미디어데이터 팩-월 9,800 TV채널서비스, LTE안심옵션-월5,500원 속도제한 무제한LTE,분실폰찾기-무료 분실 관리','0플랜 라지',69000);
Insert into SCAL."요금제" ("요금제번호","요금제종류번호","데이터","음성","문자","추가혜택","요금제이름","요금제가격") values ('1114','1004','기본5GB+주말 일1GB(주말데이터 모두 사용후 400Kbps로 속도제어)','무제한(영상/부가 300분)','무제한','FLO앤데이터-월7,900음악서비스, wavve앤데이터,미디어데이터 팩-월 9,800 TV채널서비스, LTE안심옵션-월5,500원 속도제한 무제한LTE,분실폰찾기-무료 분실 관리','주말엔 팅 5.0G',47000);
Insert into SCAL."요금제" ("요금제번호","요금제종류번호","데이터","음성","문자","추가혜택","요금제이름","요금제가격") values ('1115','1005','100GB (이후 5Mbps속도로 계속 사용)','무제한(영상/부가 300분)','무제한','FLO앤데이터-월7,900음악서비스, wavve앤데이터,미디어데이터 팩-월 9,800 TV채널서비스, LTE안심옵션-월5,500원 속도제한 무제한LTE,분실폰찾기-무료 분실 관리','0플랜 슈퍼히어로',55000);
Insert into SCAL."요금제" ("요금제번호","요금제종류번호","데이터","음성","문자","추가혜택","요금제이름","요금제가격") values ('2111','2001','무제한(로밍 데이터 최대1Mbps 무제한)','무제한(영상/부가 300분)','무제한','5G 데이터충전 - 100MB에 1,000원에 데이터를 제공 리얼 지니팩 - 월16,500원 (맴버십등록 +1개월 0원)에 genie 음악 스트리밍 서비스,전용 데이터를 제공','KT 5G 슈퍼플랜 베이직',80000);
Insert into SCAL."요금제" ("요금제번호","요금제종류번호","데이터","음성","문자","추가혜택","요금제이름","요금제가격") values ('2112','2002','무제한','무제한(영상/부가 300분)','무제한','미디어팩 무료 또는 리얼미디어팩 50% 할인 프라임키즈팩 50%할인(''18.10.16~''19.12.31)','데이터 ON 프리미엄',89000);
Insert into SCAL."요금제" ("요금제번호","요금제종류번호","데이터","음성","문자","추가혜택","요금제이름","요금제가격") values ('2113','2003','6GB+무제한(최대1Mbps 속도제어)','무제한(영상/부가 300분)','무제한','시즌 플레인(일2GB)미디어팩/프라임무비팩50% 할인','Y24 ON 톡',49000);
Insert into SCAL."요금제" ("요금제번호","요금제종류번호","데이터","음성","문자","추가혜택","요금제이름","요금제가격") values ('2114','2004','1.4GB(기본 제공량 소진후 5GB까지 최대200Kbps사용가능)','무제한(영상/부가 50분)','무제한','LTE데이터충전 - 100MB에 1,980원에 데이터를 제공 내위치전송 서비스 - 문자메세지에 위치를 지도를 첨부해주는 서비스(건당275원)','LTE베이직',33000);
Insert into SCAL."요금제" ("요금제번호","요금제종류번호","데이터","음성","문자","추가혜택","요금제이름","요금제가격") values ('2115','2005','100GB+무제한(최대 5Mbps 속도제어)','무제한(영상/부가 300분)','무제한','미디어팩/프라임무비팩 50% 할인 시즌 플레인 무료 미디어팩 3개월 무료','Y군인 55',55000);
Insert into SCAL."요금제" ("요금제번호","요금제종류번호","데이터","음성","문자","추가혜택","요금제이름","요금제가격") values ('3111','3001','무제한','무제한(영상/부가 300분)','무제한','태블릿/스마트기기 월정액 무료 - 태블릿, 스마트워치 등 2개의 스마트기기 월정액을 무료이용 해외로밍 요금제 - 1일 13,200원에 해외 로밍 데이터, 음성 전화 무제한 제공','5G슈퍼 플래티넘',115000);
Insert into SCAL."요금제" ("요금제번호","요금제종류번호","데이터","음성","문자","추가혜택","요금제이름","요금제가격") values ('3112','3001','9GB(소진시 1Mpbs 사용가능)','무제한(영상/부가 300분)','무제한','프리미엄 콘텐츠 무료 - U+모바일tv를 무료로 이용 가능','5G 라이트',55000);
Insert into SCAL."요금제" ("요금제번호","요금제종류번호","데이터","음성","문자","추가혜택","요금제이름","요금제가격") values ('3113','3002','무제한','무제한(영상/부가 300분)','무제한','나눠쓰기 데이터 100GB U+해외로밍 제로 프리미엄 50%할인 휴대폰,태블릿/스마트기기 분실/파손 보험 할인','속도 용량 걱정 없는 데이터 105',105000);
Insert into SCAL."요금제" ("요금제번호","요금제종류번호","데이터","음성","문자","추가혜택","요금제이름","요금제가격") values ('3114','3002','2.1GB','무제한(영상/부가 205분)','무제한','매너콜  - 통화 중이거나 휴대폰이 꺼져 있을 때 수신 정보를 메시지로 받는 서비스','Single LTE 망내 52',57200);
Insert into SCAL."요금제" ("요금제번호","요금제종류번호","데이터","음성","문자","추가혜택","요금제이름","요금제가격") values ('3115','3002','0.28원/KB(제한없음)','1.98원/초(제한없음)','50건(이상 추가)','기타 서비스 및  약정할인,요금할인 불가','LTE표준',11990);
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.요금제_PK 객체에 대한 INDEX DDL을 렌더링할 수 없습니다.
CREATE UNIQUE INDEX 요금제_PK ON 요금제 (요금제번호 ASC) 
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
