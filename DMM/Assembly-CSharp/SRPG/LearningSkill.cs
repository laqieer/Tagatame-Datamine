// Decompiled with JetBrains decompiler
// Type: SRPG.LearningSkill
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DC4")]
  [MessagePackObject(true)]
  public class LearningSkill
  {
    [Token(Token = "0x40076A5")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40076A6")]
    [FieldOffset(Offset = "0xC")]
    public int locklv;

    [Token(Token = "0x60079C6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public LearningSkill()
    {
    }
  }
}
