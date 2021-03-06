﻿using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI_App.Models;

namespace WebAPI_App.Controllers
{
    public class LibraryController : ApiController
    {
        public static IDictionary<int, BookModel> _bookModelDict = new Dictionary<int, BookModel>();

        // GET: api/Library
        public IList<BookModel> Get()
        {
            return _bookModelDict.Values.ToList();
        }

        // GET: api/Library/5
        public BookModel Get(int id)
        {
            return _bookModelDict[id];
        }

        // POST: api/Library
        public void Post(BookModel value)
        {
            int maxId = _bookModelDict.Count() > 0 ? _bookModelDict.Keys.Max() + 1 : 0;
            value.Id = maxId;
            _bookModelDict.Add(maxId, value);
        }

        // PUT: api/Library/5
        public void Put(int id,BookModel value)
        {
            int orgBookId = _bookModelDict[id].Id;
            value.Id = orgBookId;
            _bookModelDict[id] = value;
        }

        // DELETE: api/Library/5
        public void Delete(int id)
        {
            _bookModelDict.Remove(id);
        }
    }
}
