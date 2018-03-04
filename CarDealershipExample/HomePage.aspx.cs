using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CarDealershipExample
{
    public partial class HomePage : System.Web.UI.Page
    {
        CarDB cardb = new CarDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlcarmake.DataSource = cardb.getDistinctCarMake();
                ddlcarmake.DataTextField = "CarMake";
                ddlcarmake.DataBind();

                ShowModel(ddlcarmake.Text);
                ShowPackages(ddlcarmodel.SelectedItem.Value.ToString());
                ClearLabels();


            }


        }

        public void ShowModel(string carmake)
        {
            ddlcarmodel.DataSource = cardb.getCarModelbyCarMake(carmake);
            ddlcarmodel.DataTextField = "CarModel";
            ddlcarmodel.DataValueField = "CarID";
            ddlcarmodel.DataBind();
        }
        protected void ddlcarmake_SelectedIndexChanged(object sender, EventArgs e)
        {   
                ShowModel(ddlcarmake.SelectedValue);
            ShowPackages(ddlcarmodel.SelectedItem.Value.ToString());
            ClearLabels();


        }
        public void ShowPackages(string id)
        {
            gvPackages.DataSource = cardb.getPackagesbyCarID(id);
            gvPackages.DataBind();
            gvPackages.HeaderRow.TableSection = TableRowSection.TableHeader;
            ClearLabels();

        }

        protected void ddlcarmodel_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                gvPackages.Visible = true;
                ShowPackages(ddlcarmodel.SelectedItem.Value.ToString());
            ClearLabels();
            
        }

      

        protected void btnOrderPackage_Click1(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                ClearLabels();
                ArrayList ar = new ArrayList();
                int count = 0;

                for (int i = 0; i < gvPackages.Rows.Count; i++)
                {
                    CheckBox cbox;
                    cbox = (CheckBox)gvPackages.Rows[i].FindControl("chkSelect");

                    if (cbox.Checked)
                    {
                        string packdesc = "";
                        packdesc = gvPackages.Rows[i].Cells[2].Text;
                        ar.Add(packdesc);
                        count = count + 1;


                    }


                }

                string str = "";

                str = "You have ordered " + count + " packages: <br/>";

                foreach (string s in ar)
                {
                    str = str + s + "<br/>";
                }

                Label1.Visible = true;
                Label1.Text = "Name:  " + txtname.Text;
                Label2.Visible = true;
                Label2.Text = "Phone number: " + txtphone.Text;
                Label3.Visible = true;
                Label3.Text = str;

            }
                Response.Write("<script>alert('Order Success');</script>");
            

        }

        public void ClearLabels()
        {
            Label1.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
        }
    }
}