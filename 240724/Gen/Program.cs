using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Item // 추상 클래스 Item 정의 
{
    public string Name { get; private set; } 
    public Item(string name) // 생성자, Name을 초기화 
    {
        Name = name;
    }
}
public class Potion : Item  // item을 상속받은 potion 클래스 정의
{
    public Potion(string name) : base(name) { } // 생성자, Item의 Name을 받아서 초기화
}
public class Inventory<T> where T : Item  // Inventory클래스를 정의,
                                          //<T> where T : Item으로 아래 나올 모든 T를 Item타입만 받음
{
    private T[] _list;       // Item 타입의 배열 생성  
    private int _index;
    public Inventory(int size)   // item 타입의 배열을 생성하는 inventory 클래스의 생성자
    {
        _list = new T[size];
    }
    public void Add(T item)   // item타입을 인자로 받는 메서드 Add구현 
    {
        if (_index < _list.Length)  // item 타입의배열의 길이가 _index보다 크면 item[_index]에 item을 넣고
                                    // 인덱스 + 1
        {
            _list[_index] = item;
            _index++;
        }
    }
    public void Remove() // 아이템이 있다면 인덱스 -1 하고 가장 마지막에
                         // 들어간 아이템 삭제(해당 배열칸을 null로)
    {
        if (_index > 0)
        {
            _index--;
            _list[_index] = null;
        }
    }
    public void PrintItemNames()  // 아이템이 null이 아니면 해당 칸에있는 아이템 이름 출력 
    {
        Console.WriteLine("아이템 목록 : ");
        foreach (T item in _list)
        {
            if (item != null)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
public class Program
{
    static void Main(string[] args)
    {
        Inventory<Potion> potionInventory = new Inventory<Potion>(10);  // 10개의 potion 타입을 담을 수 있는
                                                                        // 인벤토리 생성
        potionInventory.Add(new Potion("체력 포션"));
        potionInventory.Add(new Potion("마나 포션"));
        potionInventory.Add(new Potion("경험치 포션"));
        potionInventory.Add(new Potion("활력 포션"));      

        potionInventory.Remove();   // 가장 늦게 들어간 아이템이 삭제됨 "경험치 포션 - 활력 포션순으로 삭제"
        potionInventory.Remove();
        potionInventory.PrintItemNames(); // 남은 아이템 출력 

    
    }
}