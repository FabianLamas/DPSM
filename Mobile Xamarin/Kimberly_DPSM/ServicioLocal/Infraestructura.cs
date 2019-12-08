using System;
using System.Collections.Generic;
using Modelos;
using SQLite;
using System.Linq;
using System.IO;

namespace Kimberly_DPSM.ServicioLocal
{
    public class Infraestructura
    {
        static string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Kimberly.db3");


        public SQLiteConnection connection;

        public Infraestructura()
        {
            connection = new SQLiteConnection(path);

            connection.CreateTable<Brand>();
            connection.CreateTable<Category>();
            connection.CreateTable<DP_Audit>();
            connection.CreateTable<DP_Portafolio>();
            connection.CreateTable<Format>();
            connection.CreateTable<Manufacturer>();
            connection.CreateTable<Material_Competitor>();
            connection.CreateTable<Material_KCC>();
            connection.CreateTable<Merchandiser>();
            connection.CreateTable<Pos>();
            connection.CreateTable<Promotion>();
            connection.CreateTable<Sector>();

        }
        public void InsertData(object objeto)
        {
            if (objeto != null)
            {
                connection.Insert(objeto);
            }
        }
        public bool Update(DP_Audit audit)
        {
            try
            {
                connection.Update(audit);
            }
            catch (Exception ex)
            {

            }

            return false;
        }
        public DP_Audit GetAudit(string id)
        {
            try
            {
                return connection.Get<DP_Audit>(x => x.SKU.Equals(id));
            }
            catch (Exception ex)
            {

            }
            return default;
        }
        public List<DP_Audit> GetAllAudit()
        {
            List<DP_Audit> dP_Audits = new List<DP_Audit>();
            try
            {
                dP_Audits = connection.Table<DP_Audit>().ToList();
            }
            catch (Exception ex)
            {

            }
            return dP_Audits;
        }
        public List<Category> GetAllCategories(string id)
        {
            List<Category> categories = new List<Category>();
            try
            {
                categories = connection.Table<Category>().ToList();
            }
            catch (Exception ex)
            {

            }
            return categories;
        }

    }
}
