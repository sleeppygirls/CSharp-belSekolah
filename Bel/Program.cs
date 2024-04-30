using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using Component;
using Database;
using System.Threading;

namespace Bel
{
    class Program
    {
        public static AccessDatabaseHelper DB = new AccessDatabaseHelper("./putri.accdb");

        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Bel Sekolah";

            Console.BufferWidth = 120;
            Console.WindowHeight = 34;
            Console.CursorVisible = false;

            loading();
            bg();

            //kotak
            new Kotak().SetForeColor(ConsoleColor.DarkCyan).SetXY(0, 0).SetWidthAndHeight(31, 7).Tampil();   //header 1
            new Kotak().SetForeColor(ConsoleColor.DarkGreen).SetXY(32, 0).SetWidthAndHeight(70, 7).Tampil(); //header 2
            new Kotak().SetForeColor(ConsoleColor.DarkGray).SetXY(103, 0).SetWidthAndHeight(16, 7).Tampil();  //header 3

            //new Kotak().SetForeColor(ConsoleColor.DarkYellow).SetXY(0, 0).SetWidthAndHeight(119, 4).Tampil();
            new Kotak().SetForeColor(ConsoleColor.Yellow).SetXY(0, 29).SetWidthAndHeight(119, 3).Tampil(); //footer
            new Kotak().SetForeColor(ConsoleColor.DarkMagenta).SetXY(0, 8).SetWidthAndHeight(22, 20).Tampil(); //kiri
            new Kotak().SetForeColor(ConsoleColor.DarkMagenta).SetXY(23,8).SetWidthAndHeight(96, 20).Tampil(); //kanan

            //tulisan header bag kiri
            new Tulisan().SetText("    APLIKASI BEL SEKOLAH").SetXY(2, 2).SetForeColor(ConsoleColor.DarkMagenta).SetBackColor(ConsoleColor.Cyan).Tampil();
            new Tulisan().SetText("  WEARNES EDUCATION CENTER").SetXY(2, 3).SetForeColor(ConsoleColor.DarkYellow).SetBackColor(ConsoleColor.Cyan).Tampil();
            new Tulisan().SetText("JL. THAMRIN 35 A KOTA MADIUN").SetXY(2, 4).SetForeColor(ConsoleColor.DarkRed).SetBackColor(ConsoleColor.Cyan).Tampil();
            //new Tulisan().SetText("♥ ♥ ♥ ♥ ♥ ♥ ♥♥ ♥ ♥ ♥ ♥ ♥ ♥ ♥").SetXY(2, 5).SetForeColor(ConsoleColor.Black).SetBackColor(ConsoleColor.Cyan).Tampil();

            //tulisan footer
            new Tulisan().SetText("RISA PUTRI DEVINDA SARI").SetLength(119).SetXY(0, 30).SetBackColor(ConsoleColor.DarkRed).TampilTengah();
            new Tulisan().SetText("INFORMATIKA II").SetLength(119).SetXY(0, 31).SetBackColor(ConsoleColor.DarkRed).TampilTengah();

            // logo footer kiri
            new Tulisan().SetText("▀▀▀ ▓ ▀▀▀ ▓ ▀▀▀ ▓ ▀▀▀ ▓ ▀▀▀ ▓ ▀▀▀ ▓ ▀▀▀  ▓ ▀▀▀").SetXY(1, 30).SetBackColor(ConsoleColor.DarkRed).Tampil();
            new Tulisan().SetText("   ▀▀▀   ▀▀▀   ▀▀▀   ▀▀▀   ▀▀▀   ▀▀▀    ▀▀▀").SetXY(1, 31).SetBackColor(ConsoleColor.DarkRed).Tampil();

            //logo footer kanan
            new Tulisan().SetText("▄▄▄ ▓ ▄▄▄ ▓ ▄▄▄ ▓ ▄▄▄ ▓ ▄▄▄ ▓ ▄▄▄ ▓ ▄▄▄ ▓ ▄▄▄ ▓").SetXY(72, 30).SetBackColor(ConsoleColor.DarkRed).Tampil();
            new Tulisan().SetText("   ▀▀▀   ▀▀▀   ▀▀▀   ▀▀▀   ▀▀▀   ▀▀▀   ▀▀▀   ▀▀").SetXY(72, 31).SetBackColor(ConsoleColor.DarkRed).Tampil();


