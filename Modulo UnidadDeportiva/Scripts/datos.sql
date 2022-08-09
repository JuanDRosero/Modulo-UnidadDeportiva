insert into tipoespacio (idtipoespacio, desctipoespacio) values ('1', 'unidad');
insert into tipoespacio (idtipoespacio, desctipoespacio) values ('2', 'sede');
insert into tipoespacio (idtipoespacio, desctipoespacio) values ('3', 'campo');
insert into tipoespacio (idtipoespacio, desctipoespacio) values ('4', 'pista');
insert into tipoespacio (idtipoespacio, desctipoespacio) values ('5', 'salon');
insert into tipoespacio (idtipoespacio, desctipoespacio) values ('6', 'piscina');
insert into tipoespacio (idtipoespacio, desctipoespacio) values ('7', 'sala maquinas');
insert into tipoespacio (idtipoespacio, desctipoespacio) values ('8', 'muro escalar');


insert into deporte (iddeporte, nomdeporte) values ('1', 'atletismo');
insert into deporte (iddeporte, nomdeporte) values ('2', 'tenis');
insert into deporte (iddeporte, nomdeporte) values ('3', 'tenis de mesa');
insert into deporte (iddeporte, nomdeporte) values ('4', 'natacion');
insert into deporte (iddeporte, nomdeporte) values ('5', 'voleivol');
insert into deporte (iddeporte, nomdeporte) values ('6', 'futbol');
insert into deporte (iddeporte, nomdeporte) values ('7', 'futbol sala');
insert into deporte (iddeporte, nomdeporte) values ('8', 'badminton');
insert into deporte (iddeporte, nomdeporte) values ('9', 'aerobicos');
insert into deporte (iddeporte, nomdeporte) values ('10', 'boxeo');
insert into deporte (iddeporte, nomdeporte) values ('11', 'artes marciales');
insert into deporte (iddeporte, nomdeporte) values ('12', 'gimnasia olimpica');
insert into deporte (iddeporte, nomdeporte) values ('13', 'baloncesto');


insert into estado (idestado, descestado) values ('1', 'activo');
insert into estado (idestado, descestado) values ('2', 'pretado');
insert into estado (idestado, descestado) values ('3', 'dañado');
insert into estado (idestado, descestado) values ('4', 'perdido');
insert into estado (idestado, descestado) values ('5', 'de baja');


insert into periodo (idperiodo) values ('20191');
insert into periodo (idperiodo) values ('20192');
insert into periodo (idperiodo) values ('20193');
insert into periodo (idperiodo) values ('20201');
insert into periodo (idperiodo) values ('20202');
insert into periodo (idperiodo) values ('20203');
insert into periodo (idperiodo) values ('20211');
insert into periodo (idperiodo) values ('20212');
insert into periodo (idperiodo) values ('20213');
insert into periodo (idperiodo) values ('20221');


insert into tipoelemento (idtipoelemento, desctipoelemento) values ('1', 'balon baloncesto');
insert into tipoelemento (idtipoelemento, desctipoelemento) values ('2', 'balon futbol');
insert into tipoelemento (idtipoelemento, desctipoelemento) values ('3', 'balon voleibol');
insert into tipoelemento (idtipoelemento, desctipoelemento) values ('4', 'pelota tenis mesa');
insert into tipoelemento (idtipoelemento, desctipoelemento) values ('5', 'pelota tenis campo');
insert into tipoelemento (idtipoelemento, desctipoelemento) values ('6', 'colchoneta');
insert into tipoelemento (idtipoelemento, desctipoelemento) values ('7', 'lazo salto');
insert into tipoelemento (idtipoelemento, desctipoelemento) values ('8', 'guantes box');
insert into tipoelemento (idtipoelemento, desctipoelemento) values ('9', 'malla voleibol');
insert into tipoelemento (idtipoelemento, desctipoelemento) values ('10', 'saco boxeo');
insert into tipoelemento (idtipoelemento, desctipoelemento) values ('11', 'aros hula-hula');
insert into tipoelemento (idtipoelemento, desctipoelemento) values ('12', 'chaleco boxeo');
insert into tipoelemento (idtipoelemento, desctipoelemento) values ('13', 'malla pimpon');


