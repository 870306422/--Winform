create database librarysystem2
go
use librarysystem2
go
create table book (
   b_id                 bigint               identity,
   title                varchar(128)         not null,
   author               varchar(64)          not null,
   isbn                 varchar(32)          not null,
   abstract             text                 null,
   category             varchar(64)          null,
   imageurl             varchar(256)         null,
   presscompany         varchar(64)          not null,
   count                int                  not null,
   publishdate          datetime             not null,
   inlibdate            datetime             not null,
   position             varchar(128)         null,
   bookremark           text                 null,
   constraint PK_BOOK primary key nonclustered (b_id)
)
go
/*==============================================================*/
/* Table: borrow_record                                         */
/*==============================================================*/
create table borrow_record (
   uid                  bigint               not null,
   b_id                 bigint               not null,
   borrowcount          int                  not null,
   borrowdate           datetime             not null,
   returndate           datetime             not null,
   validdate            datetime             not null,
   status               varchar(32)          not null,
   fee                  decimal              not null default 0,
   reborrow             int                  null default 0
)
go



select * from book
go
select * from borrow_record
go

SET IDENTITY_INSERT book ON
insert into book
select  N'C���Գ������', N'̷��ǿ', N'	978-7-302-22446-4 ', N'���������C���Ը������������͡����������ʽ����򵥵�C������ơ�ѭ�����ơ�������Ԥ��������ṹ���빲��������ݡ�', N'�����', N' ', N'�廪������', 1, CAST(0x00009F8E00000000 AS DateTime), CAST(0x0000A94E00000000 AS DateTime), N'��¥�߲� TP393.2 54��A��4��', N' ' union
select  N'MATLAB���Ա��', N'��կ�', N'978-7-121-30231-2', N'�����MATLAB������漰����Ҫ֪ʶ��������������⣬���Դ���淶�����������Ļ��Ƚ�����̽����ȫ�鹲�����£����ݰ���MATLAB�Ļ����ſ��������ļ����������㡢cell��STRUCT����ͼ���û����桢�������㡢����������߸�ר�⣬ÿ��ר�ⶼ��������ϸ�Ľ��⣬�������˹淶����ʾ�����롣', N'�����', N' ', N'���ӹ�ҵ������', 3, CAST(0x0000A6EE00000000 AS DateTime), CAST(0x0000A95700000000 AS DateTime), N'��¥�߲� TP312 51��A��5��', N' 'union
select  N'Perl���Ա��', N'Tom Christiansen', N'978-7-5123-5969-7', N'�����Ϊ������ϸ��������Perl�ļ�����Perl���Ļ����ο�����5���ֹ�29�¡��������ݰ�������Ҹ���á�һԪ�Ͷ�Ԫ������������������ģʽƥ�䡢Unicode�������̡����á����ݽṹ������ģ�顢����ȡ�', N'�����', N' ', N'�й�����������', 3, CAST(0x0000A3B700000000 AS DateTime), CAST(0x0000A95700000000 AS DateTime), N'��¥�߲� TP312 51��B��2��', N' 'union
select  N'C���Ա��֮��', N'���������÷������', N'978-7-115-24546-5', N'�����Ϊ5ƪ����15�£�ȫ�������ѧϰ��Ӧ��C���Խ��г��򿪷��ĸ������������󡢼���ϸ���뾭�鼼�ɡ����õ��㷨�ȡ����漰�ļ�����Ҫ����C���Թؼ�������ָ�롢���顢���ݽṹ����ѧӦ�á��㷨����ؼ���ϸ�ڡ����ɡ�', N'�����', N' ', N'�����ʵ������', 2, CAST(0x00009ED700000000 AS DateTime), CAST(0x0000A95700000000 AS DateTime), N'��¥�߲� TP312 51��B��3��', N' 'union
select  N'Java���Ա�̻����̳�', N'�����', N'978-7-302-10648-7', N'�����Java������ȫ����ܣ����ݰ�������C++���ת��Java��̣��������������ڴ棻����������ȼ��ͽ���ɵȡ�', N'�����', N' ', N'�廪��ѧ������', 1, CAST(0x000095CF00000000 AS DateTime), CAST(0x0000A95700000000 AS DateTime), N'��¥�߲� TP312 51��A��3��', N' '




insert into borrow_record
select 1,1, 1, CAST(0x0000A9580097B41F AS DateTime), CAST(0x0000A9950097B41F AS DateTime), CAST(0x0000A9950097B41F AS DateTime), N'����', CAST(0 AS Decimal(18, 0)), 1 union
select 1,2, 1, CAST(0x0000A9580097B70F AS DateTime), CAST(0x0000A9760097B70F AS DateTime), CAST(0x0000A9760097B70F AS DateTime), N'����', CAST(0 AS Decimal(18, 0)), 0 union
select 1,4, 1, CAST(0x0000A95800B4FAD1 AS DateTime), CAST(0x0000A97600B4FAD1 AS DateTime), CAST(0x0000A97600B4FAD1 AS DateTime), N'����', CAST(0 AS Decimal(18, 0)), 0 
go
insert into book values (N'C���Գ������2', N'̷��ǿ', N'	978-7-302-22446-4 ', N'���������C���Ը������������͡����������ʽ����򵥵�C������ơ�ѭ�����ơ�������Ԥ��������ṹ���빲��������ݡ�', N'�����', N' ', N'�廪������', 1, CAST(0x00009F8E00000000 AS DateTime), CAST(0x0000A94E00000000 AS DateTime), N'��¥�߲� TP393.2 54��A��4��', N' ')
go