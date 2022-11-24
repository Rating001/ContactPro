using ContactPro.Models;

namespace ContactPro.Services.Interfaces
{
    public interface IAddressBookService
    {
        //Adds the category
        Task AddContactToCategoryAsync(int categoryId, int contactId);
        //Checks if a contact is in a category
        Task<bool> IsContactInCategory(int categoryId, int contactId);
        //Pulls the list of categories
        Task<IEnumerable<Category>> GetUserCategoriesAsync(string userId);
        //Gets the IDs associates with a specific category
        Task<ICollection<int>> GetContactCategoryIdsAsync(int contactId);
        //Used to transfer from one array to another
        Task<ICollection<Category>> GetContactCategoriesAsync(int contactId);
        //Removes the category from a contact
        Task RemoveContactFromCategoryAsync(int categoryId, int contactId);
        //Searches for contacts in a specific category
        Task<IEnumerable<Contact>> SearchForContacts(string searchString, string userId);
    }
}
