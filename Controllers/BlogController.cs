using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BlogBackEnd.Models;
using BlogBackEnd.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlogBackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
       private readonly BlogItemService _data;
       
       public BlogController(BlogItemService dataFromService){
        _data = dataFromService;
       }
       [HttpPost("AddBlogItems")]
       public bool AddBlogItem(BlogItemsModels newBlogItem) {
            return _data.AddBlogItem(newBlogItem);
        }
        [HttpGet("GetBlogItem")]
        public IEnumerable<BlogItemsModels> GetAllBlogItems(){
            return _data.GetAllBlogItems();
        }
        [HttpGet("GetItemsByCategory/{category}")]
        public IEnumerable<BlogItemsModels> GetItemsByCategory(string category){
            return _data.GetItemsByCategory(category);
        }
        [HttpGet("GetItemsByTag/{tag}")]
        public List<BlogItemsModels> GetItemsByTag(string tag){
            return _data.GetItemsByTag(tag);
        }
        [HttpGet("GetItemsByDate/{date}")]
        public IEnumerable<BlogItemsModels> GetItemsByDate(string date){
            return _data.GetItemsByDate(date);
        }
        [HttpPost("UpdateBlogItems")]
          public bool UpdateBlogItems(BlogItemsModels BlogUpdate)
        {
            return _data.UpdateBlogItems(BlogUpdate);
        }
        [HttpPost("DeleteBlogItem/{BlogItemToDelete}")]
        public bool DeleteBlogItem(string deleteBlogItem){
            return _data.DeleteBlogItem(deleteBlogItem);
        }
    }
}