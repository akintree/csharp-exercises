using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QuizTime
{
    class QuizData
    {
        public static List<Dictionary<string, string>> FullQuiz = new List<Dictionary<string, string>>();
        static bool IsDataLoaded = false;

        public static List<Dictionary<string, string>> PrintPrep()
        {
            LoadData();
            return FullQuiz;
        }

        private static void LoadData()
        {
            if (IsDataLoaded)
            {
                return;
            }
            List<string[]> rows = new List<string[]>();
            using (StreamReader reader = File.OpenText("QuizQuestions.csv"))
            {
                while (reader.Peek() >= 0)
                {
                    string line = reader.ReadLine();
                    string[] rowArray = CSVRowToStringArray(line);
                    if (rowArray.Length > 0)
                    {
                        rows.Add(rowArray);
                    }
                }
                string[] headers = rows[0];
                rows.Remove(headers);

                foreach(string[] row in rows)
                {
                    Dictionary<string, string> rowDict = new Dictionary<string, string>();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        if (row[i].Length > 0){
                            rowDict.Add(headers[i], row[i]);
                        }                    
                    }
                    FullQuiz.Add(rowDict);
                }

                IsDataLoaded = true;
            }
        }

        private static string[] CSVRowToStringArray(string row, char comma = ',')
        {
            StringBuilder valueBuilder = new StringBuilder();
            List<string> rowValues = new List<string>();

            foreach (char c in row.ToCharArray())
            {
                if (c == comma)
                {
                    rowValues.Add(valueBuilder.ToString());
                    valueBuilder.Clear();
                }
            }

            rowValues.Add(valueBuilder.ToString());
            valueBuilder.Clear();
            return rowValues.ToArray();
        }

    }
}
