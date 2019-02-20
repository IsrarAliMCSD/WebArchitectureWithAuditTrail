using AppController;
using DAOCLASSLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebApp_Amjad.App_Class
{
    public class DropDown_Data
    {
        public AppManager appmanager;
        public DropDown_Data()
        {
            appmanager = new AppManager();

        }
        public void GetAllEventType(ref DropDownList ddl)
        {
            List<EventType> eventType = appmanager.GetAllEventType().ToList();
            ddl.DataSource = eventType;
            ddl.DataValueField = "EventsTypeId";
            ddl.DataTextField = "EventTypeName";
            ddl.DataBind();
            addSelectInDropdown(ref ddl);
        }
        public void GetAllIssueMedium(ref DropDownList ddl)
        {
            List<IssueMedium> issueMedium = appmanager.GetAllIssueMedium().ToList();
            ddl.DataSource = issueMedium;
            ddl.DataValueField = "IssueMediumId";
            ddl.DataTextField = "IssueMediumName";
            ddl.DataBind();
            addSelectInDropdown(ref ddl);
        }
        public void GetAllCorrespondanceType(ref DropDownList ddl)
        {
            List<CorrespondanceType> correspondanceType = appmanager.GetAllCorrespondanceType().ToList();
            ddl.DataSource = correspondanceType;
            ddl.DataValueField = "CorrespondanceTypeId";
            ddl.DataTextField = "CorrespondanceTypeName";
            ddl.DataBind();
            addSelectInDropdown(ref ddl);
        }
        public void GetAllParties(ref DropDownList ddl)
        {
            List<Party> lstParty = appmanager.GetAllParties().ToList();
            ddl.DataSource = lstParty;
            ddl.DataValueField = "PartiesID";
            ddl.DataTextField = "PartiesName";
            ddl.DataBind();
            addSelectInDropdown(ref ddl);
        }
        public void addSelectInDropdown(ref DropDownList ddl)
        {
            ddl.Items.Insert(0, new ListItem("Select", "-1")); //updated code
        }
    }
    public enum SessionNames
    {
        S_User
    }
}