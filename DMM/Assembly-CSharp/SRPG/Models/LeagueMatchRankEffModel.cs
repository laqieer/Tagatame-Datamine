// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchRankEffModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003368")]
  public class LeagueMatchRankEffModel
  {
    [Token(Token = "0x400F2E7")]
    [FieldOffset(Offset = "0x8")]
    private ReqLeagueMatchTop.Response _response;
    [Token(Token = "0x400F2E8")]
    [FieldOffset(Offset = "0xC")]
    private string _beforeRankIconKey;
    [Token(Token = "0x400F2E9")]
    [FieldOffset(Offset = "0x10")]
    private string _afterRankIconKey;

    [Token(Token = "0x17001F00")]
    public string BeforeRankIconKey
    {
      [Token(Token = "0x600E3FC"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F01")]
    public string AfterRankIconKey
    {
      [Token(Token = "0x600E3FD"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001F02")]
    public bool IsRankUp
    {
      [Token(Token = "0x600E3FE"), Address(RVA = "0xAB8660", Offset = "0xAB7460", VA = "0x10AB8660")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E3FF")]
    [Address(RVA = "0xAB84F0", Offset = "0xAB72F0", VA = "0x10AB84F0")]
    public void Initialize(SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600E400")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LeagueMatchRankEffModel()
    {
    }
  }
}
