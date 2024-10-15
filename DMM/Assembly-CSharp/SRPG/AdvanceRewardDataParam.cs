// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceRewardDataParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001961")]
  public class AdvanceRewardDataParam
  {
    [Token(Token = "0x4005C68")]
    [FieldOffset(Offset = "0x8")]
    public int ItemType;
    [Token(Token = "0x4005C69")]
    [FieldOffset(Offset = "0xC")]
    public string ItemIname;
    [Token(Token = "0x4005C6A")]
    [FieldOffset(Offset = "0x10")]
    public int ItemNum;

    [Token(Token = "0x6006783")]
    [Address(RVA = "0x31AF60", Offset = "0x319D60", VA = "0x1031AF60")]
    public void Deserialize(JSON_AdvanceRewardDataParam json)
    {
    }

    [Token(Token = "0x6006784")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AdvanceRewardDataParam()
    {
    }
  }
}
