// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001962")]
  public class AdvanceRewardParam
  {
    [Token(Token = "0x4005C6B")]
    [FieldOffset(Offset = "0x8")]
    private string mIname;
    [Token(Token = "0x4005C6C")]
    [FieldOffset(Offset = "0xC")]
    private AdvanceRewardDataParam[] mRewards;

    [Token(Token = "0x17000A8F")]
    public string Iname
    {
      [Token(Token = "0x6006785"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000A90")]
    public List<AdvanceRewardDataParam> RewardList
    {
      [Token(Token = "0x6006786"), Address(RVA = "0x31B280", Offset = "0x31A080", VA = "0x1031B280")] get
      {
        return (List<AdvanceRewardDataParam>) null;
      }
    }

    [Token(Token = "0x6006787")]
    [Address(RVA = "0x31AFA0", Offset = "0x319DA0", VA = "0x1031AFA0")]
    public void Deserialize(JSON_AdvanceRewardParam json)
    {
    }

    [Token(Token = "0x6006788")]
    [Address(RVA = "0x31B140", Offset = "0x319F40", VA = "0x1031B140")]
    public static void Deserialize(
      ref List<AdvanceRewardParam> list,
      JSON_AdvanceRewardParam[] json)
    {
    }

    [Token(Token = "0x6006789")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AdvanceRewardParam()
    {
    }
  }
}
