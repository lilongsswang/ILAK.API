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

Date: 2017-11-27 10:43:22
*/


-- ----------------------------
-- Table structure for HA_ArgGroup
-- ----------------------------
DROP TABLE [dbo].[HA_ArgGroup]
GO
CREATE TABLE [dbo].[HA_ArgGroup] (
[ag_id] int NOT NULL IDENTITY(1,1) ,
[ag_name] varchar(255) NULL ,
[ag_code] varchar(255) NULL ,
[ag_paras] varchar(500) NULL ,
[ag_note] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[HA_ArgGroup]', RESEED, 10)
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_ArgGroup', 
'COLUMN', N'ag_id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'参数组的自增id'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ArgGroup'
, @level2type = 'COLUMN', @level2name = N'ag_id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'参数组的自增id'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ArgGroup'
, @level2type = 'COLUMN', @level2name = N'ag_id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_ArgGroup', 
'COLUMN', N'ag_name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'参数组名称 随便描述一下'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ArgGroup'
, @level2type = 'COLUMN', @level2name = N'ag_name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'参数组名称 随便描述一下'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ArgGroup'
, @level2type = 'COLUMN', @level2name = N'ag_name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_ArgGroup', 
'COLUMN', N'ag_code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'由生成器自动编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ArgGroup'
, @level2type = 'COLUMN', @level2name = N'ag_code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'由生成器自动编码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ArgGroup'
, @level2type = 'COLUMN', @level2name = N'ag_code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_ArgGroup', 
'COLUMN', N'ag_paras')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'由 , 分隔'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ArgGroup'
, @level2type = 'COLUMN', @level2name = N'ag_paras'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'由 , 分隔'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ArgGroup'
, @level2type = 'COLUMN', @level2name = N'ag_paras'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_ArgGroup', 
'COLUMN', N'ag_note')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'参数组说明'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ArgGroup'
, @level2type = 'COLUMN', @level2name = N'ag_note'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'参数组说明'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_ArgGroup'
, @level2type = 'COLUMN', @level2name = N'ag_note'
GO

-- ----------------------------
-- Table structure for HA_Connection
-- ----------------------------
DROP TABLE [dbo].[HA_Connection]
GO
CREATE TABLE [dbo].[HA_Connection] (
[conn_id] int NOT NULL IDENTITY(1,1) ,
[conn_name] varchar(255) NOT NULL ,
[conn_IP] varchar(255) NULL ,
[conn_Account] varchar(255) NULL ,
[conn_Password] varchar(255) NULL ,
[conn_DBType] varchar(50) NULL ,
[conn_Alias] varchar(255) NULL ,
[conn_CType] varchar(50) NULL ,
[conn_String] varchar(500) NULL ,
[conn_note] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[HA_Connection]', RESEED, 7)
GO

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
-- Table structure for HA_Interface
-- ----------------------------
DROP TABLE [dbo].[HA_Interface]
GO
CREATE TABLE [dbo].[HA_Interface] (
[intf_id] int NOT NULL IDENTITY(1,1) ,
[intf_name] varchar(255) NULL ,
[intf_code] varchar(255) NULL ,
[intf_namespace] varchar(255) NULL ,
[intf_version] varchar(50) NULL ,
[intf_auth] varchar(50) NULL ,
[intf_dbconn] varchar(255) NULL ,
[intf_note] varchar(255) NULL ,
[proj_code] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[HA_Interface]', RESEED, 7)
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Interface', 
'COLUMN', N'intf_id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'接口ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'intf_id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'接口ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'intf_id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Interface', 
'COLUMN', N'intf_name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'接口名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'intf_name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'接口名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'intf_name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Interface', 
'COLUMN', N'intf_code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'接口代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'intf_code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'接口代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'intf_code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Interface', 
'COLUMN', N'intf_namespace')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'命名空间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'intf_namespace'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'命名空间'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'intf_namespace'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Interface', 
'COLUMN', N'intf_version')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'接口版本'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'intf_version'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'接口版本'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'intf_version'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Interface', 
'COLUMN', N'intf_auth')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'访问权限'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'intf_auth'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'访问权限'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'intf_auth'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Interface', 
'COLUMN', N'intf_dbconn')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'服务器IP'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'intf_dbconn'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'服务器IP'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'intf_dbconn'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Interface', 
'COLUMN', N'intf_note')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'memo 备注'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'intf_note'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'memo 备注'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'intf_note'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Interface', 
'COLUMN', N'proj_code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'项目代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'proj_code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'项目代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Interface'
, @level2type = 'COLUMN', @level2name = N'proj_code'
GO

