﻿using SttcBookTrade.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SttcBookTrade.Services
{
#pragma warning disable CS1591
    public interface IBookTradeRepository
    {
        bool UserExists(int userId);

        IEnumerable<User> GetUsers();

        User GetUser(int userId, bool includeBooks);

        Book GetBookOfUser(int userId, int bookId);

        IEnumerable<Book> GetBooksOfUser(int userId, int bookId);

        void AddBookToUser(int userId, Book book);

        void DeleteBook(Book book);

        IEnumerable<Book> GetBooks();

        IEnumerable<Book> SearchBooks(string query, string order, string direction);
        

        bool Save();
    }
#pragma warning restore CS1591
}