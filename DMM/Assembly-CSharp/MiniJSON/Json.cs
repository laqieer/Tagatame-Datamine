// Decompiled with JetBrains decompiler
// Type: MiniJSON.Json
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

#nullable disable
namespace MiniJSON
{
  [Token(Token = "0x2000340")]
  public static class Json
  {
    [Token(Token = "0x6001159")]
    [Address(RVA = "0x12A3790", Offset = "0x12A2590", VA = "0x112A3790")]
    public static object Deserialize(string json) => (object) null;

    [Token(Token = "0x600115A")]
    [Address(RVA = "0x12A37B0", Offset = "0x12A25B0", VA = "0x112A37B0")]
    public static string Serialize(object obj) => (string) null;

    [Token(Token = "0x2000341")]
    private sealed class Parser : IDisposable
    {
      [Token(Token = "0x4000D0D")]
      private const string WORD_BREAK = "{}[],:\"";
      [Token(Token = "0x4000D0E")]
      [FieldOffset(Offset = "0x8")]
      private StringReader json;

      [Token(Token = "0x600115B")]
      [Address(RVA = "0x12A4200", Offset = "0x12A3000", VA = "0x112A4200")]
      public static bool IsWordBreak(char c) => new bool();

      [Token(Token = "0x600115C")]
      [Address(RVA = "0x12A4C70", Offset = "0x12A3A70", VA = "0x112A4C70")]
      private Parser(string jsonString)
      {
      }

      [Token(Token = "0x600115D")]
      [Address(RVA = "0x12A4AE0", Offset = "0x12A38E0", VA = "0x112A4AE0")]
      public static object Parse(string jsonString) => (object) null;

      [Token(Token = "0x600115E")]
      [Address(RVA = "0x12A4120", Offset = "0x12A2F20", VA = "0x112A4120", Slot = "4")]
      public void Dispose()
      {
      }

      [Token(Token = "0x600115F")]
      [Address(RVA = "0x12A4730", Offset = "0x12A3530", VA = "0x112A4730")]
      private Dictionary<string, object> ParseObject() => (Dictionary<string, object>) null;

      [Token(Token = "0x6001160")]
      [Address(RVA = "0x12A4280", Offset = "0x12A3080", VA = "0x112A4280")]
      private List<object> ParseArray() => (List<object>) null;

      [Token(Token = "0x6001161")]
      [Address(RVA = "0x12A4AC0", Offset = "0x12A38C0", VA = "0x112A4AC0")]
      private object ParseValue() => (object) null;

      [Token(Token = "0x6001162")]
      [Address(RVA = "0x12A4340", Offset = "0x12A3140", VA = "0x112A4340")]
      private object ParseByToken(Json.Parser.TOKEN token) => (object) null;

      [Token(Token = "0x6001163")]
      [Address(RVA = "0x12A4850", Offset = "0x12A3650", VA = "0x112A4850")]
      private string ParseString() => (string) null;

      [Token(Token = "0x6001164")]
      [Address(RVA = "0x12A4670", Offset = "0x12A3470", VA = "0x112A4670")]
      private object ParseNumber() => (object) null;

      [Token(Token = "0x6001165")]
      [Address(RVA = "0x12A4160", Offset = "0x12A2F60", VA = "0x112A4160")]
      private void EatWhitespace()
      {
      }

      [Token(Token = "0x170001EF")]
      private char PeekChar
      {
        [Token(Token = "0x6001166"), Address(RVA = "0x12A50D0", Offset = "0x12A3ED0", VA = "0x112A50D0")] get
        {
          return new char();
        }
      }

      [Token(Token = "0x170001F0")]
      private char NextChar
      {
        [Token(Token = "0x6001167"), Address(RVA = "0x12A4CE0", Offset = "0x12A3AE0", VA = "0x112A4CE0")] get
        {
          return new char();
        }
      }

      [Token(Token = "0x170001F1")]
      private string NextWord
      {
        [Token(Token = "0x6001168"), Address(RVA = "0x12A4FB0", Offset = "0x12A3DB0", VA = "0x112A4FB0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x170001F2")]
      private Json.Parser.TOKEN NextToken
      {
        [Token(Token = "0x6001169"), Address(RVA = "0x12A4D50", Offset = "0x12A3B50", VA = "0x112A4D50")] get
        {
          return new Json.Parser.TOKEN();
        }
      }

      [Token(Token = "0x2000342")]
      private enum TOKEN
      {
        [Token(Token = "0x4000D10")] NONE,
        [Token(Token = "0x4000D11")] CURLY_OPEN,
        [Token(Token = "0x4000D12")] CURLY_CLOSE,
        [Token(Token = "0x4000D13")] SQUARED_OPEN,
        [Token(Token = "0x4000D14")] SQUARED_CLOSE,
        [Token(Token = "0x4000D15")] COLON,
        [Token(Token = "0x4000D16")] COMMA,
        [Token(Token = "0x4000D17")] STRING,
        [Token(Token = "0x4000D18")] NUMBER,
        [Token(Token = "0x4000D19")] TRUE,
        [Token(Token = "0x4000D1A")] FALSE,
        [Token(Token = "0x4000D1B")] NULL,
      }
    }

    [Token(Token = "0x2000343")]
    private sealed class Serializer
    {
      [Token(Token = "0x4000D1C")]
      [FieldOffset(Offset = "0x8")]
      private StringBuilder builder;

      [Token(Token = "0x600116A")]
      [Address(RVA = "0x3048E0", Offset = "0x3036E0", VA = "0x103048E0")]
      private Serializer()
      {
      }

      [Token(Token = "0x600116B")]
      [Address(RVA = "0x304820", Offset = "0x303620", VA = "0x10304820")]
      public static string Serialize(object obj) => (string) null;

      [Token(Token = "0x600116C")]
      [Address(RVA = "0x304680", Offset = "0x303480", VA = "0x10304680")]
      private void SerializeValue(object value)
      {
      }

      [Token(Token = "0x600116D")]
      [Address(RVA = "0x303F30", Offset = "0x302D30", VA = "0x10303F30")]
      private void SerializeObject(IDictionary obj)
      {
      }

      [Token(Token = "0x600116E")]
      [Address(RVA = "0x303D30", Offset = "0x302B30", VA = "0x10303D30")]
      private void SerializeArray(IList anArray)
      {
      }

      [Token(Token = "0x600116F")]
      [Address(RVA = "0x3043F0", Offset = "0x3031F0", VA = "0x103043F0")]
      private void SerializeString(string str)
      {
      }

      [Token(Token = "0x6001170")]
      [Address(RVA = "0x3041C0", Offset = "0x302FC0", VA = "0x103041C0")]
      private void SerializeOther(object value)
      {
      }
    }
  }
}
