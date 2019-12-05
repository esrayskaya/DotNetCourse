using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class Award
    {
        private int id;
        private string title;
        private string description;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public override int GetHashCode()
        {
            return DateTime.Now.Year ^ DateTime.Now.Month ^ DateTime.Now.Day ^ DateTime.Now.Hour ^ DateTime.Now.Minute ^ DateTime.Now.Millisecond;
        }
        public string Title
        {
            get { return title; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Поле не может быть пустым.");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("Количество символов не может быть больше 50.");
                }
                else title = value;
            }
        }
        public string Description
        {
            get { return description; }
            set
            {
                description = value;
            }
        }
        public Award(int ID, string title, string description = "")
        {
            Title = title;
            Description = description;
            this.ID = ID;
        }
        public Award(string title, string description = "")
        {
            Title = title;
            Description = description;
        }
    }
}
