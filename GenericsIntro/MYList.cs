using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // T => verdiğimiz tipe karşılık geliyor.
    class MyList<T>
    {
        // eklediklerimizi bu diziye eklemek istiyoruz ama bunu new'lemek zorundayız ve 0 elamanlı olsun istiyoruz. Bunun için ctor'dan yardım alıyoruz.

        T[] items;

        // constructor
        public MyList()
        {
            // class' ı new'lersen otomatik çalışır. Daha başlangıçta çalışacak. "New'lediğin anda çalışan metottur."  
            // Burada new 'ledik ve dizideki eleman sayısını sıfırladık!!!
            items = new T[0]; // 0 elemanlı bir dizi.
        }
        public void Add(T item)
        {
            // "Geçici dizi" oluşturuyoruz adres tutması için:
            T[] tempArray = items; // geçiciDizinin referansı, item'ın referansı. her new'lemede önceki değerler gider. Bu yüzden öncesiyi kaybetmemek için tempArray'de eskiyi tutup sonra new'liyoruz.

            // mevcuttaki eleman sayısı kaçsa onu bir arttır diyerek dinamik bir yapı oluşturmuş oluyoruz.
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];  // tempArray'e emaneten verdiğimiz değerleri, sırasıyla, yeniden kendi üzerimize alıyoruz.
            }

            items[items.Length - 1] = item;  // Eklenmek istenen elemanı aslında şu an ekleyebilmiş olduk!

        }
    }
}
