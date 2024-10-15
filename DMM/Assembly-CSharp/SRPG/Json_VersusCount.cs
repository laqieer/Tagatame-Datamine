// Decompiled with JetBrains decompiler
// Type: SRPG.Json_VersusCount
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200102B")]
  [MessagePackObject(true)]
  public class Json_VersusCount
  {
    [Token(Token = "0x4003988")]
    [FieldOffset(Offset = "0x8")]
    public string type;
    [Token(Token = "0x4003989")]
    [FieldOffset(Offset = "0xC")]
    public int win;
    [Token(Token = "0x400398A")]
    [FieldOffset(Offset = "0x10")]
    public int lose;

    [Token(Token = "0x6004290")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_VersusCount()
    {
    }
  }
}
