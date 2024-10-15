// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B12")]
  public class GenesisRewardParam
  {
    [Token(Token = "0x4006737")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4006738")]
    [FieldOffset(Offset = "0xC")]
    private GenesisRewardDataParam[] mRewards;

    [Token(Token = "0x17000D0A")]
    public string Iname
    {
      [Token(Token = "0x6006FC5"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000D0B")]
    public List<GenesisRewardDataParam> RewardList
    {
      [Token(Token = "0x6006FC6"), Address(RVA = "0x36DD10", Offset = "0x36CB10", VA = "0x1036DD10")] get
      {
        return (List<GenesisRewardDataParam>) null;
      }
    }

    [Token(Token = "0x6006FC7")]
    [Address(RVA = "0x36DB70", Offset = "0x36C970", VA = "0x1036DB70")]
    public void Deserialize(JSON_GenesisRewardParam json)
    {
    }

    [Token(Token = "0x6006FC8")]
    [Address(RVA = "0x36DA30", Offset = "0x36C830", VA = "0x1036DA30")]
    public static void Deserialize(
      ref List<GenesisRewardParam> list,
      JSON_GenesisRewardParam[] json)
    {
    }

    [Token(Token = "0x6006FC9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public GenesisRewardParam()
    {
    }
  }
}
