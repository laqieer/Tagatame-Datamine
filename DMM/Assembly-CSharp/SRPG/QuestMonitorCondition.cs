// Decompiled with JetBrains decompiler
// Type: SRPG.QuestMonitorCondition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C09")]
  [Serializable]
  public class QuestMonitorCondition
  {
    [Token(Token = "0x4001F08")]
    [FieldOffset(Offset = "0x8")]
    public List<UnitMonitorCondition> actions;
    [Token(Token = "0x4001F09")]
    [FieldOffset(Offset = "0xC")]
    public List<UnitMonitorCondition> goals;
    [Token(Token = "0x4001F0A")]
    [FieldOffset(Offset = "0x10")]
    public List<UnitMonitorCondition> withdraw;

    [Token(Token = "0x6003019")]
    [Address(RVA = "0xFEABF0", Offset = "0xFE99F0", VA = "0x10FEABF0")]
    public void Clear()
    {
    }

    [Token(Token = "0x600301A")]
    [Address(RVA = "0xFEACA0", Offset = "0xFE9AA0", VA = "0x10FEACA0")]
    public void CopyTo(QuestMonitorCondition dst)
    {
    }

    [Token(Token = "0x600301B")]
    [Address(RVA = "0xFEAE30", Offset = "0xFE9C30", VA = "0x10FEAE30")]
    public QuestMonitorCondition()
    {
    }
  }
}
