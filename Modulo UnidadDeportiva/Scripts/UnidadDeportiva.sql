/*==============================================================*/
/* DBMS name:      ORACLE Version 12c                           */
/* Created on:     6/08/2022 7:37:17 p. m.                      */
/*==============================================================*/


alter table ASISMIEMBROEQUIPO
   drop constraint FK_ASISMIEM_RELATIONS_MIEMBROE;

alter table ASISMIEMBROEQUIPO
   drop constraint FK_ASISMIEM_RELATIONS_PROGRAMA;

alter table ASISTIRRESPONSABLE
   drop constraint FK_ASISTIRR_RELATIONS_RESPONSA;

alter table ELEMENDEPORTIVO
   drop constraint FK_ELEMENDE_RELATIONS_TIPOELEM;

alter table ELEMENDEPORTIVO
   drop constraint FK_ELEMENDE_RELATIONS_ESTADO;

alter table ELEMENDEPORTIVO
   drop constraint FK_ELEMENDE_RELATIONS_MARCA;

alter table ELEMENDEPORTIVO
   drop constraint FK_ELEMENDE_RELATIONS_ESPACIO;

alter table EMPLEADO_CARGO
   drop constraint FK_EMPLEADO_RELATIONS_ESPACIO;

alter table EMPLEADO_CARGO
   drop constraint FK_EMPLEADO_RELATIONS_CARGO;

alter table EMPLEADO_CARGO
   drop constraint FK_EMPLEADO_RELATIONS_EMPLEADO;

alter table EQUIPO
   drop constraint FK_EQUIPO_RELATIONS_EMPLEADO;

alter table EQUIPO
   drop constraint FK_EQUIPO_RELATIONS_DEPORTE;

alter table ESPACIO
   drop constraint FK_ESPACIO_RELATIONS_TIPOESPA;

alter table ESPACIO
   drop constraint FK_ESPACIO_RELATIONS_ESPACIO;

alter table ESTUDIANTE
   drop constraint FK_ESTUDIAN_RELATIONS_ESPACIO;

alter table INSCRITOPRACLIBRE
   drop constraint FK_INSCRITO_RELATIONS_EMPLEADO;

alter table INSCRITOPRACLIBRE
   drop constraint FK_INSCRITO_RELATIONS_ESTUDIAN;

alter table INSCRITOPRACLIBRE
   drop constraint FK_INSCRITO_RELATIONS_PROGRAMA;

alter table MIEMBROEQUIPO
   drop constraint FK_MIEMBROE_RELATIONS_EQUIPO;

alter table MIEMBROEQUIPO
   drop constraint FK_MIEMBROE_RELATIONS_ESTUDIAN;

alter table PRESTAMO
   drop constraint FK_PRESTAMO_RELATIONS_ELEMENDE;

alter table PRESTAMO
   drop constraint FK_PRESTAMO_RELATIONS_ASISTIRR;

alter table PROGRAMACION
   drop constraint FK_PROGRAMA_HORAFIN_HORA;

alter table PROGRAMACION
   drop constraint FK_PROGRAMA_HORAINICI_HORA;

alter table PROGRAMACION
   drop constraint FK_PROGRAMA_RELATIONS_DEPORTE;

alter table PROGRAMACION
   drop constraint FK_PROGRAMA_RELATIONS_ESPACIO;

alter table PROGRAMACION
   drop constraint FK_PROGRAMA_RELATIONS_DIA;

alter table PROGRAMACION
   drop constraint FK_PROGRAMA_RELATIONS_ACTIVIDA;

alter table PROGRAMACION
   drop constraint FK_PROGRAMA_RELATIONS_PERIODO;

alter table RELATIONSHIP_12
   drop constraint FK_RELATION_DEPORTEES_DEPORTE;

alter table RELATIONSHIP_12
   drop constraint FK_RELATION_RELATIONS_TIPOELEM;

alter table RELATIONSHIP_13
   drop constraint FK_RELATION_RELATIONS_ESPACIO;

alter table RELATIONSHIP_13
   drop constraint FK_RELATION_RELATIONS_DEPORTE;

alter table RESPONSABLE
   drop constraint FK_RESPONSA_RELATIONS_EMPLEADO;

alter table RESPONSABLE
   drop constraint FK_RESPONSA_RELATIONS_ROL;

