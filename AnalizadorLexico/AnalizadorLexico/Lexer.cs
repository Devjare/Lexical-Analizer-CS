using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorLexico
{
    class Lexer
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            set { _text = value; }
        }

        private int _position;

        public Lexer(string text)
        {
            _text = text;
        }

        public Lexer(){ }

        private char Current
        {
            get
            {
                if (_position >= _text.Length)
                {
                    return '\0';
                }
                return _text[_position];
            }
        }

        private void Next() { _position++; }
        
        public Token NextToken()
        {

            if (_position >= _text.Length)
            {
                return new Token(TokenType.END_OF_FILE, _position, "\0", null);
            }


            // Find if the token is a Number
            if (char.IsDigit(Current))
            {

                var start = _position;

                while (char.IsDigit(Current))
                    Next();

                var length = _position - start;
                var text = _text.Substring(start, length);

                int.TryParse(text, out var value);

                return new Token(TokenType.NUMBER, start, text, value);

            }

            if (char.IsLetter(Current))
            {
                var start = _position;

                while (char.IsLetter(Current))
                    Next();

                var length = _position - start;
                var text = _text.Substring(start, length);

                return new Token(TokenType.LETTER, start, "STRING", text);
            }

            if (char.IsWhiteSpace(Current))
            {

                var start = _position;

                while (char.IsWhiteSpace(Current))
                    Next();

                var length = _position - start;
                var text = _text.Substring(start, length);

                return new Token(TokenType.WHITE_SPACE, start, text, null);

            }

            if (Current == '+')
                return new Token(TokenType.PLUS, _position++, "+", null);
            else if (Current == '-')
                return new Token(TokenType.MINUS, _position++, "-", null);
            else if (Current == '*')
                return new Token(TokenType.MUL, _position++, "*", null);
            else if (Current == '/')
                return new Token(TokenType.DIV, _position++, "/", null);
            else if (Current == '(')
                return new Token(TokenType.OPEN_PARENTHESIS, _position++, "(", null);
            else if (Current == ')')
                return new Token(TokenType.CLOSE_PARENTHESIS, _position++, ")", null);
            else if (Current == '{')
                return new Token(TokenType.OPEN_CURLY_BRACKETS, _position++, "{", null);
            else if (Current == '}')
                return new Token(TokenType.CLOSE_CURLY_BRACKETS, _position++, "}", null);
            else if (Current == '[')
                return new Token(TokenType.OPEN_BRACKETS, _position++, "[", null);
            else if (Current == ']')
                return new Token(TokenType.CLOSE_BRACKETS, _position++, "]", null);
            else if (Current == '=')
                return new Token(TokenType.EQUALS, _position++, "=", null);
            else if (Current == '_')
                return new Token(TokenType.UNDERSCORE, _position++, "_", null);
            else if (Current == ';')
                return new Token(TokenType.SEMICOLON, _position++, ";", null);
            else if (Current == (char)10)
                return new Token(TokenType.END_OF_LINE, _position++, "END_OF_LINE", null);
            else if (Current == '|')
                return new Token(TokenType.OR, _position++, "|", null);
            else if (Current == '&')
                return new Token(TokenType.AND, _position++, "&", null);
            else if (Current == '!')
                return new Token(TokenType.NOT, _position++, "!", null);
            else if (Current == '>')
            {
                Next();
                if (Current == '=')
                {
                    return new Token(TokenType.GREATER_THAN_OR_EQUAL, _position++, ">=", null);
                }
                return new Token(TokenType.GREATER_THAN, _position, ">", null);
            }
            else if (Current == '<')
            {
                Next();
                if (Current == '=')
                    return new Token(TokenType.LESS_THAN_OR_EQUAL, _position++, "<=", null);
                return new Token(TokenType.LESS_THAN, _position, "<", null);
            }

            return new Token(TokenType.BAD_TOKEN, _position++, _text.Substring(_position - 1, 1), null);


        }
    }

}
