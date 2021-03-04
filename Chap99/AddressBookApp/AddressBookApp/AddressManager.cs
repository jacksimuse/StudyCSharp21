using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookApp
{
    class AddressManager
    {
        public List<AddressInfo> listAddress; // 주소록을 담을 컬렉션
        public void PrintMenu()
        {
            //메뉴 츌력
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1.주소입력");
            Console.WriteLine("2.주소검색");
            Console.WriteLine("3.주소수정");
            Console.WriteLine("4.주소삭제");
            Console.WriteLine("5.주소전체 출력");
            Console.WriteLine("6.프로그램 종료");
            Console.WriteLine("----------------------------------------");
        }

        public int SelectMenu()
        {
            //메뉴번호 입력
            Console.Write("메뉴를 선택하세요 >>> ");
            string input = Console.ReadLine();
            int Result = 0;
            int.TryParse(input, out Result); //값이 들어가면 읽고 만족하지 않으면 0으로 나온다
            if (!(Result > 0 && Result < 7))  //1~6이외의 값은 아닌 값이 댄다
                Result = 0;

            return Result;
        }
        //Console.WriteLine($"선택된 메뉴 : {menuNum}");

        public void InputAddress()
        {
            Console.Clear();
            Console.WriteLine("주소입력");
            Console.WriteLine("----------------------------------------");
            Console.Write("이름입력 :");
            string name = Console.ReadLine();
            Console.Write("전화입력 :");
            string Phone = Console.ReadLine();
            Console.Write("주소입력 :");
            string address = Console.ReadLine();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(Phone))
            {
                Console.WriteLine("빈값은 입력할 수 없습니다.");
                Console.ReadLine();
            }
            else
            {
                listAddress.Add(new AddressInfo()
                { Name = name, Phone = Phone, Address = address });
            }
        }

        public void SearchAddress()
        {
            Console.WriteLine("주소검색");
            Console.WriteLine("----------------------------------------");
            Console.Write("이름입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false; //검색을 했을때 찾는 이름이 있는가?
            foreach (var item in listAddress)
            {
                if (item.Name == name) //위의 Name이랑 name2 같은지 물어봄
                {
                    isFind = true; //찾았음
                    Console.WriteLine($"[{idx}]----------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("----------------------------------------");
                    break; //foreach 를 빠져나가는것
                }
                idx++;

            }

            if (isFind == false) //false가 나오묜 "검색결과가 없습니다"로 나온다
            {
                Console.WriteLine("검색결과가 없습니다.");
            }
            Console.ReadLine(); //화면 멈춤

        }
        public void UpdateAddress()
        {
            Console.WriteLine("주소수정");
            Console.WriteLine("----------------------------------------");
            Console.Write("이름입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false; //검색을 했을때 찾는 이름이 있는가?
            foreach (var item in listAddress)
            {
                if (item.Name == name) //위의 Name이랑 name2 같은지 물어봄
                {
                    isFind = true; //찾음
                    Console.WriteLine($"[{idx}]----------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("----------------------------------------");
                    Console.Write("이름을 재입력 : ");
                    string uName = Console.ReadLine();
                    Console.Write("전화 재입력 : ");
                    string uPhone = Console.ReadLine();
                    Console.Write("주소 재입력 : ");
                    string uAddress = Console.ReadLine();

                    if (string.IsNullOrEmpty(uName) || string.IsNullOrEmpty(uPhone))
                    {
                        Console.WriteLine("빈값은 입력할 수 없습니다");
                        Console.ReadLine();
                    }
                    else
                    {
                        item.Name = uName;
                        item.Phone = uPhone;
                        item.Address = uAddress;
                    }
                    break; //foreach 를 빠져나가는것
                }
                idx++;
            }
            if (isFind == false) //false가 나오묜 "검색결과가 없습니다"로 나온다
            {
                Console.WriteLine("검색결과가 없습니다.");
            }

            Console.ReadLine(); //화면 멈춤\
        }

        public void DeleteAddress()
        {
            Console.WriteLine("주소삭제");
            Console.WriteLine("----------------------------------------");
            Console.Write("이름입력 : ");
            string name = Console.ReadLine();
            int idx = 0;
            bool isFind = false; //검색을 했을때 찾는 이름이 있는가?
            foreach (var item in listAddress)
            {
                if (item.Name == name) //위의 Name이랑 name2 같은지 물어봄
                {
                    isFind = true; //찾음
                    Console.WriteLine($"[{idx}]----------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("----------------------------------------");
                    Console.Write("삭제 하시겠습니까? [y/n]");
                    string answer = Console.ReadLine(); // y/n
                    if (answer.ToUpper() == "y")
                        listAddress.RemoveAt(idx); //주소 검색에서 계속 돌다가 "y" yse 가 나오면 지운다
                    Console.WriteLine("삭제했습니다.");
                    break; //foreach 를 빠져나가는것
                }
                idx++;

            }
            if (isFind == false) //false가 나오묜 "검색결과가 없습니다"로 나온다
            {
                Console.WriteLine("검색결과가 없습니다.");
            }
            Console.ReadLine(); //화면 멈춤
        }

        public void PrintAllAddress()
        {
            Console.WriteLine("주소전체 출력");
            Console.WriteLine("----------------------------------------");
            int idx3 = 0;

            if (listAddress.Count == 0)
            {
                Console.WriteLine("주소록이 없습니다.");

            }
            else
            {
                foreach (var item in listAddress)

                {
                    Console.WriteLine($"[{idx3}]----------------------------------------");
                    Console.WriteLine($"이름 : {item.Name}");
                    Console.WriteLine($"전화 : {item.Phone}");
                    Console.WriteLine($"주소 : {item.Address}");
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine();

                    idx3++;

                }
            }
            Console.ReadLine(); //화면 멈춤
        }
    }
}
