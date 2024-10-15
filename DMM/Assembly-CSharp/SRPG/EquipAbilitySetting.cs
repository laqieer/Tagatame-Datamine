// Decompiled with JetBrains decompiler
// Type: SRPG.EquipAbilitySetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C24")]
  [MessagePackObject(true)]
  public class EquipAbilitySetting
  {
    [Token(Token = "0x4001FBC")]
    [FieldOffset(Offset = "0x8")]
    public OString iname;
    [Token(Token = "0x4001FBD")]
    [FieldOffset(Offset = "0xC")]
    public OInt rank;
    [Token(Token = "0x4001FBE")]
    [FieldOffset(Offset = "0x20")]
    public EquipSkillSetting[] skills;

    [Token(Token = "0x600303C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public EquipAbilitySetting()
    {
    }
  }
}
