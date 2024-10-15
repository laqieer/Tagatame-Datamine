// Decompiled with JetBrains decompiler
// Type: SRPG.Json_ExpansionPurchase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001031")]
  [MessagePackObject(true)]
  public class Json_ExpansionPurchase
  {
    [Token(Token = "0x4003997")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4003998")]
    [FieldOffset(Offset = "0x10")]
    public long expired_at;

    [Token(Token = "0x6004297")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_ExpansionPurchase()
    {
    }
  }
}
