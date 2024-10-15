// Decompiled with JetBrains decompiler
// Type: SRPG.CompleteQuestMap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E83")]
  public class CompleteQuestMap
  {
    [Token(Token = "0x4002C89")]
    [FieldOffset(Offset = "0x8")]
    public Dictionary<QuestTypes, int> mQuestTypeMap;
    [Token(Token = "0x4002C8A")]
    [FieldOffset(Offset = "0xC")]
    public Dictionary<string, CompleteQuestMap.CompleteQuestData> mChapterMap;

    [Token(Token = "0x6003C2D")]
    [Address(RVA = "0x10EAE60", Offset = "0x10E9C60", VA = "0x110EAE60")]
    public void LoadData()
    {
    }

    [Token(Token = "0x6003C2E")]
    [Address(RVA = "0x10EAD10", Offset = "0x10E9B10", VA = "0x110EAD10")]
    public int GetAllCount() => new int();

    [Token(Token = "0x6003C2F")]
    [Address(RVA = "0x10EAB40", Offset = "0x10E9940", VA = "0x110EAB40")]
    public void Add(QuestParam quest)
    {
    }

    [Token(Token = "0x6003C30")]
    [Address(RVA = "0x10EAEF0", Offset = "0x10E9CF0", VA = "0x110EAEF0")]
    public CompleteQuestMap()
    {
    }

    [Token(Token = "0x2000E84")]
    public class CompleteQuestData
    {
      [Token(Token = "0x4002C8B")]
      [FieldOffset(Offset = "0x8")]
      public QuestTypes mQuestType;
      [Token(Token = "0x4002C8C")]
      [FieldOffset(Offset = "0xC")]
      public int mCount;

      [Token(Token = "0x6003C31")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public CompleteQuestData()
      {
      }

      [Token(Token = "0x6003C32")]
      [Address(RVA = "0x721420", Offset = "0x720220", VA = "0x10721420")]
      public CompleteQuestData(QuestTypes questType, int count)
      {
      }
    }
  }
}
