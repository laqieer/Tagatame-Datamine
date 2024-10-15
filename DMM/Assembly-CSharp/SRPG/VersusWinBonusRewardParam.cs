// Decompiled with JetBrains decompiler
// Type: SRPG.VersusWinBonusRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EC2")]
  public class VersusWinBonusRewardParam
  {
    [Token(Token = "0x4008118")]
    [FieldOffset(Offset = "0x8")]
    public VERSUS_REWARD_TYPE type;
    [Token(Token = "0x4008119")]
    [FieldOffset(Offset = "0xC")]
    public string iname;
    [Token(Token = "0x400811A")]
    [FieldOffset(Offset = "0x10")]
    public int num;

    [Token(Token = "0x6007DF9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusWinBonusRewardParam()
    {
    }
  }
}
