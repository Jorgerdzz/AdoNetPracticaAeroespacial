using AdoNetPracticaAeroespacial.Helpers;
using AdoNetPracticaAeroespacial.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace AdoNetPracticaAeroespacial.Repositories
{
    public class RepositoryAgenciaAereoespacial
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryAgenciaAereoespacial()
        {
            IConfigurationRoot configuration = HelperConfiguration.GetConfiguration();
            string connectionString = configuration.GetConnectionString("SqlLocalCasa");
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetNavesAsync()
        {
            string sql = "SP_ALL_NAVES";
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> naves = new List<string>();
            while(await this.reader.ReadAsync())
            {
                string nombreNave = this.reader["NOMBRE_NAVE"].ToString();
                naves.Add(nombreNave);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return naves;
        }

        public async Task<Nave> GetDatosNaveAsync(string nombreNave)
        {
            string sql = "SP_DATOS_NAVE";
            this.com.Parameters.Clear();
            this.com.Parameters.AddWithValue("@nombreNave", nombreNave);
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            Nave nave = new Nave();
            while(await this.reader.ReadAsync())
            {
                nave.NaveId = int.Parse(this.reader["NAVE_ID"].ToString());
                nave.NombreNave = this.reader["NOMBRE_NAVE"].ToString();
                nave.Modelo = this.reader["MODELO"].ToString();
                nave.CapacidadMax = int.Parse(this.reader["CAPACIDAD_MAX"].ToString());
                nave.Estado = this.reader["ESTADO"].ToString();
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return nave;
        }

        public async Task<List<string>> GetAstronautasNaveAsync(string nombreNave)
        {
            string sql = "SP_LOAD_ASTRONAUTAS_NAVE";
            this.com.Parameters.AddWithValue("@nombreNave", nombreNave);
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> astronautas = new List<string>();
            while(await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                astronautas.Add(apellido);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return astronautas;
        }

        public async Task<Astronauta> GetDatosAstronautaAsync(string apellido)
        {
            string sql = "SP_LOAD_ASTRONAUTA_POR_NOMBRE";
            this.com.Parameters.Clear();
            this.com.Parameters.AddWithValue("@nombreAstronauta", apellido);
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            Astronauta astronauta = new Astronauta();
            while(await this.reader.ReadAsync())
            {
                astronauta.Apellido = this.reader["APELLIDO"].ToString();
                astronauta.Rango = this.reader["RANGO"].ToString();
                astronauta.FechaIngreso = this.reader["FECHA_INGRESO"].ToString();
                astronauta.Salario = int.Parse(this.reader["SALARIO_ANUAL"].ToString());
                astronauta.Bono= int.Parse(this.reader["BONO_POR_MISION"].ToString());
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return astronauta;
        }

        public async Task<int> InsertarNaveAsync(int naveId, string nombreNave, string modelo, int capacidadMax, string estado)
        {
            string sql = "SP_INSERTAR_NAVE";
            this.com.Parameters.Clear();
            this.com.Parameters.AddWithValue("@naveId", naveId);
            this.com.Parameters.AddWithValue("@nombreNave", nombreNave);
            this.com.Parameters.AddWithValue("@modelo", modelo);
            this.com.Parameters.AddWithValue("@capacidadMax", capacidadMax);
            this.com.Parameters.AddWithValue("@estado", estado);
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }

        public async Task<int> UpdateAstronautaAsync(string apellido, string rango, int salario)
        {
            string sql = "SP_UPDATE_ASTRONAUTA";
            this.com.Parameters.Clear();
            this.com.Parameters.AddWithValue("@apellido", apellido);
            this.com.Parameters.AddWithValue("@rango", rango);
            this.com.Parameters.AddWithValue("@salario", salario);
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int registros = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return registros;
        }

    }
}
