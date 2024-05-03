using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEET_Data.Repository
{
    public interface IRepository
    {
        void Save();
        List<Word> GetAllWords();
        Word GetWord(int id);
        string[] GetWordENMeans(string face);
        string[] GetWordFAMeans(string face);
        bool Insert(Word word);
        bool Update(Word word1, Word word2);
        bool Delete(Word word);
        bool Delete(int id);
    }
}
