// Decompiled with JetBrains decompiler
// Type: GR.JSONParser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Text;

#nullable disable
namespace GR
{
  [Token(Token = "0x2000334")]
  public class JSONParser
  {
    [Token(Token = "0x6001132")]
    public static T[] parseJSONArray<T>(string src) where T : new() => (T[]) null;

    [Token(Token = "0x6001133")]
    public static T parseJSONObject<T>(string src) where T : new() => (T) null;

    [Token(Token = "0x6001134")]
    [Address(RVA = "0x12A3570", Offset = "0x12A2370", VA = "0x112A3570")]
    private static bool readDigits(JSONParser.Context ctx) => new bool();

    [Token(Token = "0x6001135")]
    [Address(RVA = "0x12A2250", Offset = "0x12A1050", VA = "0x112A2250")]
    private static bool parseNumber(JSONParser.Context ctx, bool ignoreDecimal) => new bool();

    [Token(Token = "0x6001136")]
    [Address(RVA = "0x12A2160", Offset = "0x12A0F60", VA = "0x112A2160")]
    private static uint parseHex(JSONParser.Context ctx) => new uint();

    [Token(Token = "0x6001137")]
    [Address(RVA = "0x12A31D0", Offset = "0x12A1FD0", VA = "0x112A31D0")]
    private static bool parseString(JSONParser.Context ctx) => new bool();

    [Token(Token = "0x6001138")]
    [Address(RVA = "0x12A36C0", Offset = "0x12A24C0", VA = "0x112A36C0")]
    private static bool skipSpaces(JSONParser.Context ctx) => new bool();

    [Token(Token = "0x6001139")]
    [Address(RVA = "0x12A1740", Offset = "0x12A0540", VA = "0x112A1740")]
    private static void forward(JSONParser.Context ctx)
    {
    }

    [Token(Token = "0x600113A")]
    [Address(RVA = "0x12A1A00", Offset = "0x12A0800", VA = "0x112A1A00")]
    private static bool match(JSONParser.Context ctx, char ch) => new bool();

    [Token(Token = "0x600113B")]
    [Address(RVA = "0x12A3750", Offset = "0x12A2550", VA = "0x112A3750")]
    private static string stringParser(JSONParser.Context ctx, Type type) => (string) null;

    [Token(Token = "0x600113C")]
    [Address(RVA = "0x12A1A40", Offset = "0x12A0840", VA = "0x112A1A40")]
    private static object objectParser(JSONParser.Context ctx, Type type) => (object) null;

    [Token(Token = "0x600113D")]
    [Address(RVA = "0x12A1650", Offset = "0x12A0450", VA = "0x112A1650")]
    private static byte byteParser(JSONParser.Context ctx, Type type) => new byte();

    [Token(Token = "0x600113E")]
    [Address(RVA = "0x12A3670", Offset = "0x12A2470", VA = "0x112A3670")]
    private static short shortParser(JSONParser.Context ctx, Type type) => new short();

    [Token(Token = "0x600113F")]
    [Address(RVA = "0x12A1960", Offset = "0x12A0760", VA = "0x112A1960")]
    private static int intParser(JSONParser.Context ctx, Type type) => new int();

    [Token(Token = "0x6001140")]
    [Address(RVA = "0x12A19B0", Offset = "0x12A07B0", VA = "0x112A19B0")]
    private static long longParser(JSONParser.Context ctx, Type type) => new long();

    [Token(Token = "0x6001141")]
    [Address(RVA = "0x12A16F0", Offset = "0x12A04F0", VA = "0x112A16F0")]
    private static float floatParser(JSONParser.Context ctx, Type type) => new float();

    [Token(Token = "0x6001142")]
    [Address(RVA = "0x12A16A0", Offset = "0x12A04A0", VA = "0x112A16A0")]
    private static double doubleParser(JSONParser.Context ctx, Type type) => new double();

    [Token(Token = "0x6001143")]
    private static object parseValueArray<T>(
      JSONParser.Context ctx,
      JSONParser.ParseElement<T> parser)
    {
      return (object) null;
    }

    [Token(Token = "0x6001144")]
    [Address(RVA = "0x12A2500", Offset = "0x12A1300", VA = "0x112A2500")]
    private static object parseObjectArray(
      JSONParser.Context ctx,
      JSONParser.ParseElement<object> parser,
      Type type)
    {
      return (object) null;
    }

    [Token(Token = "0x6001145")]
    [Address(RVA = "0x12A1BD0", Offset = "0x12A09D0", VA = "0x112A1BD0")]
    private static object parseArray(JSONParser.Context ctx, Type elementType) => (object) null;

    [Token(Token = "0x6001146")]
    [Address(RVA = "0x12A1810", Offset = "0x12A0610", VA = "0x112A1810")]
    private static object ignoreValue(JSONParser.Context ctx, Type type) => (object) null;

