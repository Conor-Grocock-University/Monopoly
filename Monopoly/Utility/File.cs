using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

using Monopoly.Models;

namespace Monopoly.Utility
{
    public class File
    {
        private static string[] GetLines(string filePath)
        {
            List<string> lines = new List<string>();
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader("Resources/" + filePath);
            while ((line = file.ReadLine()) != null)
            {
                lines.Add(line);
            }

            file.Close();

            return lines.ToArray();
        }

        public static Dictionary<int, Property> LoadCard(string filePath)
        {
            Dictionary<int, Property> cards = new Dictionary<int, Property>();
            string[] fileLines = GetLines(filePath);
            foreach (string line in fileLines)
            {
                string[] lineSegments = line.Split(',');

                string[] splitArray = lineSegments[3].Split('.');
                Color propColor = Color.FromArgb(Int32.Parse(splitArray[0]), Int32.Parse(splitArray[1]), Int32.Parse(splitArray[2]));

                // [0] - CardID
                // [1] - Type
                // [2] - Name
                // [3] - Color
                // [4] - Price
                Debug.Print(Severity.Fatal, lineSegments[2] + ": " + (lineSegments[5].Trim().ToLower() == "true").ToString());
                Property property = new Property(int.Parse(lineSegments[0]), lineSegments[1], lineSegments[2], propColor, int.Parse(lineSegments[4]), lineSegments[5].Trim().ToLower() == "true");
                cards[int.Parse(lineSegments[0])] = property;
            }

            return cards;
        }

        public static Property[,] LoadBoard(string filePath)
        {
            string[] fileLines = GetLines(filePath);
            Dictionary<int, Property> cards = LoadCard("cards.csv");
            Property[,] board = new Property[4, 10];
            
            foreach (string line in fileLines)
            {
                string[] lineSegments = line.Split(',');
                // [0] - Side
                // [1] - Position
                // [2] - CardID
                board[int.Parse(lineSegments[0]), int.Parse(lineSegments[1])] = cards[int.Parse(lineSegments[2])];
            }

            return board;
        }

        public static Image GetImageFromName(string fileName)
        {
            fileName = fileName.Trim().ToLower().Replace(' ', '_');
            if (System.IO.File.Exists("Resources/Images/" + fileName))
                return Image.FromFile("Resources/Images/" + fileName);
            else
            {
                Debug.Print(Severity.Error, $"{fileName} not found");
                return Image.FromFile("Resources/Images/missing.png");
            }
        }
    }
}