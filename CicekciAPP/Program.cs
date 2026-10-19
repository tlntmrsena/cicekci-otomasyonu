namespace CicekciAPP
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {

             https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using (var db = new AppDbContext())
            {
                try
                {
                    db.Database.EnsureCreated();//Eğer Veri Tabanı Yoksa Veri Tabanı Oluşturur.Varsa Herhangi Birşey Yapmaz.
                }
                catch (Microsoft.Data.SqlClient.SqlException ex)
                {

                    if (ex.Message != null && (ex.Message.Contains("Cannot create file") || ex.Message.Contains("already exists")))
                    {
                        System.Diagnostics.Debug.WriteLine("Database creation skipped: " + ex.Message);
                    }
                    else
                    {
                        throw;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            Application.Run(new Main());
        }
    }
}