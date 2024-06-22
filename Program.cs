using static System.Console;

static unsafe T Gen_AllIn<T>()
    where T : unmanaged
{
    Random r = new();

    byte[] bs = new byte[sizeof(T)];

    r.NextBytes(bs);

    fixed (byte* p = bs)
    {
        return *(T*)p;
    }
}

switch (args.Length)
{
    case 0:
        WriteLine("Welcome to Brendan's Random!");
        WriteLine("Version 1.0.0!");
        return;
    case 1:
        switch (args[0].ToLower())
        {
            case "sbyte" or "int8_t" or "int8" or "i8" or "__int8":
                WriteLine(Gen_AllIn<sbyte>());
                return;
            case "byte" or "uint8_t" or "uint8" or "ui8" or "256":
                WriteLine(Gen_AllIn<byte>());
                return;
            case "short" or "int16_t" or "int16" or "i16" or "__int16":
                WriteLine(Gen_AllIn<short>());
                return;
            case "ushort" or "uint16_t" or "uint16" or "ui16" or "65536":
                WriteLine(Gen_AllIn<ushort>());
                return;
            case "int" or "int32_t" or "int32" or "i32" or "__int32":
                WriteLine(Gen_AllIn<int>());
                return;
            case "uint" or "uint32_t" or "uint32" or "ui32" or "4294967296":
                WriteLine(Gen_AllIn<uint>());
                return;
            case "long" or "int64_t" or "int64" or "i64" or "__int64":
                WriteLine(Gen_AllIn<long>());
                return;
            case "ulong" or "uint64_t" or "uint64" or "ui64" or "18446744073709551616":
                WriteLine(Gen_AllIn<ulong>());
                return;
            default:
                {
                    Random r = new();
                    string a1 = args[0];
                    if (a1.StartsWith("0x"))
                    {
                        a1 = a1[2..];
                        if (a1.Length > 16)
                        {
                            WriteLine("Hexadecimal string too long.");
                            return;
                        }
                        if ((a1.Length & 1) != 0)
                        {
                            a1 = " " + a1;
                        }
                        ulong cv = 0;
                        for (int i = 0; i < a1.Length; i += 2)
                        {
                            uint hc;
                            try
                            {
                                hc = Convert.ToUInt32(a1.Substring(i, 2));
                            }
                            catch
                            {
                                WriteLine("Hexadecimal string invalid.");
                                return;
                            }
                            cv <<= 8;
                            cv |= hc;
                        }
                        ulong result = (ulong)(r.NextInt64(long.MinValue, (long)cv + long.MinValue) - long.MinValue);
                        WriteLine(result);
                        return;
                    }
                    else if (a1.StartsWith("0b"))
                    {
                        if (a1.Length > 66)
                        {
                            WriteLine("Binary string too long.");
                            return;
                        }
                        a1 = a1[2..];
                        ulong cv = 0;
                        for (int i = 0; i < a1.Length; ++i)
                        {
                            cv <<= 1;
                            switch (a1[i])
                            {
                                case '0':
                                    break;
                                case '1':
                                    cv |= 1;
                                    break;
                                default:
                                    WriteLine("Binary string invalid.");
                                    return;
                            }
                        }
                        ulong result = (ulong)(r.NextInt64(long.MinValue, (long)cv + long.MinValue) - long.MinValue);
                        WriteLine(result);
                        return;
                    }
                    else if (ulong.TryParse(a1, out ulong ul))
                    {
                        ulong result = (ulong)(r.NextInt64(long.MinValue, (long)ul + long.MinValue) - long.MinValue);
                        WriteLine(result);
                        return;
                    }
                    else
                    {
                        WriteLine("Invalid command.");
                    }
                    return;
                }
        }
    case 2:
        {
            string a1 = args[0];
            string a2 = args[1];
            if (long.TryParse(a1, out long lb) && long.TryParse(a2, out long ub))
            {
                if (lb > ub)
                {
                    WriteLine("Invalid command.");
                    return;
                }
                WriteLine(new Random().NextInt64(lb, ub));
                return;
            }
            else
            {
                WriteLine("Invalid command.");
            }
            return;
        }
    default:
        WriteLine("Invalid syntax.");
        return;
}
