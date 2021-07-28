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
select  N'C语言程序设计', N'谭浩强', N'	978-7-302-22446-4 ', N'本书包括：C语言概述、数据类型、运算符与表达式、最简单的C程序设计、循环控制、函数、预处理命令、结构体与共用体等内容。', N'计算机', N' ', N'清华出版社', 1, CAST(0x00009F8E00000000 AS DateTime), CAST(0x0000A94E00000000 AS DateTime), N'北楼七层 TP393.2 54列A面4层', N' ' union
select  N'MATLAB语言编程', N'马寨璞', N'978-7-121-30231-2', N'本书对MATLAB编程中涉及的主要知识点进行了完整讲解，并对代码规范化、内容人文化等进行了探索。全书共分七章，内容包括MATLAB的基本概况、函数文件、矩阵运算、cell与STRUCT、绘图与用户界面、符号运算、面向对象编程七个专题，每个专题都进行了详细的讲解，并给出了规范化的示例代码。', N'计算机', N' ', N'电子工业出版社', 3, CAST(0x0000A6EE00000000 AS DateTime), CAST(0x0000A95700000000 AS DateTime), N'北楼七层 TP312 51列A面5层', N' 'union
select  N'Perl语言编程', N'Tom Christiansen', N'978-7-5123-5969-7', N'本书分为概述、细节详述、Perl的技术、Perl的文化、参考资料5部分共29章。具体内容包括：集腋成裘、一元和二元操作符、语句和声明、模式匹配、Unicode、子例程、引用、数据结构、包、模块、对象等。', N'计算机', N' ', N'中国电力出版社', 3, CAST(0x0000A3B700000000 AS DateTime), CAST(0x0000A95700000000 AS DateTime), N'北楼七层 TP312 51列B面2层', N' 'union
select  N'C语言编程之道', N'刘彬彬，孙秀梅，李鑫', N'978-7-115-24546-5', N'本书分为5篇，共15章，全面介绍了学习和应用C语言进行程序开发的各种陷阱与谬误、技术细节与经验技巧、常用的算法等。其涉及的技术主要包括C语言关键技术、指针、数组、数据结构、数学应用、算法等相关技术细节、技巧。', N'计算机', N' ', N'人民邮电出版社', 2, CAST(0x00009ED700000000 AS DateTime), CAST(0x0000A95700000000 AS DateTime), N'北楼七层 TP312 51列B面3层', N' 'union
select  N'Java语言编程基础教程', N'宋振会', N'978-7-302-10648-7', N'本书对Java进行了全面介绍，内容包括：从C++编程转到Java编程；常量、变量和内存；运算符、优先级和结合律等。', N'计算机', N' ', N'清华大学出版社', 1, CAST(0x000095CF00000000 AS DateTime), CAST(0x0000A95700000000 AS DateTime), N'北楼七层 TP312 51列A面3层', N' '




insert into borrow_record
select 1,1, 1, CAST(0x0000A9580097B41F AS DateTime), CAST(0x0000A9950097B41F AS DateTime), CAST(0x0000A9950097B41F AS DateTime), N'正常', CAST(0 AS Decimal(18, 0)), 1 union
select 1,2, 1, CAST(0x0000A9580097B70F AS DateTime), CAST(0x0000A9760097B70F AS DateTime), CAST(0x0000A9760097B70F AS DateTime), N'正常', CAST(0 AS Decimal(18, 0)), 0 union
select 1,4, 1, CAST(0x0000A95800B4FAD1 AS DateTime), CAST(0x0000A97600B4FAD1 AS DateTime), CAST(0x0000A97600B4FAD1 AS DateTime), N'正常', CAST(0 AS Decimal(18, 0)), 0 
go
insert into book values (N'C语言程序设计2', N'谭浩强', N'	978-7-302-22446-4 ', N'本书包括：C语言概述、数据类型、运算符与表达式、最简单的C程序设计、循环控制、函数、预处理命令、结构体与共用体等内容。', N'计算机', N' ', N'清华出版社', 1, CAST(0x00009F8E00000000 AS DateTime), CAST(0x0000A94E00000000 AS DateTime), N'北楼七层 TP393.2 54列A面4层', N' ')
go