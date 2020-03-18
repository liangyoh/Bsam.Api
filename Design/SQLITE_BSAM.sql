drop table Inv_Bill_Dtl;

drop table Inv_Bill_Hd;

drop table Inv_District;

drop table Inv_Inv_Info;

drop table Inv_Loc;

drop table Inv_Onhand_Qty;

drop table Inv_Rcv_Bill_Dtl;

drop table Inv_Rcv_Bill_Hd;

drop table Sfc_Customer;

drop table Sfc_Mitem;

drop table Sfc_Production;

drop table Sfc_Production_Bom;

drop table Sys_Module;

drop table Sys_Module_Config_Tmpl;

drop table Sys_Permission;

drop table Sys_PermissionGroup;

drop table Sys_Permission_In_Group;

drop table Sys_Role;

drop table Sys_User;

drop table Sys_UserGroup;

drop table Sys_UserGroup_In_Role;

drop table Sys_User_In_Group;

drop table Sys_User_In_Role;

create table Inv_Bill_Dtl (
Id                   INT,
BillId               INT,
MitemCode            VARCHAR(0),
PlanQty              NUMERIC(0),
ActualQty            NUMERIC(0),
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT,
OrgId                VARCHAR(0)
);

create table Inv_Bill_Hd (
Id                   INT,
BillType             VARCHAR(0),
PlanQty              NUMERIC(0),
ActualQty            NUMERIC(0),
SrcBillId            INT,
SrcBillNo            VARCHAR(0),
InvId                INT,
InvCode              VARCHAR(0),
InvName              VARCHAR(0),
InvAddress           VARCHAR(0),
RcvUser              VARCHAR(0),
RcvDateTime          DATE,
RcvReason            VARCHAR(0),
RcvAddress           VARCHAR(0),
BillStatus           VARCHAR(0),
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT,
OrgId                VARCHAR(0)
);

create table Inv_District (
Id                   INTEGER,
DistrictCode         VARCHAR(0),
DistrictName         VARCHAR(0),
DistrictDesc         VARCHAR(0),
DistrictStatus       VARCHAR(0),
Volume               INT,
VolumeUnit           VARCHAR(0),
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT,
OrgId                VARCHAR(0),
InvId                INT
);

create table Inv_Inv_Info (
Id                   INTEGER,
InvCode              VARCHAR(0),
InvName              VARCHAR(0),
InvDesc              VARCHAR(0),
InvAddress           VARCHAR(0),
Volume               INT,
VolumeUnit           VARCHAR(0),
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT,
OrgId                VARCHAR(0)
);

create table Inv_Loc (
Id                   INTEGER,
LocCode              VARCHAR(0),
LocName              VARCHAR(0),
LocDesc              VARCHAR(0),
LocStatus            VARCHAR(0),
LocOrder             INT,
Volume               INT,
VolumeUnit           VARCHAR(0),
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT,
OrgId                VARCHAR(0),
DistrictId           INT,
InvId                INT
);

create table Inv_Onhand_Qty (
Id                   INTEGER,
MitemId              INT,
InvId                INT,
DistrictId           INT,
LocId                INT,
Trans_Qty            NUMERIC,
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT,
OrgId                VARCHAR(0)
);

create table Inv_Rcv_Bill_Dtl (
Id                   INT,
BillId               INT,
MitemCode            VARCHAR(0),
PlanQty              NUMERIC(0),
ActualQty            NUMERIC(0),
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT,
OrgId                VARCHAR(0)
);

create table Inv_Rcv_Bill_Hd (
Id                   INT,
RcvType              VARCHAR(0),
RcvUserId            INT,
RcvUserName          VARCHAR(0),
RcvPhone             VARCHAR(0),
RcvDateTime          DATE,
RcvReason            VARCHAR(0),
RcvAddress           VARCHAR(0),
RentSubject          VARCHAR(0),
RentUserId           VARCHAR(0),
RentUserName         VARCHAR(0),
RentPhone            VARCHAR(0),
RrcBillId            INT,
PlanRtnDateTime      DATE,
ActualRtnDateTime    DATE,
BillStatus           VARCHAR(0),
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT,
OrgId                VARCHAR(0)
);

