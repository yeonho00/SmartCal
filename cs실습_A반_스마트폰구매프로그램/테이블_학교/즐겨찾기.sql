--------------------------------------------------------
--  ������ ������ - �����-12��-19-2019   
--------------------------------------------------------
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.���ã�� ��ü�� ���� TABLE DDL�� �������� �� �����ϴ�.
CREATE TABLE ���ã�� 
(
  ȸ����ȣ VARCHAR2(5 BYTE) NOT NULL 
, ������ȣ VARCHAR2(5 BYTE) NOT NULL 
, �뷮 NUMBER NOT NULL 
, ������� DATE 
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
NOPARALLELCREATE UNIQUE INDEX ���ã��_PK ON ���ã�� (ȸ����ȣ ASC, ������ȣ ASC, �뷮 ASC) 
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
NOPARALLELALTER TABLE ���ã��
ADD CONSTRAINT ���ã��_PK PRIMARY KEY 
(
  ȸ����ȣ 
, ������ȣ 
, �뷮 
)
USING INDEX ���ã��_PK
ENABLE
REM INSERTING into SCAL."���ã��"
SET DEFINE OFF;
Insert into SCAL."���ã��" ("ȸ����ȣ","������ȣ","�뷮","�������") values ('0001','0016',512,to_date('19/12/18','RR/MM/DD'));
Insert into SCAL."���ã��" ("ȸ����ȣ","������ȣ","�뷮","�������") values ('0001','0020',32,to_date('19/12/19','RR/MM/DD'));
Insert into SCAL."���ã��" ("ȸ����ȣ","������ȣ","�뷮","�������") values ('0001','0016',128,to_date('19/12/18','RR/MM/DD'));
Insert into SCAL."���ã��" ("ȸ����ȣ","������ȣ","�뷮","�������") values ('0001','0017',512,to_date('19/12/18','RR/MM/DD'));
Insert into SCAL."���ã��" ("ȸ����ȣ","������ȣ","�뷮","�������") values ('0001','0004',128,to_date('19/12/18','RR/MM/DD'));
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.���ã��_PK ��ü�� ���� INDEX DDL�� �������� �� �����ϴ�.
CREATE UNIQUE INDEX ���ã��_PK ON ���ã�� (ȸ����ȣ ASC, ������ȣ ASC, �뷮 ASC) 
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
