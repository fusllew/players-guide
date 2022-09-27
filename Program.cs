///////////////////////////////////////////////////////////////////////  18 vin fletchers arrows//////////////////////////////////////////////////
///////determine generalized cost of arrows
//Arrow arrow = GetArrow();
//Console.WriteLine($"That arrow costs {arrow.GetCost()} gold.");



//Arrow GetArrow()
//{
//    Arrowhead arrowhead = GetArrowheadType();
//    Fletching fletching = GetFletchingType();
//    float length = GetLength();

//    return new Arrow(arrowhead, fletching, length);
//}

//Arrowhead GetArrowheadType()
//{
//    Console.Write("Arrowhead type (steel, wood, obsidian): ");
//    string input = Console.ReadLine();
//    return input switch
//    {
//        "steel" => Arrowhead.Steel,
//        "wood" => Arrowhead.Wood,
//        "obsidian" => Arrowhead.Obsidian
//    };
//}

//Fletching GetFletchingType()
//{
//    Console.Write("Fletching type (plastic, turkey feather, goose feather): ");
//    string input = Console.ReadLine();
//    return input switch
//    {
//        "plastic" => Fletching.Plastic,
//        "turkey feather" => Fletching.TurkeyFeathers,
//        "goose feather" => Fletching.GooseFeathers
//    };
//}

//float GetLength()
//{
//    float length = 0;

//    while (length < 60 || length > 100)
//    {
//        Console.Write("Arrow length (between 60 and 100): ");
//        length = Convert.ToSingle(Console.ReadLine());
//    }

//    return length;
//}

//class Arrow
//{
//    public Arrowhead _arrowhead;
//    public Fletching _fletching;
//    public float _length;

//    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
//    {
//        _arrowhead = arrowhead;
//        _fletching = fletching;
//        _length = length;
//    }

//    public float GetCost()
//    {
//        float arrowheadCost = _arrowhead switch
//        {
//            Arrowhead.Steel => 10,
//            Arrowhead.Wood => 3,
//            Arrowhead.Obsidian => 5
//        };

//        float fletchingCost = _fletching switch
//        {
//            Fletching.Plastic => 10,
//            Fletching.TurkeyFeathers => 5,
//            Fletching.GooseFeathers => 3
//        };

//        float shaftCost = 0.05f * _length;

//        return arrowheadCost + fletchingCost + shaftCost;
//    }
//}

//enum Arrowhead { Steel, Wood, Obsidian }
//enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }

////////////////////////////////////////////////////// 18 end //////////////////////////////////////////////////////
///
//////////////////////////////////////////////////////// 19 vins trouble ////////////////////////////////////////////
///////create arrow class with private fields so that length cannot be changed later
//Arrow arrow = GetArrow();
//Console.WriteLine($"That arrow costs {arrow.GetCost()} gold.");



//Arrow GetArrow()
//{
//    Arrowhead arrowhead = GetArrowheadType();
//    Fletching fletching = GetFletchingType();
//    float length = GetLength();

//    return new Arrow(arrowhead, fletching, length);
//}

//Arrowhead GetArrowheadType()
//{
//    Console.Write("Arrowhead type (steel, wood, obsidian): ");
//    string input = Console.ReadLine();
//    return input switch
//    {
//        "steel" => Arrowhead.Steel,
//        "wood" => Arrowhead.Wood,
//        "obsidian" => Arrowhead.Obsidian
//    };
//}

//Fletching GetFletchingType()
//{
//    Console.Write("Fletching type (plastic, turkey feather, goose feather): ");
//    string input = Console.ReadLine();
//    return input switch
//    {
//        "plastic" => Fletching.Plastic,
//        "turkey feather" => Fletching.TurkeyFeathers,
//        "goose feather" => Fletching.GooseFeathers
//    };
//}

//float GetLength()
//{
//    float length = 0;

//    while (length < 60 || length > 100)
//    {
//        Console.Write("Arrow length (between 60 and 100): ");
//        length = Convert.ToSingle(Console.ReadLine());
//    }

//    return length;
//}

//public class Arrow
//{
//    private Arrowhead _arrowhead;
//    private Fletching _fletching;
//    private float _length;

//    public Arrowhead GetArrowhead() => _arrowhead;
//    public Fletching GetFletching() => _fletching;
//    public float GetLength() => _length;

//    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
//    {
//        _arrowhead = arrowhead;
//        _fletching = fletching;
//        _length = length;
//    }

//    public float GetCost()
//    {
//        float arrowheadCost = _arrowhead switch
//        {
//            Arrowhead.Steel => 10,
//            Arrowhead.Wood => 3,
//            Arrowhead.Obsidian => 5
//        };

