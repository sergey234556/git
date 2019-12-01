using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class AuthRegConnect
    {
        public static SqlConnection sql = new SqlConnection("Data Source = DESKTOP-SJDUEE0\\RODIONOVSQL; Initial Catalog =PCC1;" +
"Persist Security Info = true; User ID = sa; Password = \"2912\""); //строка подключения

        public static bool logCon = false;
        public static Color col = Color.White;

        public static string
            qrInormacia_o_pokypkah = "select ID_pokupki, Naimenovania_tovara as 'Наименование  товара', kolichestva_tovara as 'количество товара', kolichestva_pokypok as 'количество покупок' from Inormacia_o_pokypkah",
            qrAccunt = "select ID_cheta, Otchestvo as 'Отчество', Ima as 'Имя', Famili as 'Фамилия', Logen as 'Логен', Parol as 'Пароль', Podpisca_na_rassilky as 'Подписка на рассылку', Nomer_filiala as 'Номер филиала', Dolchnost as 'Должность' from Accunt",
            qrPlan_deistvi = "select ID_plana, Plan_deistvi1 as 'план действий', pokupki_ID as 'покупки' from Plan_deistvi",
            qrInformasia_o_programme = "select ID_program, Ocnovni_polochenia as 'Основные положения', Document_dla_clienta as 'документ для клиента', Document_dla_sotridnikov as 'документ для сотрудника', Data_nachala_program as 'дата начала программы', Data_oconchnia_programm as 'дата окончания программы', Yslovia_program as 'условия программы', Osenka_testirovchica as 'оценка тестировщика', plana_ID as 'План действий' from Informasia_o_programme",
            qrTestirovania = "select ID_Testirovania, Resultat_testirovania as 'Результат тестирования', program_ID as 'Номер программы' from Testirovania",
            qrOcenka_programm = "select ID_ocenka, itog_program as 'итог программы', Testirovania_ID as 'номер тестирования', pokupki_ID as 'номер покупок' from Ocenka_programm",
            qrRossilca = "select ID_Rossilca, program_ID as 'Номер программы', cheta_ID as 'номер учетной записи' from Rossilca",
            qrOtzovi = "select ID_Otzovi, Resiltati_testov_i_oprosov as 'Ресультаты тестов', Recomendasia as 'Рекомендации', Rossilca_ID as 'Номер рассылки' from Otzovi",
            qrKarta = "select ID_Karta, program_ID as 'Номер программы', cheta_ID as 'номер учетной записи' from Karta";
         

        public static SqlCommand cmd = new SqlCommand(string.Empty, sql);

        private static void spConfiguration(string spName)
        {
            cmd.CommandText = spName;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
        }

        //__________________________________________________________________________________________________________
        //Вызов процедуры Добавления в таблицу "Client"
        public static void Accunt_Insert(string Otchestvo, string Ima, string Famili, string Logen, string Parol, string Podpisca_na_rassilky, int Nomer_filiala, int Dolchnost)
        {
            spConfiguration("Accunt_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Otchestvo", Otchestvo);
                cmd.Parameters.AddWithValue("@Ima", Ima);
                cmd.Parameters.AddWithValue("@Famili", Famili);
                cmd.Parameters.AddWithValue("@Logen", Logen);
                cmd.Parameters.AddWithValue("@Parol", Parol);
                cmd.Parameters.AddWithValue("@Podpisca_na_rassilky", Podpisca_na_rassilky);
                cmd.Parameters.AddWithValue("@Nomer_filiala", Nomer_filiala);
                cmd.Parameters.AddWithValue("@Dolchnost", Dolchnost);
                sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Client"
        public static void Accunt_Update(Int32 ID_cheta, string Otchestvo, string Ima, string Famili, string Logen, string Parol, string Podpisca_na_rassilky, int Nomer_filiala, int Dolchnost)
        {
            spConfiguration("Accunt_Update");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_cheta", ID_cheta);
                cmd.Parameters.AddWithValue("@Otchestvo", Otchestvo);
                cmd.Parameters.AddWithValue("@Ima", Ima);
                cmd.Parameters.AddWithValue("@Famili", Famili);
                cmd.Parameters.AddWithValue("@Logen", Logen);
                cmd.Parameters.AddWithValue("@Parol", Parol);
                cmd.Parameters.AddWithValue("@Podpisca_na_rassilky", Podpisca_na_rassilky);
                cmd.Parameters.AddWithValue("@Nomer_filiala", Nomer_filiala);
                cmd.Parameters.AddWithValue("@Dolchnost", Dolchnost);
                sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "Client"
        public static void Accunt_Delete(Int32 ID_cheta)
        {
            spConfiguration("Accunt_Delete");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_cheta", ID_cheta);
                sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sql.Close();
            }
        }

        //__________________________________________________________________________________________________________
        //Вызов процедуры Добавления в таблицу "Dolchinosti"
        public static void Dolchinosti_Insert(string Kadrovik, string Admin, string Supervaser, string Tacsist)
        {
            spConfiguration("Dolchinosti_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Kadrovik", Kadrovik);
                cmd.Parameters.AddWithValue("@Admin", Admin);
                cmd.Parameters.AddWithValue("@Supervaser", Supervaser);
                cmd.Parameters.AddWithValue("@Tacsist", Tacsist);
                sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Dolchinosti"
        public static void Dolchinosti_Update(Int32 ID_Dolchinosti, string Kadrovik, string Admin, string Supervaser, string Tacsist)
        {
            spConfiguration("Dolchinosti_Update");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Dolchinosti", ID_Dolchinosti);
                cmd.Parameters.AddWithValue("@Kadrovik", Kadrovik);
                cmd.Parameters.AddWithValue("@Admin", Admin);
                cmd.Parameters.AddWithValue("@Supervaser", Supervaser);
                cmd.Parameters.AddWithValue("@Tacsist", Tacsist);
                sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "Dolchinosti"
        public static void Dolchinosti_Delete(Int32 ID)
        {
            spConfiguration("Dolchinosti_Delete");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Dolchinosti", ID);
                sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sql.Close();
            }
        }

        //__________________________________________________________________________________________________________
        //Вызов процедуры Добавления в таблицу "Documenta"
        public static void Documenta_Insert(string Lizanzia_na_raboty, string Pasport_TC, string Prava, string Pasport)
        {
            spConfiguration("Documenta_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Lizanzia_na_raboty", Lizanzia_na_raboty);
                cmd.Parameters.AddWithValue("@Pasport_TC", Pasport_TC);
                cmd.Parameters.AddWithValue("@Prava", Prava);
                cmd.Parameters.AddWithValue("@Pasport", Pasport);
                sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "Documenta"
        public static void Documenta_Update(Int32 ID_Documenta_v_compaty, string Lizanzia_na_raboty, string Pasport_TC, string Prava, string Pasport)
        {
            spConfiguration("Documenta_Update");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Documenta_v_compaty", ID_Documenta_v_compaty);
                cmd.Parameters.AddWithValue("@Lizanzia_na_raboty", Lizanzia_na_raboty);
                cmd.Parameters.AddWithValue("@Pasport_TC", Pasport_TC);
                cmd.Parameters.AddWithValue("@Prava", Prava);
                cmd.Parameters.AddWithValue("@Pasport", Pasport);
                sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "Documenta"
        public static void Documenta_Delete(Int32 ID)
        {
            spConfiguration("Documenta_Delete");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Documenta_v_compaty", ID);
                sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sql.Close();
            }
        }

        //__________________________________________________________________________________________________________
        //Вызов процедуры Добавления в таблицу "tochka_otpravki"
        public static void tochka_otpravki_Insert(string Dom, string Yliza, string Podezd)
        {
            spConfiguration("tochka_otpravki_Insert");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Dom", Dom);
                cmd.Parameters.AddWithValue("@Yliza", Yliza);
                cmd.Parameters.AddWithValue("@Podezd", Podezd);
                sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sql.Close();
            }
        }

        //Вызов процедуры обновления данных в таблице "tochka_otpravki"
        public static void tochka_otpravki_Update(Int32 ID_tochka_otpravki, string Dom, string Yliza, string Podezd)
        {
            spConfiguration("tochka_otpravki_Update");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_tochka_otpravki", ID_tochka_otpravki);
                cmd.Parameters.AddWithValue("@Dom", Dom);
                cmd.Parameters.AddWithValue("@Yliza", Yliza);
                cmd.Parameters.AddWithValue("@Podezd", Podezd);
                sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sql.Close();
            }
        }

        //Вызов процедуры удаления данных в таблице "tochka_otpravki"
        public static void tochka_otpravki_Delete(Int32 ID)
        {
            spConfiguration("tochka_otpravki_Delete");
            try
            {
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_tochka_otpravki", ID);
                sql.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sql.Close();
            }
        }
    }
}
