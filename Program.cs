using System;

namespace AddressBookSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Uc1_DetailOfContact contactDetail = new Uc1_DetailOfContact();
            ContactDetail.Detail();

            Uc2_AddingNewCntact addNewContact = new Uc2_AddingNewCntact();
            addNewContact.EnterInput();
            addNewContact.ViewTheDetails();

            UC3_editingExistingContact editDetails = new UC3_editingExistingContact();
            editDetails.EditUsingName();

            UC4_DeletingAContact deleteDetails = new UC4_DeletingAContact();
            deleteDetails.DeletetheName();

        }
    }
}