alter table RESPONSABLE
   drop constraint FK_RESPONSA_RELATIONS_ESTUDIAN;

alter table RESPONSABLE
   drop constraint FK_RESPONSA_RELATIONS_PROGRAMA;

drop table ACTIVIDAD cascade constraints;

drop index RELATIONSHIP_10_FK;

drop index RELATIONSHIP_1_FK;

drop table ASISMIEMBROEQUIPO cascade constraints;

drop index RELATIONSHIP_34_FK;

drop table ASISTIRRESPONSABLE cascade constraints;

drop table CARGO cascade constraints;

drop table DEPORTE cascade constraints;

drop table DIA cascade constraints;

drop index RELATIONSHIP_20_FK;

drop index RELATIONSHIP_19_FK;

drop index RELATIONSHIP_18_FK;

drop index RELATIONSHIP_17_FK;

drop table ELEMENDEPORTIVO cascade constraints;

drop table EMPLEADO cascade constraints;

drop index RELATIONSHIP_26_FK;

drop index RELATIONSHIP_25_FK;

drop index RELATIONSHIP_23_FK;

drop table EMPLEADO_CARGO cascade constraints;

drop index RELATIONSHIP_11_FK;

drop index RELATIONSHIP_3_FK;

drop table EQUIPO cascade constraints;

drop index RELATIONSHIP_8_FK;

drop index RELATIONSHIP_7_FK;

drop table ESPACIO cascade constraints;

drop table ESTADO cascade constraints;

drop index RELATIONSHIP_24_FK;

drop table ESTUDIANTE cascade constraints;

drop table HORA cascade constraints;

drop index RELATIONSHIP_32_FK;

drop index RELATIONSHIP_30_FK;

drop index RELATIONSHIP_29_FK;

drop table INSCRITOPRACLIBRE cascade constraints;

drop table MARCA cascade constraints;

drop index RELATIONSHIP_9_FK;

drop index RELATIONSHIP_2_FK;

drop table MIEMBROEQUIPO cascade constraints;

drop table PERIODO cascade constraints;

drop index RELATIONSHIP_35_FK;

drop index RELATIONSHIP_21_FK;

drop table PRESTAMO cascade constraints;

drop index RELATIONSHIP_40_FK;

drop index RELATIONSHIP_39_FK;

drop index RELATIONSHIP_38_FK;

drop index RELATIONSHIP_37_FK;

drop index RELATIONSHIP_36_FK;

drop index RELATIONSHIP_22_FK;

drop index RELATIONSHIP_16_FK;

drop table PROGRAMACION cascade constraints;

drop index RELATIONSHIP_13_FK;

drop index RELATIONSHIP_12_FK;

drop table RELATIONSHIP_12 cascade constraints;

drop index RELATIONSHIP_15_FK;

drop index RELATIONSHIP_14_FK;

drop table RELATIONSHIP_13 cascade constraints;

drop index RELATIONSHIP_33_FK;

drop index RELATIONSHIP_31_FK;

drop index RELATIONSHIP_28_FK;

drop index RELATIONSHIP_27_FK;

drop table RESPONSABLE cascade constraints;

drop table ROL cascade constraints;

drop table TIPOELEMENTO cascade constraints;

drop table TIPOESPACIO cascade constraints;

/*==============================================================*/
/* Table: ACTIVIDAD                                             */
/*==============================================================*/
create table ACTIVIDAD (
   IDACTIVIDAD          VARCHAR2(2)           not null,
   DESCACTIVIDAD        VARCHAR2(30)          not null,
   constraint PK_ACTIVIDAD primary key (IDACTIVIDAD)
);

/*==============================================================*/
/* Table: ASISMIEMBROEQUIPO                                     */
/*==============================================================*/
create table ASISMIEMBROEQUIPO (
   CONMIEMEQUIPO        NUMBER(4,0)           not null,
   ITEMMIEMBRO          NUMBER(3,0)           not null,
   CONSEEQUIPO          NUMBER(3,0)           not null,
   CONSECPROGRA         NUMBER(4,0)           not null,
   constraint PK_ASISMIEMBROEQUIPO primary key (CONMIEMEQUIPO, CONSECPROGRA)
);

