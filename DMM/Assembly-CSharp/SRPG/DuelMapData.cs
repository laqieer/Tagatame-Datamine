// Decompiled with JetBrains decompiler
// Type: SRPG.DuelMapData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002316")]
  [MessagePackObject(true)]
  [Serializable]
  public class DuelMapData
  {
    [Token(Token = "0x4009C89")]
    [FieldOffset(Offset = "0x8")]
    private string mQuestIname;
    [Token(Token = "0x4009C8A")]
    [FieldOffset(Offset = "0x10")]
    private DateTime mEndAt;

    [Token(Token = "0x17001506")]
    public string QuestIname
    {
      [Token(Token = "0x60096D8"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001507")]
    public DateTime EndAt
    {
      [Token(Token = "0x60096D9"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x60096DA")]
    [Address(RVA = "0x5984E0", Offset = "0x5972E0", VA = "0x105984E0")]
    public void Deserialize(JSON_DuelMapData json)
    {
    }

    [Token(Token = "0x60096DB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public DuelMapData()
    {
    }
  }
}
