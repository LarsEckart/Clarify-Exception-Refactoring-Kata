﻿using System;
using System.Collections.Generic;

namespace codingdojo
{
    public class SpreadsheetException : Exception
    {
        private readonly List<string> _cells;
        private readonly string _token;

        public SpreadsheetException(string message, List<string> cells, string token) : base(message)
        {
            _cells = cells;
            _token = token;
        }

        public List<string> Cells => _cells;

        public string Token => _token;
    }
}