insert into actividad (idactividad, descactividad) values ('cu', 'curso');
insert into actividad (idactividad, descactividad) values ('pr', 'practica');
insert into actividad (idactividad, descactividad) values ('en', 'entrenamiento');


insert into hora (idhora) values ('6');
insert into hora (idhora) values ('7');
insert into hora (idhora) values ('8');
insert into hora (idhora) values ('9');
insert into hora (idhora) values ('10');
insert into hora (idhora) values ('11');
insert into hora (idhora) values ('12');
insert into hora (idhora) values ('13');
insert into hora (idhora) values ('14');
insert into hora (idhora) values ('15');
insert into hora (idhora) values ('16');
insert into hora (idhora) values ('17');
insert into hora (idhora) values ('18');
insert into hora (idhora) values ('19');
insert into hora (idhora) values ('20');
insert into hora (idhora) values ('21');
insert into hora (idhora) values ('22');


insert into marca (idmarca, nommarca) values ('1', 'nike');
insert into marca (idmarca, nommarca) values ('2', 'adidas');
insert into marca (idmarca, nommarca) values ('3', 'puma');
insert into marca (idmarca, nommarca) values ('4', 'reebok');
insert into marca (idmarca, nommarca) values ('5', 'fila');
insert into marca (idmarca, nommarca) values ('6', 'asics');
insert into marca (idmarca, nommarca) values ('7', 'kappa');
insert into marca (idmarca, nommarca) values ('8', 'the north face');
insert into marca (idmarca, nommarca) values ('9', 'under armour');
insert into marca (idmarca, nommarca) values ('10', 'under armour');
insert into marca (idmarca, nommarca) values ('11', 'converse');
insert into marca (idmarca, nommarca) values ('12', 'ti colombia');


insert into rol (idrol, descrol) values ('1', 'director');
insert into rol (idrol, descrol) values ('2', 'docente');
insert into rol (idrol, descrol) values ('3', 'entrenador');


insert into cargo (idcargo, descargo) values ('1', 'auxiliar');
insert into cargo (idcargo, descargo) values ('2', 'docente');
insert into cargo (idcargo, descargo) values ('3', 'director deportivo');
insert into cargo (idcargo, descargo) values ('4', 'admin deportivo');
insert into cargo (idcargo, descargo) values ('5', 'fisioterapeuta');
insert into cargo (idcargo, descargo) values ('6', 'entrenador');


insert into empleado (codempleado, nomempleado, apellempleado, fecharegistro, correoud) values ('0000', 'yeimer', 'serrano', to_date('2019-02-04', 'yyyy-mm-dd'), 'yeserrano@ud.com');
insert into empleado (codempleado, nomempleado, apellempleado, fecharegistro, correoud) values ('0001', 'juan', 'rosero', to_date('2019-02-18', 'yyyy-mm-dd'), 'jrosero@ud.com');
insert into empleado (codempleado, nomempleado, apellempleado, fecharegistro, correoud) values ('0010', 'santiago', 'gordillo', to_date('2019-08-05', 'yyyy-mm-dd'), 'sgordillo@ud.com');
insert into empleado (codempleado, nomempleado, apellempleado, fecharegistro, correoud) values ('0100', 'david', 'armando', to_date('2019-08-26', 'yyyy-mm-dd'), 'darmando@ud.com');
insert into empleado (codempleado, nomempleado, apellempleado, fecharegistro, correoud) values ('1000', 'jose', 'quintero', to_date('2020-02-10', 'yyyy-mm-dd'), 'jquintero@ud.com');
insert into empleado (codempleado, nomempleado, apellempleado, fecharegistro, correoud) values ('1001', 'camilo', 'martinez', to_date('2020-08-12', 'yyyy-mm-dd'), 'cmartinez@ud.com');
insert into empleado (codempleado, nomempleado, apellempleado, fecharegistro, correoud) values ('1010', 'david', 'torres', to_date('2020-10-15', 'yyyy-mm-dd'), 'dtorres@ud.com');
insert into empleado (codempleado, nomempleado, apellempleado, fecharegistro, correoud) values ('1100', 'julieth', 'mora', to_date('2021-08-24', 'yyyy-mm-dd'), 'jmora@ud.com');
insert into empleado (codempleado, nomempleado, apellempleado, fecharegistro, correoud) values ('1101', 'camilo', 'rey', to_date('2021-08-24', 'yyyy-mm-dd'), 'crey@ud.com');
insert into empleado (codempleado, nomempleado, apellempleado, fecharegistro, correoud) values ('1110', 'sebastian', 'sanchez', to_date('2021-08-24', 'yyyy-mm-dd'), 'ssanchez@ud.com');


insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('01', '1', '01', 'deporte');
insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('02', '2', '02', 'la maca');
insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('03', '2', '03', 'la 40');
insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('04', '2', '04', 'la tecno');
insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('05', '3', '05', 'parque nacional');
insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('06', '4', '06', 'atletismo');
insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('07', '6', '07', 'laguito');
insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('08', '5', '08', '202');
insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('09', '5', '09', '203');
insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('10', '5', '10', '204');
insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('11', '5', '11', '302');
insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('12', '5', '12', '303');
insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('13', '5', '13', '304');
insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('14', '5', '14', '501');
insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('15', '5', '15', '701');
insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('16', '5', '16', '702');
insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('17', '5', '17', '703');
insert into espacio (codespacio, idtipoespacio, esp_codespacio, nomespacio) values ('18', '7', '18', 'gym');


insert into empleado_cargo (consec, codespacio, idcargo, codempleado, fechacargo, fechafincar) values ('1', '01', '3', '0000', to_date('2019-02-11', 'yyyy-mm-dd'), to_date('2019-02-12', 'yyyy-mm-dd'));
insert into empleado_cargo (consec, codespacio, idcargo, codempleado, fechacargo, fechafincar) values ('2', '01', '3', '0000', to_date('2019-02-25', 'yyyy-mm-dd'), to_date('2019-02-26', 'yyyy-mm-dd'));
insert into empleado_cargo (consec, codespacio, idcargo, codempleado, fechacargo, fechafincar) values ('3', '08', '2', '0001', to_date('2019-02-19', 'yyyy-mm-dd'), to_date('2019-08-20', 'yyyy-mm-dd'));
insert into empleado_cargo (consec, codespacio, idcargo, codempleado, fechacargo, fechafincar) values ('4', '09', '2', '0010', to_date('2019-08-05', 'yyyy-mm-dd'), to_date('2019-08-06', 'yyyy-mm-dd'));
insert into empleado_cargo (consec, codespacio, idcargo, codempleado, fechacargo, fechafincar) values ('5', '10', '2', '0100', to_date('2019-08-27', 'yyyy-mm-dd'), to_date('2019-08-28', 'yyyy-mm-dd'));
insert into empleado_cargo (consec, codespacio, idcargo, codempleado, fechacargo, fechafincar) values ('6', '11', '2', '1000', to_date('2020-02-11', 'yyyy-mm-dd'), to_date('2020-02-12', 'yyyy-mm-dd'));
insert into empleado_cargo (consec, codespacio, idcargo, codempleado, fechacargo, fechafincar) values ('7', '04', '1', '1001', to_date('2020-08-13', 'yyyy-mm-dd'), to_date('2020-08-13', 'yyyy-mm-dd'));
insert into empleado_cargo (consec, codespacio, idcargo, codempleado, fechacargo, fechafincar) values ('8', '05', '1', '1010', to_date('2020-10-16', 'yyyy-mm-dd'), to_date('2020-10-16', 'yyyy-mm-dd'));
insert into empleado_cargo (consec, codespacio, idcargo, codempleado, fechacargo, fechafincar) values ('9', '06', '6', '1100', to_date('2021-08-25', 'yyyy-mm-dd'), to_date('2021-08-25', 'yyyy-mm-dd'));
insert into empleado_cargo (consec, codespacio, idcargo, codempleado, fechacargo, fechafincar) values ('10', '18', '6', '1101', to_date('2021-08-26', 'yyyy-mm-dd'), to_date('2021-08-27', 'yyyy-mm-dd'));
insert into empleado_cargo (consec, codespacio, idcargo, codempleado, fechacargo, fechafincar) values ('11', '18', '6', '1110', to_date('2021-08-27', 'yyyy-mm-dd'), to_date('2021-08-28', 'yyyy-mm-dd'));