/*==============================================================*/
/* Index: RELATIONSHIP_1_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_1_FK on ASISMIEMBROEQUIPO (
   ITEMMIEMBRO ASC,
   CONSEEQUIPO ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_10_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_10_FK on ASISMIEMBROEQUIPO (
   CONSECPROGRA ASC
);

/*==============================================================*/
/* Table: ASISTIRRESPONSABLE                                    */
/*==============================================================*/
create table ASISTIRRESPONSABLE (
   CONSECASISRES        NUMBER(4,0)           not null,
   CONSECRES            NUMBER(4,0)           not null,
   CONSECPROGRA         NUMBER(4,0)           not null,
   FECHAASISRES         DATE                  not null,
   HORAASISRES          DATE                  not null,
   constraint PK_ASISTIRRESPONSABLE primary key (CONSECASISRES, CONSECRES, CONSECPROGRA)
);

/*==============================================================*/
/* Index: RELATIONSHIP_34_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_34_FK on ASISTIRRESPONSABLE (
   CONSECRES ASC,
   CONSECPROGRA ASC
);

/*==============================================================*/
/* Table: CARGO                                                 */
/*==============================================================*/
create table CARGO (
   IDCARGO              VARCHAR2(2)           not null,
   DESCARGO             VARCHAR2(20)          not null,
   constraint PK_CARGO primary key (IDCARGO)
);

/*==============================================================*/
/* Table: DEPORTE                                               */
/*==============================================================*/
create table DEPORTE (
   IDDEPORTE            VARCHAR2(2)           not null,
   NOMDEPORTE           VARCHAR2(20)          not null,
   constraint PK_DEPORTE primary key (IDDEPORTE)
);

/*==============================================================*/
/* Table: DIA                                                   */
/*==============================================================*/
create table DIA (
   IDDIA                VARCHAR2(1)           not null,
   NOMDIA               VARCHAR2(10)          not null,
   constraint PK_DIA primary key (IDDIA)
);

/*==============================================================*/
/* Table: ELEMENDEPORTIVO                                       */
/*==============================================================*/
create table ELEMENDEPORTIVO (
   CONSECELEMENTO       NUMBER(5,0)           not null,
   IDTIPOELEMENTO       VARCHAR2(2)           not null,
   IDESTADO             VARCHAR2(2)           not null,
   IDMARCA              VARCHAR2(2)           not null,
   CODESPACIO           VARCHAR2(2)           not null,
   FECHAREGISTRO        DATE                  not null,
   constraint PK_ELEMENDEPORTIVO primary key (CONSECELEMENTO)
);

/*==============================================================*/
/* Index: RELATIONSHIP_17_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_17_FK on ELEMENDEPORTIVO (
   IDTIPOELEMENTO ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_18_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_18_FK on ELEMENDEPORTIVO (
   IDESTADO ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_19_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_19_FK on ELEMENDEPORTIVO (
   IDMARCA ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_20_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_20_FK on ELEMENDEPORTIVO (
   CODESPACIO ASC
);

/*==============================================================*/
/* Table: EMPLEADO                                              */
/*==============================================================*/
create table EMPLEADO (
   CODEMPLEADO          VARCHAR2(4)           not null,
   NOMEMPLEADO          VARCHAR2(20)          not null,
   APELLEMPLEADO        VARCHAR2(20)          not null,
   FECHAREGISTRO        DATE                  not null,
   CORREOUD             VARCHAR2(30)          not null,
   constraint PK_EMPLEADO primary key (CODEMPLEADO)
);

/*==============================================================*/
/* Table: EMPLEADO_CARGO                                        */
/*==============================================================*/
create table EMPLEADO_CARGO (
   CONSEC               NUMBER(3,0)           not null,
   CODESPACIO           VARCHAR2(2)           not null,
   IDCARGO              VARCHAR2(2)           not null,
   CODEMPLEADO          VARCHAR2(4)           not null,
   FECHACARGO           DATE                  not null,
   FECHAFINCAR          DATE,
   constraint PK_EMPLEADO_CARGO primary key (CONSEC)
);

/*==============================================================*/
/* Index: RELATIONSHIP_23_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_23_FK on EMPLEADO_CARGO (
   CODESPACIO ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_25_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_25_FK on EMPLEADO_CARGO (
   IDCARGO ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_26_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_26_FK on EMPLEADO_CARGO (
   CODEMPLEADO ASC
);

/*==============================================================*/
/* Table: EQUIPO                                                */
/*==============================================================*/
create table EQUIPO (
   CONSEEQUIPO          NUMBER(3,0)           not null,
   IDDEPORTE            VARCHAR2(2)           not null,
   CODEMPLEADO          VARCHAR2(4)           not null,
   FECHARESOL           DATE                  not null,
   constraint PK_EQUIPO primary key (CONSEEQUIPO)
);