            //logo tengah
            new Tulisan().SetText("").SetXY(1, 30).SetBackColor(ConsoleColor.DarkRed).Tampil();

            //new Tulisan().SetText("APLIKASI BEL SEKOLAH").SetXY(0, 1).SetLength(119).TampilTengah();
            //new Tulisan().SetText("WEARNES EDUCATION CENTER").SetXY(0, 2).SetLength(119).SetForeColor(ConsoleColor.Cyan).TampilTengah();
            //new Tulisan().SetText("JL. THAMRIN 35 A KOTA MADIUN").SetXY(0, 3).SetLength(119).SetForeColor(ConsoleColor.Magenta).TampilTengah();
            //new Tulisan().SetText("RISA PUTRI DEVINDA SARI").SetXY(0, 27).SetLength(119).SetForeColor(ConsoleColor.DarkYellow).TampilTengah();
            //new Tulisan().SetText("INFORMATIKA II").SetXY(0, 28).SetLength(119).SetForeColor(ConsoleColor.DarkGreen).TampilTengah();

            //logo header tengah
            new Tulisan("░██╗░░░░░░░██╗███████╗░█████╗░██████╗░███╗░░██╗███████╗░██████╗").SetXY(36, 1).SetBackColor(ConsoleColor.DarkGreen).Tampil();
            new Tulisan("░██║░░██╗░░██║██╔════╝██╔══██╗██╔══██╗████╗░██║██╔════╝██╔════╝").SetXY(36, 2).SetBackColor(ConsoleColor.DarkGreen).Tampil();
            new Tulisan("░╚██╗████╗██╔╝█████╗░░███████║██████╔╝██╔██╗██║█████╗░░╚█████╗░").SetXY(36, 3).SetBackColor(ConsoleColor.DarkGreen).Tampil();
            new Tulisan("░░████╔═████║░██╔══╝░░██╔══██║██╔══██╗██║╚████║██╔══╝░░░╚═══██╗").SetXY(36, 4).SetBackColor(ConsoleColor.DarkGreen).Tampil();
            new Tulisan("░░╚██╔╝░╚██╔╝░███████╗██║░░██║██║░░██║██║░╚███║███████╗██████╔╝").SetXY(36, 5).SetBackColor(ConsoleColor.DarkGreen).Tampil();
            new Tulisan("░░░╚═╝░░░╚═╝░░╚══════╝╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚══════╝╚═════╝░").SetXY(36, 6).SetBackColor(ConsoleColor.DarkGreen).Tampil();

            //logo header kanan
            new Tulisan("░▄▄▄▄░").SetXY(108, 2).SetForeColor(ConsoleColor.DarkYellow).SetBackColor(ConsoleColor.White).Tampil();
            new Tulisan("▀▀▄██►").SetXY(108, 3).SetForeColor(ConsoleColor.DarkYellow).SetBackColor(ConsoleColor.White).Tampil();
            new Tulisan("▀▀███►").SetXY(108, 4).SetForeColor(ConsoleColor.DarkYellow).SetBackColor(ConsoleColor.White).Tampil();
            new Tulisan("░▀███►░█►").SetXY(108, 5).SetForeColor(ConsoleColor.DarkYellow).SetBackColor(ConsoleColor.White).Tampil();
            new Tulisan("▒▄████▀▀").SetXY(108, 6).SetForeColor(ConsoleColor.DarkYellow).SetBackColor(ConsoleColor.White).Tampil();
            

            //logo tengah


            //menu
            media.block(1, 21, 15, 20, ConsoleColor.Red);
            Menu menu = new Menu("     ► JALANKAN ◄    ",
                                 "  ► LIHAT DATA ◄     ",
                                 "    ► TAMBAH DATA ◄  ",
                                 "  ► EDIT DATA ◄      ",
                                 "    ► HAPUS DATA ◄   ",
                                 "  ► KELUAR ◄         ");
            menu.SetXY(1, 15).SetForeColor(ConsoleColor.White).SetSelectedBackColor(ConsoleColor.DarkRed).SetBackColor(ConsoleColor.Red).
            SetSelectedForeColor(ConsoleColor.White).Tampil();

