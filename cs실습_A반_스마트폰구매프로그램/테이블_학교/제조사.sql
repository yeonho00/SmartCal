--------------------------------------------------------
--  ������ ������ - �����-12��-19-2019   
--------------------------------------------------------
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.������ ��ü�� ���� TABLE DDL�� �������� �� �����ϴ�.
CREATE TABLE ������ 
(
  �������ȣ VARCHAR2(5 BYTE) NOT NULL 
, �������̸� VARCHAR2(20 BYTE) 
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
NOPARALLELCREATE UNIQUE INDEX ������_PK1 ON ������ (�������ȣ ASC) 
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
NOPARALLELALTER TABLE ������
ADD CONSTRAINT ������_PK PRIMARY KEY 
(
  �������ȣ 
)
USING INDEX ������_PK1
ENABLE
REM INSERTING into SCAL."������"
SET DEFINE OFF;
Insert into SCAL."������" ("�������ȣ","�������̸�") values ('0001','SAMSUNG');
Insert into SCAL."������" ("�������ȣ","�������̸�") values ('0002','Apple');
Insert into SCAL."������" ("�������ȣ","�������̸�") values ('0003','LG');
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.������_PK1 ��ü�� ���� INDEX DDL�� �������� �� �����ϴ�.
CREATE UNIQUE INDEX ������_PK1 ON ������ (�������ȣ ASC) 
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
