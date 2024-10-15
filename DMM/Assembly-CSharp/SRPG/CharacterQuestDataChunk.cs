// Decompiled with JetBrains decompiler
// Type: SRPG.CharacterQuestDataChunk
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002148")]
  public class CharacterQuestDataChunk
  {
    [Token(Token = "0x40090EF")]
    [FieldOffset(Offset = "0x8")]
    public string areaName;
    [Token(Token = "0x40090F0")]
    [FieldOffset(Offset = "0xC")]
    public string unitName;
    [Token(Token = "0x40090F1")]
    [FieldOffset(Offset = "0x10")]
    public UnitParam unitParam;
    [Token(Token = "0x40090F2")]
    [FieldOffset(Offset = "0x14")]
    public List<QuestParam> questParams;

    [Token(Token = "0x6008BB5")]
    [Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")]
    public void SetUnitNameFromChapterID(string chapterID)
    {
    }

    [Token(Token = "0x6008BB6")]
    [Address(RVA = "0x4F70A0", Offset = "0x4F5EA0", VA = "0x104F70A0")]
    public CharacterQuestDataChunk()
    {
    }
  }
}
