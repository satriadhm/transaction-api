using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using order_api.Model;
using System.Diagnostics;

namespace order_api.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class TransactionController
    {
        public static List<Transaction> transactions = new List<Transaction>
        {
            new Transaction(1, "Toys", "3 kinds", "utils", "Toys transaction to be ordered."),
            new Transaction(2, "Utensils", "3 kinds", "utils", "Utensil transaction to be ordered.")
        };

        [HttpGet]
        public IEnumerable<Transaction> Get()
        {
            Debug.Assert(transactions != null, "Transaction data should not be null");
            return transactions;
        }

        [HttpGet("{id}")]
        public Transaction? Get(int id) 
        {
            Debug.Assert(id > 0, "Id should be greater than 0");
            for (int i = 0; i < transactions.Count; i++) 
            {
                if (transactions[i].Id == id) 
                {
                    return transactions[i];
                }
            }
            return null;
        }

        [HttpPost]
        public void Post([FromBody] Transaction transaction) 
        {
            Debug.Assert(transaction != null, "Transaction should not be null");
            transactions.Add(transaction);
        }

        [HttpPut]
        public void Put(int id,[FromBody] Transaction transaction) 
        {
            for (int i = 0; i < transactions.Count; i++) 
            {
                if (transactions[i].Id == id) 
                {
                    transactions[i] = transaction;
                }
            }
        }

        [HttpDelete]
        public void Delete(int id)
        {
            for (int i = 0; i < transactions.Count; i++) 
            {
                if (transactions[i].Id == id) 
                {
                    transactions.RemoveAt(i);
                }
            }
        }



    }
}
