--------------------------------------------------------
--  ������ ������ - �����-12��-19-2019   
--------------------------------------------------------
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.�˻���� ��ü�� ���� TABLE DDL�� �������� �� �����ϴ�.
CREATE TABLE �˻���� 
(
  �˻��ܾ� VARCHAR2(40 BYTE) NOT NULL 
, �˻�Ƚ�� NUMBER 
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
NOPARALLELCREATE UNIQUE INDEX �˻����_PK ON �˻���� (�˻��ܾ� ASC) 
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
NOPARALLELALTER TABLE �˻����
ADD CONSTRAINT �˻����_PK PRIMARY KEY 
(
  �˻��ܾ� 
)
USING INDEX �˻����_PK
ENABLE
REM INSERTING into SCAL."�˻����"
SET DEFINE OFF;
Insert into SCAL."�˻����" ("�˻��ܾ�","�˻�Ƚ��") values ('������',3);
Insert into SCAL."�˻����" ("�˻��ܾ�","�˻�Ƚ��") values ('roffjrtl',1);
Insert into SCAL."�˻����" ("�˻��ܾ�","�˻�Ƚ��") values ('IPhone',5);
Insert into SCAL."�˻����" ("�˻��ܾ�","�˻�Ƚ��") values ('lg',5);
Insert into SCAL."�˻����" ("�˻��ܾ�","�˻�Ƚ��") values ('LG',2);
Insert into SCAL."�˻����" ("�˻��ܾ�","�˻�Ƚ��") values ('�÷���',3);
Insert into SCAL."�˻����" ("�˻��ܾ�","�˻�Ƚ��") values ('+',8);
Insert into SCAL."�˻����" ("�˻��ܾ�","�˻�Ƚ��") values ('Plus',3);
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.�˻����_PK ��ü�� ���� INDEX DDL�� �������� �� �����ϴ�.
CREATE UNIQUE INDEX �˻����_PK ON �˻���� (�˻��ܾ� ASC) 
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
