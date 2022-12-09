--------------------------------------------------------
--  ������ ������ - �����-12��-19-2019   
--------------------------------------------------------
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.��Ż� ��ü�� ���� TABLE DDL�� �������� �� �����ϴ�.
CREATE TABLE ��Ż� 
(
  ��Ż��ȣ VARCHAR2(5 BYTE) NOT NULL 
, ��Ż��̸� VARCHAR2(5 BYTE) 
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
NOPARALLELCREATE UNIQUE INDEX ��Ż�_PK ON ��Ż� (��Ż��ȣ ASC) 
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
NOPARALLELALTER TABLE ��Ż�
ADD CONSTRAINT ��Ż�_PK PRIMARY KEY 
(
  ��Ż��ȣ 
)
USING INDEX ��Ż�_PK
ENABLE
REM INSERTING into SCAL."��Ż�"
SET DEFINE OFF;
Insert into SCAL."��Ż�" ("��Ż��ȣ","��Ż��̸�") values ('0001','SKT');
Insert into SCAL."��Ż�" ("��Ż��ȣ","��Ż��̸�") values ('0002','KT');
Insert into SCAL."��Ż�" ("��Ż��ȣ","��Ż��̸�") values ('0003','LGU+');
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.��Ż�_PK ��ü�� ���� INDEX DDL�� �������� �� �����ϴ�.
CREATE UNIQUE INDEX ��Ż�_PK ON ��Ż� (��Ż��ȣ ASC) 
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