insert into equipo (conseequipo, iddeporte, codempleado, fecharesol) values ('001', '1', '0001', to_date('2019-02-28', 'yyyy-mm-dd'));
insert into equipo (conseequipo, iddeporte, codempleado, fecharesol) values ('002', '3', '0010', to_date('2019-08-26', 'yyyy-mm-dd'));
insert into equipo (conseequipo, iddeporte, codempleado, fecharesol) values ('003', '4', '0100', to_date('2020-03-09', 'yyyy-mm-dd'));
insert into equipo (conseequipo, iddeporte, codempleado, fecharesol) values ('004', '5', '1000', to_date('2020-03-11', 'yyyy-mm-dd'));
insert into equipo (conseequipo, iddeporte, codempleado, fecharesol) values ('005', '6', '1010', to_date('2021-02-02', 'yyyy-mm-dd'));
insert into equipo (conseequipo, iddeporte, codempleado, fecharesol) values ('006', '7', '0010', to_date('2019-11-14', 'yyyy-mm-dd'));
insert into equipo (conseequipo, iddeporte, codempleado, fecharesol) values ('007', '9', '1100', to_date('2022-02-14', 'yyyy-mm-dd'));
insert into equipo (conseequipo, iddeporte, codempleado, fecharesol) values ('008', '10', '0100', to_date('2020-07-07', 'yyyy-mm-dd'));
insert into equipo (conseequipo, iddeporte, codempleado, fecharesol) values ('009', '11', '1100', to_date('2022-05-30', 'yyyy-mm-dd'));
insert into equipo (conseequipo, iddeporte, codempleado, fecharesol) values ('010', '12', '0001', to_date('2019-06-19', 'yyyy-mm-dd'));


insert into dia (iddia, nomdia) values ('l','lunes');
insert into dia (iddia, nomdia) values ('m','martes');
insert into dia (iddia, nomdia) values ('w','miercoles');
insert into dia (iddia, nomdia) values ('j','jueves');
insert into dia (iddia, nomdia) values ('v','viernes');


