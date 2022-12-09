--------------------------------------------------------
--  ������ ������ - �����-12��-19-2019   
--------------------------------------------------------
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.��� ��ü�� ���� TABLE DDL�� �������� �� �����ϴ�.
CREATE TABLE ��� 
(
  ����ȣ VARCHAR2(5 BYTE) NOT NULL 
, ����̸� VARCHAR2(20 BYTE) 
, �ΰ����� VARCHAR2(300 BYTE) 
, ��ȸ�� NUMBER 
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
NOPARALLELCREATE UNIQUE INDEX ���_PK ON ��� (����ȣ ASC) 
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
NOPARALLELALTER TABLE ���
ADD CONSTRAINT ���_PK PRIMARY KEY 
(
  ����ȣ 
)
USING INDEX ���_PK
ENABLE
REM INSERTING into SCAL."���"
SET DEFINE OFF;
Insert into SCAL."���" ("����ȣ","����̸�","�ΰ�����","��ȸ��") values ('001','RAM','���� ������ �о�⵵ �ϰ� �ٸ� ������ ����ų ���� �ִ� �޸𸮷ν� ��ǻ���� �ֱ����ġ, ���� ���α׷��� �Ͻ��� �ε�(loading), �������� �Ͻ��� ���� � ���',0);
Insert into SCAL."���" ("����ȣ","����̸�","�ΰ�����","��ȸ��") values ('002','CPU','��Central Processing Unit���� ���ڷν� ���� �ϸ� �߾�ó����ġ�̴� �ܾ�״�� ��ǻ���� ���߾ӿ��� ��� �����͸� ó���ϴ� ��ġ',0);
Insert into SCAL."���" ("����ȣ","����̸�","�ΰ�����","��ȸ��") values ('003','����޸�(ROM)','������ ���� �޸�ī�� ���� �⺻������ ����� �� �ִ� �������',0);
Insert into SCAL."���" ("����ȣ","����̸�","�ΰ�����","��ȸ��") values ('004','LED','�߱� ���̿���. Ga(����), P(��), As(���)�� ���� �Ͽ� ������� �ݵ�ü ������ ���� ������ ��� ���� �ӵ��� ������ �پ��� ������� ���� �� �ִٴ� �� ����',0);
Insert into SCAL."���" ("����ȣ","����̸�","�ΰ�����","��ȸ��") values ('005','LCD','����ǥ����ġ �ΰ����п� ���� ���� �������� ��ȭ�� �̿��Ͽ� ���� ��ġ���� �߻��ϴ� ���� ���� �������� ������ �ð������� ��ȭ���� �����ϴ� ��������̴�. �ڱ�߱����� ���� �ı��� �ʿ������� �Һ������� ����',0);
Insert into SCAL."���" ("����ȣ","����̸�","�ΰ�����","��ȸ��") values ('006','����������','�޴��� ���� �� ��Ż�κ��� ������ �������� �ް� ��ǰ�� �����ϴ� ������, �����Ⱓ ������ ���� �ܸ��� �ݾ��� ���� �޴� ����',0);
Insert into SCAL."���" ("����ȣ","����̸�","�ΰ�����","��ȸ��") values ('007','���','��ǰ�� ����� ���� ����',0);
Insert into SCAL."���" ("����ȣ","����̸�","�ΰ�����","��ȸ��") values ('008','mbps','�ʴ� �ް���Ʈ(�鸸��Ʈ)�� ������ �� �ִ� ������ ���ۼӵ��� ��Ÿ���� ����',0);
Insert into SCAL."���" ("����ȣ","����̸�","�ΰ�����","��ȸ��") values ('009','GB','GIABYTE(�Ⱑ����Ʈ)�� ���� ǥ�õǴ� �ڷ��� �뷮 �����μ� 1GB=1000MB(MEGABYTE)�̴�',0);
Insert into SCAL."���" ("����ȣ","����̸�","�ΰ�����","��ȸ��") values ('010','���þ�������',' �ܸ��⸦ �����ϴ� ����� ���������ݰ� �޸�, ����� 25%�� ����ϰ� ������ �ִ°�',0);
-- ���� �����⸦ �õ��ϴ� DBMS_METADATA�� SCAL.���_PK ��ü�� ���� INDEX DDL�� �������� �� �����ϴ�.
CREATE UNIQUE INDEX ���_PK ON ��� (����ȣ ASC) 
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
