INSERT INTO personal_adapost (id_angajat, nume_angajat, functie, telefon)
VALUES 
  (personal_adapost_id_angajat.NEXTVAL, 'Marius Obreja', 'Caretaker', '9876543210');
  INSERT INTO personal_adapost (id_angajat, nume_angajat, functie, telefon)
VALUES 
  (personal_adapost_id_angajat.NEXTVAL, 'Silviu Ostafi', 'Cleaner', '1234567890');
  INSERT INTO personal_adapost (id_angajat, nume_angajat, functie, telefon)
VALUES 
  (personal_adapost_id_angajat.NEXTVAL, 'Vieriu George', 'Receptionist', '5551112233');
  INSERT INTO personal_adapost (id_angajat, nume_angajat, functie, telefon)
VALUES 
  (personal_adapost_id_angajat.NEXTVAL, 'Archip Elena', 'Caretaker', '0769696969');

INSERT INTO animale (id_animal, nume_animal, specie, varsta, sex, stare_animal, id_angajat)
VALUES 
  (animale_id_animal_seq.NEXTVAL, 'Fluffy', 'Cat', 2, 'feminin', 'healthy', 1);
  INSERT INTO animale (id_animal, nume_animal, specie, varsta, sex, stare_animal, id_angajat)
VALUES 
  (animale_id_animal_seq.NEXTVAL, 'Buddy', 'Dog', 3, 'masculin', 'playfull', 2);
  INSERT INTO animale (id_animal, nume_animal, specie, varsta, sex, stare_animal, id_angajat)
VALUES 
  (animale_id_animal_seq.NEXTVAL, 'Whiskers', 'Cat', 1, 'feminin', 'ill', 1);
  INSERT INTO animale (id_animal, nume_animal, specie, varsta, sex, stare_animal, id_angajat)
VALUES 
  (animale_id_animal_seq.NEXTVAL, 'Dixie', 'Cat', 1, 'feminin', 'naughty', 3);



INSERT INTO adoptatori (id_adoptator, nume_adoptator, adresa, telefon, id_animal)
VALUES 
  (adoptatori_id_adoptator_seq.NEXTVAL, 'John Doe', '123 Main Street', '1234567890', 1);
  INSERT INTO adoptatori (id_adoptator, nume_adoptator, adresa, telefon, id_animal)
VALUES
  (adoptatori_id_adoptator_seq.NEXTVAL, 'Jane Smith', '456 Oak Avenue', '9876543210', 2);
  INSERT INTO adoptatori (id_adoptator, nume_adoptator, adresa, telefon, id_animal)
VALUES
  (adoptatori_id_adoptator_seq.NEXTVAL, 'Alice Johnson', '789 Pine Lane', '5551112233', 3);
  INSERT INTO adoptatori (id_adoptator, nume_adoptator, adresa, telefon, id_animal)
VALUES
  (adoptatori_id_adoptator_seq.NEXTVAL, 'Dabija Antonia', '136 caminT2', '0754632507', 4);



INSERT INTO sarcini_angajati (id_sarcina, descriere_sarcina, data_alocarii, deadline, id_angajat)
VALUES 
  (sarcini_angajati_id_sarcina.NEXTVAL, 'Feeding animals', SYSDATE, SYSDATE + 7, 1);
  INSERT INTO sarcini_angajati (id_sarcina, descriere_sarcina, data_alocarii, deadline, id_angajat)
VALUES 
  (sarcini_angajati_id_sarcina.NEXTVAL, 'Medical checkups', SYSDATE, SYSDATE + 14, 2);
  INSERT INTO sarcini_angajati (id_sarcina, descriere_sarcina, data_alocarii, deadline, id_angajat)
VALUES 
  (sarcini_angajati_id_sarcina.NEXTVAL, 'Cleaning cages', SYSDATE, SYSDATE + 3, 3);
  INSERT INTO sarcini_angajati (id_sarcina, descriere_sarcina, data_alocarii, deadline, id_angajat)
VALUES 
  (sarcini_angajati_id_sarcina.NEXTVAL, 'Cleaning floors', SYSDATE, SYSDATE + 3, 4);

INSERT INTO veterinari (id_veterinar, nume_veterinar, specializare, experienta, telefon)
VALUES 
  (veterinari_id_veterinar_seq.NEXTVAL, 'Alexandrescu Adrian', 'General', '5 ani', '8765432109');
  INSERT INTO veterinari (id_veterinar, nume_veterinar, specializare, experienta, telefon)
VALUES 
  (veterinari_id_veterinar_seq.NEXTVAL, 'Hustiu Sofia', 'Surgery', '8 ani', '3210987654');
  INSERT INTO veterinari (id_veterinar, nume_veterinar, specializare, experienta, telefon)
VALUES 
  (veterinari_id_veterinar_seq.NEXTVAL, 'Botezatu Niki', 'Dentistry', '3 ani', '9876543210');
  

INSERT INTO vizite_veterinar (animale_id_animal, veterinari_id_veterinar, id_vizita, data_vizitei, diagnostic, tratament)
VALUES 
  (1, 1, vizite_veterinar_id_vizita_seq.NEXTVAL, SYSDATE, 'Routine checkup', 'None');
  INSERT INTO vizite_veterinar (animale_id_animal, veterinari_id_veterinar, id_vizita, data_vizitei, diagnostic, tratament)
VALUES 
  (2, 2, vizite_veterinar_id_vizita_seq.NEXTVAL, SYSDATE, 'Vaccination', 'None');
  INSERT INTO vizite_veterinar (animale_id_animal, veterinari_id_veterinar, id_vizita, data_vizitei, diagnostic, tratament)
VALUES 
  (3, 3, vizite_veterinar_id_vizita_seq.NEXTVAL, SYSDATE, 'Dental cleaning', 'Prescribed medication');
  

