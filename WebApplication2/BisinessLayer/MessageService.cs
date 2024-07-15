using WebApplication2.DataLayer;
using WebApplication2.Models;
using System.Collections.Generic;
using System.Linq;

namespace WebApplication2.BusinessLayer
{
    public class MessageService
    {
        private readonly AppDbContext _context;

        public MessageService(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Message> GetMessages()
        {
            return _context.Messages.ToList();
        }

        public Message GetMessage(int id)
        {
            return _context.Messages.FirstOrDefault(m => m.Id == id);
        }
    }
}
