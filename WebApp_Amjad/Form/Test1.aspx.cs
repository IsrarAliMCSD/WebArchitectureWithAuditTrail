using AppController;
using DAOCLASSLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp_Amjad.App_Class;

namespace WebApp_Amjad.Form
{
    public partial class Test1 : BasePage
    {
        public AppManager appmanager;
        public DropDown_Data misop;
        public string returnMessage = "";
        protected override void Page_Load(object sender, EventArgs e)
        {
            base.Page_Load(sender, e);
            lblError.Text = "";
            if (!IsPostBack)
            {
                FormLoad();
            }

        }
        public void FormLoad()
        {
            new DropDown_Data().GetAllEventType(ref ddlEventType);
            new DropDown_Data().GetAllIssueMedium(ref ddlIssueMedium);
            new DropDown_Data().GetAllCorrespondanceType(ref ddlCorrespondanceType);
            new DropDown_Data().GetAllParties(ref ddlParties);
            FormState("ADD");
        }
        public void FormState(string state)
        {
            if (state == "ADD")
            {
                btnApprove.Enabled = false;
                btnDelete.Enabled = false;
                btnPreview.Enabled = false;
                btnSave.Enabled = false;
                btnIgnore.Enabled = false;
                btnVerify.Enabled = false;
                btnAdd.Enabled = true;

            }
            else if (state == "EDIT")
            {
                btnApprove.Enabled = false;
                btnDelete.Enabled = false;
                btnPreview.Enabled = false;
                btnSave.Enabled = true;
                btnIgnore.Enabled = false;
                btnVerify.Enabled = false;
                btnAdd.Enabled = false;

            }
            ControlState(state);
        }
        public void getAllParties()
        {
            appmanager = new AppManager();
            var rsult = appmanager.GetAllParties();
            //ddlEventType
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            appmanager = new AppManager();
            if (appmanager.InsertEventDetail(formToObject(), ref returnMessage))
            {
                lblError.Text = "The record has been saved succesffully";
                FormState("ADD");
               // FormLoad();
                //FormLoad(SessionHelper.getUserSession().userid);
            }
            else
            {
                lblError.Text = returnMessage;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            appmanager = new AppManager();
            if (appmanager.InsertEventDetail(formToObject(), ref returnMessage))
            {
                lblError.Text = "The record has been add succesffully";
                FormState("ADD");
                FormLoad();
                //FormLoad(SessionHelper.getUserSession().userid);
            }
            else
            {
                lblError.Text = returnMessage;
            }
        }

        protected void btnApprove_Click(object sender, EventArgs e)
        {

        }


        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void btnPreview_Click(object sender, EventArgs e)
        {

        }

        protected void btnIgnore_Click(object sender, EventArgs e)
        {

        }

        protected void btnVerify_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            FormState("ADD");
        }
        public EventDetail formToObject()
        {
            EventDetail eventDetail = new EventDetail();
            if (lblEventDetailId.Text != "")
            {
                eventDetail.EventDetailId = Convert.ToInt32(lblEventDetailId.Text);
            }

            eventDetail.BankBranch = rbtlBankBranch.SelectedValue;
            eventDetail.BankNo = 1;
            eventDetail.EventTypeId = Convert.ToInt32(ddlEventType.SelectedValue);
            eventDetail.IssueMediumId = Convert.ToInt32(ddlIssueMedium.SelectedValue);
            eventDetail.LCNumber = Convert.ToInt32(txtLCNumber.Text);
            eventDetail.EventNumber = Convert.ToInt32(txtEventNo.Text);
            eventDetail.EventStatus1 = txtEventStatus1.Text;
            eventDetail.EventStatus2 = txtEventStatus2.Text;
            eventDetail.correspondanceNo = Convert.ToInt32(txtCorrespondanceNo.Text);
            eventDetail.CorrespondanceDate = Convert.ToDateTime(txtCorrespondanceDate.Text);
            eventDetail.CorrespondanceTypeId = Convert.ToInt32(ddlEventType.SelectedValue);
            eventDetail.PartiesId = Convert.ToInt32(ddlParties.SelectedValue);
            eventDetail.Information = txtinformation1.Text;
            eventDetail.Information2 = txtinformation2.Text;
            eventDetail.information3 = txtinformationMain.Text;
            eventDetail.Reference = txtReference.Text;
            eventDetail.IntractionToSend = txtIntractionToSend.Text;
            eventDetail.IsActive = true;
            return eventDetail;
        }
        public void objectToForm(EventDetail eventDetail)
        {
            if (eventDetail == null)
            {
                return;
            }
            if (eventDetail.EventDetailId > 0)
            {
                lblEventDetailId.Text = eventDetail.EventDetailId.ToString();
            }
            rbtlBankBranch.SelectedValue = eventDetail.BankBranch;
            ddlEventType.SelectedValue = eventDetail.EventTypeId.ToString();
            ddlIssueMedium.SelectedValue = eventDetail.IssueMediumId.ToString();
            ddlCorrespondanceType.SelectedValue = eventDetail.CorrespondanceTypeId.ToString();
            txtLCNumber.Text = eventDetail.LCNumber.ToString();
            txtEventNo.Text = eventDetail.EventNumber.ToString();

            txtEventStatus1.Text = eventDetail.EventStatus1.ToString();
            txtEventStatus2.Text = eventDetail.EventStatus2.ToString();
            txtCorrespondanceNo.Text = eventDetail.correspondanceNo.ToString();
            txtCorrespondanceDate.Text = eventDetail.CorrespondanceDate.Value.ToString("MM/dd/yyyy");
            ddlParties.SelectedValue = eventDetail.PartiesId.ToString();
            txtinformation1.Text = eventDetail.Information.ToString();
            txtinformation2.Text = eventDetail.Information2.ToString();
            txtinformationMain.Text = eventDetail.information3.ToString();
            txtReference.Text = eventDetail.Reference.ToString();
            txtIntractionToSend.Text = eventDetail.IntractionToSend.ToString();
        }

        protected void ibtnLCFind_Click(object sender, ImageClickEventArgs e)
        {
            if (txtLCNumber.Text != "")
            {
                int Lcnum = 0;
                int.TryParse(txtLCNumber.Text, out Lcnum);
                appmanager = new AppManager();
                var rsult = appmanager.GetEventDetailByLC(Lcnum);
                if (rsult != null)
                {
                    objectToForm(rsult);
                    FormState("EDIT");
                }
            }
            else
            {
                lblError.Text = "No LC found";
            }
        }
        public void ControlState(string state)
        {
            if (state == "ADD")
            {
                lblEventDetailId.Text = "";
                rbtlBankBranch.SelectedValue = "BANK";
                ddlEventType.SelectedIndex = 0;
                ddlIssueMedium.SelectedIndex = 0;
                ddlCorrespondanceType.SelectedIndex = 0;
                txtLCNumber.Text = "";
                txtEventNo.Text = "";
                txtEventStatus1.Text = "";
                txtEventStatus2.Text = "";
                txtCorrespondanceNo.Text = "";
                txtCorrespondanceDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
                ddlParties.SelectedIndex = 0;
                txtinformation1.Text = "";
                txtinformation2.Text = "";
                txtinformationMain.Text = "";
                txtReference.Text = "";
                txtIntractionToSend.Text = "";
            }
        }
    }
}