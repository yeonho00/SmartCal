--------------------------------------------------------
--  파일이 생성됨 - 목요일-12월-19-2019   
--------------------------------------------------------
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.기종 객체에 대한 TABLE DDL을 렌더링할 수 없습니다.
CREATE TABLE 기종 
(
  기종번호 VARCHAR2(5 BYTE) NOT NULL 
, 기종이름 VARCHAR2(20 BYTE) 
, 제조사번호 VARCHAR2(5 BYTE) 
, 배터리용량 NUMBER 
, 기종사진 VARCHAR2(40 BYTE) 
, 디스플레이종류 VARCHAR2(4 BYTE) 
, 해상도 VARCHAR2(10 BYTE) 
, 크기 NUMBER 
, 무게 NUMBER 
, 두께 NUMBER 
, CPU VARCHAR2(20 BYTE) 
, RAM NUMBER 
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
NOPARALLELCREATE UNIQUE INDEX 기종_PK ON 기종 (기종번호 ASC) 
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
NOPARALLELCOMMENT ON COLUMN 기종.디스플레이종류 IS 'LCD 또는 LED';
COMMENT ON COLUMN 기종.해상도 IS '단위: 픽셀';
COMMENT ON COLUMN 기종.크기 IS '단위: 인치';
COMMENT ON COLUMN 기종.무게 IS '단위: g';
COMMENT ON COLUMN 기종.두께 IS '단위: mm';ALTER TABLE 기종
ADD CONSTRAINT FK_기종_제조사 FOREIGN KEY
(
  제조사번호 
)
REFERENCES 제조사
(
  제조사번호 
)
ENABLEALTER TABLE 기종
ADD CONSTRAINT 기종_PK PRIMARY KEY 
(
  기종번호 
)
USING INDEX 기종_PK
ENABLE
REM INSERTING into SCAL."기종"
SET DEFINE OFF;
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0001','GalaxyNote10','0001',3500,'1)GalaxyNote10.png','LED','2280x1080',6.3,168,7.9,'엑시노스9825',12);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0002','GalaxyNote10+','0001',4300,'2)GalaxyNote10+.png','LED','3040x1440',6.8,196,7.9,'엑시노스9825',12);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0003','GalaxyS10','0001',4500,'4)GalaxyS10.png','LED','33040x1440',6.1,198,7.9,'스냅드래곤855',8);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0004','LGV50','0003',4000,'5)LGV50.png','LED','3120x1440',6.3,183,8.3,'스냅드래곤855',6);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0005','LGV50s','0003',4000,'6)LGV50s.png','LED','2340x1080',6.3,192,8.4,'스냅드래곤855',8);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0006','GalaxyA90','0001',4500,'7)GalaxyA90.png','LED','1080x2400',4.3,206,8.4,'스냅드래곤855',6);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0007','IPhone11','0002',3110,'8)IPhone11.png','LCD','1792x828',6.1,194,8.3,'A13Bionic',4);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0008','IPhone11Pro','0002',3046,'10)IPhone11Pro.png','LED','1792x828',5.8,188,8.1,'A13Bionic',4);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0009','IPhone11ProMax','0002',3969,'12)IPhone11ProMax.png','LED','1792x828',6.5,226,8.1,'A13Bionic',4);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0010','GalaxyS9','0001',3000,'13)GalaxyS9.png','LED','2960x1440',5.8,163,8.5,'엑시노스9820',4);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0011','LGV40','0003',3300,'14)LGV40.png','LED','3120x1440',6.4,169,7.7,'스냅드래곤845',6);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0012','IPhoneX','0002',2716,'15)IPhoneX.png','LCD','2436x1125',5.8,174,7.7,'A11Bionic',3);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0013','IPhoneXs','0002',2658,'16)IPhoneXS.png','LED','2436x1125',5.8,177,7.7,'A12Bionic',4);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0014','IPhoneXr','0002',2942,'17)IPhoneXr.png','LCD','1792x828',6.1,194,7.8,'A12Bionic',3);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0015','GalaxyS10E','0001',3100,'19)GalaxyS10e.png','LED','2280x1080',5.8,150,7.9,'엑시노스9820',6);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0016','GalaxyS10+','0001',4100,'22)GalaxyS10+.png','LED','3040x1770',6.1,175,7.8,'엑시노스9820',8);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0017','GalaxyNote9','0001',4000,'24)GalaxyNote9.png','LED','2960x1440',6.3,201,8.8,'엑시노스9810',8);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0018','IPhone7','0002',1960,'26)IPhone7.png','LCD','1334x750',4.7,138,7.1,'A10Fusion',6);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0019','LGG8','0003',3500,'27)LGG8.png','LED','3120x1440',6.1,167,8.4,'스냅드래곤855',8);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0020','GalaxyA3','0001',1900,'28)GalaxyA3.png','LED','960x540',4.5,110,6.9,'스냅드래곤410',1);
Insert into SCAL."기종" ("기종번호","기종이름","제조사번호","배터리용량","기종사진","디스플레이종류","해상도","크기","무게","두께",CPU,RAM) values ('0021','GalaxyA9Pro','0001',3400,'29)GalaxyA9Pro.png','LED','2340x1080',6.4,173,7.4,'스냅드래곤710',6);
-- 내부 생성기를 시도하는 DBMS_METADATA로 SCAL.기종_PK 객체에 대한 INDEX DDL을 렌더링할 수 없습니다.
CREATE UNIQUE INDEX 기종_PK ON 기종 (기종번호 ASC) 
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
