--------------------------------------------------------
--  ������ ������ - �����-12��-19-2019   
--------------------------------------------------------
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.ȸ�� ��ü�� ���� TABLE DDL�� �������� �� �����ϴ�.
CREATE TABLE ȸ�� 
(
  ȸ����ȣ VARCHAR2(5 BYTE) NOT NULL 
, ȸ��������ȣ VARCHAR2(5 BYTE) 
, ȸ���̸� VARCHAR2(20 BYTE) 
, ȸ�����̵� VARCHAR2(20 BYTE) 
, ȸ����й�ȣ VARCHAR2(20 BYTE) 
, ���������� VARCHAR2(20 BYTE) 
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
NOPARALLELCREATE UNIQUE INDEX ȸ��_PK ON ȸ�� (ȸ����ȣ ASC) 
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
NOPARALLELCOMMENT ON COLUMN ȸ��.ȸ��������ȣ IS '�Ϲ�, ������, ������, ��Ż�';ALTER TABLE ȸ��
ADD CONSTRAINT FK_ȸ��_ȸ������ FOREIGN KEY
(
  ȸ��������ȣ 
)
REFERENCES ȸ������
(
  ȸ��������ȣ 
)
ENABLEALTER TABLE ȸ��
ADD CONSTRAINT ȸ��_PK PRIMARY KEY 
(
  ȸ����ȣ 
)
USING INDEX ȸ��_PK
ENABLE
REM INSERTING into SCAL."ȸ��"
SET DEFINE OFF;
Insert into SCAL."ȸ��" ("ȸ����ȣ","ȸ��������ȣ","ȸ���̸�","ȸ�����̵�","ȸ����й�ȣ","����������") values ('0001','0001','���ϵ�','1','1',null);
Insert into SCAL."ȸ��" ("ȸ����ȣ","ȸ��������ȣ","ȸ���̸�","ȸ�����̵�","ȸ����й�ȣ","����������") values ('0002','0001','���̵�','ntester2','1',null);
Insert into SCAL."ȸ��" ("ȸ����ȣ","ȸ��������ȣ","ȸ���̸�","ȸ�����̵�","ȸ����й�ȣ","����������") values ('0003','0001','�ϻﵿ','ntester3','1',null);
Insert into SCAL."ȸ��" ("ȸ����ȣ","ȸ��������ȣ","ȸ���̸�","ȸ�����̵�","ȸ����й�ȣ","����������") values ('0004','0002','���ϵ�','master1','1',null);
Insert into SCAL."ȸ��" ("ȸ����ȣ","ȸ��������ȣ","ȸ���̸�","ȸ�����̵�","ȸ����й�ȣ","����������") values ('0005','0003','���ϵ�','stester1','1',null);
Insert into SCAL."ȸ��" ("ȸ����ȣ","ȸ��������ȣ","ȸ���̸�","ȸ�����̵�","ȸ����й�ȣ","����������") values ('0006','0003','���ϵ�','atester1','1',null);
Insert into SCAL."ȸ��" ("ȸ����ȣ","ȸ��������ȣ","ȸ���̸�","ȸ�����̵�","ȸ����й�ȣ","����������") values ('0007','0003','���ϵ�','ltester1','1',null);
Insert into SCAL."ȸ��" ("ȸ����ȣ","ȸ��������ȣ","ȸ���̸�","ȸ�����̵�","ȸ����й�ȣ","����������") values ('0008','0004','���ϵ�','skt1','1',null);
Insert into SCAL."ȸ��" ("ȸ����ȣ","ȸ��������ȣ","ȸ���̸�","ȸ�����̵�","ȸ����й�ȣ","����������") values ('0009','0004','���ϵ�','kt1','1',null);
Insert into SCAL."ȸ��" ("ȸ����ȣ","ȸ��������ȣ","ȸ���̸�","ȸ�����̵�","ȸ����й�ȣ","����������") values ('0010','0004','���ϵ�','u1','1',null);
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.ȸ��_PK ��ü�� ���� INDEX DDL�� �������� �� �����ϴ�.
CREATE UNIQUE INDEX ȸ��_PK ON ȸ�� (ȸ����ȣ ASC) 
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
