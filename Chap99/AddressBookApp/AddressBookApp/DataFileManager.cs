using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AddressBookApp
{
    class DataFileManager
    {
        // 텍스트 파일에서 자ㅓ장된 주소록을 불러온다(로드)
        const string dataFileName = "address.dat";
        public List<AddressInfo> ReadData()
        {
            var listResult = new List<AddressInfo>();
            var filepath = Environment.CurrentDirectory + "\\" + dataFileName; // 데이터 파일

            var sr = new StreamReader(new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Read)); // Open
            while (sr.EndOfStream == false)
            {
                var temp = sr.ReadLine();
                // temp 잘라서 manager.listAddress 할당
                string[] splits = temp.Split("|");
                listResult.Add(new AddressInfo() { Name = splits[0], Phone = splits[1], Address = splits[2] });
            }
            sr.Close();

            return listResult;
        }
        public void WriteData(List<AddressInfo> list)
        {
            var filepath = Environment.CurrentDirectory + "\\" + dataFileName; // 데이터 파일
            // 주소록을 다시 파일에 씀
            var sw = new StreamWriter(new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write));
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    sw.WriteLine($"{item.Name}|{item.Phone}|{item.Address}");
                }
            }

            sw.Close();
        }
    }
}
