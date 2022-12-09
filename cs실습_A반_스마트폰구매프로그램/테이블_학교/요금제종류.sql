--------------------------------------------------------
--  ������ ������ - �����-12��-19-2019   
--------------------------------------------------------
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.��������� ��ü�� ���� TABLE DDL�� �������� �� �����ϴ�.
CREATE TABLE ��������� 
(
  �����������ȣ VARCHAR2(5 BYTE) NOT NULL 
, ��Ż��ȣ VARCHAR2(5 BYTE) NOT NULL 
, ����������̸� VARCHAR2(20 BYTE) 
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
NOPARALLELCREATE UNIQUE INDEX ���������_PK ON ��������� (�����������ȣ ASC, ��Ż��ȣ ASC) 
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
NOPARALLELALTER TABLE ���������
ADD CONSTRAINT FK_���������_��Ż� FOREIGN KEY
(
  ��Ż��ȣ 
)
REFERENCES ��Ż�
(
  ��Ż��ȣ 
)
ENABLE
REM INSERTING into SCAL."���������"
SET DEFINE OFF;
Insert into SCAL."���������" ("�����������ȣ","��Ż��ȣ","����������̸�") values ('1001','0001','5GX�÷�');
Insert into SCAL."���������" ("�����������ȣ","��Ż��ȣ","����������̸�") values ('1002','0001','T�÷�');
Insert into SCAL."���������" ("�����������ȣ","��Ż��ȣ","����������̸�") values ('1003','0001','0�÷�');
Insert into SCAL."���������" ("�����������ȣ","��Ż��ȣ","����������̸�") values ('1004','0001','�ָ��� ��');
Insert into SCAL."���������" ("�����������ȣ","��Ż��ȣ","����������̸�") values ('1005','0001','0�÷� �����');
Insert into SCAL."���������" ("�����������ȣ","��Ż��ȣ","����������̸�") values ('2001','0002','KT 5G �����÷�');
Insert into SCAL."���������" ("�����������ȣ","��Ż��ȣ","����������̸�") values ('2002','0002','������ ON');
Insert into SCAL."���������" ("�����������ȣ","��Ż��ȣ","����������̸�") values ('2003','0002','Y24 ON');
Insert into SCAL."���������" ("�����������ȣ","��Ż��ȣ","����������̸�") values ('2004','0002','LTE������');
Insert into SCAL."���������" ("�����������ȣ","��Ż��ȣ","����������̸�") values ('2005','0002','Y����');
Insert into SCAL."���������" ("�����������ȣ","��Ż��ȣ","����������̸�") values ('3001','0003','5G�����');
Insert into SCAL."���������" ("�����������ȣ","��Ż��ȣ","����������̸�") values ('3002','0003','����Ͽ����');
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.���������_PK ��ü�� ���� INDEX DDL�� �������� �� �����ϴ�.
CREATE UNIQUE INDEX ���������_PK ON ��������� (�����������ȣ ASC, ��Ż��ȣ ASC) 
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
