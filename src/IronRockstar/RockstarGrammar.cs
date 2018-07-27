using System;
using System.Collections.Generic;
using System.Text;
using Irony.Ast;
using Irony.Parsing;

namespace IronRockstar
{
    public class RockstarGrammar : Grammar
    {

        public RockstarGrammar() : base(true) //Rockstar is case sensitive (for variable assignment)
        {
            //var comment = new CommentTerminal("comment", "(", ")");
            //NonGrammarTerminals.Add(comment);
        }
    }
}
