create database librarysystem3
go
use librarysystem3
go
create table Book
(				
BookId int identity(0001,1) ,		--书籍编号
BookTitle varchar(20) not null,		--书籍标题
Author varchar(30) not null,		--作者
LendingBook int not null,			--借出数量
LendingTime datetime not null,		--借出时间
DueDate datetime not null,			--应还时间
LateFees real not null				--逾期费用
)
go
insert into Book
select N'C语言程序设计', N'谭浩强', 20, CAST(0x0000A9950097B41F AS DateTime), CAST(0x0000A9950097B41F AS DateTime), CAST(20.05 AS Decimal(18, 2)) union
select N'MATLAB语言编程',  N'马寨璞', 25, CAST(0x0000A9760097B70F AS DateTime), CAST(0x0000A9760097B70F AS DateTime), CAST(0 AS Decimal(18, 2)) union
select N'Perl语言编程', N'Tom Christiansen',32, CAST(0x0000A09C01283323  AS DateTime), CAST(0x0000A09C01283323  AS DateTime), CAST(6.90 AS Decimal(18, 2)) union
select N'C语言编程之道', N'刘彬彬', 15,CAST(0x0000A9950097B41F AS DateTime),CAST(0x0000A9950097B41F AS DateTime), CAST(3.20 AS Decimal(18, 2)) union
select N'Java语言编程基础教程',N'宋振会',22,CAST(0x0000A9580097B70F AS DateTime), CAST(0x0000A9760097B70F AS DateTime),CAST(0.5 AS Decimal(18, 2))
go
select * from Book
go
create table BookTwo
(
BookId int identity(0001,1),		--书籍ID
BookTitle varchar(20) not null,		--书籍标题
Author varchar(30) not null,		--作者
ISBN varchar(50) not null,			--国际标准书号isbn
Abstract varchar(1500) not null,		--摘要
Category varchar(50) not null,		--类别
Press varchar(20) not null,			--出版社
Number int not null,			--数量
PublicationTime datetime not null,	--出版时间
StorageTime datetime not null,		--入库时间
CollectionLocation varchar(30) not null,	--馆藏位置
PicturePath varchar(300) not null,  --图片路径
)
go
update BookTwo set BookTitle = '看11',Author='谭浩强2',ISBN= 'ISBN',Abstract= '摘要',Category= '类别' ,Press= '出版社',Number= 9,PublicationTime=CAST(0x00009F8E00000000 AS DateTime) ,StorageTime= CAST(0x0000A95700000000 AS DateTime),CollectionLocation= '馆藏位置' where BookTitle = N'看11'
go
drop table BookTwo
go
insert into BookTwo
select  N'C语言程序设计', N'谭浩强', N'978-7-302-22446-4 ', N'本书包括：C语言概述、数据类型、运算符与表达式、最简单的C程序设计、循环控制、函数、预处理命令、结构体与共用体等内容。', N'计算机', N'清华出版社', 1, CAST(0x00009F8E00000000 AS DateTime), CAST(0x0000A94E00000000 AS DateTime), N'北楼七层 TP393.2 54列A面4层', N'北楼七层 TP393.2 54列A面4层 ' union
select  N'MATLAB语言编程', N'马寨璞', N'978-7-121-30231-2', N'本书对MATLAB编程中涉及的主要知识点进行了完整讲解，并对代码规范化、内容人文化等进行了探索。全书共分七章，内容包括MATLAB的基本概况、函数文件、矩阵运算、cell与STRUCT、绘图与用户界面、符号运算、面向对象编程七个专题，每个专题都进行了详细的讲解，并给出了规范化的示例代码。', N'计算机', N'电子工业出版社', 3, CAST(0x0000A6EE00000000 AS DateTime), CAST(0x0000A95700000000 AS DateTime), N'北楼七层 TP312 51列A面5层', N'北楼七层 TP312 51列A面5层'union
select  N'Perl语言编程', N'Tom Christiansen', N'978-7-5123-5969-7', N'本书分为概述、细节详述、Perl的技术、Perl的文化、参考资料5部分共29章。具体内容包括：集腋成裘、一元和二元操作符、语句和声明、模式匹配、Unicode、子例程、引用、数据结构、包、模块、对象等。', N'计算机',N'中国电力出版社', 3, CAST(0x0000A3B700000000 AS DateTime), CAST(0x0000A95700000000 AS DateTime), N'北楼七层 TP312 51列B面2层', N'北楼七层 TP312 51列B面2层'union
select  N'C语言编程之道', N'刘彬彬，孙秀梅，李鑫', N'978-7-115-24546-5', N'本书分为5篇，共15章，全面介绍了学习和应用C语言进行程序开发的各种陷阱与谬误、技术细节与经验技巧、常用的算法等。其涉及的技术主要包括C语言关键技术、指针、数组、数据结构、数学应用、算法等相关技术细节、技巧。', N'计算机',  N'人民邮电出版社', 2, CAST(0x00009ED700000000 AS DateTime), CAST(0x0000A95700000000 AS DateTime), N'北楼七层 TP312 51列B面3层', N'北楼七层 TP312 51列B面3层 'union
select  N'Java语言编程基础教程', N'宋振会', N'978-7-302-10648-7', N'本书对Java进行了全面介绍，内容包括：从C++编程转到Java编程；常量、变量和内存；运算符、优先级和结合律等。', N'计算机',  N'清华大学出版社', 1, CAST(0x000095CF00000000 AS DateTime), CAST(0x0000A95700000000 AS DateTime), N'北楼七层 TP312 51列A面3层', N' '
go
select * from BookTwo
go
select BookTitle '书籍标题',Author '作者',Press '出版社',ISBN 'ISBN',Category '类别',PublicationTime '出版时间',StorageTime '入库时间',Number '数量',CollectionLocation '馆藏位置',Abstract '摘要' from BookTwo
go
SET IDENTITY_INSERT BookTwo ON
insert into BookTwo values (N'C语言程序设计2', N'谭浩强', N'978-7-302-22446-4 ', N'本书包括：C语言概述、数据类型、运算符与表达式、最简单的C程序设计、循环控制、函数、预处理命令、结构体与共用体等内容。', N'计算机', N'清华出版社', 1, CAST(0x00009F8E00000000 AS DateTime), CAST(0x0000A94E00000000 AS DateTime), N'北楼七层 TP393.2 54列A面4层', N' ')
go
update BookTwo set BookTitle = 'C语言程序设计2',Author='谭浩强',Press= '出版社',ISBN= 'ISBN',Category= '类别',PublicationTime=CAST(0x00009F8E00000000 AS DateTime) ,StorageTime= CAST(0x0000A95700000000 AS DateTime),Number= 9,CollectionLocation= '馆藏位置',Abstract= '摘要' where BookTitle = 'Java语言编程基础教程'where BookTitle = 'C语言程序设计'
go
