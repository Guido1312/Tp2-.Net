﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using Data.Database;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    class PlanesAdapter:Adapter
    {
        public List<Planes> GetAll()
        {
            List<Planes> planes = new List<Planes>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlanes = new SqlCommand("select * from planes", sqlConn);
                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();
                while (drPlanes.Read())
                {
                    Planes pla = new Planes();
                    pla.ID = (int)drPlanes["id_plan"];
                    pla.Descripcion = (string)drPlanes["desc_plan"];
                    pla.IDEspecialidad = (int)drPlanes["id_especialidad"];
                    planes.Add(pla);
                }
                drPlanes.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de planes", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return planes;
        }

        public Business.Entities.Planes GetOne(int ID)
        {
            Planes pla = new Planes();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlanes = new SqlCommand("select * from planes where id_plan = @id", sqlConn);
                cmdPlanes.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();
                if (drPlanes.Read())
                {
                    pla.ID = (int)drPlanes["id_plan"];
                    pla.Descripcion = (string)drPlanes["desc_plan"];
                    pla.IDEspecialidad = (int)drPlanes["id_especialidad"];
                }
                drPlanes.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos del plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return pla;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete planes where id_plan = @id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Planes plan)
        {
            if (plan.State == BusinessEntity.States.Deleted)
            {
                this.Delete(plan.ID);
            }
            else if (plan.State == BusinessEntity.States.New)
            {
                this.Insert(plan);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                this.Update(plan);
            }
            plan.State = BusinessEntity.States.Unmodified;
        }

        protected void Update(Planes plan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("UPDATE planes SET desc_plan=@desc_plan, id_especialidad=@id_especialidad",sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = plan.ID;
                cmdSave.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdSave.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = plan.IDEspecialidad;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Planes plan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand("insert into planes(desc_plan,id_especialidad)" +
                    "values(@desc_plan,@id_especialidad)" +
                    "select @@identity", sqlConn);

                cmdSave.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdSave.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = plan.IDEspecialidad;
                plan.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear plan", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

    }
}
