--------------------------------------------------------
--  ������ ������ - �����-12��-19-2019   
--------------------------------------------------------
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.ȸ������ ��ü�� ���� TABLE DDL�� �������� �� �����ϴ�.
CREATE TABLE ȸ������ 
(
  ȸ��������ȣ VARCHAR2(5 BYTE) NOT NULL 
, ȸ�������̸� VARCHAR2(20 BYTE) 
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
NOPARALLELCREATE UNIQUE INDEX ȸ������_PK ON ȸ������ (ȸ��������ȣ ASC) 
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
NOPARALLELALTER TABLE ȸ������
ADD CONSTRAINT ȸ������_PK PRIMARY KEY 
(
  ȸ��������ȣ 
)
USING INDEX ȸ������_PK
ENABLE
REM INSERTING into SCAL."ȸ������"
SET DEFINE OFF;
Insert into SCAL."ȸ������" ("ȸ��������ȣ","ȸ�������̸�") values ('0001','�Ϲ�');
Insert into SCAL."ȸ������" ("ȸ��������ȣ","ȸ�������̸�") values ('0002','������');
Insert into SCAL."ȸ������" ("ȸ��������ȣ","ȸ�������̸�") values ('0003','������');
Insert into SCAL."ȸ������" ("ȸ��������ȣ","ȸ�������̸�") values ('0004','��Ż�');
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.ȸ������_PK ��ü�� ���� INDEX DDL�� �������� �� �����ϴ�.
CREATE UNIQUE INDEX ȸ������_PK ON ȸ������ (ȸ��������ȣ ASC) 
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