insert into programacion (consecprogra, iddeporte, codespacio, iddia, idhorafin, idhorainicio, idactividad, idperiodo, cupo, noinscrito) values ('1','1','06','l','8','6','cu','20191','10','10');
insert into programacion (consecprogra, iddeporte, codespacio, iddia, idhorafin, idhorainicio, idactividad, idperiodo, cupo, noinscrito) values ('2','3','04','m','10','12','cu','20191','2','2');
insert into programacion (consecprogra, iddeporte, codespacio, iddia, idhorafin, idhorainicio, idactividad, idperiodo, cupo, noinscrito) values ('3','10','02','w','14','12','cu','20192','15','10');
insert into programacion (consecprogra, iddeporte, codespacio, iddia, idhorafin, idhorainicio, idactividad, idperiodo, cupo, noinscrito) values ('4','7','05','j','18','12','cu','20193','40','25');
insert into programacion (consecprogra, iddeporte, codespacio, iddia, idhorafin, idhorainicio, idactividad, idperiodo, cupo, noinscrito) values ('5','8','08','l','14','12','en','20193','25','15');
insert into programacion (consecprogra, iddeporte, codespacio, iddia, idhorafin, idhorainicio, idactividad, idperiodo, cupo, noinscrito) values ('6','11','09','v','10','12','en','20201','30','10');
insert into programacion (consecprogra, iddeporte, codespacio, iddia, idhorafin, idhorainicio, idactividad, idperiodo, cupo, noinscrito) values ('7','12','10','v','10','12','en','20201','25','10');
insert into programacion (consecprogra, iddeporte, codespacio, iddia, idhorafin, idhorainicio, idactividad, idperiodo, cupo, noinscrito) values ('8','5','11','l','14','12','en','20201','30','10');
insert into programacion (consecprogra, iddeporte, codespacio, iddia, idhorafin, idhorainicio, idactividad, idperiodo, cupo, noinscrito) values ('9','6','05','l','12','10','pr','20202','30','30');
insert into programacion (consecprogra, iddeporte, codespacio, iddia, idhorafin, idhorainicio, idactividad, idperiodo, cupo, noinscrito) values ('10','10','05','j','12','10','pr','20203','30','25');
insert into programacion (consecprogra, iddeporte, codespacio, iddia, idhorafin, idhorainicio, idactividad, idperiodo, cupo, noinscrito) values ('11','5','02','l','16','12','pr','20211','20','20');
insert into programacion (consecprogra, iddeporte, codespacio, iddia, idhorafin, idhorainicio, idactividad, idperiodo, cupo, noinscrito) values ('12','3','04','v','18','14','pr','20211','20','18');


insert into elemendeportivo (consecelemento, idtipoelemento, idestado, idmarca, codespacio, fecharegistro) values ('1','1','1','1','02',to_date('2019-03-01', 'yyyy-mm-dd'));
insert into elemendeportivo (consecelemento, idtipoelemento, idestado, idmarca, codespacio, fecharegistro) values ('2','2','1','2','02',to_date('2019-03-15', 'yyyy-mm-dd'));
insert into elemendeportivo (consecelemento, idtipoelemento, idestado, idmarca, codespacio, fecharegistro) values ('3','3','1','3','02',to_date('2019-04-28', 'yyyy-mm-dd'));
insert into elemendeportivo (consecelemento, idtipoelemento, idestado, idmarca, codespacio, fecharegistro) values ('4','4','1','4','05',to_date('2019-05-05', 'yyyy-mm-dd'));
insert into elemendeportivo (consecelemento, idtipoelemento, idestado, idmarca, codespacio, fecharegistro) values ('5','5','1','5','05',to_date('2019-02-28', 'yyyy-mm-dd'));
insert into elemendeportivo (consecelemento, idtipoelemento, idestado, idmarca, codespacio, fecharegistro) values ('6','6','1','6','02',to_date('2020-02-15', 'yyyy-mm-dd'));
insert into elemendeportivo (consecelemento, idtipoelemento, idestado, idmarca, codespacio, fecharegistro) values ('7','7','1','7','05',to_date('2020-03-01', 'yyyy-mm-dd'));
insert into elemendeportivo (consecelemento, idtipoelemento, idestado, idmarca, codespacio, fecharegistro) values ('8','8','1','8','05',to_date('2021-08-28', 'yyyy-mm-dd'));
insert into elemendeportivo (consecelemento, idtipoelemento, idestado, idmarca, codespacio, fecharegistro) values ('9','9','1','9','02',to_date('2021-10-02', 'yyyy-mm-dd'));
insert into elemendeportivo (consecelemento, idtipoelemento, idestado, idmarca, codespacio, fecharegistro) values ('10','10','1','10','05',to_date('2022-02-28', 'yyyy-mm-dd'));
insert into elemendeportivo (consecelemento, idtipoelemento, idestado, idmarca, codespacio, fecharegistro) values ('11','11','1','11','05',to_date('2022-06-06', 'yyyy-mm-dd'));
insert into elemendeportivo (consecelemento, idtipoelemento, idestado, idmarca, codespacio, fecharegistro) values ('12','12','1','12','05',to_date('2022-07-06', 'yyyy-mm-dd'));
insert into elemendeportivo (consecelemento, idtipoelemento, idestado, idmarca, codespacio, fecharegistro) values ('13','13','1','1','05',to_date('2022-08-06', 'yyyy-mm-dd'));

