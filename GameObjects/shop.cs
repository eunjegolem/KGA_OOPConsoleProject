using System;
using System.Collections.Generic;

namespace KGA_OOPConsoleProject.GameObjects
{
    class shop
    {
        
        List<Item> items = new List<Item>()
        {
            new Potion(new Vector2(1, 1)),
            new Potion(new Vector2(2, 2))
        };

        public void Shop()
        {
            


        }

        public void ShowItems()
        {
            Console.WriteLine("==== 상점 아이템 목록 ====");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {items[i].name} - {items[i].price} G");
            }
        }

        public void Buy(Player player)
        {
            ShowItems();
            Console.Write("구매할 아이템 번호를 입력하세요 (0: 취소): ");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice) && choice > 0 && choice <= items.Count)
            {
                Item selectedItem = items[choice - 1];
                if (player.gold >= selectedItem.price)
                {
                    player.gold -= selectedItem.price;
                    player.Inventory.Add(selectedItem);
                    Console.WriteLine($"{selectedItem.name}을(를) 구매했습니다!");
                }
                else
                {
                    Console.WriteLine("골드가 부족합니다.");
                }
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }
        }
    }
}
