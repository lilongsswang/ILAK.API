/*
Navicat SQL Server Data Transfer

Source Server         : 172.18.107.250
Source Server Version : 105000
Source Host           : 172.18.107.250:1433
Source Database       : HDSAPI
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 105000
File Encoding         : 65001

Date: 2017-11-27 14:42:09
*/


-- ----------------------------
-- Table structure for HA_ExecLog
-- ----------------------------
DROP TABLE [dbo].[HA_ExecLog]
GO
CREATE TABLE [dbo].[HA_ExecLog] (
[log_id] int NOT NULL IDENTITY(1,1) ,
[log_intfcode] varchar(255) NULL ,
[log_intfver] varchar(255) NULL ,
[log_reqjson] varchar(MAX) NULL ,
[log_requestStmt] varchar(MAX) NULL ,
[log_datetime] datetime NULL ,
[log_executor] varchar(255) NULL ,
[log_mcode] varchar(255) NULL ,
[log_projcode] varchar(255) NULL ,
[log_action] varchar(50) NULL DEFAULT ('Query') 
)


GO
DBCC CHECKIDENT(N'[dbo].[HA_ExecLog]', RESEED, 2)
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_ExecLog', 
'COLUMN', N'log_id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'log自增id'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ExecLog'
, @level2type = 'COLUMN', @level2name = N'log_id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'log自增id'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ExecLog'
, @level2type = 'COLUMN', @level2name = N'log_id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_ExecLog', 
'COLUMN', N'log_intfcode')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'接口代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ExecLog'
, @level2type = 'COLUMN', @level2name = N'log_intfcode'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'接口代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ExecLog'
, @level2type = 'COLUMN', @level2name = N'log_intfcode'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_ExecLog', 
'COLUMN', N'log_intfver')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'接口版本'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ExecLog'
, @level2type = 'COLUMN', @level2name = N'log_intfver'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'接口版本'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ExecLog'
, @level2type = 'COLUMN', @level2name = N'log_intfver'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_ExecLog', 
'COLUMN', N'log_reqjson')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'请求json'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ExecLog'
, @level2type = 'COLUMN', @level2name = N'log_reqjson'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'请求json'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ExecLog'
, @level2type = 'COLUMN', @level2name = N'log_reqjson'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_ExecLog', 
'COLUMN', N'log_requestStmt')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'返回json'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ExecLog'
, @level2type = 'COLUMN', @level2name = N'log_requestStmt'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'返回json'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ExecLog'
, @level2type = 'COLUMN', @level2name = N'log_requestStmt'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_ExecLog', 
'COLUMN', N'log_datetime')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'执行日期时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ExecLog'
, @level2type = 'COLUMN', @level2name = N'log_datetime'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'执行日期时间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ExecLog'
, @level2type = 'COLUMN', @level2name = N'log_datetime'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_ExecLog', 
'COLUMN', N'log_executor')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'执行人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ExecLog'
, @level2type = 'COLUMN', @level2name = N'log_executor'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'执行人'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ExecLog'
, @level2type = 'COLUMN', @level2name = N'log_executor'
GO

-- ----------------------------
-- Indexes structure for table HA_ExecLog
-- ----------------------------
CREATE INDEX [logdatetimeIdx] ON [dbo].[HA_ExecLog]
([log_datetime] ASC) 
INCLUDE ([log_intfcode]) 
GO
CREATE INDEX [ActionIndex] ON [dbo].[HA_ExecLog]
([log_action] ASC) 
INCLUDE ([log_datetime], [log_mcode]) 
GO

-- ----------------------------
-- Primary Key structure for table HA_ExecLog
-- ----------------------------
ALTER TABLE [dbo].[HA_ExecLog] ADD PRIMARY KEY ([log_id])
GO