/*==============================================================*/
/* Index: RELATIONSHIP_3_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_3_FK on EQUIPO (
   IDDEPORTE ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_11_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_11_FK on EQUIPO (
   CODEMPLEADO ASC
);

/*==============================================================*/
/* Table: ESPACIO                                               */
/*==============================================================*/
create table ESPACIO (
   CODESPACIO           VARCHAR2(2)           not null,
   IDTIPOESPACIO        VARCHAR2(2)           not null,
   ESP_CODESPACIO       VARCHAR2(2),
   NOMESPACIO           VARCHAR2(20)          not null,
   constraint PK_ESPACIO primary key (CODESPACIO)
);

/*==============================================================*/
/* Index: RELATIONSHIP_7_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_7_FK on ESPACIO (
   IDTIPOESPACIO ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_8_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_8_FK on ESPACIO (
   ESP_CODESPACIO ASC
);

/*==============================================================*/
/* Table: ESTADO                                                */
/*==============================================================*/
create table ESTADO (
   IDESTADO             VARCHAR2(2)           not null,
   DESCESTADO           VARCHAR2(20)          not null,
   constraint PK_ESTADO primary key (IDESTADO)
);

/*==============================================================*/
/* Table: ESTUDIANTE                                            */
/*==============================================================*/
create table ESTUDIANTE (
   CODESTU              VARCHAR2(12)          not null,
   CODESPACIO           VARCHAR2(2)           not null,
   NOMESTU              VARCHAR2(30)          not null,
   APELESTU             VARCHAR2(30)          not null,
   FECHAREGESTU         DATE                  not null,
   CORREOUDESTU         VARCHAR2(30)          not null,
   FECHANACESTU         DATE                  not null,
   constraint PK_ESTUDIANTE primary key (CODESTU)
);

/*==============================================================*/
/* Index: RELATIONSHIP_24_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_24_FK on ESTUDIANTE (
   CODESPACIO ASC
);

/*==============================================================*/
/* Table: HORA                                                  */
/*==============================================================*/
create table HORA (
   IDHORA               VARCHAR2(2)           not null,
   constraint PK_HORA primary key (IDHORA)
);

/*==============================================================*/
/* Table: INSCRITOPRACLIBRE                                     */
/*==============================================================*/
create table INSCRITOPRACLIBRE (
   CONSECPRACT          NUMBER(4)             not null,
   CODEMPLEADO          VARCHAR2(4),
   CODESTU              VARCHAR2(12),
   CONSECPROGRA         NUMBER(4,0)           not null,
   constraint PK_INSCRITOPRACLIBRE primary key (CONSECPRACT, CONSECPROGRA)
);

/*==============================================================*/
/* Index: RELATIONSHIP_29_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_29_FK on INSCRITOPRACLIBRE (
   CODEMPLEADO ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_30_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_30_FK on INSCRITOPRACLIBRE (
   CODESTU ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_32_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_32_FK on INSCRITOPRACLIBRE (
   CONSECPROGRA ASC
);

/*==============================================================*/
/* Table: MARCA                                                 */
/*==============================================================*/
create table MARCA (
   IDMARCA              VARCHAR2(2)           not null,
   NOMMARCA             VARCHAR2(20)          not null,
   constraint PK_MARCA primary key (IDMARCA)
);

/*==============================================================*/
/* Table: MIEMBROEQUIPO                                         */
/*==============================================================*/
create table MIEMBROEQUIPO (
   ITEMMIEMBRO          NUMBER(3,0)           not null,
   CONSEEQUIPO          NUMBER(3,0)           not null,
   CODESTU              VARCHAR2(12)          not null,
   constraint PK_MIEMBROEQUIPO primary key (ITEMMIEMBRO, CONSEEQUIPO)
);

/*==============================================================*/
/* Index: RELATIONSHIP_2_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_2_FK on MIEMBROEQUIPO (
   CONSEEQUIPO ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_9_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_9_FK on MIEMBROEQUIPO (
   CODESTU ASC
);

/*==============================================================*/
/* Table: PERIODO                                               */
/*==============================================================*/
create table PERIODO (
   IDPERIODO            VARCHAR2(5)           not null,
   constraint PK_PERIODO primary key (IDPERIODO)
);

