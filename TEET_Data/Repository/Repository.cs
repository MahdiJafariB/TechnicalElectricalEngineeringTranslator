using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TEET_Data.Repository
{
    public class Repository : IRepository
    {
        List<Word> db;
        private string path;

        public Repository(string Path)
        {
            try
            {
                var temp = File.ReadLines(Path).ToList() ?? new List<string>();
                db = temp.Select(w => (Word)w).ToList();
            }
            catch 
            { 
                File.WriteAllText(Path, "");
                var temp = new List<string>();
                db = new();
            }
            path = Path;
        }

        public bool Delete(Word word)
        {
            try
            {
                db.Remove(word);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            return Delete(GetWord(id));
        }

        public List<Word> GetAllWords()
        {
            var res = db.OrderBy(w => w.WordFace).ToList();
            return res;
        }

        public Word GetWord(int id)
        {
            return db.FirstOrDefault(w => w.WordID == id);
        }

        public string[] GetWordENMeans(string face)
        {
            return db
                .Where(w => w.WordFace.ToLower() == face.ToLower())
                .Select(w => w.WordEnglishMean)
                .ToArray();
        }
        public string[] GetWordFAMeans(string face)
        {
            return db
                .Where(w => w.WordFace.ToLower() == face.ToLower())
                .Select(w => w.WordPersianMean)
                .ToArray();
        }

        public bool Insert(Word word)
        {
            try
            {
                if (db.Any())
                    word.WordID = db.Last().WordID + 1;
                db.Add((string)word);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Save()
        {
            File.WriteAllLines(path, db.Select(x => (string)x));
        }

        public bool Update(Word word1, Word word2)
        {
            try
            {
                var selected = db.FirstOrDefault(w => w.WordID == word1.WordID);
                selected.WordFace = word2.WordFace;
                selected.WordEnglishMean = word2.WordEnglishMean;
                selected.WordPersianMean = word2.WordPersianMean;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