            new Tulisan("▄▀▀▀▄▄▄▄▄▀▀▀▄▄▄▄▄▀▀▀▄").SetXY(1, 9).SetForeColor(ConsoleColor.White).SetBackColor(ConsoleColor.Yellow).Tampil();
            new Tulisan("▀▄▄▄▀▀▀▀▀▄▄▄▀▀▀▀▀▄▄▄▀").SetXY(1, 10).SetForeColor(ConsoleColor.White).SetBackColor(ConsoleColor.Yellow).Tampil();
            //new Tulisan("▀   ▀▀▀▀▀   ▀▀▀▀▀   ▀").SetXY(1, 11).SetForeColor(ConsoleColor.White).SetBackColor(ConsoleColor.Yellow).Tampil();

            new Tulisan("▄▀▀▀▄▄▄▄▄▀▀▀▄▄▄▄▄▀▀▀▄").SetXY(1, 26).SetForeColor(ConsoleColor.White).SetBackColor(ConsoleColor.Yellow).Tampil();
            new Tulisan("▀▄▄▄▀▀▀▀▀▄▄▄▀▀▀▀▀▄▄▄▀").SetXY(1, 27).SetForeColor(ConsoleColor.White).SetBackColor(ConsoleColor.Yellow).Tampil();


            //arah
            bool ProgramJalan = true;
            while (ProgramJalan)
            {
                ConsoleKeyInfo tombol = Console.ReadKey(true);

                if (tombol.Key == ConsoleKey.DownArrow)
                {
                    menu.Next();
                    menu.Tampil();
                }
                else if (tombol.Key == ConsoleKey.UpArrow)
                {
                    menu.Prev();
                    menu.Tampil();
                }
                else if (tombol.Key == ConsoleKey.Enter)
                {
                    int MenuTerpilih = menu.SelectedIndex;
                    if (MenuTerpilih == 0)
                    {
                        Jalankan();
                    }
                    else if (MenuTerpilih == 1)
                    {
                        LihatData();
                    }
                    else if (MenuTerpilih == 2)
                    {
                        TambahData();
                    }
                    else if (MenuTerpilih == 3)
                    {
                        EditData();
                    }
                    else if (MenuTerpilih == 4)
                    {
                        HapusData();
                    }
                    else if (MenuTerpilih == 5)
                    {
                        ProgramJalan = false;
                    }
                }


            }
        }
        static void Jalankan()
        {
            new Clear(24, 9, 95, 18).SetBackColor(ConsoleColor.Blue).Tampil();
            media.block(24, 118, 9, 27, ConsoleColor.Blue);      //bag dalam
            media.block(24, 118, 9, 12, ConsoleColor.DarkBlue);  //judul

            new Tulisan().SetText("  █ ▄▀█ █   ▄▀█ █▄ █ █▄▀ ▄▀█ █▄ █").SetXY(27, 10).SetLength(96).SetForeColor(ConsoleColor.White).SetBackColor(ConsoleColor.DarkBlue).TampilTengah();
            new Tulisan().SetText("█▄█ █▀█ █▄▄ █▀█ █ ▀█ █ █ █▀█ █ ▀█").SetXY(27, 11).SetLength(96).SetForeColor(ConsoleColor.White).SetBackColor(ConsoleColor.DarkBlue).TampilTengah();

            Tulisan HariSekarang = new Tulisan().SetXY(38, 15);
            Tulisan JamSekarang = new Tulisan().SetXY(38, 16);

            string QSelect = "SELECT * FROM tb_jadwal WHERE hari=@hari AND jam=@jam;";

            DB.Connect();

            bool play = true;
            while (play)
            {
                DateTime sekarang = DateTime.Now;
                HariSekarang.SetText("Hari Sekarang     : " + sekarang.ToString("dddd")).SetBackColor(ConsoleColor.Blue);
                HariSekarang.Tampil();

                JamSekarang.SetText("Jam Sekarang      : " + sekarang.ToString("HH:mm:ss")).SetBackColor(ConsoleColor.Blue);
                JamSekarang.Tampil();

                DataTable DT = DB.RunQuery(QSelect,
                    new OleDbParameter("@hari", sekarang.ToString("dddd")),
                    new OleDbParameter("@jam", sekarang.ToString("HH:mm")));
                if (DT.Rows.Count > 0)
                {
                    Audio me = new Audio();
                    me.File = "./Suara/" + DT.Rows[0]["sound"];
                    me.Play();

                    new Tulisan().SetXY(23, 19).SetText("BEL TELAH BERBUNYI!!!!").SetBackColor(ConsoleColor.DarkCyan).SetLength(96).TampilTengah();
                    new Tulisan().SetXY(23, 20).SetText(DT.Rows[0]["ket"].ToString()).SetBackColor(ConsoleColor.DarkCyan).SetLength(96).TampilTengah();

                    play = false;
                    Thread.Sleep(3000);
                    new Clear(24, 9, 95, 18).SetBackColor(ConsoleColor.Blue).Tampil();

                }
                if (Console.KeyAvailable == true)
                {
                    ConsoleKeyInfo tombol = Console.ReadKey(true);
                    if (tombol.Key == ConsoleKey.Escape)
                    {
                        play = false;
                        new Clear(24, 9, 95, 12).SetBackColor(ConsoleColor.Blue).Tampil();
                    }
                }

                Thread.Sleep(1000);


            }

        }
        static void LihatData()
        {
            new Clear(24, 9, 95, 18).SetBackColor(ConsoleColor.Green).Tampil();
            media.block(24, 118, 9, 27, ConsoleColor.Green);      //bag dalam
            media.block(24, 118, 9, 12, ConsoleColor.DarkGreen);  //judul

            new Tulisan().SetText("█   █ █ █ ▄▀█ ▀█▀   █▀▄ ▄▀█ ▀█▀ ▄▀█").SetXY(23, 10).SetLength(96).SetForeColor(ConsoleColor.White).SetBackColor(ConsoleColor.DarkGreen).TampilTengah();
            new Tulisan().SetText("█▄▄ █ █▀█ █▀█  █    █▄▀ █▀█  █  █▀█").SetXY(23, 11).SetLength(96).SetForeColor(ConsoleColor.White).SetBackColor(ConsoleColor.DarkGreen).TampilTengah();

            DB.Connect();
            DataTable DT = DB.RunQuery("SELECT * FROM tb_jadwal");

            new Tulisan("┌──────┬────────────────┬───────────┬──────────────────────────────┐").SetXY(38, 14).Tampil();
            new Tulisan("│  NO  │      HARI      │    JAM    │          KETERANGAN          │").SetXY(38, 15).Tampil();
            new Tulisan("├──────┼────────────────┼───────────┼──────────────────────────────┤").SetXY(38, 16).Tampil();

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                string ID = DT.Rows[i]["id"].ToString();
                string Hari = DT.Rows[i]["hari"].ToString();
                string Jam = DT.Rows[i]["jam"].ToString();
                string Keterangan = DT.Rows[i]["ket"].ToString();

                string isi = string.Format("│{0,-6}│{1,-16}│{2,-11}│{3,-30}│", ID, Hari, Jam, Keterangan);
                new Tulisan(isi).SetXY(38, 17 + i).Tampil();
            }