//        float fletchingCost = _fletching switch
//        {
//            Fletching.Plastic => 10,
//            Fletching.TurkeyFeathers => 5,
//            Fletching.GooseFeathers => 3
//        };

//        float shaftCost = 0.05f * _length;

//        return arrowheadCost + fletchingCost + shaftCost;
//    }
//}

//public enum Arrowhead { Steel, Wood, Obsidian }
//public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }
/////////////////////////////////// 19 end//////////////////////////////////////////////////////////////////////

///////////////////////////////////// 20 properties of arrows //////////////////////////////////////////////////////

////////////using prior work using properties instead of get/set
//Arrow arrow = GetArrow();
//Console.WriteLine($"That arrow costs {arrow.Cost} gold.");



//Arrow GetArrow()
//{
//    Arrowhead arrowhead = GetArrowheadType();
//    Fletching fletching = GetFletchingType();
//    float length = GetLength();

//    return new Arrow(arrowhead, fletching, length);
//}

//Arrowhead GetArrowheadType()
//{
//    Console.Write("Arrowhead type (steel, wood, obsidian): ");
//    string input = Console.ReadLine();
//    return input switch
//    {
//        "steel" => Arrowhead.Steel,
//        "wood" => Arrowhead.Wood,
//        "obsidian" => Arrowhead.Obsidian
//    };
//}

//Fletching GetFletchingType()
//{
//    Console.Write("Fletching type (plastic, turkey feather, goose feather): ");
//    string input = Console.ReadLine();
//    return input switch
//    {
//        "plastic" => Fletching.Plastic,
//        "turkey feather" => Fletching.TurkeyFeathers,
//        "goose feather" => Fletching.GooseFeathers
//    };
//}

//float GetLength()
//{
//    float length = 0;

//    while (length < 60 || length > 100)
//    {
//        Console.Write("Arrow length (between 60 and 100): ");
//        length = Convert.ToSingle(Console.ReadLine());
//    }

//    return length;
//}

//public class Arrow
//{
//    public Arrowhead Arrowhead { get; }
//    public Fletching Fletching { get; }
//    public float Length { get; }

//    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
//    {
//        Arrowhead = arrowhead;
//        Fletching = fletching;
//        Length = length;
//    }

//    public float Cost
//    {
//        get
//        {
//            float arrowheadCost = Arrowhead switch
//            {
//                Arrowhead.Steel => 10,
//                Arrowhead.Wood => 3,
//                Arrowhead.Obsidian => 5
//            };

//            float fletchingCost = Fletching switch
//            {
//                Fletching.Plastic => 10,
//                Fletching.TurkeyFeathers => 5,
//                Fletching.GooseFeathers => 3
//            };

//            float shaftCost = 0.05f * Length;

//            return arrowheadCost + fletchingCost + shaftCost;
//        }
//    }
//}

//public enum Arrowhead { Steel, Wood, Obsidian }
//public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }

//////////////////////////////////////////////////////// 20 end //////////////////////////////////////////////////////////////////////

///////////////////////////////////////////////////////////  21 arrow factory /////////////////////////////////////////////////////////
////////use above work to make "custom arrows"
//Console.WriteLine("What arrow do you want?");
//Console.WriteLine("1 - Elite Arrow");
//Console.WriteLine("2 - Beginner Arrow");
//Console.WriteLine("3 - Marksman Arrow");
//Console.WriteLine("4 - Custom Arrow");

//string choice = Console.ReadLine();

//Arrow arrow = choice switch
//{
//    "1" => Arrow.CreateEliteArrow(),
//    "2" => Arrow.CreateBeginnerArrow(),
//    "3" => Arrow.CreateMarksmanArrow(),
//    _ => CreateCustomArrow(),
//};

//Console.WriteLine($"That arrow costs {arrow.Cost} gold.");



//Arrow CreateCustomArrow()
//{
//    Arrowhead arrowhead = GetArrowheadType();
//    Fletching fletching = GetFletchingType();
//    float length = GetLength();

//    return new Arrow(arrowhead, fletching, length);
//}

//Arrowhead GetArrowheadType()
//{
//    Console.Write("Arrowhead type (steel, wood, obsidian): ");
//    string input = Console.ReadLine();
//    return input switch
//    {
//        "steel" => Arrowhead.Steel,
//        "wood" => Arrowhead.Wood,
//        "obsidian" => Arrowhead.Obsidian
//    };
//}

//Fletching GetFletchingType()
//{
//    Console.Write("Fletching type (plastic, turkey feather, goose feather): ");
//    string input = Console.ReadLine();
//    return input switch
//    {
//        "plastic" => Fletching.Plastic,
//        "turkey feather" => Fletching.TurkeyFeathers,
//        "goose feather" => Fletching.GooseFeathers
//    };
//}

