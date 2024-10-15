// Decompiled with JetBrains decompiler
// Type: SRPG.MultiTowerRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BF7")]
  public class MultiTowerRewardParam
  {
    [Token(Token = "0x4006C44")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006C45")]
    [FieldOffset(Offset = "0xC")]
    public MultiTowerRewardItem[] mReward;

    [Token(Token = "0x6007333")]
    [Address(RVA = "0x37CBF0", Offset = "0x37B9F0", VA = "0x1037CBF0")]
    public void Deserialize(JSON_MultiTowerRewardParam json)
    {
    }

    [Token(Token = "0x6007334")]
    [Address(RVA = "0x37CE00", Offset = "0x37BC00", VA = "0x1037CE00")]
    public List<MultiTowerRewardItem> GetReward(int round) => (List<MultiTowerRewardItem>) null;

    [Token(Token = "0x6007335")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MultiTowerRewardParam()
    {
    }
  }
}
