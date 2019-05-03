using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    public enum TokenType
    {
        BAD_TOKEN,
        END_OF_FILE,
        END_OF_LINE,
        WHITE_SPACE,
        PLUS,
        MINUS,
        MUL,
        DIV,
        MOD,
        OR,
        NOT,
        AND,
        EQUALS,
        LESS_THAN,
        GREATER_THAN,
        GREATER_THAN_OR_EQUAL,
        LESS_THAN_OR_EQUAL,
        OPEN_PARENTHESIS,
        CLOSE_PARENTHESIS,
        OPEN_BRACKETS,
        CLOSE_BRACKETS,
        OPEN_CURLY_BRACKETS,
        CLOSE_CURLY_BRACKETS,
        DOT,
        COLON,
        SEMICOLON,
        NUMBER,
        STRING,
        LETTER,
        UNDERSCORE,
        COMMENT,
        KEYWORD
    }

    class Token
    {
        
        public TokenType Type { get; }
        public int Position { get; }
        public String Text { get; }
        public Object Value { get; }

        public Token(TokenType type, int position, string text, object value)
        {
            Type = type;
            Position = position;
            Text = text;
            Value = value;
        }
    }
}