//float GetLength()
//{
//    float length = 0;

//    while (length < 60 || length > 100)
//    {
//        Console.Write("Arrow length (between 60 and 100): ");
//        length = Convert.ToSingle(Console.ReadLine());
//    }

//    return length;
//}

//public class Arrow
//{
//    public Arrowhead Arrowhead { get; }
//    public Fletching Fletching { get; }
//    public float Length { get; }

//    public Arrow(Arrowhead arrowhead, Fletching fletching, float length)
//    {
//        Arrowhead = arrowhead;
//        Fletching = fletching;
//        Length = length;
//    }

//    public float Cost
//    {
//        get
//        {
//            float arrowheadCost = Arrowhead switch
//            {
//                Arrowhead.Steel => 10,
//                Arrowhead.Wood => 3,
//                Arrowhead.Obsidian => 5
//            };

//            float fletchingCost = Fletching switch
//            {
//                Fletching.Plastic => 10,
//                Fletching.TurkeyFeathers => 5,
//                Fletching.GooseFeathers => 3
//            };

//            float shaftCost = 0.05f * Length;

//            return arrowheadCost + fletchingCost + shaftCost;
//        }
//    }

//    public static Arrow CreateEliteArrow() => new Arrow(Arrowhead.Steel, Fletching.Plastic, 95);
//    public static Arrow CreateBeginnerArrow() => new Arrow(Arrowhead.Wood, Fletching.GooseFeathers, 75);
//    public static Arrow CreateMarksmanArrow() => new Arrow(Arrowhead.Steel, Fletching.GooseFeathers, 65);
//}

//public enum Arrowhead { Steel, Wood, Obsidian }
//public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }




////////////////////////////////////////////////////////////// 21 end //////////////////////////////////////////////////////////////////


////////////////////////////////////////////////////////////// 24 a  the point  ///////////////////////////////////////////////////////

//Point a = new Point(2, 3);
//Point b = new Point(-4, 0);

//Console.WriteLine($"({a.X}, {a.Y})");
//Console.WriteLine($"({b.X}, {b.Y})");

//public class Point
//{
//    public float X { get; }
//    public float Y { get; }

//    public Point(float x, float y)
//    {
//        X = x;
//        Y = y;
//    }

//    public Point() : this(0, 0) { }
//}



/////////////////////////////////////////////////////////////// 24 a end **imutable as unable to set new ///////////////////////////////////////////////////////////////


////////////////////////////////////////////////////////////////  24 b thecolor //////////////////////////////////////////////////////////

//Color random = new Color(2, 200, 20);
//Color fixedColor = Color.Orange;

//Console.WriteLine($"R={random.R} G={random.G} B={random.B}");
//Console.WriteLine($"R={fixedColor.R} G={fixedColor.G} B={fixedColor.B}");

//public class Color
//{
//    public byte R { get; }
//    public byte G { get; }
//    public byte B { get; }

//    public Color(byte r, byte g, byte b)
//    {
//        R = r;
//        G = g;
//        B = b;
//    }

//    public static Color White { get; } = new Color(255, 255, 255);
//    public static Color Black { get; } = new Color(0, 0, 0);
//    public static Color Red { get; } = new Color(255, 0, 0);
//    public static Color Orange { get; } = new Color(255, 165, 0);
//    public static Color Yellow { get; } = new Color(255, 255, 0);
//    public static Color Green { get; } = new Color(0, 128, 0);
//    public static Color Blue { get; } = new Color(0, 0, 255);
//    public static Color Purple { get; } = new Color(128, 0, 128);

// }
//    //////////////////////////////////////////////////////////////  24 b end/////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////  24 c the card////////////////////////////////////////////////////////
//Color[] colors = new Color[] { Color.Red, Color.Green, Color.Blue, Color.Yellow };
//Rank[] ranks = new Rank[] { Rank.One, Rank.Two, Rank.Three, Rank.Four, Rank.Five, Rank.Six, Rank.Seven, Rank.Eight, Rank.Nine, Rank.Ten, Rank.DollarSign, Rank.Percent, Rank.Caret, Rank.Ampersand };

//foreach (Color color in colors)
//{
//    foreach (Rank rank in ranks)
//    {
//        Card card = new Card(rank, color);
//        Console.WriteLine($"The {card.Color} {card.Rank}");
//    }
//}



//public class Card
//{
//    public Rank Rank { get; }
//    public Color Color { get; }

//    public Card(Rank rank, Color color)
//    {
//        Rank = rank;
//        Color = color;
//    }

//    public bool IsSymbol => Rank == Rank.Ampersand || Rank == Rank.Caret || Rank == Rank.DollarSign || Rank == Rank.Percent;
//    public bool IsNumber => !IsSymbol;
//}