-- ----------------------------
-- Table structure for HA_Method
-- ----------------------------
DROP TABLE [dbo].[HA_Method]
GO
CREATE TABLE [dbo].[HA_Method] (
[intf_code] varchar(255) NULL ,
[m_id] int NOT NULL IDENTITY(1,1) ,
[m_name] varchar(255) NULL ,
[m_code] varchar(255) NULL ,
[m_desc] varchar(255) NULL ,
[m_reqtype] varchar(255) NULL DEFAULT ('POST') ,
[m_template] int NULL ,
[m_version] varchar(50) NULL ,
[m_funcode] varchar(MAX) NULL ,
[m_isencrypted] bit NULL ,
[m_arggrpcode] varchar(255) NULL ,
[m_rtnvaluecode] varchar(255) NULL ,
[m_pagesize] int NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[HA_Method]', RESEED, 15)
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Method', 
'COLUMN', N'intf_code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'接口代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'intf_code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'接口代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'intf_code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Method', 
'COLUMN', N'm_name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'方法名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'方法名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Method', 
'COLUMN', N'm_code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'方法代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'方法代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Method', 
'COLUMN', N'm_desc')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'方法描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_desc'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'方法描述'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_desc'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Method', 
'COLUMN', N'm_reqtype')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'请求类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_reqtype'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'请求类型'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_reqtype'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Method', 
'COLUMN', N'm_template')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'模版类型:枚举'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_template'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'模版类型:枚举'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_template'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Method', 
'COLUMN', N'm_version')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'方法版本'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_version'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'方法版本'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_version'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Method', 
'COLUMN', N'm_isencrypted')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'是否加密返回值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_isencrypted'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'是否加密返回值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_isencrypted'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Method', 
'COLUMN', N'm_arggrpcode')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'参数组代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_arggrpcode'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'参数组代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_arggrpcode'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Method', 
'COLUMN', N'm_rtnvaluecode')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'返回值代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_rtnvaluecode'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'返回值代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Method'
, @level2type = 'COLUMN', @level2name = N'm_rtnvaluecode'
GO

-- ----------------------------
-- Table structure for HA_Parameter
-- ----------------------------
DROP TABLE [dbo].[HA_Parameter]
GO
CREATE TABLE [dbo].[HA_Parameter] (
[para_id] int NOT NULL IDENTITY(1,1) ,
[para_name] varchar(255) NULL ,
[para_code] varchar(255) NULL ,
[para_datatype] varchar(255) NULL ,
[para_length] varchar(50) NULL ,
[para_required] bit NULL ,
[para_default] varchar(255) NULL ,
[para_note] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[HA_Parameter]', RESEED, 17)
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Parameter', 
'COLUMN', N'para_id')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'参数自增长ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Parameter'
, @level2type = 'COLUMN', @level2name = N'para_id'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'参数自增长ID'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Parameter'
, @level2type = 'COLUMN', @level2name = N'para_id'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Parameter', 
'COLUMN', N'para_name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'参数名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Parameter'
, @level2type = 'COLUMN', @level2name = N'para_name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'参数名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Parameter'
, @level2type = 'COLUMN', @level2name = N'para_name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Parameter', 
'COLUMN', N'para_code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'参数代码: 有生成器自动生成'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Parameter'
, @level2type = 'COLUMN', @level2name = N'para_code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'参数代码: 有生成器自动生成'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Parameter'
, @level2type = 'COLUMN', @level2name = N'para_code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Parameter', 
'COLUMN', N'para_datatype')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'数据类型(存储枚举值)'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Parameter'
, @level2type = 'COLUMN', @level2name = N'para_datatype'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'数据类型(存储枚举值)'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Parameter'
, @level2type = 'COLUMN', @level2name = N'para_datatype'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Parameter', 
'COLUMN', N'para_length')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'长度或格式'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Parameter'
, @level2type = 'COLUMN', @level2name = N'para_length'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'长度或格式'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Parameter'
, @level2type = 'COLUMN', @level2name = N'para_length'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Parameter', 
'COLUMN', N'para_required')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'是否必填'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Parameter'
, @level2type = 'COLUMN', @level2name = N'para_required'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'是否必填'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Parameter'
, @level2type = 'COLUMN', @level2name = N'para_required'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Parameter', 
'COLUMN', N'para_default')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'默认值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Parameter'
, @level2type = 'COLUMN', @level2name = N'para_default'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'默认值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Parameter'
, @level2type = 'COLUMN', @level2name = N'para_default'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Parameter', 
'COLUMN', N'para_note')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'memo 备注'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Parameter'
, @level2type = 'COLUMN', @level2name = N'para_note'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'memo 备注'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Parameter'
, @level2type = 'COLUMN', @level2name = N'para_note'
GO

-- ----------------------------
-- Table structure for HA_Project
-- ----------------------------
DROP TABLE [dbo].[HA_Project]
GO
CREATE TABLE [dbo].[HA_Project] (
[proj_id] int NOT NULL IDENTITY(1,1) ,
[proj_name] varchar(255) NULL ,
[proj_code] varchar(255) NULL ,
[proj_note] varchar(255) NULL ,
[proj_port] int NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[HA_Project]', RESEED, 14)
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Project', 
'COLUMN', N'proj_name')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'项目名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Project'
, @level2type = 'COLUMN', @level2name = N'proj_name'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'项目名称'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Project'
, @level2type = 'COLUMN', @level2name = N'proj_name'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Project', 
'COLUMN', N'proj_code')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'唯一代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Project'
, @level2type = 'COLUMN', @level2name = N'proj_code'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'唯一代码'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Project'
, @level2type = 'COLUMN', @level2name = N'proj_code'
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_Project', 
'COLUMN', N'proj_note')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'memo'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Project'
, @level2type = 'COLUMN', @level2name = N'proj_note'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'memo'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_Project'
, @level2type = 'COLUMN', @level2name = N'proj_note'
GO

