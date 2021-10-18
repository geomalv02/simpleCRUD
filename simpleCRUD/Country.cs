using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace simpleCRUD
{
    class Country
    {
        //propiedades
        public int _countryId { get; set; }
        public string _name { get; set; }
        public string _population { get; set; }

        //instancia a la clase Crud
        private Crud crud = new Crud();

        //metodo para retornar los registros de la tabla Book
        public MySqlDataReader getAllCountries()
        {
            string query = "SELECT countryId,name,population FROM country";

            //llamado al metodo select de la clase Crud
            return crud.select(query);
        }

        //metodo para insertar o editar un registro
        public Boolean newEditCountry(string action)
        {
            if (action == "new")
            {
                string query = "INSERT INTO country(name, population)" +
                    "VALUES ('" + _name + "', '" + _population + "')";
                crud.executeQuery(query); //llamato al metodo executeQuery de la clase Crud
                return true;
            }
            else if (action == "edit")
            {
                string query = "UPDATE country SET "
                    + "name='" + _name + "' ,"
                    + "subtitle='" + _population + "',"
                    + "WHERE "
                    + "countryId='" + _countryId + "'";
                crud.executeQuery(query);
                return true;
            }

            return false;
        }

        //metodo para eliminar
        public Boolean deleteCountry()
        {
            string query = "DELETE FROM country WHERE countryId='" + _countryId + "'";
            crud.executeQuery(query);
            return true;
        }
    }
}