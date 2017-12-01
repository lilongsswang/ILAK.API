USE [HDSAPI]
GO

/****** Object:  UserDefinedFunction [dbo].[split]    Script Date: 2017/11/30 17:59:30 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[split]

(

 @str varchar(4500),

 @sep varchar(1)

)

returns @t  table(id int identity(1,1),col   varchar(4500))

as

begin

--分别定义了 目前位置，分隔符开始和字符串长度和，当前获取的字符串

declare @posi int,@start int,@str_leg int,@gchar varchar(2),@mingzhong int

set @str_leg=len(@str)

set @posi=0

set @start=0

set @mingzhong=0

while(@posi<=@str_leg)

    begin

    set @gchar=substring(@str,@posi,1)

     if(@gchar=@sep)

         begin

             insert into @t  values(substring(@str,@start+1,@posi-@start-1))

             set @start=@posi

         end

      set @posi=@posi+1

     end

 return

end 
GO