    [Token(Token = "0x6001147")]
    [Address(RVA = "0x12A2780", Offset = "0x12A1580", VA = "0x112A2780")]
    private static bool parseObject(JSONParser.Context ctx, object obj) => new bool();

    [Token(Token = "0x6001148")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSONParser()
    {
    }

    [Token(Token = "0x2000335")]
    public class Context
    {
      [Token(Token = "0x4000D08")]
      [FieldOffset(Offset = "0x8")]
      public string src;
      [Token(Token = "0x4000D09")]
      [FieldOffset(Offset = "0xC")]
      public int pos;
      [Token(Token = "0x4000D0A")]
      [FieldOffset(Offset = "0x10")]
      public StringBuilder sb;
      [Token(Token = "0x4000D0B")]
      [FieldOffset(Offset = "0x14")]
      public ArrayList ab;

      [Token(Token = "0x170001ED")]
      public string history
      {
        [Token(Token = "0x6001149"), Address(RVA = "0x12A10A0", Offset = "0x129FEA0", VA = "0x112A10A0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x600114A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Context()
      {
      }
    }

    [Token(Token = "0x2000336")]
    public class JSONException : Exception
    {
      [Token(Token = "0x4000D0C")]
      [FieldOffset(Offset = "0x48")]
      private JSONParser.Context mCtx;

      [Token(Token = "0x600114B")]
      [Address(RVA = "0x12A1500", Offset = "0x12A0300", VA = "0x112A1500")]
      public JSONException(JSONParser.Context ctx)
      {
      }

      [Token(Token = "0x170001EE")]
      public override string Message
      {
        [Token(Token = "0x600114C"), Address(RVA = "0x12A1600", Offset = "0x12A0400", VA = "0x112A1600", Slot = "5")] get
        {
          return (string) null;
        }
      }
    }

    [Token(Token = "0x2000337")]
    public class InvalidNumberException : JSONParser.JSONException
    {
      [Token(Token = "0x600114D")]
      [Address(RVA = "0x12A13F0", Offset = "0x12A01F0", VA = "0x112A13F0")]
      public InvalidNumberException(JSONParser.Context ctx)
      {
      }
    }

    [Token(Token = "0x2000338")]
    public class InvalidStringException : JSONParser.JSONException
    {
      [Token(Token = "0x600114E")]
      [Address(RVA = "0x12A13F0", Offset = "0x12A01F0", VA = "0x112A13F0")]
      public InvalidStringException(JSONParser.Context ctx)
      {
      }
    }

    [Token(Token = "0x2000339")]
    public class UnexpectedEOFException : JSONParser.JSONException
    {
      [Token(Token = "0x600114F")]
      [Address(RVA = "0x12A13F0", Offset = "0x12A01F0", VA = "0x112A13F0")]
      public UnexpectedEOFException(JSONParser.Context ctx)
      {
      }
    }

    [Token(Token = "0x200033A")]
    public class UnexpectedCharacterException : JSONParser.JSONException
    {
      [Token(Token = "0x6001150")]
      [Address(RVA = "0x12A13F0", Offset = "0x12A01F0", VA = "0x112A13F0")]
      public UnexpectedCharacterException(JSONParser.Context ctx)
      {
      }
    }

    [Token(Token = "0x200033B")]
    public class UnknownException : JSONParser.JSONException
    {
      [Token(Token = "0x6001151")]
      [Address(RVA = "0x12A13F0", Offset = "0x12A01F0", VA = "0x112A13F0")]
      public UnknownException(JSONParser.Context ctx)
      {
      }
    }

    [Token(Token = "0x200033C")]
    public class InvalidCharacterException : JSONParser.JSONException
    {
      [Token(Token = "0x6001152")]
      [Address(RVA = "0x12A13F0", Offset = "0x12A01F0", VA = "0x112A13F0")]
      public InvalidCharacterException(JSONParser.Context ctx)
      {
      }
    }

    [Token(Token = "0x200033D")]
    public class InvalidKeyException : JSONParser.JSONException
    {
      [Token(Token = "0x6001153")]
      [Address(RVA = "0x12A13F0", Offset = "0x12A01F0", VA = "0x112A13F0")]
      public InvalidKeyException(JSONParser.Context ctx)
      {
      }
    }

    [Token(Token = "0x200033E")]
    public class UnsupportedTypeException : JSONParser.JSONException
    {
      [Token(Token = "0x6001154")]
      [Address(RVA = "0x12A13F0", Offset = "0x12A01F0", VA = "0x112A13F0")]
      public UnsupportedTypeException(JSONParser.Context ctx)
      {
      }
    }

    [Token(Token = "0x200033F")]
    private delegate T ParseElement<T>(JSONParser.Context ctx, Type type);
  }
}
