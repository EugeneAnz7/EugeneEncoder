using System;
using System.Collections.Generic;

namespace EugeneEncoder.BL
{
    public class EncodingController : IEncodingController
    {
        public CeaserCode Encoding { get; set; }

        public EncodingController(string encoding)
        {
            if (encoding == "Ceaser's Code")
            {
                Encoding = new CeaserCode();
            }
        }


        public string Decode(string input)
        {
            var output = new List<char>();
            foreach (var Char in input)
            {
                var index = Encoding.Dictionary.IndexOf(Char);
                if (index < 3)
                {
                    output.Add((Encoding.Dictionary[25+(index - 2)]));
                }
                else
                {
                    output.Add((Encoding.Dictionary[(index - 3)]));
                }
            }
            return new string(output.ToArray());
        }

        public string Encode(string input)
        {
            var output = new List<char>(); 
            foreach(var Char in input)
            {
                var index = Encoding.Dictionary.IndexOf(Char);
                output.Add(Encoding.Dictionary[(index + 3)%26]);
            }
            return new string(output.ToArray());
        }
    }
}
