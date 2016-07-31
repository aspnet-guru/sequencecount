using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Text;

namespace sequencecount
    {
    public class Sequence
        {
        //for example purposes assume two paths of equal lenghts delimited in this case by a ';'
        private static string ExamplePathInfo = "STVAJSRFFSL;FFOOFIOFFSL";

        public string[] GetSubPaths()
            {
            //set delimiters parse paths and return sub paths
            char[] DelimiterChars = { '\x003B' ,  '\t' };
            string[] ExamplePaths = ExamplePathInfo.Split(DelimiterChars);            
            return ExamplePaths;
            }

        public string FindPathSeq(string[] fromTheseSubs)
            {
            //parse substrings into char array
            char[] SubPath1 = fromTheseSubs[0].ToCharArray();
            char[] SubPath2 = fromTheseSubs[1].ToCharArray();

            //determine length of char arrary since both are of equal length this only needs to be done once
            int LengthOfPaths = SubPath1.Length;

            StringBuilder ActualStringFound = new StringBuilder();
            
            //parse char arrarys and compare character by character
            //build stringbuilder object based on contiguous characters found in each char arrary
            for (int i = 0; i < LengthOfPaths; i++)
                {

                if (SubPath1[i] == SubPath2[i])
                    {
                    ActualStringFound.Append(SubPath1[i]);
                    }
                else if (ActualStringFound.Length > 0 && SubPath1[i] != SubPath2[i])
                    {
                    break;
                    }
                }
            //return the contiguous string to caller
            return ActualStringFound.ToString();
            }
        }
    }