            new Tulisan("└──────┴────────────────┴───────────┴──────────────────────────────┘").SetXY(38, 17 + DT.Rows.Count).Tampil();
        }
        static void TambahData()
        {
            new Clear(24, 9, 95, 18).SetBackColor(ConsoleColor.Yellow).Tampil();
            media.block(24, 118, 9, 25, ConsoleColor.Yellow);      //bag dalam
            media.block(24, 118, 9, 12, ConsoleColor.DarkYellow);  //judul

            new Tulisan().SetText("▀█▀ ▄▀█ █▀▄▀█ █▄▄ ▄▀█ █ █   █▀▄ ▄▀█ ▀█▀ ▄▀█").SetXY(23, 10).SetLength(96).SetForeColor(ConsoleColor.White).SetBackColor(ConsoleColor.DarkYellow).TampilTengah();
            new Tulisan().SetText(" █  █▀█ █ ▀ █ █▄█ █▀█ █▀█   █▄▀ █▀█  █  █▀█").SetXY(23, 11).SetLength(96).SetForeColor(ConsoleColor.White).SetBackColor(ConsoleColor.DarkYellow).TampilTengah();

            Inputan HariInput = new Inputan();
            HariInput.Text = "Masukan Hari       : ";
            HariInput.SetXY(38, 15).SetBackColor(ConsoleColor.Yellow).SetForeColor(ConsoleColor.DarkYellow);

            Inputan JamInput = new Inputan();
            JamInput.Text = "Masukan Jam        : ";
            JamInput.SetXY(38, 16).SetBackColor(ConsoleColor.Yellow).SetForeColor(ConsoleColor.DarkYellow);

            Inputan KetInput = new Inputan();
            KetInput.Text = "Masukan Keterangan : ";
            KetInput.SetXY(38, 17).SetBackColor(ConsoleColor.Yellow).SetForeColor(ConsoleColor.DarkYellow);

            Pilihan SoundInput = new Pilihan();
            SoundInput.SetPilihans(
                "5 Menit Akhir Istirahat I.wav", "5 Menit Akhir Istirahat II.wav",
                "5 Menit Akhir Kegiatan Keagamaan.wav", "5 Menit Awal Kegiatan Keagamaan.wav",
                "5 Menit Awal Upacara.wav", "Akhir Pekan 1.wav",
                "Akhir Pekan 2.wav", "Akhir Pelajaran A.wav",
                "Akhir Pelajaran B.wav", "awal jam ke 1.wav",
                "Istirahat I.wav", "Istirahat II.wav",
                "Pelajaran ke 1.wav", "Pelajaran ke 2.wav",
                "Pelajaran ke 3.wav", "Pelajaran ke 4.wav",
                "Pelajaran ke 5.wav", "Pelajaran ke 6.wav",
                "Pelajaran ke 7.wav", "Pelajaran ke 8.wav",
                "Pelajaran ke 9.wav", "pembuka.wav");

            SoundInput.Text = "Masukan Audio      : ";
            SoundInput.SetXY(38, 18).SetBackColor(ConsoleColor.Yellow).SetForeColor(ConsoleColor.DarkYellow);

            string Hari = HariInput.Read();
            string Jam = JamInput.Read();
            string Keterangan = KetInput.Read();
            string Sound = SoundInput.Read();


            DB.Connect();
            DB.RunNonQuery("INSERT INTO tb_jadwal (hari, jam, ket, sound) VALUES (@hari, @jam, @ket, @sound);",
                new OleDbParameter("@hari", Hari),
                new OleDbParameter("@jam", Jam),
                new OleDbParameter("@ket", Keterangan),
                new OleDbParameter("@sound", Sound)
                );

            DB.Disconnect();

            //new Tulisan().SetXY(23, 23).SetText("┌────────────────────────┐").SetBackColor(ConsoleColor.Yellow).SetLength(96).TampilTengah();
            //new Tulisan().SetXY(23, 24).SetText("│                        │" ).SetBackColor(ConsoleColor.Yellow).SetLength(96).TampilTengah();
            //new Tulisan().SetXY(23, 25).SetText("└────────────────────────┘").SetBackColor(ConsoleColor.Yellow).SetLength(96).TampilTengah();
            new Tulisan().SetXY(23, 24).SetText(" DATA BERHASIL DISIMPAN ").SetBackColor(ConsoleColor.Green).SetForeColor(ConsoleColor.White).SetLength(96).TampilTengah();

        }
        static void EditData()
        {
            new Clear(24, 9, 95, 18).SetBackColor(ConsoleColor.Magenta).Tampil();
            media.block(24, 118, 9, 25, ConsoleColor.Magenta);      //bag dalam
            media.block(24, 118, 9, 12, ConsoleColor.DarkMagenta);  //judul

            new Tulisan().SetText("█▀▀ █▀▄ █ ▀█▀   █▀▄ ▄▀█ ▀█▀ ▄▀█").SetXY(23, 10).SetLength(96).SetForeColor(ConsoleColor.White).SetBackColor(ConsoleColor.DarkMagenta).TampilTengah();
            new Tulisan().SetText("██▄ █▄▀ █  █    █▄▀ █▀█  █  █▀█").SetXY(23, 11).SetLength(96).SetForeColor(ConsoleColor.White).SetBackColor(ConsoleColor.DarkMagenta).TampilTengah();

            Inputan IDInput = new Inputan();
            IDInput.Text = "Masukan ID Yang Ingin Dirubah : ";
            IDInput.SetXY(38, 15).SetForeColor(ConsoleColor.Black).SetBackColor(ConsoleColor.Magenta);

            Inputan HariInput = new Inputan();
            HariInput.Text = "Masukan Hari                  : ";
            HariInput.SetXY(38, 16).SetForeColor(ConsoleColor.Black).SetBackColor(ConsoleColor.Magenta);

            Inputan JamInput = new Inputan();
            JamInput.Text = "Masukan Jam                   : ";
            JamInput.SetXY(38, 17).SetForeColor(ConsoleColor.Black).SetBackColor(ConsoleColor.Magenta);

            Inputan KetInput = new Inputan();
            KetInput.Text = "Masukan Keterangan            : ";
            KetInput.SetXY(38, 18).SetForeColor(ConsoleColor.Black).SetBackColor(ConsoleColor.Magenta);

            Pilihan SoundInput = new Pilihan();
            SoundInput.SetPilihans(
                "5 Menit Akhir Istirahat I.wav", "5 Menit Akhir Istirahat II.wav",
                "5 Menit Akhir Kegiatan Keagamaan.wav", "5 Menit Awal Kegiatan Keagamaan.wav",
                "5 Menit Awal Upacara.wav", "Akhir Pekan 1.wav",
                "Akhir Pekan 2.wav", "Akhir Pelajaran A.wav",
                "Akhir Pelajaran B.wav", "awal jam ke 1.wav",
                "Istirahat I.wav", "Istirahat II.wav",
                "Pelajaran ke 1.wav", "Pelajaran ke 2.wav",
                "Pelajaran ke 3.wav", "Pelajaran ke 4.wav",
                "Pelajaran ke 5.wav", "Pelajaran ke 6.wav",
                "Pelajaran ke 7.wav", "Pelajaran ke 8.wav",
                "Pelajaran ke 9.wav", "pembuka.wav");

            SoundInput.Text = "Masukan Audio                 : ";
            SoundInput.SetXY(38, 19).SetForeColor(ConsoleColor.Black).SetBackColor(ConsoleColor.Magenta);

            string ID = IDInput.Read();
            string Hari = HariInput.Read();
            string Jam = JamInput.Read();
            string Keterangan = KetInput.Read();
            string Sound = SoundInput.Read();

            DB.Connect();
            DB.RunNonQuery("UPDATE tb_jadwal SET hari=@hari, jam=@jam, ket=@ket, sound=@sound WHERE id=@id;",
                new OleDbParameter("@hari", Hari),
                new OleDbParameter("@jam", Jam),
                new OleDbParameter("@ket", Keterangan),
                new OleDbParameter("@sound", Sound),
                new OleDbParameter("@id", ID)
                );

            DB.Disconnect();

            //new Tulisan().SetXY(23, 23).SetText("┌────────────────────────┐").SetBackColor(ConsoleColor.DarkBlue).SetLength(96).TampilTengah();
            //new Tulisan().SetXY(23, 24).SetText("│  DATA BERHASIL DIEDIT  │").SetBackColor(ConsoleColor.DarkBlue).SetLength(96).TampilTengah();
            //new Tulisan().SetXY(23, 25).SetText("└────────────────────────┘").SetBackColor(ConsoleColor.DarkBlue).SetLength(96).TampilTengah();
            new Tulisan().SetXY(23, 24).SetText("  DATA BERHASIL DIEDIT  ").SetBackColor(ConsoleColor.DarkBlue).SetLength(96).TampilTengah();
        }
        static void HapusData()
        {

            new Clear(24, 9, 95, 18).SetBackColor(ConsoleColor.Red).Tampil();
            media.block(24, 118, 9, 25, ConsoleColor.Red);      //bag dalam
            media.block(24, 118, 9, 12, ConsoleColor.DarkRed);  //judul

            new Tulisan().SetText("█ █ ▄▀█ █▀█ █ █ █▀   █▀▄ ▄▀█ ▀█▀ ▄▀█").SetXY(23, 10).SetLength(96).SetForeColor(ConsoleColor.White).SetBackColor(ConsoleColor.DarkRed).TampilTengah();
            new Tulisan().SetText("█▀█ █▀█ █▀▀ █▄█ ▄█   █▄▀ █▀█  █  █▀█").SetXY(23, 11).SetLength(96).SetForeColor(ConsoleColor.White).SetBackColor(ConsoleColor.DarkRed).TampilTengah();

            Inputan IDInput = new Inputan();
            IDInput.Text = "Masukan ID Yang Akan Dihapus : ";
            IDInput.SetXY(38, 15).SetForeColor(ConsoleColor.Black).SetBackColor(ConsoleColor.Red);
            string ID = IDInput.Read();

            DB.Connect();
            DB.RunNonQuery("DELETE FROM tb_jadwal WHERE id=@id;", new OleDbParameter("@id", ID));

            DB.Disconnect();

            //new Tulisan().SetXY(23, 23).SetText("┌─────────────────────────┐").SetForeColor(ConsoleColor.DarkRed).SetBackColor(ConsoleColor.White).SetLength(96).TampilTengah();
            //new Tulisan().SetXY(23, 24).SetText("│  DATA BERHASIL DIHAPUS  │").SetForeColor(ConsoleColor.DarkRed).SetBackColor(ConsoleColor.White).SetLength(96).TampilTengah();
            //new Tulisan().SetXY(23, 25).SetText("└─────────────────────────┘").SetForeColor(ConsoleColor.DarkRed).SetBackColor(ConsoleColor.White).SetLength(96).TampilTengah();
            new Tulisan().SetXY(23, 24).SetText("  DATA BERHASIL DIHAPUS  ").SetForeColor(ConsoleColor.DarkRed).SetBackColor(ConsoleColor.White).SetLength(96).TampilTengah();
        }
        public static void bg()
        {
            media.block(0, 31, 0, 7, ConsoleColor.Cyan);        //header 1
            media.block(32, 101, 0, 7, ConsoleColor.Green);     //header 2
            media.block(102, 119, 0, 7, ConsoleColor.White);     //header 3
            media.block(0, 23, 8, 28, ConsoleColor.Yellow);      // kiri
            media.block(24, 119, 8, 28, ConsoleColor.Blue);     // kanan
            media.block(0, 119, 29, 32, ConsoleColor.DarkRed);  // footer        
        }
        public static void loading()
        {
            new Clear(1, 1, 119, 31).SetBackColor(ConsoleColor.Cyan).Tampil();
            new Kotak().SetForeColor(ConsoleColor.DarkCyan).SetXY(0, 0).SetWidthAndHeight(119, 32).Tampil();
            string judul = "Sabar yaa, siput nya mo lewat";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(43, 18);
            Console.WriteLine(judul);
            for (int a = 1; a <= 45; a++)
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(30 + a, 12);
                Console.Write("   ▄▄▄");
                Console.SetCursorPosition(30 + a, 13);
                Console.Write(" ▄▀░▄░▀▄");
                Console.SetCursorPosition(30 + a, 14);
                Console.Write(" █░█▄▀░█");
                Console.SetCursorPosition(30 + a, 15);
                Console.Write(" █░▀▄▄▀█▄█▄▀");
                Console.SetCursorPosition(30 + a, 16);
                Console.Write("▄▄█▄▄▄▄███▀");
                //Console.SetCursorPosition(40 + a, 16);
                //Console.Write(" ");
                Thread.Sleep(50);

            }

            Thread.Sleep(500);
            new Clear(0, 0, 119, 50).SetBackColor(ConsoleColor.Black).Tampil();
        }
    }
}
