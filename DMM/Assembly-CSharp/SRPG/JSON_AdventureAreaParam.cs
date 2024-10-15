// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AdventureAreaParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001967")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_AdventureAreaParam
  {
    [Token(Token = "0x4005C75")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005C76")]
    [FieldOffset(Offset = "0xC")]
    public string area_name;
    [Token(Token = "0x4005C77")]
    [FieldOffset(Offset = "0x10")]
    public string[] cond_areas;
    [Token(Token = "0x4005C78")]
    [FieldOffset(Offset = "0x14")]
    public int[] cond_levels;
    [Token(Token = "0x4005C79")]
    [FieldOffset(Offset = "0x18")]
    public int ui_index;
    [Token(Token = "0x4005C7A")]
    [FieldOffset(Offset = "0x1C")]
    public string webview_url;
    [Token(Token = "0x4005C7B")]
    [FieldOffset(Offset = "0x20")]
    public string webview_title;
    [Token(Token = "0x4005C7C")]
    [FieldOffset(Offset = "0x24")]
    public JSON_AdventureAreaParam.QuestInfo[] quests;

    [Token(Token = "0x6006793")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AdventureAreaParam()
    {
    }

    [Token(Token = "0x2001968")]
    [MessagePackObject(true)]
    [Serializable]
    public class QuestInfo
    {
      [Token(Token = "0x4005C7D")]
      [FieldOffset(Offset = "0x8")]
      public string adv_time;
      [Token(Token = "0x4005C7E")]
      [FieldOffset(Offset = "0xC")]
      public string cost_id;
      [Token(Token = "0x4005C7F")]
      [FieldOffset(Offset = "0x10")]
      public string reward_id;
      [Token(Token = "0x4005C80")]
      [FieldOffset(Offset = "0x14")]
      public string cond_id;
      [Token(Token = "0x4005C81")]
      [FieldOffset(Offset = "0x18")]
      public string buff_id;
      [Token(Token = "0x4005C82")]
      [FieldOffset(Offset = "0x1C")]
      public string buff_name;
      [Token(Token = "0x4005C83")]
      [FieldOffset(Offset = "0x20")]
      public string buff_desc;

      [Token(Token = "0x6006794")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public QuestInfo()
      {
      }
    }
  }
}
