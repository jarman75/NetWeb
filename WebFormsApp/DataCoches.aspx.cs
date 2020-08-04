using Example.DAL;
using System;
using System.Collections.Generic;

namespace WebFormsApp
{
    public partial class DataCoches : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        // El nombre de parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
        public void cochesGrid_UpdateItem(Guid id)
        {

            
            Example.DAL.DataModels.Coche item = DataContext.GetCoche(id);
            // Cargar el elemento aquí, por ejemplo item = MyDataLayer.Find(id);
            if (item == null)
            {
                // No se encontró el elemento
                ModelState.AddModelError("", String.Format("No se encontró el elemento con id. {0}", id));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                // Guarde los cambios aquí, por ejemplo MyDataLayer.SaveChanges();
                DataContext.UpdateCoche(item);
                DataContext.SaveChanges();

            }
        }

        // El tipo devuelto puede ser modificado a IEnumerable, sin embargo, para ser compatible con la paginación y ordenación de 
        //, se deben agregar los siguientes parametros:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IEnumerable<Example.DAL.DataModels.Coche> cochesGrid_GetData()
        {
           
            return DataContext.GetCoches();
        }

        // El nombre de parámetro del id. debe coincidir con el valor DataKeyNames establecido en el control
        public void cochesGrid_DeleteItem(Guid id)
        {
            
            DataContext.DeleteCoche(id);
        }
    }
}