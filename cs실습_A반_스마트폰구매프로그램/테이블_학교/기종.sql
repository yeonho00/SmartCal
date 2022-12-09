--------------------------------------------------------
--  ������ ������ - �����-12��-19-2019   
--------------------------------------------------------
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.���� ��ü�� ���� TABLE DDL�� �������� �� �����ϴ�.
CREATE TABLE ���� 
(
  ������ȣ VARCHAR2(5 BYTE) NOT NULL 
, �����̸� VARCHAR2(20 BYTE) 
, �������ȣ VARCHAR2(5 BYTE) 
, ���͸��뷮 NUMBER 
, �������� VARCHAR2(40 BYTE) 
, ���÷������� VARCHAR2(4 BYTE) 
, �ػ� VARCHAR2(10 BYTE) 
, ũ�� NUMBER 
, ���� NUMBER 
, �β� NUMBER 
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
NOPARALLELCREATE UNIQUE INDEX ����_PK ON ���� (������ȣ ASC) 
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
NOPARALLELCOMMENT ON COLUMN ����.���÷������� IS 'LCD �Ǵ� LED';
COMMENT ON COLUMN ����.�ػ� IS '����: �ȼ�';
COMMENT ON COLUMN ����.ũ�� IS '����: ��ġ';
COMMENT ON COLUMN ����.���� IS '����: g';
COMMENT ON COLUMN ����.�β� IS '����: mm';ALTER TABLE ����
ADD CONSTRAINT FK_����_������ FOREIGN KEY
(
  �������ȣ 
)
REFERENCES ������
(
  �������ȣ 
)
ENABLEALTER TABLE ����
ADD CONSTRAINT ����_PK PRIMARY KEY 
(
  ������ȣ 
)
USING INDEX ����_PK
ENABLE
REM INSERTING into SCAL."����"
SET DEFINE OFF;
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0001','GalaxyNote10','0001',3500,'1)GalaxyNote10.png','LED','2280x1080',6.3,168,7.9,'���ó뽺9825',12);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0002','GalaxyNote10+','0001',4300,'2)GalaxyNote10+.png','LED','3040x1440',6.8,196,7.9,'���ó뽺9825',12);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0003','GalaxyS10','0001',4500,'4)GalaxyS10.png','LED','33040x1440',6.1,198,7.9,'�����巡��855',8);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0004','LGV50','0003',4000,'5)LGV50.png','LED','3120x1440',6.3,183,8.3,'�����巡��855',6);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0005','LGV50s','0003',4000,'6)LGV50s.png','LED','2340x1080',6.3,192,8.4,'�����巡��855',8);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0006','GalaxyA90','0001',4500,'7)GalaxyA90.png','LED','1080x2400',4.3,206,8.4,'�����巡��855',6);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0007','IPhone11','0002',3110,'8)IPhone11.png','LCD','1792x828',6.1,194,8.3,'A13Bionic',4);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0008','IPhone11Pro','0002',3046,'10)IPhone11Pro.png','LED','1792x828',5.8,188,8.1,'A13Bionic',4);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0009','IPhone11ProMax','0002',3969,'12)IPhone11ProMax.png','LED','1792x828',6.5,226,8.1,'A13Bionic',4);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0010','GalaxyS9','0001',3000,'13)GalaxyS9.png','LED','2960x1440',5.8,163,8.5,'���ó뽺9820',4);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0011','LGV40','0003',3300,'14)LGV40.png','LED','3120x1440',6.4,169,7.7,'�����巡��845',6);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0012','IPhoneX','0002',2716,'15)IPhoneX.png','LCD','2436x1125',5.8,174,7.7,'A11Bionic',3);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0013','IPhoneXs','0002',2658,'16)IPhoneXS.png','LED','2436x1125',5.8,177,7.7,'A12Bionic',4);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0014','IPhoneXr','0002',2942,'17)IPhoneXr.png','LCD','1792x828',6.1,194,7.8,'A12Bionic',3);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0015','GalaxyS10E','0001',3100,'19)GalaxyS10e.png','LED','2280x1080',5.8,150,7.9,'���ó뽺9820',6);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0016','GalaxyS10+','0001',4100,'22)GalaxyS10+.png','LED','3040x1770',6.1,175,7.8,'���ó뽺9820',8);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0017','GalaxyNote9','0001',4000,'24)GalaxyNote9.png','LED','2960x1440',6.3,201,8.8,'���ó뽺9810',8);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0018','IPhone7','0002',1960,'26)IPhone7.png','LCD','1334x750',4.7,138,7.1,'A10Fusion',6);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0019','LGG8','0003',3500,'27)LGG8.png','LED','3120x1440',6.1,167,8.4,'�����巡��855',8);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0020','GalaxyA3','0001',1900,'28)GalaxyA3.png','LED','960x540',4.5,110,6.9,'�����巡��410',1);
Insert into SCAL."����" ("������ȣ","�����̸�","�������ȣ","���͸��뷮","��������","���÷�������","�ػ�","ũ��","����","�β�",CPU,RAM) values ('0021','GalaxyA9Pro','0001',3400,'29)GalaxyA9Pro.png','LED','2340x1080',6.4,173,7.4,'�����巡��710',6);
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.����_PK ��ü�� ���� INDEX DDL�� �������� �� �����ϴ�.
CREATE UNIQUE INDEX ����_PK ON ���� (������ȣ ASC) 
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
