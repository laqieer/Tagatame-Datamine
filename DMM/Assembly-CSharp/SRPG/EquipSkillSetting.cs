// Decompiled with JetBrains decompiler
// Type: SRPG.EquipSkillSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C2B")]
  [MessagePackObject(true)]
  public class EquipSkillSetting
  {
    [Token(Token = "0x4001FD1")]
    [FieldOffset(Offset = "0x8")]
    public OString iname;
    [Token(Token = "0x4001FD2")]
    [FieldOffset(Offset = "0xC")]
    public OInt rate;
    [Token(Token = "0x4001FD3")]
    [FieldOffset(Offset = "0x20")]
    public SkillLockCondition cond;
    [Token(Token = "0x4001FD4")]
    [FieldOffset(Offset = "0x24")]
    public OInt check_cnt;

    [Token(Token = "0x6003043")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EquipSkillSetting()
    {
    }
  }
}
