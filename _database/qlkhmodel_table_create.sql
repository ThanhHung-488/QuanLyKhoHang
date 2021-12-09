CREATE TABLE hanghoa (
    mahang int(11) NOT NULL,
    tenhang varchar(200) NOT NULL,
    donvitinh varchar(50) NOT NULL,
    dongia bigint NOT NULL,
    manhomhang int(5) NOT NULL,
    PRIMARY KEY (mahang)
);

CREATE TABLE nhomhang (
    manhomhang int(5) NOT NULL,
    tennhomhang varchar(200) NOT NULL,
    ghichu varchar(500) NOT NULL,
    PRIMARY KEY (manhomhang)
);


CREATE TABLE nhanvien (
    manhanvien int(2) NOT NULL,
    tennhanvien varchar(100) NOT NULL,
    PRIMARY KEY (manhanvien)
);


CREATE TABLE phieunhapkho (
    maphieunhap int(11) NOT NULL,
    mahang int(11) NOT NULL,
    manhanvien int(2) NOT NULL,
    ngaynhap date NOT NULL,
    soluongnhap int(10) NOT NULL,
    PRIMARY KEY (maphieunhap)
);

CREATE TABLE phieuxuatkho (
    maphieuxuat int(11) NOT NULL,
    mahang int(11) NOT NULL,
    manhanvien int(2) NOT NULL,
    ngayxuat date NOT NULL,
    soluongxuat int(10) NOT NULL,
    PRIMARY KEY (maphieuxuat)
);

ALTER TABLE hanghoa ADD CONSTRAINT FK_hanghoa__manhomhang FOREIGN KEY (manhomhang) REFERENCES nhomhang(manhomhang);
ALTER TABLE phieunhapkho ADD CONSTRAINT FK_phieunhapkho__mahang FOREIGN KEY (mahang) REFERENCES hanghoa(mahang);
ALTER TABLE phieunhapkho ADD CONSTRAINT FK_phieunhapkho__manhanvien FOREIGN KEY (manhanvien) REFERENCES nhanvien(manhanvien);
ALTER TABLE phieuxuatkho ADD CONSTRAINT FK_phieuxuatkho__mahang FOREIGN KEY (mahang) REFERENCES   hanghoa(mahang);
ALTER TABLE phieuxuatkho ADD CONSTRAINT FK_phieuxuatkho__manhanvien FOREIGN KEY (manhanvien) REFERENCES nhanvien(manhanvien);