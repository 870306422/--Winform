create database librarysystem3
go
use librarysystem3
go
create table Book
(				
BookId int identity(0001,1) ,		--�鼮���
BookTitle varchar(20) not null,		--�鼮����
Author varchar(30) not null,		--����
LendingBook int not null,			--�������
LendingTime datetime not null,		--���ʱ��
DueDate datetime not null,			--Ӧ��ʱ��
LateFees real not null				--���ڷ���
)
go
insert into Book
select N'C���Գ������', N'̷��ǿ', 20, CAST(0x0000A9950097B41F AS DateTime), CAST(0x0000A9950097B41F AS DateTime), CAST(20.05 AS Decimal(18, 2)) union
select N'MATLAB���Ա��',  N'��կ�', 25, CAST(0x0000A9760097B70F AS DateTime), CAST(0x0000A9760097B70F AS DateTime), CAST(0 AS Decimal(18, 2)) union
select N'Perl���Ա��', N'Tom Christiansen',32, CAST(0x0000A09C01283323  AS DateTime), CAST(0x0000A09C01283323  AS DateTime), CAST(6.90 AS Decimal(18, 2)) union
select N'C���Ա��֮��', N'�����', 15,CAST(0x0000A9950097B41F AS DateTime),CAST(0x0000A9950097B41F AS DateTime), CAST(3.20 AS Decimal(18, 2)) union
select N'Java���Ա�̻����̳�',N'�����',22,CAST(0x0000A9580097B70F AS DateTime), CAST(0x0000A9760097B70F AS DateTime),CAST(0.5 AS Decimal(18, 2))
go
select * from Book
go
create table BookTwo
(
BookId int identity(0001,1),		--�鼮ID
BookTitle varchar(20) not null,		--�鼮����
Author varchar(30) not null,		--����
ISBN varchar(50) not null,			--���ʱ�׼���isbn
Abstract varchar(1500) not null,		--ժҪ
Category varchar(50) not null,		--���
Press varchar(20) not null,			--������
Number int not null,			--����
PublicationTime datetime not null,	--����ʱ��
StorageTime datetime not null,		--���ʱ��
CollectionLocation varchar(30) not null,	--�ݲ�λ��
PicturePath varchar(300) not null,  --ͼƬ·��
)
go
update BookTwo set BookTitle = '��11',Author='̷��ǿ2',ISBN= 'ISBN',Abstract= 'ժҪ',Category= '���' ,Press= '������',Number= 9,PublicationTime=CAST(0x00009F8E00000000 AS DateTime) ,StorageTime= CAST(0x0000A95700000000 AS DateTime),CollectionLocation= '�ݲ�λ��' where BookTitle = N'��11'
go
drop table BookTwo
go
insert into BookTwo
select  N'C���Գ������', N'̷��ǿ', N'978-7-302-22446-4 ', N'���������C���Ը������������͡����������ʽ����򵥵�C������ơ�ѭ�����ơ�������Ԥ��������ṹ���빲��������ݡ�', N'�����', N'�廪������', 1, CAST(0x00009F8E00000000 AS DateTime), CAST(0x0000A94E00000000 AS DateTime), N'��¥�߲� TP393.2 54��A��4��', N'��¥�߲� TP393.2 54��A��4�� ' union
select  N'MATLAB���Ա��', N'��կ�', N'978-7-121-30231-2', N'�����MATLAB������漰����Ҫ֪ʶ��������������⣬���Դ���淶�����������Ļ��Ƚ�����̽����ȫ�鹲�����£����ݰ���MATLAB�Ļ����ſ��������ļ����������㡢cell��STRUCT����ͼ���û����桢�������㡢����������߸�ר�⣬ÿ��ר�ⶼ��������ϸ�Ľ��⣬�������˹淶����ʾ�����롣', N'�����', N'���ӹ�ҵ������', 3, CAST(0x0000A6EE00000000 AS DateTime), CAST(0x0000A95700000000 AS DateTime), N'��¥�߲� TP312 51��A��5��', N'��¥�߲� TP312 51��A��5��'union
select  N'Perl���Ա��', N'Tom Christiansen', N'978-7-5123-5969-7', N'�����Ϊ������ϸ��������Perl�ļ�����Perl���Ļ����ο�����5���ֹ�29�¡��������ݰ�������Ҹ���á�һԪ�Ͷ�Ԫ������������������ģʽƥ�䡢Unicode�������̡����á����ݽṹ������ģ�顢����ȡ�', N'�����',N'�й�����������', 3, CAST(0x0000A3B700000000 AS DateTime), CAST(0x0000A95700000000 AS DateTime), N'��¥�߲� TP312 51��B��2��', N'��¥�߲� TP312 51��B��2��'union
select  N'C���Ա��֮��', N'���������÷������', N'978-7-115-24546-5', N'�����Ϊ5ƪ����15�£�ȫ�������ѧϰ��Ӧ��C���Խ��г��򿪷��ĸ������������󡢼���ϸ���뾭�鼼�ɡ����õ��㷨�ȡ����漰�ļ�����Ҫ����C���Թؼ�������ָ�롢���顢���ݽṹ����ѧӦ�á��㷨����ؼ���ϸ�ڡ����ɡ�', N'�����',  N'�����ʵ������', 2, CAST(0x00009ED700000000 AS DateTime), CAST(0x0000A95700000000 AS DateTime), N'��¥�߲� TP312 51��B��3��', N'��¥�߲� TP312 51��B��3�� 'union
select  N'Java���Ա�̻����̳�', N'�����', N'978-7-302-10648-7', N'�����Java������ȫ����ܣ����ݰ�������C++���ת��Java��̣��������������ڴ棻����������ȼ��ͽ���ɵȡ�', N'�����',  N'�廪��ѧ������', 1, CAST(0x000095CF00000000 AS DateTime), CAST(0x0000A95700000000 AS DateTime), N'��¥�߲� TP312 51��A��3��', N' '
go
select * from BookTwo
go
select BookTitle '�鼮����',Author '����',Press '������',ISBN 'ISBN',Category '���',PublicationTime '����ʱ��',StorageTime '���ʱ��',Number '����',CollectionLocation '�ݲ�λ��',Abstract 'ժҪ' from BookTwo
go
SET IDENTITY_INSERT BookTwo ON
insert into BookTwo values (N'C���Գ������2', N'̷��ǿ', N'978-7-302-22446-4 ', N'���������C���Ը������������͡����������ʽ����򵥵�C������ơ�ѭ�����ơ�������Ԥ��������ṹ���빲��������ݡ�', N'�����', N'�廪������', 1, CAST(0x00009F8E00000000 AS DateTime), CAST(0x0000A94E00000000 AS DateTime), N'��¥�߲� TP393.2 54��A��4��', N' ')
go
update BookTwo set BookTitle = 'C���Գ������2',Author='̷��ǿ',Press= '������',ISBN= 'ISBN',Category= '���',PublicationTime=CAST(0x00009F8E00000000 AS DateTime) ,StorageTime= CAST(0x0000A95700000000 AS DateTime),Number= 9,CollectionLocation= '�ݲ�λ��',Abstract= 'ժҪ' where BookTitle = 'Java���Ա�̻����̳�'where BookTitle = 'C���Գ������'
go
