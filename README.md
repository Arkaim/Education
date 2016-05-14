# Education
Programming Technologies
Прочитать текст из файла:
           
            FileStream fs = new FileStream("input.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string text = sr.ReadToEnd();
            sr.Close();
            fs.Close();
            Console.WriteLine(text);
