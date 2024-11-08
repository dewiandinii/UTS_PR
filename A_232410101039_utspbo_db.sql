CREATE TABLE tugas(
	id SERIAL PRIMARY KEY,
	judul VARCHAR(100) NOT NULL,
	deskripsi VARCHAR(100) NOT NULL,
	deadline DATE NOT NULL
);

CREATE TABLE dataAkun(
	id SERIAL PRIMARY KEY,
	email VARCHAR(20) NOT NULL,
	password VARCHAR(8) NOT NULL
);

INSERT INTO tugas (judul, deskripsi, deadline) VALUES
('Mendata stok barang', 'Perhatikan stok barang yang <10 lusin', '2024-11-08');

select * from dataAkun
select * from tugas