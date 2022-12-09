--------------------------------------------------------
--  ������ ������ - �����-12��-19-2019   
--------------------------------------------------------
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.�˻�������ȭ ��ü�� ���� TABLE DDL�� �������� �� �����ϴ�.
CREATE TABLE �˻�������ȭ 
(
  �������˻��� VARCHAR2(40 BYTE) NOT NULL 
, �����İ˻��� VARCHAR2(40 BYTE) 
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
NOPARALLELCREATE UNIQUE INDEX �˻�������ȭ_PK ON �˻�������ȭ (�������˻��� ASC) 
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
NOPARALLELALTER TABLE �˻�������ȭ
ADD CONSTRAINT �˻�������ȭ_PK PRIMARY KEY 
(
  �������˻��� 
)
USING INDEX �˻�������ȭ_PK
ENABLE
REM INSERTING into SCAL."�˻�������ȭ"
SET DEFINE OFF;
Insert into SCAL."�˻�������ȭ" ("�������˻���","�����İ˻���") values ('aaa','e1');
Insert into SCAL."�˻�������ȭ" ("�������˻���","�����İ˻���") values ('roffjrtl','Galaxy');
Insert into SCAL."�˻�������ȭ" ("�������˻���","�����İ˻���") values ('�ַ���','Galaxy');
Insert into SCAL."�˻�������ȭ" ("�������˻���","�����İ˻���") values ('������','IPhone');
Insert into SCAL."�˻�������ȭ" ("�������˻���","�����İ˻���") values ('�÷���','+');
Insert into SCAL."�˻�������ȭ" ("�������˻���","�����İ˻���") values ('Plus','+');
Insert into SCAL."�˻�������ȭ" ("�������˻���","�����İ˻���") values ('galaxy','Galaxy');
Insert into SCAL."�˻�������ȭ" ("�������˻���","�����İ˻���") values ('dkdlvhs','IPhone');
Insert into SCAL."�˻�������ȭ" ("�������˻���","�����İ˻���") values ('iphone','IPhone');
Insert into SCAL."�˻�������ȭ" ("�������˻���","�����İ˻���") values ('�Ӥ�','LG');
Insert into SCAL."�˻�������ȭ" ("�������˻���","�����İ˻���") values ('lg','LG');
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.�˻�������ȭ_PK ��ü�� ���� INDEX DDL�� �������� �� �����ϴ�.
CREATE UNIQUE INDEX �˻�������ȭ_PK ON �˻�������ȭ (�������˻��� ASC) 
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
