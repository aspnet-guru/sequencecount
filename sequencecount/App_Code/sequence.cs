using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;

namespace sequencecount
    {
    public class sequence
        {
        //for example purposes assume two paths of equal lenghts delimited in this case by a ';'
        static string pathinfo = "STVAJSOFFSL;FFOOFIOFFSL";

        public string[] getSubPaths()
            {
            //set delimiters parse paths and return sub paths
            char[] delimiterChars = { '\x003B' ,  '\t' };
            string path = Path.GetFileName(pathinfo);
            string[] subPaths = path.Split(delimiterChars);
            return subPaths;
            }

        public string findPathSeq(string[] fromTheseSubs)
            {
            //parse substrings into char array
            char[] subPath1 = fromTheseSubs[0].ToCharArray();
            char[] subPath2 = fromTheseSubs[1].ToCharArray();

            //determine length of char arrary since both are of equal length this only needs to be done once
            int lengthOfPaths = subPath1.Length;

            StringBuilder actStringFound = new StringBuilder();
            
            //parse char arrarys and compare character by character
            //build stringbuilder object based on contiguous characters found in each char arrary
            for (int i = 0; i < lengthOfPaths; i++)
                {

                if (subPath1[i] == subPath2[i])
                    {
                    actStringFound.Append(subPath1[i]);
                    }
                else if (actStringFound.Length > 0 && subPath1[i] != subPath2[i])
                    {
                    break;
                    }
                }
            //return the contiguous string to caller
            return actStringFound.ToString();
            }
        }
    }