insert into relationship_12 (iddeporte, idtipoelemento) values ('1','6');
insert into relationship_12 (iddeporte, idtipoelemento) values ('2','5');
insert into relationship_12 (iddeporte, idtipoelemento) values ('3','4');
insert into relationship_12 (iddeporte, idtipoelemento) values ('3','13');
insert into relationship_12 (iddeporte, idtipoelemento) values ('5','3');
insert into relationship_12 (iddeporte, idtipoelemento) values ('5','9');
insert into relationship_12 (iddeporte, idtipoelemento) values ('6','2');
insert into relationship_12 (iddeporte, idtipoelemento) values ('10','8');
insert into relationship_12 (iddeporte, idtipoelemento) values ('10','10');
insert into relationship_12 (iddeporte, idtipoelemento) values ('10','12');
insert into relationship_12 (iddeporte, idtipoelemento) values ('12','11');
insert into relationship_12 (iddeporte, idtipoelemento) values ('12','7');
insert into relationship_12 (iddeporte, idtipoelemento) values ('13','1');

insert into relationship_13 (codespacio, iddeporte) values ('06','1');
insert into relationship_13 (codespacio, iddeporte) values ('05','9');
insert into relationship_13 (codespacio, iddeporte) values ('02','11');
insert into relationship_13 (codespacio, iddeporte) values ('05','2');
insert into relationship_13 (codespacio, iddeporte) values ('03','3');
insert into relationship_13 (codespacio, iddeporte) values ('07','4');
insert into relationship_13 (codespacio, iddeporte) values ('05','5');
insert into relationship_13 (codespacio, iddeporte) values ('05','6');
insert into relationship_13 (codespacio, iddeporte) values ('04','7');
insert into relationship_13 (codespacio, iddeporte) values ('02','8');
insert into relationship_13 (codespacio, iddeporte) values ('18','10');
insert into relationship_13 (codespacio, iddeporte) values ('06','12');
insert into relationship_13 (codespacio, iddeporte) values ('05','13');

insert into estudiante (codestu, codespacio, nomestu, apelestu, fecharegestu, correoudestu, fechanacestu) values ('20181020001', '02', 'laura', 'romero', to_date('2019-01-11', 'yyyy-mm-dd'), 'lromero@ud.com', to_date('2000-01-11', 'yyyy-mm-dd'));
insert into estudiante (codestu, codespacio, nomestu, apelestu, fecharegestu, correoudestu, fechanacestu) values ('20181020002', '02', 'diego', 'diaz', to_date('2019-02-12', 'yyyy-mm-dd'), 'ddiaz@ud.com', to_date('2000-02-12', 'yyyy-mm-dd'));
insert into estudiante (codestu, codespacio, nomestu, apelestu, fecharegestu, correoudestu, fechanacestu) values ('20181020003', '02', 'juan', 'perez', to_date('2019-03-13', 'yyyy-mm-dd'), 'jperez@ud.com', to_date('2000-03-13', 'yyyy-mm-dd'));
insert into estudiante (codestu, codespacio, nomestu, apelestu, fecharegestu, correoudestu, fechanacestu) values ('20181020004', '03', 'andres', 'rodriguez', to_date('2019-04-14', 'yyyy-mm-dd'), 'arodriguez@ud.com', to_date('2001-04-14', 'yyyy-mm-dd'));
insert into estudiante (codestu, codespacio, nomestu, apelestu, fecharegestu, correoudestu, fechanacestu) values ('20181020005', '03', 'julian', 'gonzales', to_date('2019-05-15', 'yyyy-mm-dd'), 'jgonzales@ud.com', to_date('2001-05-15', 'yyyy-mm-dd'));
insert into estudiante (codestu, codespacio, nomestu, apelestu, fecharegestu, correoudestu, fechanacestu) values ('20181020006', '03', 'valeria', 'montenegro', to_date('2019-06-16', 'yyyy-mm-dd'), 'vmontenegro@ud.com', to_date('2001-06-16', 'yyyy-mm-dd'));
insert into estudiante (codestu, codespacio, nomestu, apelestu, fecharegestu, correoudestu, fechanacestu) values ('20181020007', '04', 'sofia', 'castillo', to_date('2019-07-17', 'yyyy-mm-dd'), 'scastillo@ud.com', to_date('2002-07-17', 'yyyy-mm-dd'));
insert into estudiante (codestu, codespacio, nomestu, apelestu, fecharegestu, correoudestu, fechanacestu) values ('20181020008', '04', 'lina', 'torres', to_date('2019-08-18', 'yyyy-mm-dd'), 'ltorres@ud.com', to_date('2002-08-18', 'yyyy-mm-dd'));
insert into estudiante (codestu, codespacio, nomestu, apelestu, fecharegestu, correoudestu, fechanacestu) values ('20181020009', '04', 'luis', 'galindo', to_date('2019-09-19', 'yyyy-mm-dd'), 'lgalindo@ud.com', to_date('2002-09-19', 'yyyy-mm-dd'));
insert into estudiante (codestu, codespacio, nomestu, apelestu, fecharegestu, correoudestu, fechanacestu) values ('20181020010', '04', 'lucia', 'acosta', to_date('2019-10-20', 'yyyy-mm-dd'), 'lacosta@ud.com', to_date('2002-10-20', 'yyyy-mm-dd'));

