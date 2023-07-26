using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEET_Data
{
    public class Word
    {
        public int WordID { get; set; }
        public string WordFace { get; set; }
        public string WordEnglishMean { get; set; }
        public string WordPersianMean { get; set; }
        public Word()
        {

        }
        public Word(int id, string face, string enm, string fam)
        {
            WordID = id;
            WordFace = face;
            WordEnglishMean = enm;
            WordPersianMean = fam;
        }

        public static implicit operator Word(string line)
        {
            var s = line.Split('|');
            return new Word(int.Parse(s[0]), s[1], s[2], s[3]);
        }

        public static implicit operator string(Word word)
        {
            return string.Format("{0}|{1}|{2}|{3}|",
                word.WordID, word.WordFace, word.WordEnglishMean, word.WordPersianMean);
        }

        //public override string ToString()
        //{
        //    return $"{WordFace}: {WordEnglishMean} - {WordPersianMean}";
        //}
    }
}
