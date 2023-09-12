using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogBackEnd.Models;
using BlogBackEnd.Services.Context;

namespace BlogBackEnd.Services
{
    public class BlogItemService
    {
        private readonly DataContext _context;
        public BlogItemService(DataContext context){
            _context = context;
        }
        public bool AddBlogItem(BlogItemsModels newBlogItem)
        {
            bool result = false;
            _context.Add(newBlogItem);
            result = _context.SaveChanges() != 0;
            return result;
        }

        internal bool DeleteBlogItem(string deleteBlogItem)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<BlogItemsModels> GetAllBlogItems()
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<BlogItemsModels> GetItemsByCategory(string category)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<BlogItemsModels> GetItemsByDate(string date)
        {
            throw new NotImplementedException();
        }

        internal List<BlogItemsModels> GetItemsByTag(string tag)
        {
            throw new NotImplementedException();
        }

        internal bool UpdateBlogItems(BlogItemsModels blogUpdate)
        {
            throw new NotImplementedException();
        }
    }
}