//public enum Color { Red, Green, Blue, Yellow }
//public enum Rank { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, DollarSign, Percent, Caret, Ampersand }


//    //////////////////////////////////////////////////////////////  24 c end/////////////////////////////////////////////////////////



////////////////////////////////////////////////////////////////  24 d the locked door ////////////////////////////////////////////////////////
//int initialPasscode = GetInt("What is the initial passcode?");
//Door door = new Door(initialPasscode);

//while (true)
//{
//    Console.Write($"The door is {door.State}. What do you want to do? (open, close, lock, unlock, change code) ");
//    string? command = Console.ReadLine();

//    switch (command)
//    {
//        case "open":
//            door.Open();
//            break;
//        case "close":
//            door.Close();
//            break;
//        case "lock":
//            door.Lock();
//            break;
//        case "unlock":
//            int guess = GetInt("What is the passcode?");
//            door.Unlock(guess);
//            break;
//        case "change code":
//            int currentCode = GetInt("What is the current passcode?");
//            int newCode = GetInt("What do you want to change it to?");
//            door.ChangeCode(currentCode, newCode);
//            break;
//    }
//}

//int GetInt(string text)
//{
//    Console.Write(text + " ");
//    return Convert.ToInt32(Console.ReadLine());
//}

//public class Door
//{
//    private int _passcode;
//    public DoorState State { get; private set; }

//    public Door(int initialPasscode)
//    {
//        _passcode = initialPasscode;
//        State = DoorState.Closed;
//    }

//    public void Close()
//    {
//        if (State == DoorState.Open) State = DoorState.Closed;
//    }

//    public void Open()
//    {
//        if (State == DoorState.Closed) State = DoorState.Open;
//    }

//    public void Lock()
//    {
//        if (State == DoorState.Closed) State = DoorState.Locked;
//    }

//    public void Unlock(int passcode)
//    {
//        if (State == DoorState.Locked && passcode == _passcode) State = DoorState.Closed;
//    }

//    public void ChangeCode(int oldPasscode, int newPasscode)
//    {
//        if (oldPasscode == _passcode) _passcode = newPasscode;
//    }
//}

//public enum DoorState { Open, Closed, Locked }

////    //////////////////////////////////////////////////////////////  24 d end/////////////////////////////////////////////////////////

////    //////////////////////////////////////////////////////////////  24 e the password validator/////////////////////////////////////////////////////////
//PasswordValidator validator = new PasswordValidator();

//while (true)
//{
//    Console.Write("Enter a password: ");
//    string? password = Console.ReadLine();

//    if (password == null) break; // If the user enters a null password (Ctrl+Z) then let's be done.
//                                 // An alternative could be to make `IsValid` handle null or to fall
//                                 // back to some default string like the empty string ("") instead.
//                                 // This challenge doesn't specifically call out dealing with null,
//                                 // and it isn't easy to get a null in there in the first place. If
//                                 // you ignored this possibility, that's fine too.

//    if (validator.IsValid(password)) Console.WriteLine("That password is valid.");
//    else Console.WriteLine("That password is not valid.");
//}

//public class PasswordValidator
//{
//    public bool IsValid(string password)
//    {
//        if (password.Length < 6) return false;
//        if (password.Length > 13) return false;
//        if (!HasUppercase(password)) return false;
//        if (!HasLowercase(password)) return false;
//        if (!HasDigits(password)) return false;
//        if (Contains(password, 'T')) return false;
//        if (Contains(password, '&')) return false;

//        return true;
//    }

//    private bool HasUppercase(string password)
//    {
//        foreach (char letter in password)
//            if (char.IsUpper(letter)) return true;

//        return false;
//    }

//    private bool HasLowercase(string password)
//    {
//        foreach (char letter in password)
//            if (char.IsLower(letter)) return true;

//        return false;
//    }

//    private bool HasDigits(string password)
//    {
//        foreach (char letter in password)
//            if (char.IsDigit(letter)) return true;

//        return false;
//    }

//    private bool Contains(string password, char letter)
//    {
//        foreach (char character in password)
//            if (character == letter) return true;

//        return false;
//    }
//}

//////////////////////////////////////////////////////////////  24 e end/////////////////////////////////////////////////////////


//////////////////////////////////////////////////////////////  24 f the chamber design/////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////  24 f end/////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////  24 g janken/////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////  24 g end/////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////  24 h puzzle /////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////  24 h end/////////////////////////////////////////////////////////


//////////////////////////////////////////////////////////////  24 i hangman/////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////  24 i end/////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////  24 j tic-tac-toe/////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////  24 j end/////////////////////////////////////////////////////////

