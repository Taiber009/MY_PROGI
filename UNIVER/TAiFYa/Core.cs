using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TAiFYa
{
    class Core
    {
        Symbol[] _Vt, _Vt2;
        Symbol[] _Vn, _Vn1, _Vn2;
        Rule[] _P, _P1, _P2;
        public Core(string[] input)
        {
            List<Symbol> symbol_list = new List<Symbol>();

            var line = input[0].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var val in line)
                symbol_list.Add(new Symbol(val[0], true));
            symbol_list.Add(new Symbol('ε', true));//
            _Vt = symbol_list.ToArray();

            symbol_list = new List<Symbol>();

            line = input[1].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var val in line)
                symbol_list.Add(new Symbol(val[0], false));
            _Vn = symbol_list.ToArray();

            List<Rule> rule_list = new List<Rule>();
            symbol_list = new List<Symbol>();

            for (int i = 2; i < input.Length; i++)
            {
                line = input[i].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                Symbol left_part = Array.Find(_Vn, symbol => symbol.value == line[0][0]);

                var right_part = line[1].Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var chain in right_part)
                {
                    //if (chain[0] == 'ε')
                    //    rule_list.Add(new Rule(left_part, null));
                    // else
                    //{
                    foreach (var s in chain)
                        symbol_list.Add(Array.Find(_Vt.Union(_Vn).ToArray(), symbol => symbol.value == s)); //тут страшно
                    rule_list.Add(new Rule(left_part, symbol_list.ToArray()));

                    symbol_list = new List<Symbol>();
                    // }
                }
            }

            _P = rule_list.ToArray();
        }

        public string StartGram()
        {
            string s = "G = ({" + _Vt[0].value;
            for (int i = 1; i < _Vt.Length; i++)
                if (_Vt[i].value != 'ε')//
                    s += "," + _Vt[i].value;

            s += "}, {" + _Vn[0].value;
            for (int i = 1; i < _Vn.Length; i++)
                s += "," + _Vn[i].value;

            s += "}, {" + _P[0].TextFull();
            for (int i = 1; i < _P.Length; i++)
            {
                if (_P[i].left == _P[i - 1].left)
                    s += " | " + _P[i].TextRightPart(); //|B;
                else
                    s += ", " + _P[i].TextFull(); //,A→B
            }
            return s + "}, S)";
        }
        public string SubGram()
        {
            Delete1();
            string s = "G` = ({" + _Vt[0].value;
            for (int i = 1; i < _Vt.Length; i++)
                if (_Vt[i].value != 'ε')//
                    s += "," + _Vt[i].value;

            s += "}, {" + _Vn1[0].value;
            for (int i = 1; i < _Vn1.Length; i++)
                s += "," + _Vn1[i].value;

            s += "}, {" + _P1[0].TextFull();
            for (int i = 1; i < _P1.Length; i++)
            {
                if (_P1[i].left == _P1[i - 1].left)
                    s += " | " + _P1[i].TextRightPart(); //|B;
                else
                    s += ", " + _P1[i].TextFull(); //,A→B
            }
            return s + "}, S)";
        }
        public string FinalGram()
        {
            //Delete1();
            Delete2();

            string s = "G`` = ({" + _Vt2[0].value;
            for (int i = 1; i < _Vt2.Length; i++)
                if (_Vt2[i].value != 'ε')//
                    s += "," + _Vt2[i].value;

            s += "}, {" + _Vn2[0].value;
            for (int i = 1; i < _Vn2.Length; i++)
                s += "," + _Vn2[i].value;

            s += "}, {" + _P2[0].TextFull();//,A→B
            for (int i = 1; i < _P2.Length; i++)
            {
                if (_P2[i].left == _P2[i - 1].left)
                    s += " | " + _P2[i].TextRightPart(); //|C;
                else
                    s += ", " + _P2[i].TextFull(); //,A→B
            }
            return s + "}, S)";
        }

        void Delete1()//1.	Удаление бесплодных символов.
        {
            List<Symbol> vi = new List<Symbol>(),          //множество V`i
                         new_symbols = new List<Symbol>(); //приращение ко множеству V'i (если новых нет, то V`N = V`i)
            List<Rule> new_rules = new List<Rule>();

            while (true)
            {
                foreach (var rule in _P)
                {
                    if (rule.right.All(right_part_symbol => right_part_symbol.terminal ||    //если все правые символы входят в множество терминалов...
                                                            vi.Contains(right_part_symbol))//или в множество V`
                        && !new_symbols.Contains(rule.left) && !vi.Contains(rule.left))    //защита от повтора левого символа
                        new_symbols.Add(rule.left);
                }
                if (new_symbols.Count != 0)//если есть новые символы
                {
                    foreach (var s in new_symbols)
                        vi.Add(s);
                    new_symbols = new List<Symbol>();
                }
                else//если нет
                    break;

            }
            vi = vi.OrderBy(symbol => symbol.value).ToList();
            _Vn1 = vi.ToArray(); //V`N = V`i

            foreach (var rule in _P)
            {
                if (rule.left.terminal || _Vn1.Contains(rule.left) &&
                    rule.right.All(right_part_symbol => right_part_symbol.terminal || _Vn1.Contains(right_part_symbol)))
                    new_rules.Add(rule);
            }
            _P1 = new_rules.OrderBy(rule => rule.left.value).ToArray();

        }
        void Delete2()//2.	Удаление недостижимых символов.
        {
            List<Symbol> vi = new List<Symbol>(),          //множество Vi (терминалы и нет)
                         new_symbols = new List<Symbol>(); //приращение ко множеству Vi (если новых нет, то Vi -> Vt2 и Vn2)
            List<Rule> new_rules = new List<Rule>();
            vi.Add(Array.Find(_Vn1, symbol => symbol.value == 'S')); //V0 := {S}, i=1

            while (true)
            {
                foreach (var rule in _P1)
                {
                    if (vi.Contains(rule.left)       //левый символ правила находится в Vi
                        && !new_rules.Contains(rule))//защита от повтора правила
                    {
                        new_rules.Add(rule);
                        foreach (var symbol in rule.right)
                        {
                            if (!vi.Union(new_symbols).Contains(symbol)) //только новые символы
                                new_symbols.Add(symbol);//новые символы для множества Vi
                        }
                    }
                }
                if (new_symbols.Count != 0)//если есть новые символы
                {
                    foreach (var s in new_symbols)
                        vi.Add(s);
                    new_symbols = new List<Symbol>();
                }
                else//если нет
                    break;
            }

            vi = vi.OrderBy(symbol => symbol.value).ToList();
            //vi.Sort();
            List<Symbol> vt2 = new List<Symbol>(),
                         vn2 = new List<Symbol>();

            foreach (Symbol symbol in vi)
            {
                if (symbol.terminal)
                    vt2.Add(symbol);
                else
                    vn2.Add(symbol);
            }

            _Vt2 = vt2.ToArray();
            _Vn2 = vn2.ToArray();
            _P2 = new_rules.OrderBy(rule => rule.left.value).ToArray();
        }

    }
}
