// Задача со звездочкой: Написать программу для перевода римских чисел в десятичные арабские.
// III -> 3
// LVIII -> 58
// MCMXCIV -> 1994



// string text = "";
// char[] ROMAN = { 'M', 'D', 'C', 'L', 'X', 'V', 'I' };

// char[] mas = new char[text.Length];
// Int16[]Arab = {
// 1000, 500, 100, 50, 10, 5, 1};

// Console.Write("Введите строку заглавных латинских  букв:n ");
// text = Console.ReadLine();
// Console.WriteLine("Переведенные числа:");
// for (int i = 0; i < text.Length; i++) {
//     for (int j = 0; j < 7; j++) {
//     if (text[i] == ROMAN[j]) {
//         mas[i] = Convert.ToChar(Arab[j]);

//     } else
//         break;
//     }
// }

// int g = 0, u = 0;
// // В этом блоке надо, чтоб был алгоритм перевода чисел из римских в арабские
// for (int i = 1; i < text.Length; i++)   
// {
// }

// Console.WriteLine(g);
// Console.ReadKey();






// int[] Pounds()
// {
//     int[] mass=new int[4];
//     string[] arr = { "b1", "k1", "b2", "k2" };  
//     for (int i = 0; i < mass.Length; i++)
//     {       
//         Console.Write($"Введите точку {arr[i]}:\t");
//         mass[i] = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine(mass[i]);
//     } 
//     return mass;    
// }

// void Method(int [] array)                             // Функция вывода пересечения прямых
// {   
//     int b1=array[0];
//     int k1=array[1];
//     int b2=array[2];
//     int k2=array[3];
//     double x,y;
   
//     if (b1 == b2 && k1 == k2) Console.WriteLine("Прямые совпадают");
//     else if (k1 == k2) Console.WriteLine("Прямые параллельны друг другу");
//     else
//     {
//         x = (b2 - b1) / (k1 - k2);
//         y = k1 * x + b1;
//         Console.WriteLine("точка пересечения " + " (" + x + " ; " + y + ")");
//     }
    
// }

// Console.Clear();

// Pounds();
// Method();







function Level(i, v, x)
        {
        this.i = i;
        this.v = v;
        this.x = x
        }

levels = new Array();

levels[0] = new Level('I', 'V', 'X');
levels[1] = new Level('X', 'L', 'C');
levels[2] = new Level('C', 'D', 'M');




function calcDigit(d, l)
        {
        if (l > 2)
                {
                str = '';
                for (var m = 1; m <= d * Math.pow(10, l - 3) ; m++)
                        str += 'M';
                return str
                }
                        
        else
                if (d == 1)
                        return levels[l].i
                else
                        if (d == 2)
                                return levels[l].i + levels[l].i
                        else
                                if (d == 3)
                                        return levels[l].i + levels[l].i + levels[l].i
                                else
                                        if (d == 4)
                                                return levels[l].i + levels[l].v
                                        else
                                                if (d == 5)
                                                        return levels[l].v
                                                else
                                                        if (d == 6)
                                                                return levels[l].v + levels[l].i
                                                        else
                                                                if (d == 7)
                                                                        return levels[l].v + levels[l].i + levels[l].i
                                                                else
                                                                        if (d == 8)
                                                                                return levels[l].v + levels[l].i + levels[l].i + levels[l].i
                                                                        else
                                                                                if (d == 9)
                                                                                        return levels[l].i + levels[l].x
                                                                                else
                                                                                        return ''
        }

function toRoman(n)
        {
        var r = ''
        for (var c = 0; c < n.length; c++)
                r += calcDigit(eval(n.charAt(c)), n.length - c - 1);
        return r        
        }
        
function fromRoman(n)
        {
        var r = 0
        
        for (var c = 0; c < n.length; c++)
                {
                var chr = n.charAt(c).toLowerCase();
                if (c < n.length - 1)
                        var next = n.charAt(c + 1).toLowerCase()
                else
                        var next = '';
                        
                if (c > 0)
                        var prev = n.charAt(c - 1).toLowerCase()
                else
                        var prev = '';
                
                if (chr == 'i')
                        {
                        if (next == 'v')
                                r += 4
                        else
                                if (next == 'x')
                                        r += 9
                                else
                                        r += 1;
                        continue
                        }
                        
                if (chr == 'v') 
                        {
                        if (prev != 'i')
                                r += 5;
                        continue
                        }
                        
                if (chr == 'x')
                        {
                        if (prev != 'i')
                                if (next == 'l')
                                        r += 40
                                else
                                        if (next == 'c')
                                                r += 90
                                        else
                                                r += 10;
                        continue
                        }
                        
                if (chr == 'l')
                        {
                        if (prev != 'x')
                                r += 50;
                        continue
                        }
                        
                if (chr == 'c')
                        {
                        if (prev != 'x')
                                if (next == 'd')
                                        r += 400
                                else
                                        if (next == 'm')
                                                r += 900
                                        else
                                                r += 100;
                        continue
                        }

                if (chr == 'd')
                        {
                        if (prev != 'c')
                                r += 500;
                        continue
                        }
                
                if (chr == 'm')
                        {
                        if (prev != 'c')
                                r += 1000;
                        continue
                                
                        }
                }
        
        return r
        
        }


function isNuneric(str)
        {
        for (var c = 0; c < str.length; c++)
                {
                var chr = str.charAt(c);
                if (chr != '0' & chr != '1' & chr != '2' & chr != '3' & chr != '4' & chr != '5' & chr != '6' & chr != '7' & chr != '8' & chr != '9')
                        return false
                }
        return true
        }

function get(f)
        {
        
        var n = f.elements[0].value
        
        if (!isNuneric(n))
                {
                for (var c = 0; c < n.length; c++)
                        {
                        var chr = n.charAt(c).toLowerCase();
                        if (chr != 'i' & chr != 'v' & chr != 'x' & chr != 'l' & chr != 'c' & chr != 'd' & chr != 'm')
                                {
                                document.getElementById('errorMessage').innerHTML = "<strong>Используйте символы IVXLCDM!</strong><p>&nbsp;</p>";
                                return false
                                }
                        }
                mode = 'fromRoman'
                }
        else
                mode = 'toRoman';

        if (mode == 'toRoman')
                f.elements[0].value = toRoman(f.elements[0].value)
        else
                f.elements[0].value = fromRoman(f.elements[0].value);
        
        return false
        }
  