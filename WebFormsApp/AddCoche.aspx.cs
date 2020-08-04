using Example.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsApp
{
    public partial class AddCoche : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }       

        protected void addCocheForm_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/DataCoches");
        }

        protected void Cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DataCoches");
        }

        public void addStudentForm_InsertItem()
        {
            var item = new Example.DAL.DataModels.Coche();
            item.Id = Guid.NewGuid();

            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                

                DataContext.AddCoche(item);
                DataContext.SaveChanges();
                
            }
        }

        

        
    }
}