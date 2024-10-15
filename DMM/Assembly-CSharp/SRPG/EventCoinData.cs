// Decompiled with JetBrains decompiler
// Type: SRPG.EventCoinData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200104A")]
  public class EventCoinData
  {
    [Token(Token = "0x4003A1F")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4003A20")]
    [FieldOffset(Offset = "0xC")]
    public ItemData have;
    [Token(Token = "0x4003A21")]
    [FieldOffset(Offset = "0x10")]
    public ItemParam param;

    [Token(Token = "0x60042D9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EventCoinData()
    {
    }
  }
}
