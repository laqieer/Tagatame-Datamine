// Decompiled with JetBrains decompiler
// Type: SRPG.GachaHistoryItemData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200242D")]
  public class GachaHistoryItemData
  {
    [Token(Token = "0x400A3EC")]
    [FieldOffset(Offset = "0x8")]
    private GachaHistoryData[] mHistorys;
    [Token(Token = "0x400A3ED")]
    [FieldOffset(Offset = "0xC")]
    private string mGachaTitle;
    [Token(Token = "0x400A3EE")]
    [FieldOffset(Offset = "0x10")]
    private long mDropAt;

    [Token(Token = "0x17001612")]
    public GachaHistoryData[] historys
    {
      [Token(Token = "0x6009DC6"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (GachaHistoryData[]) null;
      }
    }

    [Token(Token = "0x17001613")]
    public string gachaTitle
    {
      [Token(Token = "0x6009DC7"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001614")]
    public long drop_at
    {
      [Token(Token = "0x6009DC8"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x6009DC9")]
    [Address(RVA = "0x608DC0", Offset = "0x607BC0", VA = "0x10608DC0")]
    public GachaHistoryItemData(GachaHistoryData[] historys, string title, long drop_at)
    {
    }

    [Token(Token = "0x6009DCA")]
    [Address(RVA = "0x608D70", Offset = "0x607B70", VA = "0x10608D70")]
    public DateTime GetDropAt() => new DateTime();
  }
}
