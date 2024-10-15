// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchMapListModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200335E")]
  public class LeagueMatchMapListModel
  {
    [Token(Token = "0x400F2A1")]
    [FieldOffset(Offset = "0x8")]
    private int _nowPageCount;
    [Token(Token = "0x400F2A2")]
    [FieldOffset(Offset = "0xC")]
    private int _maxPageCount;

    [Token(Token = "0x17001EC4")]
    public int NowPageCount
    {
      [Token(Token = "0x600E39C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001EC5")]
    public int MaxPageCount
    {
      [Token(Token = "0x600E39D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x600E39E")]
    [Address(RVA = "0xAB7EA0", Offset = "0xAB6CA0", VA = "0x10AB7EA0")]
    public void Initialize(int now_page, int max_page)
    {
    }

    [Token(Token = "0x600E39F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchMapListModel()
    {
    }
  }
}
