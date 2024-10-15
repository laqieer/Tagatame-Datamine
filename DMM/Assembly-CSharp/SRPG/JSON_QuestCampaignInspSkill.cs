// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_QuestCampaignInspSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C2D")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_QuestCampaignInspSkill
  {
    [Token(Token = "0x4006D49")]
    [FieldOffset(Offset = "0x8")]
    public string children_iname;
    [Token(Token = "0x4006D4A")]
    [FieldOffset(Offset = "0xC")]
    public string insp;
    [Token(Token = "0x4006D4B")]
    [FieldOffset(Offset = "0x10")]
    public int rate;

    [Token(Token = "0x60073EB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_QuestCampaignInspSkill()
    {
    }
  }
}