create table Sfc_Customer (
Id                   INTEGER,
CustomerCode         VARCHAR(0),
CustomerName         VARCHAR(0),
CustomerShortName    VARCHAR(0),
CustomerPhone        VARCHAR(0),
CustomerWebchat      VARCHAR(0),
EnterpriseName       VARCHAR(0),
EnterpriseLegal      VARCHAR(0),
EnterpriseAddress    VARCHAR(0),
EnterprisePhone      VARCHAR(0),
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT,
OrgId                VARCHAR(0)
);

create table Sfc_Mitem (
Id                   INTEGER,
MitemCode            VARCHAR(0),
MitemName            VARCHAR(0),
MitemDesc            VARCHAR(0),
MitemType            VARCHAR(0),
Brand                VARCHAR(0),
Buyer                VARCHAR(0),
DutyPerson           VARCHAR(0),
SupplierId           INT,
DefaultInvId         INT,
Uom                  VARCHAR(0),
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT,
OrgId                VARCHAR(0)
);

create table Sfc_Production (
Id                   INTEGER,
ProductCode          VARCHAR(0),
ProductName          VARCHAR(0),
ProductDesc          VARCHAR(0),
ModelType            VARCHAR(0),
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT,
OrgId                VARCHAR(0)
);

create table Sfc_Production_Bom (
Id                   INTEGER,
ProductId            INT,
MitemId              INT,
ReqQty               NUMERIC(0),
Version              VARCHAR(0),
VersionDesc          VARCHAR(0),
BatchNo              VARCHAR(0),
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT,
OrgId                VARCHAR(0)
);

create table Sys_Module (
Id                   INT                            not null,
ModuleType           VARCHAR(0),
ModuleCode           VARCHAR(0),
ModuleName           varchar(0),
ModuleDesc           VARCHAR(0),
ModuleConfig         VARCHAR(0),
Path                 VARCHAR(0),
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT
);

create table Sys_Module_Config_Tmpl (
Id                   INT                            not null,
ModuleType           VARCHAR(0),
ModuleConfig         VARCHAR(0),
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT
);

create table Sys_Permission (
Id                   INT                            not null,
PermissionName       varchar(0),
PermissionDesc       VARCHAR(0),
RequestType          VARCHAR(0),
ClientType           VARCHAR(0),
ModuleId             INT,
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT
);

create table Sys_PermissionGroup (
Id                   INT                            not null,
PermissionGroupName  VARCHAR(0),
PermissionGroupDesc  VARCHAR(0),
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT,
OrgId                VARCHAR(0)
);

create table Sys_Permission_In_Group (
PermissionId         INT,
PermissionGroupId    INT                            not null
);

create table Sys_Role (
Id                   INT                            not null,
RoleName             VARCHAR(0),
RoleDesc             VARCHAR(0),
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT,
OrgId                VARCHAR(0)
);

create table Sys_User (
Id                   INT                            not null,
UserName             varchar(0),
UserAccount          VARCHAR(0),
UserPwd              VARCHAR(0),
Address              VARCHAR(0),
Phone                VARCHAR(0),
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT
);

create table Sys_UserGroup (
Id                   INT                            not null,
UserGroupName        VARCHAR(0),
UserGroupDesc        VARCHAR(0),
DateTimeCreated      DATE,
UserCreator          VARCHAR(0),
DateTimeModified     DATE,
UserModified         VARCHAR(0),
State                BIT,
OrgId                VARCHAR(0)
);

create table Sys_UserGroup_In_Role (
UserGroupId          INT                            not null,
RoleId               INT
);

create table Sys_User_In_Group (
UserId               INT,
UserGroupId          INT                            not null
);

create table Sys_User_In_Role (
UserId               INT                            not null,
RoleId               INT
);