/*==============================================================*/
/* Table: PRESTAMO                                              */
/*==============================================================*/
create table PRESTAMO (
   CONSECPRESTAMO       NUMBER(4,0)           not null,
   CONSECELEMENTO       NUMBER(5,0)           not null,
   CONSECASISRES        NUMBER(4,0)           not null,
   CONSECRES            NUMBER(4,0)           not null,
   CONSECPROGRA         NUMBER(4,0)           not null,
   constraint PK_PRESTAMO primary key (CONSECPRESTAMO)
);

/*==============================================================*/
/* Index: RELATIONSHIP_21_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_21_FK on PRESTAMO (
   CONSECELEMENTO ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_35_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_35_FK on PRESTAMO (
   CONSECASISRES ASC,
   CONSECRES ASC,
   CONSECPROGRA ASC
);

/*==============================================================*/
/* Table: PROGRAMACION                                          */
/*==============================================================*/
create table PROGRAMACION (
   CONSECPROGRA         NUMBER(4,0)           not null,
   IDDEPORTE            VARCHAR2(2)           not null,
   CODESPACIO           VARCHAR2(2)           not null,
   IDDIA                VARCHAR2(1)           not null,
   IDHORAFIN            VARCHAR2(2)           not null,
   IDHORAINICIO         VARCHAR2(2)           not null,
   IDACTIVIDAD          VARCHAR2(2)           not null,
   IDPERIODO            VARCHAR2(5)           not null,
   CUPO                 NUMBER(3)             not null,
   NOINSCRITO           NUMBER(3),
   constraint PK_PROGRAMACION primary key (CONSECPROGRA)
);

/*==============================================================*/
/* Index: RELATIONSHIP_16_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_16_FK on PROGRAMACION (
   IDDEPORTE ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_22_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_22_FK on PROGRAMACION (
   CODESPACIO ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_36_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_36_FK on PROGRAMACION (
   IDDIA ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_37_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_37_FK on PROGRAMACION (
   IDHORAFIN ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_38_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_38_FK on PROGRAMACION (
   IDHORAINICIO ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_39_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_39_FK on PROGRAMACION (
   IDACTIVIDAD ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_40_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_40_FK on PROGRAMACION (
   IDPERIODO ASC
);

/*==============================================================*/
/* Table: RELATIONSHIP_12                                       */
/*==============================================================*/
create table RELATIONSHIP_12 (
   IDDEPORTE            VARCHAR2(2)           not null,
   IDTIPOELEMENTO       VARCHAR2(2)           not null
);

/*==============================================================*/
/* Index: RELATIONSHIP_12_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_12_FK on RELATIONSHIP_12 (
   IDDEPORTE ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_13_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_13_FK on RELATIONSHIP_12 (
   IDTIPOELEMENTO ASC
);

/*==============================================================*/
/* Table: RELATIONSHIP_13                                       */
/*==============================================================*/
create table RELATIONSHIP_13 (
   CODESPACIO           VARCHAR2(2)           not null,
   IDDEPORTE            VARCHAR2(2)           not null
);

/*==============================================================*/
/* Index: RELATIONSHIP_14_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_14_FK on RELATIONSHIP_13 (
   CODESPACIO ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_15_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_15_FK on RELATIONSHIP_13 (
   IDDEPORTE ASC
);

/*==============================================================*/
/* Table: RESPONSABLE                                           */
/*==============================================================*/
create table RESPONSABLE (
   CONSECRES            NUMBER(4,0)           not null,
   CODEMPLEADO          VARCHAR2(4)           not null,
   IDROL                VARCHAR2(1),
   CODESTU              VARCHAR2(12),
   CONSECPROGRA         NUMBER(4,0)           not null,
   FECHAINI             DATE                  not null,
   FECHAFIN             DATE                  not null,
   constraint PK_RESPONSABLE primary key (CONSECRES, CONSECPROGRA)
);

