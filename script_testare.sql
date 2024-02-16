#Operatii de Vizualizare
-- Selectarea animalelor impreuna cu informatii despre adoptator si angajat
SELECT a.id_animal, a.nume_animal, a.specie, a.varsta, a.sex, a.stare_animal, ad.nume_adoptator, pa.nume_angajat
FROM animale a
JOIN adoptatori ad ON a.id_animal = ad.id_animal
JOIN personal_adapost pa ON a.id_angajat = pa.id_angajat;

-- Vizualizarea informatiilor despre vizitele veterinare
SELECT vv.id_vizita, a.nume_animal, v.nume_veterinar, vv.data_vizitei, vv.diagnostic, vv.tratament
FROM vizite_veterinar vv
JOIN animale a ON vv.animale_id_animal = a.id_animal
JOIN veterinari v ON vv.veterinari_id_veterinar = v.id_veterinar;

-- Selectarea informatiilor despre animale si angajatii cu sarcini asignate
SELECT a.nume_animal, a.specie, pa.nume_angajat, sa.descriere_sarcina, sa.data_alocarii, sa.deadline
FROM animale a
JOIN personal_adapost pa ON a.id_angajat = pa.id_angajat
JOIN sarcini_angajati sa ON pa.id_angajat = sa.id_angajat;

#Operatii de adaugare/modificare
-- Operatii de Adaugare cu Check Constraint Violation
-- Adaugarea unui animal cu nume invalid
INSERT INTO animale (id_animal, nume_animal, specie, varsta, sex, stare_animal, id_angajat)
VALUES (animale_id_animal_seq.NEXTVAL, '123', 'Dog', 2, 'masculin', 'healthy', 2);

-- Adaugare animal cu varsta negativa (violand constrangerea de verificare)
INSERT INTO animale (id_animal, nume_animal, specie, varsta, sex, stare_animal, id_angajat)
VALUES (animale_id_animal_seq.NEXTVAL, 'Rex', 'Caine', -1, 'masculin', 'healthy', 2);

--Adaugare sarcina angajat cu o data in trecut
INSERT INTO sarcini_angajati (id_sarcina, descriere_sarcina, data_alocarii, deadline, id_angajat)
VALUES 
  (sarcini_angajati_id_sarcina.NEXTVAL, 'Feeding animals', to_date('03-11-2024', 'dd-mm-yyyy'), to_date('19-10-2012', 'dd-mm-yyyy'), 2);

-- Operatii de Modificare cu Check Constraint Violation
-- Modificarea unui animal pentru a avea varsta negativa
UPDATE animale
SET varsta = -1
WHERE id_animal = 1;

-- Actualizeaza sexul unui animal la o valoare nepermisa (violand constrangerea de verificare)
UPDATE animale
SET sex = 'altul'
WHERE id_animal = 2;

-- Actualizeaza specializarea unui veterinar cu o valoare invalida (violand constrangerea de verificare)
UPDATE veterinari
SET specializare = 'Chirurg123'
WHERE id_veterinar = 2;


-- Alte Operatii de Testare
-- Adaugarea unui adoptator cu nume si telefon duplicat (violand constraintul unique)
INSERT INTO adoptatori (id_adoptator, nume_adoptator, adresa, telefon, id_animal)
VALUES (adoptatori_id_adoptator_seq.NEXTVAL, 'Jane Smith', '456 Oak Avenue', '9876543210', 2);


-- Actualizeaza numele unui animal pentru a coincide cu numele altui animal (violand constrângerea UNIQUE)
UPDATE animale
SET nume_animal = 'Rex'
WHERE id_animal = 3;
-- Incercarea de a face aceeasi actualizare cu acelasi nume pentru un alt animal
UPDATE animale
SET nume_animal = 'Rex'
WHERE id_animal = 2;


-- Stergerea unui angajat cu sarcini asignate (violand constraintul de cheie straina)
DELETE FROM personal_adapost WHERE id_angajat = 1;


-- Adaugarea unei vizite veterinare pentru un animal si un veterinar neexistenti (violand constraintul de cheie straina)
INSERT INTO vizite_veterinar (animale_id_animal, veterinari_id_veterinar, id_vizita, data_vizitei, diagnostic, tratament)
VALUES (10, 10, vizite_veterinar_id_vizita_seq.NEXTVAL, SYSDATE, 'Examinare', 'Tratament');


-- Actualizeaza id_angajat al unui animal la o valoare care nu exista in tabela personal_adapost
UPDATE animale
SET id_angajat = 999  -- Presupunand ca 999 nu exista in tabela personal_adapost
WHERE id_animal = 3;


# Operatii de stergere
-- Stergerea unui animal si a adoptatorului asociat
delete from vizite_veterinar where animale_id_animal=1;
DELETE FROM adoptatori WHERE id_animal = 1;
DELETE FROM animale WHERE id_animal = 1;


-- Operatie de stergere a unui Angajat si Sarcinilor Asignate
delete from adoptatori where id_animal = (select id_animal from animale where id_angajat=1);
delete from vizite_veterinar where animale_id_animal = (select id_animal from animale where id_angajat=1);
delete from animale where id_angajat=1;

-- sterge toate sarcinile asignate angajatului cu id_angajat
DELETE FROM sarcini_angajati
WHERE id_angajat = 1;

-- sterge angajatul cu id_angajat specificat din personal_adapost
DELETE FROM personal_adapost
WHERE id_angajat = 1;


  
select * from animale;
select * from adoptatori;
select * from personal_adapost;
select * from sarcini_angajati;
select * from veterinari;
select * from vizite_veterinar;

delete from personal_adapost;
delete from ANIMALE;
delete from veterinari;

SELECT * FROM USER_CONSTRAINTS
WHERE TABLE_NAME = 'PERSONAL_ADAPOST' 
      OR TABLE_NAME = 'ANIMALE' 
      OR TABLE_NAME = 'ADOPTATORI' 
      OR TABLE_NAME = 'SARCINI_ANGAJATI' 
      OR TABLE_NAME = 'VETERINARI' 
      OR TABLE_NAME = 'VIZITE_VETERINAR';

DELETE FROM USER_CONSTRAINTS
WHERE TABLE_NAME = 'PERSONAL_ADAPOST' 
      OR TABLE_NAME = 'ANIMALE' 
      OR TABLE_NAME = 'ADOPTATORI' 
      OR TABLE_NAME = 'SARCINI_ANGAJATI' 
      OR TABLE_NAME = 'VETERINARI' 
      OR TABLE_NAME = 'VIZITE_VETERINAR';

drop table personal_adapost;
drop table adoptatori;
drop table animale;
drop table veterinari;
drop table vizite_veterinar;
drop table sarcini_angajati;

DROP SEQUENCE adoptatori_id_adoptator_seq;
DROP SEQUENCE animale_id_animal_seq;
DROP SEQUENCE personal_adapost_id_angajat;
DROP SEQUENCE sarcini_angajati_id_sarcina;
DROP SEQUENCE veterinari_id_veterinar_seq;
DROP SEQUENCE vizite_veterinar_id_vizita_seq;

SELECT * FROM USER_CONSTRAINTS;
SELECT * FROM USER_TABLES;
