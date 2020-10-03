using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TushehbarApp.Data
{
    public class PhraseFinderService
    {
        private const string fileAddress = @"file.txt";

        private Task<List<string>> GetSentencesFromFile(string phrase, string fileAddress)
        {
            List<string> sentences = new List<string>();
            try
            {
                string line;
                StreamReader file = new StreamReader(fileAddress);
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains(phrase.ToLower().Trim()))
                    {
                        sentences.Add(line);
                    }
                }
            }
            catch (Exception)
            {

                throw new Exception("Error in Parsing File");
            }

            return Task.FromResult(sentences);
        }

        public Task<List<string>> GetSentencesAsync(string phrase)
        {
            if (string.IsNullOrEmpty(phrase))
            {
                return null;
            }

            return GetSentencesFromFile(phrase, fileAddress);
        }
    }
}
