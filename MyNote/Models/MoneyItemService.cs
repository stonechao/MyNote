using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyNote.Models
{
    public class MoneyItemService
    {

        private readonly Model1 _db;
        public MoneyItemService()
        {
            _db = new Model1();
        }

        public IEnumerable<AccountBook> Lookup()
        {
            return _db.AccountBook.ToList();
        }

        public AccountBook GetSingle(Guid itemId)
        {
            return _db.AccountBook.Find(itemId);
        }

        public void Add(AccountBook item)
        {
            item.Dateee = DateTime.Now;
            _db.AccountBook.Add(item);

        }

        public void Edit(AccountBook pageData, AccountBook oldData)
        {
            oldData.Categoryyy = pageData.Categoryyy;
            oldData.Amounttt = pageData.Amounttt;
            oldData.Dateee = pageData.Dateee;
            oldData.Remarkkk = pageData.Remarkkk;
        }

        public void Delete(AccountBook data)
        {
            _db.AccountBook.Remove(data);
        }

        public void Save()
        {
            _db.SaveChanges();
        }



    }
}