-- ----------------------------
-- Table structure for HA_RetValObject
-- ----------------------------
DROP TABLE [dbo].[HA_RetValObject]
GO
CREATE TABLE [dbo].[HA_RetValObject] (
[rv_id] int NOT NULL IDENTITY(1,1) ,
[rv_name] varchar(255) NULL ,
[rv_JSON] varchar(MAX) NULL ,
[rv_exttype] varchar(255) NULL ,
[rv_note] varchar(255) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[HA_RetValObject]', RESEED, 16)
GO
IF ((SELECT COUNT(*) from fn_listextendedproperty('MS_Description', 
'SCHEMA', N'dbo', 
'TABLE', N'HA_RetValObject', 
'COLUMN', N'rv_note')) > 0) 
EXEC sp_updateextendedproperty @name = N'MS_Description', @value = N'返回值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_RetValObject'
, @level2type = 'COLUMN', @level2name = N'rv_note'
ELSE
EXEC sp_addextendedproperty @name = N'MS_Description', @value = N'返回值'
, @level0type = 'SCHEMA', @level0name = N'dbo'
, @level1type = 'TABLE', @level1name = N'HA_RetValObject'
, @level2type = 'COLUMN', @level2name = N'rv_note'
GO

-- ----------------------------
-- Indexes structure for table HA_ArgGroup
-- ----------------------------
CREATE INDEX [ag_code_NCIndex] ON [dbo].[HA_ArgGroup]
([ag_code] ASC) 
GO
CREATE UNIQUE INDEX [codeIdx] ON [dbo].[HA_ArgGroup]
([ag_code] ASC) 
WITH (IGNORE_DUP_KEY = ON)
GO

-- ----------------------------
-- Primary Key structure for table HA_ArgGroup
-- ----------------------------
ALTER TABLE [dbo].[HA_ArgGroup] ADD PRIMARY KEY ([ag_id])
GO

-- ----------------------------
-- Indexes structure for table HA_Connection
-- ----------------------------
CREATE UNIQUE INDEX [connnameIdx] ON [dbo].[HA_Connection]
([conn_name] ASC) 
WITH (IGNORE_DUP_KEY = ON)
GO

-- ----------------------------
-- Primary Key structure for table HA_Connection
-- ----------------------------
ALTER TABLE [dbo].[HA_Connection] ADD PRIMARY KEY ([conn_id])
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

-- ----------------------------
-- Indexes structure for table HA_Interface
-- ----------------------------
CREATE UNIQUE INDEX [code_Idx] ON [dbo].[HA_Interface]
([intf_code] ASC) 
WITH (IGNORE_DUP_KEY = ON)
GO

-- ----------------------------
-- Primary Key structure for table HA_Interface
-- ----------------------------
ALTER TABLE [dbo].[HA_Interface] ADD PRIMARY KEY ([intf_id])
GO

-- ----------------------------
-- Indexes structure for table HA_Method
-- ----------------------------
CREATE UNIQUE INDEX [code_Idx] ON [dbo].[HA_Method]
([m_code] ASC) 
WITH (IGNORE_DUP_KEY = ON)
GO

-- ----------------------------
-- Primary Key structure for table HA_Method
-- ----------------------------
ALTER TABLE [dbo].[HA_Method] ADD PRIMARY KEY ([m_id])
GO

-- ----------------------------
-- Indexes structure for table HA_Parameter
-- ----------------------------
CREATE UNIQUE INDEX [code_Idx] ON [dbo].[HA_Parameter]
([para_code] ASC) 
WITH (IGNORE_DUP_KEY = ON)
GO

-- ----------------------------
-- Primary Key structure for table HA_Parameter
-- ----------------------------
ALTER TABLE [dbo].[HA_Parameter] ADD PRIMARY KEY ([para_id])
GO

-- ----------------------------
-- Indexes structure for table HA_Project
-- ----------------------------
CREATE UNIQUE INDEX [codeIdx] ON [dbo].[HA_Project]
([proj_code] ASC) 
WITH (IGNORE_DUP_KEY = ON)
GO

-- ----------------------------
-- Primary Key structure for table HA_Project
-- ----------------------------
ALTER TABLE [dbo].[HA_Project] ADD PRIMARY KEY ([proj_id])
GO

-- ----------------------------
-- Indexes structure for table HA_RetValObject
-- ----------------------------
CREATE UNIQUE INDEX [code_Idx] ON [dbo].[HA_RetValObject]
([rv_name] ASC) 
WITH (IGNORE_DUP_KEY = ON)
GO

-- ----------------------------
-- Primary Key structure for table HA_RetValObject
-- ----------------------------
ALTER TABLE [dbo].[HA_RetValObject] ADD PRIMARY KEY ([rv_id])
GO
