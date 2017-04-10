using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Mediator
{
    public class Save
    {
       public void OnDiskWrite(string message, string from)
        {

            string result = String.Format("{0} {1}:{2}", DateTime.Now, from, message);
            using (FileStream fstream = new FileStream("Messages.txt", FileMode.Append))
            {
                // преобразуем строку в байты
                byte[] array = System.Text.Encoding.Default.GetBytes(result);
                // запись массива байтов в файл
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Сообщение сохранено на диск в файл: Messages.txt");
            }
        }
    }
}
