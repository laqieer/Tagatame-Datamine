// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayResumeAutoHpJudge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000D9B")]
  [MessagePackObject(true)]
  public class MultiPlayResumeAutoHpJudge
  {
    [Token(Token = "0x40026D2")]
    [FieldOffset(Offset = "0x8")]
    public string skillId;
    [Token(Token = "0x40026D3")]
    [FieldOffset(Offset = "0xC")]
    public List<string> usedSkills;

    [Token(Token = "0x6003738")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MultiPlayResumeAutoHpJudge()
    {
    }
  }
}