insert into miembroequipo (itemmiembro, conseequipo, codestu) values ('100', '001', '20181020001');
insert into miembroequipo (itemmiembro, conseequipo, codestu) values ('101', '001', '20181020002');
insert into miembroequipo (itemmiembro, conseequipo, codestu) values ('102', '001', '20181020003');
insert into miembroequipo (itemmiembro, conseequipo, codestu) values ('103', '002', '20181020004');
insert into miembroequipo (itemmiembro, conseequipo, codestu) values ('104', '002', '20181020005');
insert into miembroequipo (itemmiembro, conseequipo, codestu) values ('105', '002', '20181020006');
insert into miembroequipo (itemmiembro, conseequipo, codestu) values ('106', '003', '20181020007');
insert into miembroequipo (itemmiembro, conseequipo, codestu) values ('107', '003', '20181020008');
insert into miembroequipo (itemmiembro, conseequipo, codestu) values ('108', '003', '20181020009');
insert into miembroequipo (itemmiembro, conseequipo, codestu) values ('109', '003', '20181020010');

insert into asismiembroequipo (conmiemequipo, itemmiembro, conseequipo, consecprogra) values ('200', '100', '001', '1');
insert into asismiembroequipo (conmiemequipo, itemmiembro, conseequipo, consecprogra) values ('201', '101', '001', '1');
insert into asismiembroequipo (conmiemequipo, itemmiembro, conseequipo, consecprogra) values ('202', '102', '001', '1');
insert into asismiembroequipo (conmiemequipo, itemmiembro, conseequipo, consecprogra) values ('203', '103', '002', '2');
insert into asismiembroequipo (conmiemequipo, itemmiembro, conseequipo, consecprogra) values ('204', '104', '002', '2');
insert into asismiembroequipo (conmiemequipo, itemmiembro, conseequipo, consecprogra) values ('205', '105', '002', '2');
insert into asismiembroequipo (conmiemequipo, itemmiembro, conseequipo, consecprogra) values ('206', '106', '003', '3');
insert into asismiembroequipo (conmiemequipo, itemmiembro, conseequipo, consecprogra) values ('207', '107', '003', '3');
insert into asismiembroequipo (conmiemequipo, itemmiembro, conseequipo, consecprogra) values ('208', '108', '003', '3');
insert into asismiembroequipo (conmiemequipo, itemmiembro, conseequipo, consecprogra) values ('209', '109', '003', '3');


