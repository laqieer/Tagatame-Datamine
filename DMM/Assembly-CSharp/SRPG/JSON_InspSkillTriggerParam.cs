// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_InspSkillTriggerParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BA5")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_InspSkillTriggerParam
  {
    [Token(Token = "0x4006971")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006972")]
    [FieldOffset(Offset = "0xC")]
    public JSON_InspSkillTriggerParam.JSON_TriggerData[] triggers;

    [Token(Token = "0x600723B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_InspSkillTriggerParam()
    {
    }

    [Token(Token = "0x2001BA6")]
    [MessagePackObject(true)]
    [Serializable]
    public class JSON_TriggerData
    {
      [Token(Token = "0x4006973")]
      [FieldOffset(Offset = "0x8")]
      public int type;
      [Token(Token = "0x4006974")]
      [FieldOffset(Offset = "0xC")]
      public string val;

      [Token(Token = "0x600723C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JSON_TriggerData()
      {
      }
    }
  }
}