/*==============================================================*/
/* Index: RELATIONSHIP_27_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_27_FK on RESPONSABLE (
   CODEMPLEADO ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_28_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_28_FK on RESPONSABLE (
   IDROL ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_31_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_31_FK on RESPONSABLE (
   CODESTU ASC
);

/*==============================================================*/
/* Index: RELATIONSHIP_33_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_33_FK on RESPONSABLE (
   CONSECPROGRA ASC
);

/*==============================================================*/
/* Table: ROL                                                   */
/*==============================================================*/
create table ROL (
   IDROL                VARCHAR2(1)           not null,
   DESCROL              VARCHAR2(15)          not null,
   constraint PK_ROL primary key (IDROL)
);

/*==============================================================*/
/* Table: TIPOELEMENTO                                          */
/*==============================================================*/
create table TIPOELEMENTO (
   IDTIPOELEMENTO       VARCHAR2(2)           not null,
   DESCTIPOELEMENTO     VARCHAR2(40)          not null,
   constraint PK_TIPOELEMENTO primary key (IDTIPOELEMENTO)
);

/*==============================================================*/
/* Table: TIPOESPACIO                                           */
/*==============================================================*/
create table TIPOESPACIO (
   IDTIPOESPACIO        VARCHAR2(2)           not null,
   DESCTIPOESPACIO      VARCHAR2(30)          not null,
   constraint PK_TIPOESPACIO primary key (IDTIPOESPACIO)
);

alter table ASISMIEMBROEQUIPO
   add constraint FK_ASISMIEM_RELATIONS_MIEMBROE foreign key (ITEMMIEMBRO, CONSEEQUIPO)
      references MIEMBROEQUIPO (ITEMMIEMBRO, CONSEEQUIPO);

alter table ASISMIEMBROEQUIPO
   add constraint FK_ASISMIEM_RELATIONS_PROGRAMA foreign key (CONSECPROGRA)
      references PROGRAMACION (CONSECPROGRA);

alter table ASISTIRRESPONSABLE
   add constraint FK_ASISTIRR_RELATIONS_RESPONSA foreign key (CONSECRES, CONSECPROGRA)
      references RESPONSABLE (CONSECRES, CONSECPROGRA);

alter table ELEMENDEPORTIVO
   add constraint FK_ELEMENDE_RELATIONS_TIPOELEM foreign key (IDTIPOELEMENTO)
      references TIPOELEMENTO (IDTIPOELEMENTO);

alter table ELEMENDEPORTIVO
   add constraint FK_ELEMENDE_RELATIONS_ESTADO foreign key (IDESTADO)
      references ESTADO (IDESTADO);

alter table ELEMENDEPORTIVO
   add constraint FK_ELEMENDE_RELATIONS_MARCA foreign key (IDMARCA)
      references MARCA (IDMARCA);

alter table ELEMENDEPORTIVO
   add constraint FK_ELEMENDE_RELATIONS_ESPACIO foreign key (CODESPACIO)
      references ESPACIO (CODESPACIO);

alter table EMPLEADO_CARGO
   add constraint FK_EMPLEADO_RELATIONS_ESPACIO foreign key (CODESPACIO)
      references ESPACIO (CODESPACIO);

alter table EMPLEADO_CARGO
   add constraint FK_EMPLEADO_RELATIONS_CARGO foreign key (IDCARGO)
      references CARGO (IDCARGO);

alter table EMPLEADO_CARGO
   add constraint FK_EMPLEADO_RELATIONS_EMPLEADO foreign key (CODEMPLEADO)
      references EMPLEADO (CODEMPLEADO);

alter table EQUIPO
   add constraint FK_EQUIPO_RELATIONS_EMPLEADO foreign key (CODEMPLEADO)
      references EMPLEADO (CODEMPLEADO);

alter table EQUIPO
   add constraint FK_EQUIPO_RELATIONS_DEPORTE foreign key (IDDEPORTE)
      references DEPORTE (IDDEPORTE);

alter table ESPACIO
   add constraint FK_ESPACIO_RELATIONS_TIPOESPA foreign key (IDTIPOESPACIO)
      references TIPOESPACIO (IDTIPOESPACIO);

alter table ESPACIO
   add constraint FK_ESPACIO_RELATIONS_ESPACIO foreign key (ESP_CODESPACIO)
      references ESPACIO (CODESPACIO);

alter table ESTUDIANTE
   add constraint FK_ESTUDIAN_RELATIONS_ESPACIO foreign key (CODESPACIO)
      references ESPACIO (CODESPACIO);

