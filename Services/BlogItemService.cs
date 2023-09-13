using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogBackEnd.Models;
using BlogBackEnd.Services.Context;
using Microsoft.EntityFrameworkCore.Query.Internal;

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

        public bool DeleteBlogItem(BlogItemsModels deleteBlogItem)
        {
            _context.Update<BlogItemsModels>(deleteBlogItem);
            return _context.SaveChanges() != 0;

        }

        public IEnumerable<BlogItemsModels> GetAllBlogItems()
        {
            return _context.BlogInfo;
        }

        public IEnumerable<BlogItemsModels> GetItemsByCategory(string category)
        {
            return _context.BlogInfo.Where(item => item.Category == category);
        }

        public IEnumerable<BlogItemsModels> GetItemsByDate(string date)
        {
            return _context.BlogInfo.Where(item => item.Date == date);
        }

        public List<BlogItemsModels> GetItemsByTag(string tag)
        {
            List<BlogItemsModels> AllBlogsWithTag = new List<BlogItemsModels>();
           var allItems = GetAllBlogItems().ToList();
           for(int i = 0;i < allItems.Count;i++)
           {
              BlogItemsModels Item = allItems[i];
            var itemArr = Item.Tag.Split(',');
            for(int j = 0;j < itemArr.Length;j++)
            {
                if(itemArr[j].Contains(tag))
                {
                    AllBlogsWithTag.Add(Item);
                }
            }
           }
            return AllBlogsWithTag;
        }

        public bool UpdateBlogItems(BlogItemsModels blogUpdate)
        {
            _context.Update<BlogItemsModels>(blogUpdate);
            return _context.SaveChanges() != 0;
        }

        public IEnumerable<BlogItemsModels> GetPublishedItems()
        {
           return _context.BlogInfo.Where(item => item.IsPublished);
        }
    }
}