alter table INSCRITOPRACLIBRE
   add constraint FK_INSCRITO_RELATIONS_EMPLEADO foreign key (CODEMPLEADO)
      references EMPLEADO (CODEMPLEADO);

alter table INSCRITOPRACLIBRE
   add constraint FK_INSCRITO_RELATIONS_ESTUDIAN foreign key (CODESTU)
      references ESTUDIANTE (CODESTU);

alter table INSCRITOPRACLIBRE
   add constraint FK_INSCRITO_RELATIONS_PROGRAMA foreign key (CONSECPROGRA)
      references PROGRAMACION (CONSECPROGRA);

alter table MIEMBROEQUIPO
   add constraint FK_MIEMBROE_RELATIONS_EQUIPO foreign key (CONSEEQUIPO)
      references EQUIPO (CONSEEQUIPO);

alter table MIEMBROEQUIPO
   add constraint FK_MIEMBROE_RELATIONS_ESTUDIAN foreign key (CODESTU)
      references ESTUDIANTE (CODESTU);

alter table PRESTAMO
   add constraint FK_PRESTAMO_RELATIONS_ELEMENDE foreign key (CONSECELEMENTO)
      references ELEMENDEPORTIVO (CONSECELEMENTO);

alter table PRESTAMO
   add constraint FK_PRESTAMO_RELATIONS_ASISTIRR foreign key (CONSECASISRES, CONSECRES, CONSECPROGRA)
      references ASISTIRRESPONSABLE (CONSECASISRES, CONSECRES, CONSECPROGRA);

alter table PROGRAMACION
   add constraint FK_PROGRAMA_HORAFIN_HORA foreign key (IDHORAINICIO)
      references HORA (IDHORA);

alter table PROGRAMACION
   add constraint FK_PROGRAMA_HORAINICI_HORA foreign key (IDHORAFIN)
      references HORA (IDHORA);

alter table PROGRAMACION
   add constraint FK_PROGRAMA_RELATIONS_DEPORTE foreign key (IDDEPORTE)
      references DEPORTE (IDDEPORTE);

alter table PROGRAMACION
   add constraint FK_PROGRAMA_RELATIONS_ESPACIO foreign key (CODESPACIO)
      references ESPACIO (CODESPACIO);

alter table PROGRAMACION
   add constraint FK_PROGRAMA_RELATIONS_DIA foreign key (IDDIA)
      references DIA (IDDIA);

alter table PROGRAMACION
   add constraint FK_PROGRAMA_RELATIONS_ACTIVIDA foreign key (IDACTIVIDAD)
      references ACTIVIDAD (IDACTIVIDAD);

alter table PROGRAMACION
   add constraint FK_PROGRAMA_RELATIONS_PERIODO foreign key (IDPERIODO)
      references PERIODO (IDPERIODO);

alter table RELATIONSHIP_12
   add constraint FK_RELATION_DEPORTEES_DEPORTE foreign key (IDDEPORTE)
      references DEPORTE (IDDEPORTE);

alter table RELATIONSHIP_12
   add constraint FK_RELATION_RELATIONS_TIPOELEM foreign key (IDTIPOELEMENTO)
      references TIPOELEMENTO (IDTIPOELEMENTO);

alter table RELATIONSHIP_13
   add constraint FK_RELATION_RELATIONS_ESPACIO foreign key (CODESPACIO)
      references ESPACIO (CODESPACIO);

alter table RELATIONSHIP_13
   add constraint FK_RELATION_RELATIONS_DEPORTE foreign key (IDDEPORTE)
      references DEPORTE (IDDEPORTE);

alter table RESPONSABLE
   add constraint FK_RESPONSA_RELATIONS_EMPLEADO foreign key (CODEMPLEADO)
      references EMPLEADO (CODEMPLEADO);

alter table RESPONSABLE
   add constraint FK_RESPONSA_RELATIONS_ROL foreign key (IDROL)
      references ROL (IDROL);

alter table RESPONSABLE
   add constraint FK_RESPONSA_RELATIONS_ESTUDIAN foreign key (CODESTU)
      references ESTUDIANTE (CODESTU);

alter table RESPONSABLE
   add constraint FK_RESPONSA_RELATIONS_PROGRAMA foreign key (CONSECPROGRA)
      references PROGRAMACION (CONSECPROGRA);

